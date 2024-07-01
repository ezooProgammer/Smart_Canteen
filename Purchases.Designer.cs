namespace SmartCanteen
{
    partial class Purchases
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.label2 = new System.Windows.Forms.Label();
            this.gunapur = new Guna.UI2.WinForms.Guna2DataGridView();
            this.dgvSno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvpid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvprice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvqu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewImageColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.txtqu = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtpurchase = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.dtnsavepur = new Guna.UI2.WinForms.Guna2Button();
            this.btnclear = new Guna.UI2.WinForms.Guna2Button();
            this.textsearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtsale = new Guna.UI2.WinForms.Guna2TextBox();
            this.lid = new System.Windows.Forms.Label();
            this.guna2MessageDialog1 = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.Btnadd = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.gunapur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(12, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = " Product Name :";
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Separator1.Location = new System.Drawing.Point(15, 44);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(990, 10);
            this.guna2Separator1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(40, 12);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.label2.Size = new System.Drawing.Size(106, 32);
            this.label2.TabIndex = 0;
            this.label2.Text = "purchases";
            // 
            // gunapur
            // 
            this.gunapur.AllowUserToAddRows = false;
            this.gunapur.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.gunapur.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gunapur.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gunapur.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gunapur.ColumnHeadersHeight = 40;
            this.gunapur.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.gunapur.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvSno,
            this.dgvid,
            this.dgvpid,
            this.dgvName,
            this.dgvprice,
            this.dgvqu,
            this.dgvtotal,
            this.dgvdate,
            this.Edit});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gunapur.DefaultCellStyle = dataGridViewCellStyle3;
            this.gunapur.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gunapur.Location = new System.Drawing.Point(15, 220);
            this.gunapur.Name = "gunapur";
            this.gunapur.ReadOnly = true;
            this.gunapur.RowHeadersVisible = false;
            this.gunapur.RowTemplate.Height = 35;
            this.gunapur.Size = new System.Drawing.Size(995, 282);
            this.gunapur.TabIndex = 65;
            this.gunapur.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.gunapur.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.gunapur.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.gunapur.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.gunapur.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.gunapur.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.gunapur.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gunapur.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            this.gunapur.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gunapur.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunapur.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.gunapur.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.gunapur.ThemeStyle.HeaderStyle.Height = 40;
            this.gunapur.ThemeStyle.ReadOnly = true;
            this.gunapur.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.gunapur.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gunapur.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunapur.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gunapur.ThemeStyle.RowsStyle.Height = 35;
            this.gunapur.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gunapur.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gunapur.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.guna2DataGridView1_CellContentClick);
            this.gunapur.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.guna2DataGridView1_CellFormatting);
            // 
            // dgvSno
            // 
            this.dgvSno.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgvSno.FillWeight = 70F;
            this.dgvSno.HeaderText = "Sr#";
            this.dgvSno.MinimumWidth = 70;
            this.dgvSno.Name = "dgvSno";
            this.dgvSno.ReadOnly = true;
            this.dgvSno.Width = 70;
            // 
            // dgvid
            // 
            this.dgvid.HeaderText = "id";
            this.dgvid.Name = "dgvid";
            this.dgvid.ReadOnly = true;
            this.dgvid.Visible = false;
            // 
            // dgvpid
            // 
            this.dgvpid.HeaderText = "pid";
            this.dgvpid.Name = "dgvpid";
            this.dgvpid.ReadOnly = true;
            this.dgvpid.Visible = false;
            // 
            // dgvName
            // 
            this.dgvName.HeaderText = "Name";
            this.dgvName.Name = "dgvName";
            this.dgvName.ReadOnly = true;
            // 
            // dgvprice
            // 
            this.dgvprice.HeaderText = "Price";
            this.dgvprice.Name = "dgvprice";
            this.dgvprice.ReadOnly = true;
            // 
            // dgvqu
            // 
            this.dgvqu.HeaderText = "Quantity";
            this.dgvqu.Name = "dgvqu";
            this.dgvqu.ReadOnly = true;
            // 
            // dgvtotal
            // 
            this.dgvtotal.HeaderText = "Total";
            this.dgvtotal.Name = "dgvtotal";
            this.dgvtotal.ReadOnly = true;
            // 
            // dgvdate
            // 
            this.dgvdate.HeaderText = "Date";
            this.dgvdate.Name = "dgvdate";
            this.dgvdate.ReadOnly = true;
            // 
            // Edit
            // 
            this.Edit.HeaderText = "";
            this.Edit.Image = global::SmartCanteen.Properties.Resources.icons8_edit_24__2_;
            this.Edit.Name = "Edit";
            this.Edit.ReadOnly = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(147, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Quantity :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(12, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "buying price : :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(147, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = " price :";
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = global::SmartCanteen.Properties.Resources.icons8_edit_24__2_;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            this.dataGridViewImageColumn1.Width = 154;
            // 
            // txtqu
            // 
            this.txtqu.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtqu.DefaultText = "";
            this.txtqu.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtqu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtqu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtqu.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtqu.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtqu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtqu.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtqu.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtqu.IconRight = global::SmartCanteen.Properties.Resources.icons8_plus_and_minus_30;
            this.txtqu.Location = new System.Drawing.Point(150, 167);
            this.txtqu.Name = "txtqu";
            this.txtqu.PasswordChar = '\0';
            this.txtqu.PlaceholderText = "0";
            this.txtqu.SelectedText = "";
            this.txtqu.Size = new System.Drawing.Size(115, 36);
            this.txtqu.TabIndex = 4;
            this.txtqu.Tag = "v";
            this.txtqu.TextChanged += new System.EventHandler(this.txtqu_TextChanged);
            // 
            // txtpurchase
            // 
            this.txtpurchase.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtpurchase.DefaultText = "";
            this.txtpurchase.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtpurchase.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtpurchase.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtpurchase.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtpurchase.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtpurchase.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtpurchase.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtpurchase.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtpurchase.IconRight = global::SmartCanteen.Properties.Resources.icons8_money_24__1_;
            this.txtpurchase.IconRightSize = new System.Drawing.Size(18, 18);
            this.txtpurchase.Location = new System.Drawing.Point(15, 165);
            this.txtpurchase.Name = "txtpurchase";
            this.txtpurchase.PasswordChar = '\0';
            this.txtpurchase.PlaceholderText = "LYD";
            this.txtpurchase.SelectedText = "";
            this.txtpurchase.Size = new System.Drawing.Size(115, 36);
            this.txtpurchase.TabIndex = 3;
            this.txtpurchase.Tag = "v";
            this.txtpurchase.TextChanged += new System.EventHandler(this.txtpurchase_TextChanged);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.Image = global::SmartCanteen.Properties.Resources.icons8_bill_662;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(0, 12);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(43, 32);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 64;
            this.guna2PictureBox1.TabStop = false;
            this.guna2PictureBox1.UseTransparentBackground = true;
            // 
            // dtnsavepur
            // 
            this.dtnsavepur.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtnsavepur.AutoRoundedCorners = true;
            this.dtnsavepur.BorderRadius = 17;
            this.dtnsavepur.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.dtnsavepur.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.dtnsavepur.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.dtnsavepur.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.dtnsavepur.FillColor = System.Drawing.Color.LightSeaGreen;
            this.dtnsavepur.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.dtnsavepur.ForeColor = System.Drawing.Color.White;
            this.dtnsavepur.Image = global::SmartCanteen.Properties.Resources.icons8_save_321;
            this.dtnsavepur.Location = new System.Drawing.Point(716, 165);
            this.dtnsavepur.Name = "dtnsavepur";
            this.dtnsavepur.Size = new System.Drawing.Size(140, 36);
            this.dtnsavepur.TabIndex = 6;
            this.dtnsavepur.Text = "Save";
            this.dtnsavepur.Click += new System.EventHandler(this.dtnsavepur_Click);
            // 
            // btnclear
            // 
            this.btnclear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnclear.AutoRoundedCorners = true;
            this.btnclear.BorderRadius = 17;
            this.btnclear.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnclear.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnclear.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnclear.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnclear.FillColor = System.Drawing.Color.Red;
            this.btnclear.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear.ForeColor = System.Drawing.Color.White;
            this.btnclear.Image = global::SmartCanteen.Properties.Resources.icons8_clear_24;
            this.btnclear.Location = new System.Drawing.Point(862, 165);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(140, 36);
            this.btnclear.TabIndex = 7;
            this.btnclear.Text = "Clear";
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // textsearch
            // 
            this.textsearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textsearch.DefaultText = "";
            this.textsearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textsearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textsearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textsearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textsearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textsearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textsearch.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textsearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textsearch.IconRight = global::SmartCanteen.Properties.Resources.icons8_search_641;
            this.textsearch.Location = new System.Drawing.Point(15, 87);
            this.textsearch.Name = "textsearch";
            this.textsearch.PasswordChar = '\0';
            this.textsearch.PlaceholderText = "search";
            this.textsearch.SelectedText = "";
            this.textsearch.Size = new System.Drawing.Size(115, 36);
            this.textsearch.TabIndex = 1;
            this.textsearch.Tag = "v";
            this.textsearch.TextChanged += new System.EventHandler(this.textsearch_TextChanged);
            this.textsearch.Leave += new System.EventHandler(this.textsearch_Leave);
            // 
            // txtsale
            // 
            this.txtsale.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtsale.DefaultText = "";
            this.txtsale.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtsale.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtsale.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtsale.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtsale.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtsale.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtsale.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtsale.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtsale.IconRight = global::SmartCanteen.Properties.Resources.icons8_money_24__1_;
            this.txtsale.IconRightSize = new System.Drawing.Size(18, 18);
            this.txtsale.Location = new System.Drawing.Point(150, 87);
            this.txtsale.Name = "txtsale";
            this.txtsale.PasswordChar = '\0';
            this.txtsale.PlaceholderText = "LYD";
            this.txtsale.SelectedText = "";
            this.txtsale.Size = new System.Drawing.Size(115, 36);
            this.txtsale.TabIndex = 2;
            this.txtsale.Tag = "v";
            // 
            // lid
            // 
            this.lid.AutoSize = true;
            this.lid.Font = new System.Drawing.Font("Segoe UI", 1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lid.Location = new System.Drawing.Point(7, 120);
            this.lid.Name = "lid";
            this.lid.Size = new System.Drawing.Size(2, 3);
            this.lid.TabIndex = 83;
            this.lid.Text = ".";
            // 
            // guna2MessageDialog1
            // 
            this.guna2MessageDialog1.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
            this.guna2MessageDialog1.Caption = null;
            this.guna2MessageDialog1.Icon = Guna.UI2.WinForms.MessageDialogIcon.None;
            this.guna2MessageDialog1.Parent = null;
            this.guna2MessageDialog1.Style = Guna.UI2.WinForms.MessageDialogStyle.Dark;
            this.guna2MessageDialog1.Text = null;
            // 
            // Btnadd
            // 
            this.Btnadd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btnadd.AutoRoundedCorners = true;
            this.Btnadd.BorderRadius = 17;
            this.Btnadd.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Btnadd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Btnadd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Btnadd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Btnadd.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(74)))), ((int)(((byte)(69)))));
            this.Btnadd.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btnadd.ForeColor = System.Drawing.Color.White;
            this.Btnadd.Image = global::SmartCanteen.Properties.Resources.icons8_add_new_24;
            this.Btnadd.Location = new System.Drawing.Point(570, 165);
            this.Btnadd.Name = "Btnadd";
            this.Btnadd.Size = new System.Drawing.Size(140, 36);
            this.Btnadd.TabIndex = 5;
            this.Btnadd.Text = "Add";
            this.Btnadd.Click += new System.EventHandler(this.Btnadd_Click);
            // 
            // Purchases
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1014, 610);
            this.Controls.Add(this.Btnadd);
            this.Controls.Add(this.lid);
            this.Controls.Add(this.txtsale);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textsearch);
            this.Controls.Add(this.txtqu);
            this.Controls.Add(this.txtpurchase);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.gunapur);
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.guna2Separator1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtnsavepur);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Purchases";
            this.Tag = "";
            this.Text = "Purchases";
            this.Load += new System.EventHandler(this.Purchases_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gunapur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btnclear;
        private Guna.UI2.WinForms.Guna2Button dtnsavepur;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        public System.Windows.Forms.Label label2;
        public Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2DataGridView gunapur;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TextBox textsearch;
        private Guna.UI2.WinForms.Guna2TextBox txtsale;
        public Guna.UI2.WinForms.Guna2TextBox txtpurchase;
        public Guna.UI2.WinForms.Guna2TextBox txtqu;
        private System.Windows.Forms.Label lid;
        public Guna.UI2.WinForms.Guna2MessageDialog guna2MessageDialog1;
        private Guna.UI2.WinForms.Guna2Button Btnadd;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvSno;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvid;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvpid;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvprice;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvqu;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvdate;
        private System.Windows.Forms.DataGridViewImageColumn Edit;
    }
}