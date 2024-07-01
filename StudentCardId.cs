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
    public partial class StudentCardId : Form
    {
        public StudentCardId()
        {
            InitializeComponent();
        }

        private void closedBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MinimizedBTN_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void ReportBtn_Click(object sender, EventArgs e)
        {
            // التأكد من أن القيمة المدخلة صحيحة قبل تحويلها لتجنب استثناءات غير متوقعة
            if (int.TryParse(CardIdValue.Text, out int cardId))
            {
                // استعلام SQL
                string qr = @"SELECT n.invoice_Date, s.product_id, p.Pro_Name, c.stu_id, T.Student_Name 
                  FROM Invoice n
                  INNER JOIN Sales s ON n.invoice_ID = s.invoice_id 
                  INNER JOIN Product p ON p.Pro_ID = s.product_id
                  INNER JOIN Cards c ON c.Card_ID = n.cardId
                  INNER JOIN Student T ON c.stu_id = T.Student_ID
                  WHERE c.Card_ID = @CardIdValue"; // تم تعديلها هنا لضمان الشرط الصحيح

                // استخدام using لضمان إغلاق الاتصال بقاعدة البيانات تلقائيًا
                using (SqlConnection con = new SqlConnection(MainClass.con_string))
                {
                    using (SqlCommand cmd = new SqlCommand(qr, con))
                    {
                        cmd.Parameters.AddWithValue("@CardIdValue", cardId);

                        try
                        {
                            con.Open();
                            DataTable dt = new DataTable();
                            SqlDataAdapter da = new SqlDataAdapter(cmd);
                            da.Fill(dt);

                            // التحقق مما إذا كانت هناك بيانات معينة في الجدول
                            if (dt.Rows.Count > 0)
                            {
                                report r = new report();
                                StudentReport sr = new StudentReport();

                                sr.SetDataSource(dt);
                                r.crystalReportViewer1.ReportSource = sr;
                                r.crystalReportViewer1.Refresh();
                                r.Show();
                            }
                            else
                            {
                                MessageBox.Show("لا توجد بيانات تطابق الشرط المحدد.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("حدث خطأ: " + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("الرجاء إدخال قيمة رقمية صحيحة.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
    }
}
