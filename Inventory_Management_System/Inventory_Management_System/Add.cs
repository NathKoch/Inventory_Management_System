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
    public partial class NK_Form_Add : Form
    {
        Database database = new Database();
        public NK_Form_Add()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;

        }

        private void NK_btn_Save_Click(object sender, EventArgs e)
        {
            
            database.openConnection();
            var type = NK_txt_Type.Text;
            var quantity = NK_txt_Quantity.Text;
            var supplier = NK_txt_Supplier.Text;
            int price;

            if(int.TryParse(NK_txt_Price.Text, out price))
            {
                var addQuery = $"INSERT INTO Inventory (type_of, count_of, supplier, price) VALUES ( '{type}', '{quantity}', '{supplier}', '{price}' )";

                var command = new SqlCommand(addQuery, database.GetSqlConnection());
                command.ExecuteNonQuery();

                MessageBox.Show("You successfully created an entry !", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                NK_txt_Type.Text = "";
                NK_txt_Quantity.Text = "";
                NK_txt_Supplier.Text = "";
                NK_txt_Price.Text = "";
            }
            else
            {
                MessageBox.Show("Price must be in numeric format !", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            database.closeConnection();
        }

        private void NK_pic_Clear_Click(object sender, EventArgs e)
        {
            NK_txt_Type.Text = "";
            NK_txt_Quantity.Text = "";
            NK_txt_Supplier.Text = "";
            NK_txt_Price.Text = "";
        }
    }
}
