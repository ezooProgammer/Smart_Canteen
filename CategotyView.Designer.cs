namespace SmartCanteen
{
    partial class CategotyView
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
            this.label1 = new System.Windows.Forms.Label();
            this.AddBtn = new Guna.UI2.WinForms.Guna2ImageButton();
            this.Searchtxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(736, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Search";
            // 
            // AddBtn
            // 
            this.AddBtn.BackColor = System.Drawing.Color.Transparent;
            this.AddBtn.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.AddBtn.HoverState.ImageSize = new System.Drawing.Size(57, 57);
            this.AddBtn.Image = global::SmartCanteen.Properties.Resources.icons8_add_button_50;
            this.AddBtn.ImageOffset = new System.Drawing.Point(0, 0);
            this.AddBtn.ImageRotate = 0F;
            this.AddBtn.ImageSize = new System.Drawing.Size(55, 55);
            this.AddBtn.IndicateFocus = true;
            this.AddBtn.Location = new System.Drawing.Point(36, 79);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.PressedState.ImageSize = new System.Drawing.Size(55, 55);
            this.AddBtn.Size = new System.Drawing.Size(63, 54);
            this.AddBtn.TabIndex = 1;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // Searchtxt
            // 
            this.Searchtxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Searchtxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Searchtxt.DefaultText = "";
            this.Searchtxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Searchtxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Searchtxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Searchtxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Searchtxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Searchtxt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Searchtxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Searchtxt.IconLeft = global::SmartCanteen.Properties.Resources.icons8_search_641;
            this.Searchtxt.Location = new System.Drawing.Point(739, 88);
            this.Searchtxt.Name = "Searchtxt";
            this.Searchtxt.PasswordChar = '\0';
            this.Searchtxt.PlaceholderText = "Search here";
            this.Searchtxt.SelectedText = "";
            this.Searchtxt.Size = new System.Drawing.Size(285, 36);
            this.Searchtxt.TabIndex = 0;
            this.Searchtxt.TextChanged += new System.EventHandler(this.Searchtxt_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Header Text";
            // 
            // CategotyView
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1036, 588);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.Searchtxt);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CategotyView";
            this.Text = "CategotyView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        public Guna.UI2.WinForms.Guna2TextBox Searchtxt;
        public Guna.UI2.WinForms.Guna2ImageButton AddBtn;
    }
}