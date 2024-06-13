namespace Inventory_Management_System
{
    partial class NK_Form_Administration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NK_Form_Administration));
            this.NK_pnl_Registration = new System.Windows.Forms.Panel();
            this.NK_lbl_Creating = new System.Windows.Forms.Label();
            this.NK_pic_Admin = new System.Windows.Forms.PictureBox();
            this.NK_btn_Save = new System.Windows.Forms.Button();
            this.NK_btn_Delete = new System.Windows.Forms.Button();
            this.NK_Admin_dataGridView = new System.Windows.Forms.DataGridView();
            this.NK_pnl_Registration.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NK_pic_Admin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NK_Admin_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // NK_pnl_Registration
            // 
            this.NK_pnl_Registration.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.NK_pnl_Registration.Controls.Add(this.NK_lbl_Creating);
            this.NK_pnl_Registration.Location = new System.Drawing.Point(126, 12);
            this.NK_pnl_Registration.Name = "NK_pnl_Registration";
            this.NK_pnl_Registration.Size = new System.Drawing.Size(528, 78);
            this.NK_pnl_Registration.TabIndex = 25;
            // 
            // NK_lbl_Creating
            // 
            this.NK_lbl_Creating.AutoSize = true;
            this.NK_lbl_Creating.Font = new System.Drawing.Font("Century Schoolbook", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NK_lbl_Creating.Location = new System.Drawing.Point(68, 19);
            this.NK_lbl_Creating.Name = "NK_lbl_Creating";
            this.NK_lbl_Creating.Size = new System.Drawing.Size(297, 41);
            this.NK_lbl_Creating.TabIndex = 6;
            this.NK_lbl_Creating.Text = "Administration";
            // 
            // NK_pic_Admin
            // 
            this.NK_pic_Admin.Image = ((System.Drawing.Image)(resources.GetObject("NK_pic_Admin.Image")));
            this.NK_pic_Admin.Location = new System.Drawing.Point(2, 2);
            this.NK_pic_Admin.Name = "NK_pic_Admin";
            this.NK_pic_Admin.Size = new System.Drawing.Size(118, 99);
            this.NK_pic_Admin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.NK_pic_Admin.TabIndex = 24;
            this.NK_pic_Admin.TabStop = false;
            // 
            // NK_btn_Save
            // 
            this.NK_btn_Save.Location = new System.Drawing.Point(110, 571);
            this.NK_btn_Save.Name = "NK_btn_Save";
            this.NK_btn_Save.Size = new System.Drawing.Size(174, 51);
            this.NK_btn_Save.TabIndex = 34;
            this.NK_btn_Save.Text = "Save";
            this.NK_btn_Save.UseVisualStyleBackColor = true;
            this.NK_btn_Save.Click += new System.EventHandler(this.NK_btn_Save_Click);
            // 
            // NK_btn_Delete
            // 
            this.NK_btn_Delete.Location = new System.Drawing.Point(363, 571);
            this.NK_btn_Delete.Name = "NK_btn_Delete";
            this.NK_btn_Delete.Size = new System.Drawing.Size(174, 51);
            this.NK_btn_Delete.TabIndex = 35;
            this.NK_btn_Delete.Text = "Delete";
            this.NK_btn_Delete.UseVisualStyleBackColor = true;
            this.NK_btn_Delete.Click += new System.EventHandler(this.NK_btn_Delete_Click);
            // 
            // NK_Admin_dataGridView
            // 
            this.NK_Admin_dataGridView.AllowUserToAddRows = false;
            this.NK_Admin_dataGridView.AllowUserToDeleteRows = false;
            this.NK_Admin_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.NK_Admin_dataGridView.Location = new System.Drawing.Point(12, 125);
            this.NK_Admin_dataGridView.Name = "NK_Admin_dataGridView";
            this.NK_Admin_dataGridView.Size = new System.Drawing.Size(634, 409);
            this.NK_Admin_dataGridView.TabIndex = 36;
            // 
            // NK_Form_Administration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 666);
            this.Controls.Add(this.NK_Admin_dataGridView);
            this.Controls.Add(this.NK_btn_Delete);
            this.Controls.Add(this.NK_pnl_Registration);
            this.Controls.Add(this.NK_pic_Admin);
            this.Controls.Add(this.NK_btn_Save);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "NK_Form_Administration";
            this.Text = "Administration";
            this.Load += new System.EventHandler(this.NK_Form_Administration_Load);
            this.NK_pnl_Registration.ResumeLayout(false);
            this.NK_pnl_Registration.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NK_pic_Admin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NK_Admin_dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel NK_pnl_Registration;
        private System.Windows.Forms.Label NK_lbl_Creating;
        private System.Windows.Forms.PictureBox NK_pic_Admin;
        private System.Windows.Forms.Button NK_btn_Save;
        private System.Windows.Forms.Button NK_btn_Delete;
        private System.Windows.Forms.DataGridView NK_Admin_dataGridView;
    }
}