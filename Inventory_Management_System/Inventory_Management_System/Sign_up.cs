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
//using Inventory_Management_System.Connection;

namespace Inventory_Management_System
{
    public partial class NK_Form_SignUp : Form
    {
        Database database = new Database();

        public NK_Form_SignUp()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void NK_pic_Clear_Click(object sender, EventArgs e)
        {
            NK_txt_UserS.Text = "";
            NK_txt_PassS.Text = "";
        }

        private void NK_Form_SignUp_Load(object sender, EventArgs e)
        {
            NK_pic_OpenEye.Visible = true;
            NK_txt_PassS.MaxLength = 50;
            NK_txt_UserS.MaxLength = 50;
        }

        private void NK_pic_OpenEye_Click(object sender, EventArgs e)
        {
            NK_txt_PassS.UseSystemPasswordChar = false;
            NK_pic_OpenEye.Visible = false;
            NK_pic_ClosedEye.Visible = true;

        }

        private void NK_pic_ClosedEye_Click(object sender, EventArgs e)
        {
            NK_txt_PassS.UseSystemPasswordChar = true;
            NK_pic_OpenEye.Visible = true;
            NK_pic_ClosedEye.Visible = false;
        }

        private void NK_btn_Create_Click(object sender, EventArgs e)
        {
            
            if (checkIsUserUnique())
            {
                return;
            }
            else
            {
                var loginReg = NK_txt_UserS.Text;
                var passReg = md5.hashPassword(NK_txt_PassS.Text);
                if (NK_txt_UserS.Text != string.Empty && NK_txt_PassS.Text != string.Empty)
                {
                      string queryString = $"INSERT INTO Users(login_user, password_user, permission) VALUES('{loginReg}', '{passReg}', 0)";

                      SqlCommand command = new SqlCommand(queryString, database.GetSqlConnection());

                      database.openConnection();

                     if (command.ExecuteNonQuery() == 1)
                     {

                         MessageBox.Show("Account has been successfully created !", "Success!");
                                    
                         NK_Form_Login form_Login = new NK_Form_Login();
                        this.Hide();
                        form_Login.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Account not created !", "Error");
                    }
                    database.closeConnection();
                }
                else
                {
                    MessageBox.Show("Username and password cannot be empty !", "Error");
                }
            }
        }

        private Boolean checkIsUserUnique()
        {
            var loginUser = NK_txt_UserS.Text;
            var passUser = NK_txt_PassS.Text;

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            string queryString = $"SELECT id, login_user, password_user, permission FROM Users WHERE login_user = '{loginUser}' AND password_user = '{passUser}'";

            SqlCommand command = new SqlCommand(queryString, database.GetSqlConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if(table.Rows.Count > 0)
            {
                MessageBox.Show("Account already exists !", "Error");
                return true;
            }
            else { return false; }
        }


    }
}
