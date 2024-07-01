namespace SmartCanteen
{
    partial class BtnProduct
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.PriceLbl = new System.Windows.Forms.Label();
            this.ProductLbl = new System.Windows.Forms.Label();
            this.CategoryLbl = new System.Windows.Forms.Label();
            this.guna2GradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.BorderRadius = 10;
            this.guna2GradientPanel1.Controls.Add(this.PriceLbl);
            this.guna2GradientPanel1.Controls.Add(this.ProductLbl);
            this.guna2GradientPanel1.Controls.Add(this.CategoryLbl);
            this.guna2GradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2GradientPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(79)))), ((int)(((byte)(80)))));
            this.guna2GradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(79)))), ((int)(((byte)(80)))));
            this.guna2GradientPanel1.Location = new System.Drawing.Point(4, 4);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.Size = new System.Drawing.Size(176, 132);
            this.guna2GradientPanel1.TabIndex = 0;
            // 
            // PriceLbl
            // 
            this.PriceLbl.BackColor = System.Drawing.Color.Transparent;
            this.PriceLbl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PriceLbl.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriceLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(125)))), ((int)(((byte)(49)))));
            this.PriceLbl.Location = new System.Drawing.Point(0, 115);
            this.PriceLbl.Name = "PriceLbl";
            this.PriceLbl.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.PriceLbl.Size = new System.Drawing.Size(176, 17);
            this.PriceLbl.TabIndex = 7;
            this.PriceLbl.Text = "LYD";
            this.PriceLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ProductLbl
            // 
            this.ProductLbl.BackColor = System.Drawing.Color.Transparent;
            this.ProductLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProductLbl.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductLbl.ForeColor = System.Drawing.Color.White;
            this.ProductLbl.Location = new System.Drawing.Point(0, 17);
            this.ProductLbl.Name = "ProductLbl";
            this.ProductLbl.Size = new System.Drawing.Size(176, 115);
            this.ProductLbl.TabIndex = 6;
            this.ProductLbl.Text = "Product";
            this.ProductLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ProductLbl.Click += new System.EventHandler(this.ProductLbl_Click);
            // 
            // CategoryLbl
            // 
            this.CategoryLbl.BackColor = System.Drawing.Color.Transparent;
            this.CategoryLbl.Dock = System.Windows.Forms.DockStyle.Top;
            this.CategoryLbl.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CategoryLbl.ForeColor = System.Drawing.Color.White;
            this.CategoryLbl.Location = new System.Drawing.Point(0, 0);
            this.CategoryLbl.Name = "CategoryLbl";
            this.CategoryLbl.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.CategoryLbl.Size = new System.Drawing.Size(176, 17);
            this.CategoryLbl.TabIndex = 5;
            this.CategoryLbl.Text = "Category";
            // 
            // BtnProduct
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(68)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.guna2GradientPanel1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(68)))), ((int)(((byte)(64)))));
            this.Name = "BtnProduct";
            this.Padding = new System.Windows.Forms.Padding(4);
            this.Size = new System.Drawing.Size(184, 140);
            this.guna2GradientPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private System.Windows.Forms.Label CategoryLbl;
        private System.Windows.Forms.Label PriceLbl;
        private System.Windows.Forms.Label ProductLbl;
    }
}
