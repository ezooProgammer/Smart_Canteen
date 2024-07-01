using SmartCanteen.model;
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
    public partial class ReportsForm : Form
    {
        public ReportsForm()
        {
            InitializeComponent();
        }

        private void Enabledbtn()
        {
            StartDate.Enabled = true;
            EndDate.Enabled = true;
         
        }
        private void Deeabledbtn()
        {
            StartDate.Enabled = false;
            EndDate.Enabled = false;
          
        }

        private void StoreRpt_Click(object sender, EventArgs e)
        {
            if (StartDate.Value != null && EndDate.Value != null)
            {
                string qr = @"select * from Purchases p inner join Product r on p.pro_id=r.Pro_ID where p.Purchase_Date 
                            between @startdate and @enddate";

                SqlCommand cmd = new SqlCommand(qr, MainClass.con);
                cmd.Parameters.AddWithValue("@startdate", StartDate.Value.Date);
                cmd.Parameters.AddWithValue("@enddate", EndDate.Value.Date);
                MainClass.con.Open();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                MainClass.con.Close();
                if (dt.Rows.Count > 0) // التحقق من وجود بيانات قبل عرض التقرير
                {
                    report r = new report();
                    PurchasesReport sr = new PurchasesReport();
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

        private void label1_Click(object sender, EventArgs e)
        {
            
            if (StartDate.Value != null && EndDate.Value != null)
            {
                string qr = @"select * from Invoice n
                      inner join Sales s on n.invoice_ID=s.invoice_id 
                      inner join Product p on p.Pro_ID=s.product_id
                      inner join Category c on c.Category_id=p.Catid
                      where n.invoice_Date between @startdate and @enddate";

                SqlCommand cmd = new SqlCommand(qr, MainClass.con);
                cmd.Parameters.AddWithValue("@startdate", StartDate.Value.Date);
                cmd.Parameters.AddWithValue("@enddate", EndDate.Value.Date);
                MainClass.con.Open();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                MainClass.con.Close();
                if (dt.Rows.Count > 0) // التحقق من وجود بيانات قبل عرض التقرير
                {
                    report r = new report();
                    SalesReport sr = new SalesReport();
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

        private void label5_Click(object sender, EventArgs e)
        {
            string qr = @"select Deposit ,s.Student_Name,e.Emp_Name from Cards c inner join Student s on c.stu_id=s.Student_ID
                         inner join Employee e on c.Empid=e.Emp_ID where Deposit_Date=@Todaydate ";
            SqlCommand cmd = new SqlCommand(qr, MainClass.con);
            cmd.Parameters.AddWithValue("@Todaydate", DateTime.Now.Date);
            MainClass.con.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            MainClass.con.Close();
            report r = new report();
            DepositReport sr = new DepositReport();

            sr.SetDataSource(dt);
            r.crystalReportViewer1.ReportSource = sr;
            r.crystalReportViewer1.Refresh();
            r.Show();
        }

        private void StudentReport_Click(object sender, EventArgs e)
        {
            MainClass.BlueBackGround(new StudentCardId());
           
        }
    }
    }

