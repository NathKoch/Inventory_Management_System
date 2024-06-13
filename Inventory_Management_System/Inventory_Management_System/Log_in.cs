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
    public partial class NK_Form_Login : Form
    {
        Database database = new Database();
        public NK_Form_Login()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void Log_in_Load(object sender, EventArgs e)
        {
            //NK_txt_PassL.PasswordChar = '*';
            NK_pic_OpenEye.Visible = true;
            NK_txt_PassL.MaxLength = 50;
            NK_txt_UserL.MaxLength = 50;
        }

        private void NK_btn_Login_Click(object sender, EventArgs e)
        {
            var loginUser = NK_txt_UserL.Text;
            var passUser = md5.hashPassword(NK_txt_PassL.Text);

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            string queryString = $"SELECT id, login_user, password_user, permission FROM Users WHERE login_user = '{loginUser}' AND password_user = '{passUser}'";

            SqlCommand command = new SqlCommand(queryString, database.GetSqlConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count == 1)
            {
                var permission = new checkPermission(table.Rows[0].ItemArray[1].ToString(), Convert.ToBoolean(table.Rows[0].ItemArray[3]));

                MessageBox.Show("You successfully logged in !", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                NK_Form_Inventory form_Inventory = new NK_Form_Inventory(permission);
                this.Hide();
                form_Inventory.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("The account does not exist !", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void NK_linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            NK_Form_SignUp form_SignUp = new NK_Form_SignUp();
            form_SignUp.Show();
            this.Hide();
        }

        private void NK_pic_Clear_Click(object sender, EventArgs e)
        {
            NK_txt_UserL.Text = "";
            NK_txt_PassL.Text = "";
        }

        private void NK_pic_OpenEye_Click(object sender, EventArgs e)
        {
            NK_txt_PassL.UseSystemPasswordChar = false;
            NK_pic_OpenEye.Visible = false;
            NK_pic_ClosedEye.Visible = true;

        }

        private void NK_pic_ClosedEye_Click(object sender, EventArgs e)
        {
            NK_txt_PassL.UseSystemPasswordChar = true;
            NK_pic_OpenEye.Visible = true;
            NK_pic_ClosedEye.Visible = false;
        }
    }
}
