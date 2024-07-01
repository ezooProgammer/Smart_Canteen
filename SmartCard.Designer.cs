namespace SmartCanteen
{
    partial class SmartCard
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
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.label2 = new System.Windows.Forms.Label();
            this.SmartCardGridView = new Guna.UI2.WinForms.Guna2DataGridView();
            this.DepositBtn = new Guna.UI2.WinForms.Guna2Button();
            this.DailyLimitBtn = new Guna.UI2.WinForms.Guna2Button();
            this.NoteBtn = new Guna.UI2.WinForms.Guna2Button();
            this.NotAllowedd = new Guna.UI2.WinForms.Guna2Button();
            this.guna2PictureBox2 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.CategoryLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.guna2MessageDialog1 = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.texcards = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dgvsro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvidstu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvdailyLimit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvbalance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvWithdrawal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvamount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvnote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvdeposit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dvgshipping = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.SmartCardGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Separator1.FillColor = System.Drawing.Color.DarkGray;
            this.guna2Separator1.Location = new System.Drawing.Point(8, 33);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(982, 10);
            this.guna2Separator1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(36, 5);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.label2.Size = new System.Drawing.Size(116, 32);
            this.label2.TabIndex = 0;
            this.label2.Text = "Smart Card";
            // 
            // SmartCardGridView
            // 
            this.SmartCardGridView.AllowUserToAddRows = false;
            this.SmartCardGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.SmartCardGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.SmartCardGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.SmartCardGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.SmartCardGridView.ColumnHeadersHeight = 40;
            this.SmartCardGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.SmartCardGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvsro,
            this.dgvid,
            this.dgvidstu,
            this.dgvName,
            this.dgvdailyLimit,
            this.dgvbalance,
            this.dgvWithdrawal,
            this.dgvamount,
            this.dgvdate,
            this.dgvnote,
            this.dgvdeposit,
            this.dvgshipping});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.SmartCardGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.SmartCardGridView.Enabled = false;
            this.SmartCardGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.SmartCardGridView.Location = new System.Drawing.Point(12, 378);
            this.SmartCardGridView.Name = "SmartCardGridView";
            this.SmartCardGridView.ReadOnly = true;
            this.SmartCardGridView.RowHeadersVisible = false;
            this.SmartCardGridView.RowTemplate.Height = 35;
            this.SmartCardGridView.Size = new System.Drawing.Size(954, 234);
            this.SmartCardGridView.TabIndex = 0;
            this.SmartCardGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.SmartCardGridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.SmartCardGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.SmartCardGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.SmartCardGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.SmartCardGridView.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.SmartCardGridView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.SmartCardGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            this.SmartCardGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.SmartCardGridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SmartCardGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.SmartCardGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.SmartCardGridView.ThemeStyle.HeaderStyle.Height = 40;
            this.SmartCardGridView.ThemeStyle.ReadOnly = true;
            this.SmartCardGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.SmartCardGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.SmartCardGridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SmartCardGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.SmartCardGridView.ThemeStyle.RowsStyle.Height = 35;
            this.SmartCardGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.SmartCardGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.SmartCardGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SmartCardGridView_CellContentClick);
            // 
            // DepositBtn
            // 
            this.DepositBtn.AutoRoundedCorners = true;
            this.DepositBtn.BorderRadius = 80;
            this.DepositBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.DepositBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.DepositBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.DepositBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.DepositBtn.Enabled = false;
            this.DepositBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DepositBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.DepositBtn.ForeColor = System.Drawing.Color.White;
            this.DepositBtn.Image = global::SmartCanteen.Properties.Resources.icons8_card_50__1_;
            this.DepositBtn.ImageSize = new System.Drawing.Size(100, 100);
            this.DepositBtn.Location = new System.Drawing.Point(708, 136);
            this.DepositBtn.Name = "DepositBtn";
            this.DepositBtn.Size = new System.Drawing.Size(192, 162);
            this.DepositBtn.TabIndex = 5;
            this.DepositBtn.Click += new System.EventHandler(this.DepositBtn_Click);
            // 
            // DailyLimitBtn
            // 
            this.DailyLimitBtn.AutoRoundedCorners = true;
            this.DailyLimitBtn.BorderRadius = 80;
            this.DailyLimitBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.DailyLimitBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.DailyLimitBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.DailyLimitBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.DailyLimitBtn.Enabled = false;
            this.DailyLimitBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DailyLimitBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.DailyLimitBtn.ForeColor = System.Drawing.Color.White;
            this.DailyLimitBtn.Image = global::SmartCanteen.Properties.Resources.icons8_withdrawal_limit_802;
            this.DailyLimitBtn.ImageSize = new System.Drawing.Size(100, 100);
            this.DailyLimitBtn.Location = new System.Drawing.Point(486, 136);
            this.DailyLimitBtn.Name = "DailyLimitBtn";
            this.DailyLimitBtn.Size = new System.Drawing.Size(192, 162);
            this.DailyLimitBtn.TabIndex = 4;
            this.DailyLimitBtn.Click += new System.EventHandler(this.DailyLimitBtn_Click);
            // 
            // NoteBtn
            // 
            this.NoteBtn.AutoRoundedCorners = true;
            this.NoteBtn.BorderRadius = 80;
            this.NoteBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.NoteBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.NoteBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.NoteBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.NoteBtn.Enabled = false;
            this.NoteBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.NoteBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.NoteBtn.ForeColor = System.Drawing.Color.White;
            this.NoteBtn.Image = global::SmartCanteen.Properties.Resources.icons8_note_50;
            this.NoteBtn.ImageSize = new System.Drawing.Size(80, 80);
            this.NoteBtn.Location = new System.Drawing.Point(257, 136);
            this.NoteBtn.Name = "NoteBtn";
            this.NoteBtn.Size = new System.Drawing.Size(192, 162);
            this.NoteBtn.TabIndex = 3;
            this.NoteBtn.Click += new System.EventHandler(this.NoteBtn_Click);
            // 
            // NotAllowedd
            // 
            this.NotAllowedd.AutoRoundedCorners = true;
            this.NotAllowedd.BorderRadius = 80;
            this.NotAllowedd.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.NotAllowedd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.NotAllowedd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.NotAllowedd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.NotAllowedd.Enabled = false;
            this.NotAllowedd.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.NotAllowedd.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.NotAllowedd.ForeColor = System.Drawing.Color.White;
            this.NotAllowedd.Image = global::SmartCanteen.Properties.Resources.icons8_id_not_verified_1002;
            this.NotAllowedd.ImageSize = new System.Drawing.Size(120, 120);
            this.NotAllowedd.Location = new System.Drawing.Point(41, 136);
            this.NotAllowedd.Name = "NotAllowedd";
            this.NotAllowedd.Size = new System.Drawing.Size(192, 162);
            this.NotAllowedd.TabIndex = 2;
            this.NotAllowedd.Click += new System.EventHandler(this.NotAllowedd_Click);
            // 
            // guna2PictureBox2
            // 
            this.guna2PictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox2.Image = global::SmartCanteen.Properties.Resources.icons8_card_payment_50;
            this.guna2PictureBox2.ImageRotate = 0F;
            this.guna2PictureBox2.Location = new System.Drawing.Point(-6, 7);
            this.guna2PictureBox2.Name = "guna2PictureBox2";
            this.guna2PictureBox2.Size = new System.Drawing.Size(46, 35);
            this.guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox2.TabIndex = 67;
            this.guna2PictureBox2.TabStop = false;
            this.guna2PictureBox2.UseTransparentBackground = true;
            // 
            // CategoryLbl
            // 
            this.CategoryLbl.BackColor = System.Drawing.Color.Transparent;
            this.CategoryLbl.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CategoryLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(125)))), ((int)(((byte)(49)))));
            this.CategoryLbl.Location = new System.Drawing.Point(51, 301);
            this.CategoryLbl.Name = "CategoryLbl";
            this.CategoryLbl.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.CategoryLbl.Size = new System.Drawing.Size(167, 36);
            this.CategoryLbl.TabIndex = 0;
            this.CategoryLbl.Text = "NOT ALLOWED";
            this.CategoryLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(125)))), ((int)(((byte)(49)))));
            this.label1.Location = new System.Drawing.Point(277, 301);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.label1.Size = new System.Drawing.Size(141, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "NOTES";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(125)))), ((int)(((byte)(49)))));
            this.label3.Location = new System.Drawing.Point(515, 301);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.label3.Size = new System.Drawing.Size(141, 36);
            this.label3.TabIndex = 0;
            this.label3.Text = "DAILY LIMIT";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(125)))), ((int)(((byte)(49)))));
            this.label4.Location = new System.Drawing.Point(746, 301);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.label4.Size = new System.Drawing.Size(141, 36);
            this.label4.TabIndex = 0;
            this.label4.Text = "DEPOSIT";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(74)))), ((int)(((byte)(49)))));
            this.label5.Location = new System.Drawing.Point(12, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Scan card barcode";
            // 
            // guna2MessageDialog1
            // 
            this.guna2MessageDialog1.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
            this.guna2MessageDialog1.Caption = "Message...";
            this.guna2MessageDialog1.Icon = Guna.UI2.WinForms.MessageDialogIcon.None;
            this.guna2MessageDialog1.Parent = null;
            this.guna2MessageDialog1.Style = Guna.UI2.WinForms.MessageDialogStyle.Light;
            this.guna2MessageDialog1.Text = null;
            // 
            // texcards
            // 
            this.texcards.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.texcards.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.texcards.Location = new System.Drawing.Point(15, 81);
            this.texcards.Name = "texcards";
            this.texcards.Size = new System.Drawing.Size(226, 33);
            this.texcards.TabIndex = 68;
            this.texcards.TextChanged += new System.EventHandler(this.texcards_TextChanged);
            this.texcards.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.texcards_KeyPress);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SmartCanteen.Properties.Resources.icons8_search_64;
            this.pictureBox1.Location = new System.Drawing.Point(207, 85);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(27, 23);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 69;
            this.pictureBox1.TabStop = false;
            // 
            // dgvsro
            // 
            this.dgvsro.HeaderText = "Sr#";
            this.dgvsro.Name = "dgvsro";
            this.dgvsro.ReadOnly = true;
            this.dgvsro.Visible = false;
            // 
            // dgvid
            // 
            this.dgvid.HeaderText = "id";
            this.dgvid.Name = "dgvid";
            this.dgvid.ReadOnly = true;
            // 
            // dgvidstu
            // 
            this.dgvidstu.HeaderText = "idstu";
            this.dgvidstu.Name = "dgvidstu";
            this.dgvidstu.ReadOnly = true;
            this.dgvidstu.Visible = false;
            // 
            // dgvName
            // 
            this.dgvName.HeaderText = "Name";
            this.dgvName.Name = "dgvName";
            this.dgvName.ReadOnly = true;
            // 
            // dgvdailyLimit
            // 
            this.dgvdailyLimit.HeaderText = "daily limit";
            this.dgvdailyLimit.Name = "dgvdailyLimit";
            this.dgvdailyLimit.ReadOnly = true;
            // 
            // dgvbalance
            // 
            this.dgvbalance.HeaderText = "balance";
            this.dgvbalance.Name = "dgvbalance";
            this.dgvbalance.ReadOnly = true;
            // 
            // dgvWithdrawal
            // 
            this.dgvWithdrawal.HeaderText = "Withdrawal";
            this.dgvWithdrawal.Name = "dgvWithdrawal";
            this.dgvWithdrawal.ReadOnly = true;
            // 
            // dgvamount
            // 
            this.dgvamount.HeaderText = "amount";
            this.dgvamount.Name = "dgvamount";
            this.dgvamount.ReadOnly = true;
            // 
            // dgvdate
            // 
            this.dgvdate.HeaderText = "Expiry Date";
            this.dgvdate.Name = "dgvdate";
            this.dgvdate.ReadOnly = true;
            // 
            // dgvnote
            // 
            this.dgvnote.HeaderText = "Notes";
            this.dgvnote.Name = "dgvnote";
            this.dgvnote.ReadOnly = true;
            // 
            // dgvdeposit
            // 
            this.dgvdeposit.HeaderText = "Deposit";
            this.dgvdeposit.Name = "dgvdeposit";
            this.dgvdeposit.ReadOnly = true;
            this.dgvdeposit.Visible = false;
            // 
            // dvgshipping
            // 
            this.dvgshipping.HeaderText = "Deposit_Date";
            this.dvgshipping.Name = "dvgshipping";
            this.dvgshipping.ReadOnly = true;
            // 
            // SmartCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1000, 668);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.texcards);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CategoryLbl);
            this.Controls.Add(this.DepositBtn);
            this.Controls.Add(this.DailyLimitBtn);
            this.Controls.Add(this.NoteBtn);
            this.Controls.Add(this.NotAllowedd);
            this.Controls.Add(this.SmartCardGridView);
            this.Controls.Add(this.guna2PictureBox2);
            this.Controls.Add(this.guna2Separator1);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SmartCard";
            this.Text = "SmartCard";
            this.Load += new System.EventHandler(this.SmartCard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SmartCardGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox2;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        public System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2DataGridView SmartCardGridView;
        private Guna.UI2.WinForms.Guna2Button NotAllowedd;
        private Guna.UI2.WinForms.Guna2Button NoteBtn;
        private Guna.UI2.WinForms.Guna2Button DailyLimitBtn;
        private Guna.UI2.WinForms.Guna2Button DepositBtn;
        private System.Windows.Forms.Label CategoryLbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        public Guna.UI2.WinForms.Guna2MessageDialog guna2MessageDialog1;
        private System.Windows.Forms.TextBox texcards;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvsro;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvid;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvidstu;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvdailyLimit;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvbalance;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvWithdrawal;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvamount;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvnote;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvdeposit;
        private System.Windows.Forms.DataGridViewTextBoxColumn dvgshipping;
    }
}