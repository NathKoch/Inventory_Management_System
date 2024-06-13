using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Inventory_Management_System
{
    enum RowState
    {
        Existed,
        New,
        Modified,
        ModifiedNew,
        Deleted

    }
    public partial class NK_Form_Inventory : Form
    {
        private readonly checkPermission _permission;

        Database database = new Database();

        int selectedRow;
        public NK_Form_Inventory(checkPermission permission)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            _permission = permission;
        }

        private void IsAdmin()
        {
            NK_administrationToolStripMenuItem.Enabled = _permission.IsAdmin;
            NK_btn_Delete.Enabled = _permission.IsAdmin;
        }

        private void CreateColumns()
        {
            NK_dataGridView1.Columns.Add("id", "ID");
            NK_dataGridView1.Columns.Add("type_of", "Type");
            NK_dataGridView1.Columns.Add("count_of", "Quantity");
            NK_dataGridView1.Columns.Add("supplier", "Supplier");
            NK_dataGridView1.Columns.Add("price", "Price");
            NK_dataGridView1.Columns.Add("IsNew", String.Empty);

        }

        private void ReadSingleRow(DataGridView dgw,IDataRecord record)
        {
            dgw.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetInt32(2), record.GetString(3), record.GetInt32(4), RowState.ModifiedNew);
        }

        private void RefreshDataGrid(DataGridView dgw) 
        { 
            dgw.Rows.Clear();
            string queryString = $"SELECT * FROM Inventory";

            SqlCommand command = new SqlCommand(queryString, database.GetSqlConnection());

            database.openConnection();
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ReadSingleRow(dgw, reader);
            }
            reader.Close();
        }

        private void NK_Form_Inventory_Load(object sender, EventArgs e)
        {
            CreateColumns();
            RefreshDataGrid(NK_dataGridView1);
            NK_lbl_Permission.Text = $"{_permission.Login}: {_permission.Status}";
            IsAdmin();
        }

        private void NK_dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
            if(e.RowIndex >= 0)
            {
                DataGridViewRow row = NK_dataGridView1.Rows[selectedRow];

                NK_txt_ID.Text = row.Cells[0].Value.ToString();
                NK_txt_Type.Text = row.Cells[1].Value.ToString();
                NK_txt_Quantity.Text = row.Cells[2].Value.ToString();
                NK_txt_Supplier.Text = row.Cells[3].Value.ToString();
                NK_txt_Price.Text = row.Cells[4].Value.ToString();
            }
        }

        private void Search(DataGridView dgw)
        {
            dgw.Rows.Clear();

            string searchString = $"SELECT * FROM Inventory WHERE CONCAT (id, type_of, count_of, supplier, price) LIKE '%" + NK_txt_Search.Text +"%'";
            SqlCommand com = new SqlCommand(searchString, database.GetSqlConnection());
            database.openConnection();
            SqlDataReader read = com.ExecuteReader();

            while (read.Read())
            {
                ReadSingleRow(dgw, read);
            }
            read.Close();
        }

        private void NK_txt_Search_TextChanged(object sender, EventArgs e)
        {
            Search(NK_dataGridView1);
        }

        private void deleteRow()
        {
            int index = NK_dataGridView1.CurrentCell.RowIndex;

            NK_dataGridView1.Rows[index].Visible = false;

            if (NK_dataGridView1.Rows[index].Cells[0].Value.ToString() == string.Empty)
            {
                NK_dataGridView1.Rows[index].Cells[5].Value = RowState.Deleted;
                return;
            }
            NK_dataGridView1.Rows[index].Cells[5].Value = RowState.Deleted;

        }
        private void NK_btn_Delete_Click(object sender, EventArgs e)
        {
            deleteRow();
            ClearFields();
        }

        private void Update()
        {
            database.openConnection();

            for(int i = 0; i < NK_dataGridView1.Rows.Count; i++)
            {
                var rowState = (RowState)NK_dataGridView1.Rows[i].Cells[5].Value;
                if (rowState == RowState.Existed)
                    continue;

                if (rowState == RowState.Deleted)
                {
                    var id = Convert.ToInt32(NK_dataGridView1.Rows[i].Cells[0].Value);
                    var deleteQuery = $"DELETE FROM Inventory WHERE id = {id}";

                    var command = new SqlCommand(deleteQuery, database.GetSqlConnection());
                    command.ExecuteNonQuery();
                }

                if (rowState == RowState.Modified)
                {
                    var id = NK_dataGridView1.Rows[i].Cells[0].Value.ToString();
                    var type = NK_dataGridView1.Rows[i].Cells[1].Value.ToString();
                    var quantity = NK_dataGridView1.Rows[i].Cells[2].Value.ToString();
                    var supplier = NK_dataGridView1.Rows[i].Cells[3].Value.ToString();
                    var price = NK_dataGridView1.Rows[i].Cells[4].Value.ToString();

                    var changeQuery = $"UPDATE Inventory SET type_of = '{type}', count_of = '{quantity}', supplier = '{supplier}', price = '{price}' WHERE id = '{id}'";
                    var command = new SqlCommand(changeQuery, database.GetSqlConnection());
                    command.ExecuteNonQuery();
                }
            }
            database.closeConnection();
        }
        private void NK_pic_Reload_Click(object sender, EventArgs e)
        {
            RefreshDataGrid(NK_dataGridView1);
            ClearFields();
        }

        private void NK_btn_NewEntry_Click(object sender, EventArgs e)
        {
            NK_Form_Add form_Add = new NK_Form_Add();
            form_Add.Show();
        }

        private void NK_btn_Save_Click(object sender, EventArgs e)
        {
            Update();
            ClearFields();
        }

        private void Change()
        {
            var selectedRowIndex = NK_dataGridView1.CurrentCell.RowIndex;

            var id = NK_txt_ID.Text;
            var type = NK_txt_Type.Text;
            var quantity = NK_txt_Quantity.Text;
            var supplier = NK_txt_Supplier.Text;
            int price;

            if (NK_dataGridView1.Rows[selectedRowIndex].Cells[0].Value.ToString() != string.Empty) 
            {
                if (int.TryParse(NK_txt_Price.Text, out price))
                {
                    NK_dataGridView1.Rows[selectedRowIndex].SetValues(id, type, quantity, supplier, price);
                    NK_dataGridView1.Rows[selectedRowIndex].Cells[5].Value = RowState.Modified;
                }
                else
                {
                    MessageBox.Show("Price must be in numeric format !", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
           
        }

        private void NK_btn_Change_Click(object sender, EventArgs e)
        {
            Change();
            
        }
        private void ClearFields()
        {
            NK_txt_ID.Text = "";
            NK_txt_Type.Text = "";
            NK_txt_Quantity.Text = "";
            NK_txt_Supplier.Text = "";
            NK_txt_Price.Text = "";
        }

        private void NK_administrationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NK_Form_Administration form_Administration = new NK_Form_Administration();
            form_Administration.Show();

        }
        private void NK_pic_Clear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }
        private void NK_lbl_Price_Click(object sender, EventArgs e)
        {

        }

        private void NK_tabPage1_Click(object sender, EventArgs e)
        {

        }

       
    }
}
