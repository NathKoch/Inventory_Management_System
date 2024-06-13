namespace Inventory_Management_System
{
    partial class NK_Form_Add
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NK_Form_Add));
            this.NK_pic_Admin = new System.Windows.Forms.PictureBox();
            this.NK_pnl_Registration = new System.Windows.Forms.Panel();
            this.NK_pic_Info = new System.Windows.Forms.PictureBox();
            this.NK_pic_Clear = new System.Windows.Forms.PictureBox();
            this.NK_lbl_Creating = new System.Windows.Forms.Label();
            this.NK_txt_Price = new System.Windows.Forms.TextBox();
            this.NK_txt_Supplier = new System.Windows.Forms.TextBox();
            this.NK_txt_Quantity = new System.Windows.Forms.TextBox();
            this.NK_txt_Type = new System.Windows.Forms.TextBox();
            this.NK_lbl_Type = new System.Windows.Forms.Label();
            this.NK_lbl_Price = new System.Windows.Forms.Label();
            this.NK_lbl_Quantity = new System.Windows.Forms.Label();
            this.NK_lbl_Supplier = new System.Windows.Forms.Label();
            this.NK_btn_Save = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.NK_pic_Admin)).BeginInit();
            this.NK_pnl_Registration.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NK_pic_Info)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NK_pic_Clear)).BeginInit();
            this.SuspendLayout();
            // 
            // NK_pic_Admin
            // 
            this.NK_pic_Admin.Image = ((System.Drawing.Image)(resources.GetObject("NK_pic_Admin.Image")));
            this.NK_pic_Admin.Location = new System.Drawing.Point(9, 12);
            this.NK_pic_Admin.Name = "NK_pic_Admin";
            this.NK_pic_Admin.Size = new System.Drawing.Size(113, 78);
            this.NK_pic_Admin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.NK_pic_Admin.TabIndex = 0;
            this.NK_pic_Admin.TabStop = false;
            // 
            // NK_pnl_Registration
            // 
            this.NK_pnl_Registration.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.NK_pnl_Registration.Controls.Add(this.NK_pic_Info);
            this.NK_pnl_Registration.Controls.Add(this.NK_pic_Clear);
            this.NK_pnl_Registration.Controls.Add(this.NK_lbl_Creating);
            this.NK_pnl_Registration.Location = new System.Drawing.Point(128, 12);
            this.NK_pnl_Registration.Name = "NK_pnl_Registration";
            this.NK_pnl_Registration.Size = new System.Drawing.Size(611, 78);
            this.NK_pnl_Registration.TabIndex = 6;
            // 
            // NK_pic_Info
            // 
            this.NK_pic_Info.Image = ((System.Drawing.Image)(resources.GetObject("NK_pic_Info.Image")));
            this.NK_pic_Info.Location = new System.Drawing.Point(442, 19);
            this.NK_pic_Info.Name = "NK_pic_Info";
            this.NK_pic_Info.Size = new System.Drawing.Size(80, 41);
            this.NK_pic_Info.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.NK_pic_Info.TabIndex = 7;
            this.NK_pic_Info.TabStop = false;
            // 
            // NK_pic_Clear
            // 
            this.NK_pic_Clear.Image = ((System.Drawing.Image)(resources.GetObject("NK_pic_Clear.Image")));
            this.NK_pic_Clear.Location = new System.Drawing.Point(528, 19);
            this.NK_pic_Clear.Name = "NK_pic_Clear";
            this.NK_pic_Clear.Size = new System.Drawing.Size(80, 41);
            this.NK_pic_Clear.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.NK_pic_Clear.TabIndex = 4;
            this.NK_pic_Clear.TabStop = false;
            this.NK_pic_Clear.Click += new System.EventHandler(this.NK_pic_Clear_Click);
            // 
            // NK_lbl_Creating
            // 
            this.NK_lbl_Creating.AutoSize = true;
            this.NK_lbl_Creating.Font = new System.Drawing.Font("Century Schoolbook", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NK_lbl_Creating.Location = new System.Drawing.Point(23, 24);
            this.NK_lbl_Creating.Name = "NK_lbl_Creating";
            this.NK_lbl_Creating.Size = new System.Drawing.Size(284, 41);
            this.NK_lbl_Creating.TabIndex = 6;
            this.NK_lbl_Creating.Text = "Entry creating";
            // 
            // NK_txt_Price
            // 
            this.NK_txt_Price.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.NK_txt_Price.Location = new System.Drawing.Point(245, 295);
            this.NK_txt_Price.Name = "NK_txt_Price";
            this.NK_txt_Price.Size = new System.Drawing.Size(270, 29);
            this.NK_txt_Price.TabIndex = 22;
            // 
            // NK_txt_Supplier
            // 
            this.NK_txt_Supplier.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.NK_txt_Supplier.Location = new System.Drawing.Point(245, 259);
            this.NK_txt_Supplier.Name = "NK_txt_Supplier";
            this.NK_txt_Supplier.Size = new System.Drawing.Size(270, 29);
            this.NK_txt_Supplier.TabIndex = 21;
            // 
            // NK_txt_Quantity
            // 
            this.NK_txt_Quantity.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.NK_txt_Quantity.Location = new System.Drawing.Point(245, 219);
            this.NK_txt_Quantity.Name = "NK_txt_Quantity";
            this.NK_txt_Quantity.Size = new System.Drawing.Size(270, 29);
            this.NK_txt_Quantity.TabIndex = 20;
            // 
            // NK_txt_Type
            // 
            this.NK_txt_Type.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.NK_txt_Type.Location = new System.Drawing.Point(245, 181);
            this.NK_txt_Type.Name = "NK_txt_Type";
            this.NK_txt_Type.Size = new System.Drawing.Size(270, 29);
            this.NK_txt_Type.TabIndex = 19;
            // 
            // NK_lbl_Type
            // 
            this.NK_lbl_Type.AutoSize = true;
            this.NK_lbl_Type.Location = new System.Drawing.Point(190, 189);
            this.NK_lbl_Type.Name = "NK_lbl_Type";
            this.NK_lbl_Type.Size = new System.Drawing.Size(49, 21);
            this.NK_lbl_Type.TabIndex = 17;
            this.NK_lbl_Type.Text = "Type:";
            // 
            // NK_lbl_Price
            // 
            this.NK_lbl_Price.AutoSize = true;
            this.NK_lbl_Price.Location = new System.Drawing.Point(189, 298);
            this.NK_lbl_Price.Name = "NK_lbl_Price";
            this.NK_lbl_Price.Size = new System.Drawing.Size(50, 21);
            this.NK_lbl_Price.TabIndex = 18;
            this.NK_lbl_Price.Text = "Price:";
            // 
            // NK_lbl_Quantity
            // 
            this.NK_lbl_Quantity.AutoSize = true;
            this.NK_lbl_Quantity.Location = new System.Drawing.Point(163, 222);
            this.NK_lbl_Quantity.Name = "NK_lbl_Quantity";
            this.NK_lbl_Quantity.Size = new System.Drawing.Size(76, 21);
            this.NK_lbl_Quantity.TabIndex = 16;
            this.NK_lbl_Quantity.Text = "Quantity:";
            // 
            // NK_lbl_Supplier
            // 
            this.NK_lbl_Supplier.AutoSize = true;
            this.NK_lbl_Supplier.Location = new System.Drawing.Point(163, 262);
            this.NK_lbl_Supplier.Name = "NK_lbl_Supplier";
            this.NK_lbl_Supplier.Size = new System.Drawing.Size(76, 21);
            this.NK_lbl_Supplier.TabIndex = 15;
            this.NK_lbl_Supplier.Text = "Supplier:";
            // 
            // NK_btn_Save
            // 
            this.NK_btn_Save.Location = new System.Drawing.Point(284, 359);
            this.NK_btn_Save.Name = "NK_btn_Save";
            this.NK_btn_Save.Size = new System.Drawing.Size(174, 51);
            this.NK_btn_Save.TabIndex = 23;
            this.NK_btn_Save.Text = "Save";
            this.NK_btn_Save.UseVisualStyleBackColor = true;
            this.NK_btn_Save.Click += new System.EventHandler(this.NK_btn_Save_Click);
            // 
            // NK_Form_Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 512);
            this.Controls.Add(this.NK_btn_Save);
            this.Controls.Add(this.NK_txt_Price);
            this.Controls.Add(this.NK_txt_Supplier);
            this.Controls.Add(this.NK_txt_Quantity);
            this.Controls.Add(this.NK_txt_Type);
            this.Controls.Add(this.NK_lbl_Type);
            this.Controls.Add(this.NK_lbl_Price);
            this.Controls.Add(this.NK_lbl_Quantity);
            this.Controls.Add(this.NK_lbl_Supplier);
            this.Controls.Add(this.NK_pnl_Registration);
            this.Controls.Add(this.NK_pic_Admin);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "NK_Form_Add";
            this.Text = "Add";
            ((System.ComponentModel.ISupportInitialize)(this.NK_pic_Admin)).EndInit();
            this.NK_pnl_Registration.ResumeLayout(false);
            this.NK_pnl_Registration.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NK_pic_Info)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NK_pic_Clear)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox NK_pic_Admin;
        private System.Windows.Forms.Panel NK_pnl_Registration;
        private System.Windows.Forms.PictureBox NK_pic_Clear;
        private System.Windows.Forms.Label NK_lbl_Creating;
        private System.Windows.Forms.PictureBox NK_pic_Info;
        private System.Windows.Forms.TextBox NK_txt_Price;
        private System.Windows.Forms.TextBox NK_txt_Supplier;
        private System.Windows.Forms.TextBox NK_txt_Quantity;
        private System.Windows.Forms.TextBox NK_txt_Type;
        private System.Windows.Forms.Label NK_lbl_Type;
        private System.Windows.Forms.Label NK_lbl_Price;
        private System.Windows.Forms.Label NK_lbl_Quantity;
        private System.Windows.Forms.Label NK_lbl_Supplier;
        private System.Windows.Forms.Button NK_btn_Save;
    }
}