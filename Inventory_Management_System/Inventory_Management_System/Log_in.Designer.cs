namespace Inventory_Management_System
{
    partial class NK_Form_Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NK_Form_Login));
            this.NK_pic_OpenEye = new System.Windows.Forms.PictureBox();
            this.NK_pic_ClosedEye = new System.Windows.Forms.PictureBox();
            this.NK_pic_Login = new System.Windows.Forms.PictureBox();
            this.NK_pic_Clear = new System.Windows.Forms.PictureBox();
            this.NK_pnl_Registration = new System.Windows.Forms.Panel();
            this.NK_lbl_Login = new System.Windows.Forms.Label();
            this.NK_btn_Login = new System.Windows.Forms.Button();
            this.NK_txt_PassL = new System.Windows.Forms.TextBox();
            this.NK_txt_UserL = new System.Windows.Forms.TextBox();
            this.NK_lbl_Password = new System.Windows.Forms.Label();
            this.NK_lbl_Username = new System.Windows.Forms.Label();
            this.NK_linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.NK_pic_OpenEye)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NK_pic_ClosedEye)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NK_pic_Login)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NK_pic_Clear)).BeginInit();
            this.NK_pnl_Registration.SuspendLayout();
            this.SuspendLayout();
            // 
            // NK_pic_OpenEye
            // 
            this.NK_pic_OpenEye.Image = ((System.Drawing.Image)(resources.GetObject("NK_pic_OpenEye.Image")));
            this.NK_pic_OpenEye.Location = new System.Drawing.Point(452, 186);
            this.NK_pic_OpenEye.Name = "NK_pic_OpenEye";
            this.NK_pic_OpenEye.Size = new System.Drawing.Size(40, 35);
            this.NK_pic_OpenEye.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.NK_pic_OpenEye.TabIndex = 14;
            this.NK_pic_OpenEye.TabStop = false;
            this.NK_pic_OpenEye.Click += new System.EventHandler(this.NK_pic_OpenEye_Click);
            // 
            // NK_pic_ClosedEye
            // 
            this.NK_pic_ClosedEye.Image = ((System.Drawing.Image)(resources.GetObject("NK_pic_ClosedEye.Image")));
            this.NK_pic_ClosedEye.Location = new System.Drawing.Point(452, 186);
            this.NK_pic_ClosedEye.Name = "NK_pic_ClosedEye";
            this.NK_pic_ClosedEye.Size = new System.Drawing.Size(40, 35);
            this.NK_pic_ClosedEye.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.NK_pic_ClosedEye.TabIndex = 13;
            this.NK_pic_ClosedEye.TabStop = false;
            this.NK_pic_ClosedEye.Click += new System.EventHandler(this.NK_pic_ClosedEye_Click);
            // 
            // NK_pic_Login
            // 
            this.NK_pic_Login.Image = ((System.Drawing.Image)(resources.GetObject("NK_pic_Login.Image")));
            this.NK_pic_Login.Location = new System.Drawing.Point(12, 12);
            this.NK_pic_Login.Name = "NK_pic_Login";
            this.NK_pic_Login.Size = new System.Drawing.Size(91, 80);
            this.NK_pic_Login.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.NK_pic_Login.TabIndex = 12;
            this.NK_pic_Login.TabStop = false;
            // 
            // NK_pic_Clear
            // 
            this.NK_pic_Clear.Image = ((System.Drawing.Image)(resources.GetObject("NK_pic_Clear.Image")));
            this.NK_pic_Clear.Location = new System.Drawing.Point(439, 24);
            this.NK_pic_Clear.Name = "NK_pic_Clear";
            this.NK_pic_Clear.Size = new System.Drawing.Size(80, 41);
            this.NK_pic_Clear.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.NK_pic_Clear.TabIndex = 4;
            this.NK_pic_Clear.TabStop = false;
            this.NK_pic_Clear.Click += new System.EventHandler(this.NK_pic_Clear_Click);
            // 
            // NK_pnl_Registration
            // 
            this.NK_pnl_Registration.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.NK_pnl_Registration.Controls.Add(this.NK_pic_Clear);
            this.NK_pnl_Registration.Controls.Add(this.NK_lbl_Login);
            this.NK_pnl_Registration.Location = new System.Drawing.Point(113, 14);
            this.NK_pnl_Registration.Name = "NK_pnl_Registration";
            this.NK_pnl_Registration.Size = new System.Drawing.Size(532, 78);
            this.NK_pnl_Registration.TabIndex = 15;
            // 
            // NK_lbl_Login
            // 
            this.NK_lbl_Login.AutoSize = true;
            this.NK_lbl_Login.Font = new System.Drawing.Font("Century Schoolbook", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NK_lbl_Login.Location = new System.Drawing.Point(32, 24);
            this.NK_lbl_Login.Name = "NK_lbl_Login";
            this.NK_lbl_Login.Size = new System.Drawing.Size(122, 41);
            this.NK_lbl_Login.TabIndex = 6;
            this.NK_lbl_Login.Text = "Login";
            // 
            // NK_btn_Login
            // 
            this.NK_btn_Login.Location = new System.Drawing.Point(248, 243);
            this.NK_btn_Login.Name = "NK_btn_Login";
            this.NK_btn_Login.Size = new System.Drawing.Size(198, 46);
            this.NK_btn_Login.TabIndex = 20;
            this.NK_btn_Login.Text = "Login";
            this.NK_btn_Login.UseVisualStyleBackColor = true;
            this.NK_btn_Login.Click += new System.EventHandler(this.NK_btn_Login_Click);
            // 
            // NK_txt_PassL
            // 
            this.NK_txt_PassL.Location = new System.Drawing.Point(248, 186);
            this.NK_txt_PassL.Name = "NK_txt_PassL";
            this.NK_txt_PassL.Size = new System.Drawing.Size(198, 35);
            this.NK_txt_PassL.TabIndex = 19;
            this.NK_txt_PassL.UseSystemPasswordChar = true;
            // 
            // NK_txt_UserL
            // 
            this.NK_txt_UserL.Location = new System.Drawing.Point(248, 136);
            this.NK_txt_UserL.Name = "NK_txt_UserL";
            this.NK_txt_UserL.Size = new System.Drawing.Size(198, 35);
            this.NK_txt_UserL.TabIndex = 18;
            // 
            // NK_lbl_Password
            // 
            this.NK_lbl_Password.AutoSize = true;
            this.NK_lbl_Password.Location = new System.Drawing.Point(117, 186);
            this.NK_lbl_Password.Name = "NK_lbl_Password";
            this.NK_lbl_Password.Size = new System.Drawing.Size(108, 30);
            this.NK_lbl_Password.TabIndex = 17;
            this.NK_lbl_Password.Text = "Password:";
            // 
            // NK_lbl_Username
            // 
            this.NK_lbl_Username.AutoSize = true;
            this.NK_lbl_Username.Location = new System.Drawing.Point(111, 136);
            this.NK_lbl_Username.Name = "NK_lbl_Username";
            this.NK_lbl_Username.Size = new System.Drawing.Size(114, 30);
            this.NK_lbl_Username.TabIndex = 16;
            this.NK_lbl_Username.Text = "Username:";
            // 
            // NK_linkLabel1
            // 
            this.NK_linkLabel1.AutoSize = true;
            this.NK_linkLabel1.LinkColor = System.Drawing.Color.Gray;
            this.NK_linkLabel1.Location = new System.Drawing.Point(282, 319);
            this.NK_linkLabel1.Name = "NK_linkLabel1";
            this.NK_linkLabel1.Size = new System.Drawing.Size(118, 30);
            this.NK_linkLabel1.TabIndex = 21;
            this.NK_linkLabel1.TabStop = true;
            this.NK_linkLabel1.Text = "Or Sign Up";
            this.NK_linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.NK_linkLabel1_LinkClicked);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // NK_Form_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 358);
            this.Controls.Add(this.NK_linkLabel1);
            this.Controls.Add(this.NK_pic_OpenEye);
            this.Controls.Add(this.NK_pic_ClosedEye);
            this.Controls.Add(this.NK_pic_Login);
            this.Controls.Add(this.NK_pnl_Registration);
            this.Controls.Add(this.NK_btn_Login);
            this.Controls.Add(this.NK_txt_PassL);
            this.Controls.Add(this.NK_txt_UserL);
            this.Controls.Add(this.NK_lbl_Password);
            this.Controls.Add(this.NK_lbl_Username);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "NK_Form_Login";
            this.Text = "Log_in";
            this.Load += new System.EventHandler(this.Log_in_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NK_pic_OpenEye)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NK_pic_ClosedEye)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NK_pic_Login)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NK_pic_Clear)).EndInit();
            this.NK_pnl_Registration.ResumeLayout(false);
            this.NK_pnl_Registration.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox NK_pic_OpenEye;
        private System.Windows.Forms.PictureBox NK_pic_ClosedEye;
        private System.Windows.Forms.PictureBox NK_pic_Login;
        private System.Windows.Forms.PictureBox NK_pic_Clear;
        private System.Windows.Forms.Panel NK_pnl_Registration;
        private System.Windows.Forms.Label NK_lbl_Login;
        private System.Windows.Forms.Button NK_btn_Login;
        private System.Windows.Forms.TextBox NK_txt_PassL;
        private System.Windows.Forms.TextBox NK_txt_UserL;
        private System.Windows.Forms.Label NK_lbl_Password;
        private System.Windows.Forms.Label NK_lbl_Username;
        private System.Windows.Forms.LinkLabel NK_linkLabel1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}