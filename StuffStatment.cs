using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartCanteen
{
    public partial class StuffStatment : Form
    {
        public StuffStatment()
        {
            InitializeComponent();
        }
        public void GetData()
        {
            //DateTime swld = dates.Value;
            string query = "select *from TransactionID ";
            ListBox lb = new ListBox();
            lb.Items.Add(dgvid);
            lb.Items.Add(dgvName);
            lb.Items.Add(dgvt);
            lb.Items.Add(dgva);
            lb.Items.Add(dgvd);
            MainClass.LoadData(query, gunads, lb);
        }
        private void StuffStatment_Load(object sender, EventArgs e)
        {
            GetData();
        }

        private void dates_ValueChanged(object sender, EventArgs e)
        {
            string query = "select *from TransactionID where TDate= '" + TransactionDate.Value.ToString("yyyy-MM-dd") + "'";
            ListBox lb = new ListBox();
            lb.Items.Add(dgvid);
            lb.Items.Add(dgvName);
            lb.Items.Add(dgvt);
            lb.Items.Add(dgva);
            lb.Items.Add(dgvd);
            MainClass.LoadData(query, gunads, lb);

        }
        private void guna2PictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void guna2PictureBox3_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;

        }

        private void ExportBtn_Click(object sender, EventArgs e)
        {
            if (TransactionDate.Value != null )
            {
                string qr = @"select * from TransactionID
                      
                      where TDate=@TransactionDate"
                ;

                SqlCommand cmd = new SqlCommand(qr, MainClass.con);
                cmd.Parameters.AddWithValue("@TransactionDate", TransactionDate.Value.Date);
                MainClass.con.Open();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                MainClass.con.Close();
                if (dt.Rows.Count > 0) // التحقق من وجود بيانات قبل عرض التقرير
                {
                    report r = new report();
                    TransactionReport sr = new TransactionReport();
                    sr.SetDataSource(dt);
                    r.crystalReportViewer1.ReportSource = sr;
                    r.crystalReportViewer1.Refresh();
                    r.Show();
                }
                else
                {
                    MessageBox.Show("لا توجد بيانات متوفرة بين التواريخ المحددة.");
                }
            }
            else
            {
                MessageBox.Show("الرجاء تحديد تاريخ البداية وتاريخ النهاية.");
            }
        }
    }
    }

