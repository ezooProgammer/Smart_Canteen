using SmartCanteen.Reports;
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

namespace SmartCanteen
{
    public partial class Store : Form
    {
        public Store()
        {
            InitializeComponent();
        }
        public void GetData()
        {
            string query = "select Pro_ID , Pro_Name , Catid , c.category_name , Quantity  from Product p inner join Category c on c.Category_id = p.Catid ";
            query += " where Pro_Name like '%" + Searchtxt.Text + "%' ";
            //query += " OR Pro_ID like '%" + Searchtxt.Text + "%' ";
            ListBox lb = new ListBox();
            lb.Items.Add(dgvid);
            lb.Items.Add(dgvName);
            lb.Items.Add(dgvidcat);
            lb.Items.Add(Category);
            lb.Items.Add(Quantity);
            MainClass.LoadData(query, guna2DataGridView1, lb);
        }
        private void Searchtxt_TextChanged(object sender, EventArgs e)
        {
            GetData();
        }
        private void Store_Load(object sender, EventArgs e)
        {
            GetData();
            Searchtxt.Focus();
        }

        private void PrintBtn_Click(object sender, EventArgs e)
        {
            string qr = "select Pro_Name,Quantity from Product";
            SqlCommand cmd = new SqlCommand(qr, MainClass.con);
            MainClass.con.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            MainClass.con.Close();
            report r = new report();
            StoreReport1 sr = new StoreReport1();

            sr.SetDataSource(dt);
            r.crystalReportViewer1.ReportSource = sr;
            r.crystalReportViewer1.Refresh();
            r.Show();
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
