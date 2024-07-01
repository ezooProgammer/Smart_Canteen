using SmartCanteen.model;
using SmartCanteen.Reports;
using SmartCanteen.view;
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
    public partial class StuffForm : Form
    {
        public StuffForm()
        {
            InitializeComponent();
        }
        public void GetDatar()
        {

            string query = "select* From Employee  where Role like '%" + cmbrole.SelectedItem + "%' ";
            ListBox lb = new ListBox();
            lb.Items.Add(dgvid);
            lb.Items.Add(dgvName);
            lb.Items.Add(dgvRole);
            lb.Items.Add(dgvPhone);
            lb.Items.Add(dgvAccount);
            lb.Items.Add(dgvPassword);
            lb.Items.Add(dgvStartingDate);
            lb.Items.Add(dgvisactive);
            MainClass.LoadData(query, guna2DataGridView1, lb);


        }

        public void GetDatas()
        {

            string query = "select* From Employee  where IsActive like '%" + cmbstate.SelectedIndex + "%' ";
            ListBox lb = new ListBox();
            lb.Items.Add(dgvid);
            lb.Items.Add(dgvName);
            lb.Items.Add(dgvRole);
            lb.Items.Add(dgvPhone);
            lb.Items.Add(dgvAccount);
            lb.Items.Add(dgvPassword);
            lb.Items.Add(dgvStartingDate);
            lb.Items.Add(dgvisactive);
            MainClass.LoadData(query, guna2DataGridView1, lb);


        }

        public void GetData()
        {
            string query = "select* From Employee ";
            query += " where Emp_ID like '%" + Searchtxt.Text + "%' ";
            query += " OR Emp_Name like '%" + Searchtxt.Text + "%' ";


            ListBox lb = new ListBox();
            lb.Items.Add(dgvid);
            lb.Items.Add(dgvName);
            lb.Items.Add(dgvRole);
            lb.Items.Add(dgvPhone);
            lb.Items.Add(dgvAccount);
            lb.Items.Add(dgvPassword);
            lb.Items.Add(dgvStartingDate);
            lb.Items.Add(dgvisactive);
            MainClass.LoadData(query, guna2DataGridView1, lb);

        }


        private void StuffStatementBtn_Click(object sender, EventArgs e)
        {
            MainClass.BlueBackGround(new StuffStatment());
        }
        private void AddBtn_Click(object sender, EventArgs e)
        {
            MainClass.BlueBackGround(new StuffAdd());
            GetData();
        }
        private void StuffForm_Load(object sender, EventArgs e)
        {
            GetData();
        }
        private void Searchtxt_TextChanged(object sender, EventArgs e)
        {
            GetData();

        }

        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (guna2DataGridView1.CurrentCell.OwningColumn.Name == "dgvEdit")
            {
                StuffAdd SA = new StuffAdd();
                SA.id = Convert.ToInt32(guna2DataGridView1.CurrentRow.Cells["dgvid"].Value);
                SA.ShowDialog();
                GetData();
            }

        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetDatar();
        }

        private void StuffPrintBtn_Click(object sender, EventArgs e)
        {
            string qr = "select Emp_Name,Role,Phone,Start_Date from Employee";
            SqlCommand cmd = new SqlCommand(qr, MainClass.con);
            MainClass.con.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            MainClass.con.Close();
            report r = new report();
            StuffReport sr = new StuffReport();

            sr.SetDataSource(dt);
            r.crystalReportViewer1.ReportSource = sr;
            r.crystalReportViewer1.Refresh();
            r.Show();
        }
        private void cmbstate_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetDatas();
        }
    }
}
