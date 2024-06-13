using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Inventory_Management_System
{
    public partial class NK_Form_Administration : Form
    {
        Database database = new Database();
        public NK_Form_Administration()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void CreateColumns()
        {
            NK_Admin_dataGridView.Columns.Add("id", "ID");
            NK_Admin_dataGridView.Columns.Add("login_user", "Login");
            NK_Admin_dataGridView.Columns.Add("password_user", "Password");
            var checkColumn = new DataGridViewCheckBoxColumn();
            checkColumn.HeaderText = "IsAdmin";
            NK_Admin_dataGridView.Columns.Add(checkColumn);
        }
        private void ReadSingleRow(IDataRecord record)
        {
            NK_Admin_dataGridView.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetString(2), record.GetBoolean(3));
        }
        private void RefreshDataGrid()
        {
            NK_Admin_dataGridView.Rows.Clear();

            string queryString = $"SELECT * FROM Users";

            SqlCommand command = new SqlCommand(queryString, database.GetSqlConnection());

            database.openConnection();


            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ReadSingleRow(reader);
            }
            reader.Close();
        }

        private void NK_Form_Administration_Load(object sender, EventArgs e)
        {
            CreateColumns();
            RefreshDataGrid();
        }

        private void NK_btn_Save_Click(object sender, EventArgs e)
        {
            database.openConnection();

            for (int i = 0; i < NK_Admin_dataGridView.Rows.Count; i++)
            {
                var id = NK_Admin_dataGridView.Rows[i].Cells[0].Value.ToString();
                var isadmin = NK_Admin_dataGridView.Rows[i].Cells[3].Value.ToString();

                var changeQuery = $"UPDATE Users SET permission = '{isadmin}' WHERE id = '{id}'";

                var command = new SqlCommand(changeQuery, database.GetSqlConnection());
                command.ExecuteNonQuery();
            }
            database.closeConnection();
            RefreshDataGrid();
        }
        private void NK_btn_Delete_Click(object sender, EventArgs e)
        {
            database.openConnection();

            var selectedRowIndex = NK_Admin_dataGridView.CurrentCell.RowIndex;

            var id = Convert.ToInt32(NK_Admin_dataGridView.Rows[selectedRowIndex].Cells[0].Value);
            var deleteQuery = $"DELETE FROM Users WHERE id = {id}";

            var command = new SqlCommand(deleteQuery, database.GetSqlConnection());
            command.ExecuteNonQuery();

            database.closeConnection();
            RefreshDataGrid();
        }


    }
}
