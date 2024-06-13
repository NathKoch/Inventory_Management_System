namespace Inventory_Management_System
{
    partial class NK_Form_SignUp
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NK_Form_SignUp));
            this.NK_pic_AddUser = new System.Windows.Forms.PictureBox();
            this.NK_pic_ClosedEye = new System.Windows.Forms.PictureBox();
            this.NK_pic_OpenEye = new System.Windows.Forms.PictureBox();
            this.NK_pic_Clear = new System.Windows.Forms.PictureBox();
            this.NK_pnl_Registration = new System.Windows.Forms.Panel();
            this.NK_lbl_Registration = new System.Windows.Forms.Label();
            this.NK_lbl_Username = new System.Windows.Forms.Label();
            this.NK_lbl_Password = new System.Windows.Forms.Label();
            this.NK_txt_UserS = new System.Windows.Forms.TextBox();
            this.NK_txt_PassS = new System.Windows.Forms.TextBox();
            this.NK_btn_Create = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.NK_pic_AddUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NK_pic_ClosedEye)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NK_pic_OpenEye)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NK_pic_Clear)).BeginInit();
            this.NK_pnl_Registration.SuspendLayout();
            this.SuspendLayout();
            // 
            // NK_pic_AddUser
            // 
            this.NK_pic_AddUser.Image = ((System.Drawing.Image)(resources.GetObject("NK_pic_AddUser.Image")));
            this.NK_pic_AddUser.Location = new System.Drawing.Point(12, 12);
            this.NK_pic_AddUser.Name = "NK_pic_AddUser";
            this.NK_pic_AddUser.Size = new System.Drawing.Size(91, 80);
            this.NK_pic_AddUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.NK_pic_AddUser.TabIndex = 1;
            this.NK_pic_AddUser.TabStop = false;
            // 
            // NK_pic_ClosedEye
            // 
            this.NK_pic_ClosedEye.Image = ((System.Drawing.Image)(resources.GetObject("NK_pic_ClosedEye.Image")));
            this.NK_pic_ClosedEye.Location = new System.Drawing.Point(445, 201);
            this.NK_pic_ClosedEye.Name = "NK_pic_ClosedEye";
            this.NK_pic_ClosedEye.Size = new System.Drawing.Size(40, 35);
            this.NK_pic_ClosedEye.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.NK_pic_ClosedEye.TabIndex = 2;
            this.NK_pic_ClosedEye.TabStop = false;
            this.NK_pic_ClosedEye.Click += new System.EventHandler(this.NK_pic_ClosedEye_Click);
            // 
            // NK_pic_OpenEye
            // 
            this.NK_pic_OpenEye.Image = ((System.Drawing.Image)(resources.GetObject("NK_pic_OpenEye.Image")));
            this.NK_pic_OpenEye.Location = new System.Drawing.Point(445, 201);
            this.NK_pic_OpenEye.Name = "NK_pic_OpenEye";
            this.NK_pic_OpenEye.Size = new System.Drawing.Size(40, 35);
            this.NK_pic_OpenEye.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.NK_pic_OpenEye.TabIndex = 3;
            this.NK_pic_OpenEye.TabStop = false;
            this.NK_pic_OpenEye.Click += new System.EventHandler(this.NK_pic_OpenEye_Click);
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
            this.NK_pnl_Registration.Controls.Add(this.NK_lbl_Registration);
            this.NK_pnl_Registration.Location = new System.Drawing.Point(109, 13);
            this.NK_pnl_Registration.Name = "NK_pnl_Registration";
            this.NK_pnl_Registration.Size = new System.Drawing.Size(532, 78);
            this.NK_pnl_Registration.TabIndex = 5;
            // 
            // NK_lbl_Registration
            // 
            this.NK_lbl_Registration.AutoSize = true;
            this.NK_lbl_Registration.Font = new System.Drawing.Font("Century Schoolbook", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NK_lbl_Registration.Location = new System.Drawing.Point(23, 24);
            this.NK_lbl_Registration.Name = "NK_lbl_Registration";
            this.NK_lbl_Registration.Size = new System.Drawing.Size(161, 41);
            this.NK_lbl_Registration.TabIndex = 6;
            this.NK_lbl_Registration.Text = "Sign Up";
            // 
            // NK_lbl_Username
            // 
            this.NK_lbl_Username.AutoSize = true;
            this.NK_lbl_Username.Location = new System.Drawing.Point(104, 151);
            this.NK_lbl_Username.Name = "NK_lbl_Username";
            this.NK_lbl_Username.Size = new System.Drawing.Size(114, 30);
            this.NK_lbl_Username.TabIndex = 7;
            this.NK_lbl_Username.Text = "Username:";
            // 
            // NK_lbl_Password
            // 
            this.NK_lbl_Password.AutoSize = true;
            this.NK_lbl_Password.Location = new System.Drawing.Point(110, 201);
            this.NK_lbl_Password.Name = "NK_lbl_Password";
            this.NK_lbl_Password.Size = new System.Drawing.Size(108, 30);
            this.NK_lbl_Password.TabIndex = 8;
            this.NK_lbl_Password.Text = "Password:";
            // 
            // NK_txt_UserS
            // 
            this.NK_txt_UserS.Location = new System.Drawing.Point(241, 151);
            this.NK_txt_UserS.Name = "NK_txt_UserS";
            this.NK_txt_UserS.Size = new System.Drawing.Size(198, 35);
            this.NK_txt_UserS.TabIndex = 9;
            // 
            // NK_txt_PassS
            // 
            this.NK_txt_PassS.Location = new System.Drawing.Point(241, 201);
            this.NK_txt_PassS.Name = "NK_txt_PassS";
            this.NK_txt_PassS.Size = new System.Drawing.Size(198, 35);
            this.NK_txt_PassS.TabIndex = 10;
            this.NK_txt_PassS.UseSystemPasswordChar = true;
            // 
            // NK_btn_Create
            // 
            this.NK_btn_Create.Location = new System.Drawing.Point(241, 258);
            this.NK_btn_Create.Name = "NK_btn_Create";
            this.NK_btn_Create.Size = new System.Drawing.Size(198, 46);
            this.NK_btn_Create.TabIndex = 11;
            this.NK_btn_Create.Text = "Create";
            this.NK_btn_Create.UseVisualStyleBackColor = true;
            this.NK_btn_Create.Click += new System.EventHandler(this.NK_btn_Create_Click);
            // 
            // NK_Form_SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 355);
            this.Controls.Add(this.NK_btn_Create);
            this.Controls.Add(this.NK_txt_PassS);
            this.Controls.Add(this.NK_txt_UserS);
            this.Controls.Add(this.NK_lbl_Password);
            this.Controls.Add(this.NK_lbl_Username);
            this.Controls.Add(this.NK_pnl_Registration);
            this.Controls.Add(this.NK_pic_OpenEye);
            this.Controls.Add(this.NK_pic_ClosedEye);
            this.Controls.Add(this.NK_pic_AddUser);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "NK_Form_SignUp";
            this.Text = "Sign up";
            this.Load += new System.EventHandler(this.NK_Form_SignUp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NK_pic_AddUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NK_pic_ClosedEye)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NK_pic_OpenEye)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NK_pic_Clear)).EndInit();
            this.NK_pnl_Registration.ResumeLayout(false);
            this.NK_pnl_Registration.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox NK_pic_AddUser;
        private System.Windows.Forms.PictureBox NK_pic_ClosedEye;
        private System.Windows.Forms.PictureBox NK_pic_OpenEye;
        private System.Windows.Forms.PictureBox NK_pic_Clear;
        private System.Windows.Forms.Panel NK_pnl_Registration;
        private System.Windows.Forms.Label NK_lbl_Registration;
        private System.Windows.Forms.Label NK_lbl_Username;
        private System.Windows.Forms.Label NK_lbl_Password;
        private System.Windows.Forms.TextBox NK_txt_UserS;
        private System.Windows.Forms.TextBox NK_txt_PassS;
        private System.Windows.Forms.Button NK_btn_Create;
    }
}

