using SmartCanteen.view;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartCanteen
{
    public partial class MainForm : Form
    {
        private Dashboard model;
        private Button currentBtn;
        public MainForm()
        {
            InitializeComponent();
            dtpStartDate.Value = DateTime.Today.AddDays(-7);
            dtpEndDate.Value = DateTime.Now;
            btnLast7Days.Select();
            DisableCustomDates(btnLast7Days);
            model = new Dashboard();
            Loaddata();
        }
        private void Loaddata()
        {
            var refreashdata = model.loadData(dtpStartDate.Value, dtpEndDate.Value);
            if (refreashdata == true)
            {
                lblNumberOfOrders.Text = model.NumOrders.ToString();
                lblTotalRevenue.Text = "LYD" + model.TotalRevenue.ToString();
                lblTotalProfit.Text = "LYD" + model.Totalprofit.ToString();

                lblNumberofProducts.Text = model.Numproducts.ToString();
                lblNumberofStudents.Text = model.NumStudent.ToString();

                chartGroosRevenue.DataSource = model.GrossRevenueList;
                chartGroosRevenue.Series[0].XValueMember = "Date";
                chartGroosRevenue.Series[0].YValueMembers = "TotalAmount";
                chartGroosRevenue.DataBind();

                chartTop5Products.DataSource = model.TopProductsList;
                chartTop5Products.Series[0].XValueMember = "key";
                chartTop5Products.Series[0].YValueMembers = "value";
                chartTop5Products.DataBind();

                dgvUnderStock.DataSource = model.UnderStockList;
                dgvUnderStock.Columns[0].HeaderText = "Item";
                dgvUnderStock.Columns[1].HeaderText = "Units";

                Console.WriteLine("loaded view:)");
            }
            else Console.WriteLine("view not loaded ,same query");
        }




        static MainForm _obj;
        public static MainForm instance
        {
            get { if( _obj == null ) { _obj = new MainForm(); } return _obj; }
        }
        public void AddControls(Form f)
        {
            CenterPanel.Controls.Clear();
            f.Dock = DockStyle.Fill;
            f.TopLevel = false;
            CenterPanel.Controls.Add(f);
            f.Show();
        }
        private void UsersBtn_Click(object sender, EventArgs e)
        {
            AddControls(new StuffForm());
        }
        private void CategoriesBtn_Click(object sender, EventArgs e)
        {
            AddControls(new FrmCategoryView());
        }
        private void ProductsBtn_Click(object sender, EventArgs e)
        {
            AddControls(new FrmProdctViewcs());
        }
        private void BuyBtn_Click(object sender, EventArgs e)
        {
         

            BuyForm b = new BuyForm();
            this.Close();
            b.Show();
            
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            _obj = this;
            UserLabel.Text = MainClass.names;
          //  UserLabel.Text = MainClass.USER;
        }
        private void purcheseBtn_Click(object sender, EventArgs e)
        {
            AddControls(new Purchases());
        }
        private void StoreBtn_Click(object sender, EventArgs e)
        {
            AddControls(new Store());
        }
        private void SmartBtn_Click(object sender, EventArgs e)
        {
            AddControls(new SmartCard());
        }
        private void ReportsBtn_Click(object sender, EventArgs e)
        {
            AddControls(new ReportsForm());
        }
        private void StudentBtn_Click(object sender, EventArgs e)
        {
            AddControls(new StudentForm());
        }
        private void guna2PictureBox5_Click(object sender, EventArgs e)
        {
            this.Close();
            login g = new login();
            g.Show();
        }
        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void DisableCustomDates(object button)
        {
            //Highlight button

            var btn = (Button)button;
            btn.BackColor = BtnLast30Days.FlatAppearance.BorderColor;
            btn.ForeColor = Color.White;

            //Unhighlight button

            if (currentBtn != null&&currentBtn!=btn)
            {
                currentBtn.BackColor = this.BackColor;
                currentBtn.ForeColor = Color.FromArgb(237, 125, 25);
            }
            currentBtn = btn;


            //    dtpStartDate.Enabled = false;
            //    dtpEndDate.Enabled = false;
            //    btnOK.Visible = false;
        }
        private void btnToday_Click(object sender, EventArgs e)
        {
            dtpStartDate.Value = DateTime.Today;
            dtpEndDate.Value = DateTime.Now;
            Loaddata();
            DisableCustomDates(sender);
                
        }

        private void btnLast7Days_Click(object sender, EventArgs e)
        {
            dtpStartDate.Value = DateTime.Today.AddDays(-7);
            dtpEndDate.Value = DateTime.Now;
            Loaddata();
            DisableCustomDates(sender);
        }

        private void BtnLast30Days_Click(object sender, EventArgs e)
        {
            dtpStartDate.Value = DateTime.Today.AddDays(-30);
            dtpEndDate.Value = DateTime.Now;
            Loaddata();
            DisableCustomDates(sender);
        }

        private void btnThisMonth_Click(object sender, EventArgs e)
        {
            dtpStartDate.Value = new DateTime(DateTime.Today.Year,DateTime.Today.Month,1);
            dtpEndDate.Value = DateTime.Now;
            Loaddata();
            DisableCustomDates(sender);
        }

        private void btnCustomDate_Click(object sender, EventArgs e)
        {
            dtpStartDate.Enabled = true;
            dtpEndDate.Enabled = true;
            btnOK.Visible = true;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Loaddata();
        }

        private void BtnHome_Click(object sender, EventArgs e)
        {
            MainClass mc = new MainClass();

            if (!(CenterPanel.Visible)){
                
            }
        }

       
    }
}
