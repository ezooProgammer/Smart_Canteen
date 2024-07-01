using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartCanteen
{
    public partial class NewCardForm : Form
    {
        public NewCardForm()
        {
            InitializeComponent();
        }
        public int idT = 0;
        private void addtur()
        {
            string tryrype = "Import card";


            string query = "Insert into TransactionID Values (@Acc , @Type , @action , @Date)";

            Hashtable ht = new Hashtable();
            ht.Add("@idt", idT);
            ht.Add("@Acc", MainClass.names);
            ht.Add("@Type", tryrype);
            ht.Add("@action", lbid.Text);
            ht.Add("@Date", DateTime.Today.Date);

            MainClass.SQL(query, ht);

        }

        Byte[] ImageByteArrayy;
        private void NewCardForm_Load(object sender, EventArgs e)
        {
            float cardWidthDefault = 30 * 25.4f; // العرض بالبكسل
            float cardHeightDefault = 0.76f * 25.4f; // الارتفاع بالبكسل

            // تحديد حجم الصفحة لـ printDocument1 ليكون مطابقًا للأبعاد التصميمية للبطاقة
            printDocument1.DefaultPageSettings.PaperSize = new PaperSize("front", (int)cardWidthDefault, (int)cardHeightDefault);

            // تحديد حجم الصفحة لـ printDocument2 ليكون مطابقًا للأبعاد التصميمية للبطاقة
            printDocument2.DefaultPageSettings.PaperSize = new PaperSize("back", (int)cardWidthDefault, (int)cardHeightDefault);

            DateTime dt = DateTime.Now.Date;
            lbdate.Text = dt.ToString("yyy/MM/dd");
            DateTime dend = dt.AddYears(+1);
            lbend.Text = dend.ToString("yyy/MM/dd");
            lbid.Text = StudentForm.studentid;
            lbname.Text = StudentForm.studentname;
            var stuim = StudentForm.studentimage;
            var byteconvertimage = new MemoryStream(stuim);
            Image byteconvertimage2 = Image.FromStream(byteconvertimage);
            imagestu.Image = byteconvertimage2;
        }

        private void Btnfront_Click(object sender, EventArgs e)
        {
            printDocument1.DocumentName = "Print Document";
            printDialog1.Document = printDocument1;
            printDialog1.AllowSelection = true;
            printDialog1.AllowSomePages = true;
            if (printDialog1.ShowDialog() == DialogResult.OK) printDocument1.Print();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            if (printDialog2.ShowDialog() == DialogResult.OK) printDocument2.Print();
        }
        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            // تحديد الأبعاد الفعلية للبطاقة (30 mil أو 0.76 mm)
            float cardWidthActual = 30 * 25.4f; // تحويل 30 mil إلى ملليمتر
            float cardHeightActual = 0.76f * 25.4f; // تحويل 0.76 mm إلى ملليمتر

            // تحديد حجم الصفحة ليكون مطابقًا لأبعاد البطاقة الفعلية
            e.PageSettings.PaperSize = new PaperSize("front", (int)cardWidthActual, (int)cardHeightActual);

            // إعادة تحديد أبعاد الصورة (front) لتتناسب مع الحجم الجديد للصفحة
            int h = e.PageBounds.Height;
            int w = e.PageBounds.Width;

            // رسم الصورة في الصفحة باستخدام الأبعاد الجديدة
            Bitmap bt = new Bitmap(w, h);
            Rectangle re = new Rectangle(0, 0, w, h);
            front.DrawToBitmap(bt, re);
            e.Graphics.DrawImage(bt, re);
            //// تحديد الأبعاد الفعلية للبطاقة (30 mil أو 0.76 ملم)
            //float cardWidthActual = 0.76f * e.Graphics.DpiX / 25.4f; // العرض بالبكسل
            //float cardHeightActual = 0.76f * e.Graphics.DpiY / 25.4f; // الارتفاع بالبكسل

            //// تحديد حجم الصفحة ليكون مطابقًا لأبعاد البطاقة الفعلية
            //e.PageSettings.PaperSize = new PaperSize("front", (int)cardWidthActual, (int)cardHeightActual);

            //// إعادة تحديد أبعاد الصورة (front) لتتناسب مع الحجم الجديد للصفحة
            //int h = e.PageBounds.Height;
            //int w = e.PageBounds.Width;

            //// رسم الصورة في الصفحة باستخدام الأبعاد الجديدة
            //Bitmap bt = new Bitmap(w, h);
            //Rectangle re = new Rectangle(0, 0, w, h);
            //front.DrawToBitmap(bt, re);
            //e.Graphics.DrawImage(bt, re);
        }
        private void printDocument2_PrintPage(object sender, PrintPageEventArgs e)
        {
            // تحديد الأبعاد الفعلية للبطاقة (30 mil أو 0.76 mm)
            float cardWidthActual = 30 * 25.4f; // تحويل 30 mil إلى ملليمتر
            float cardHeightActual = 0.76f * 25.4f; // تحويل 0.76 mm إلى ملليمتر

            // تحديد حجم الصفحة ليكون مطابقًا لأبعاد البطاقة الفعلية
            e.PageSettings.PaperSize = new PaperSize("back", (int)cardWidthActual, (int)cardHeightActual);

            // إعادة تحديد أبعاد الصورة (front) لتتناسب مع الحجم الجديد للصفحة
            int h = e.PageBounds.Height;
            int w = e.PageBounds.Width;

            // رسم الصورة في الصفحة باستخدام الأبعاد الجديدة
            Bitmap bt = new Bitmap(w, h);
            Rectangle re = new Rectangle(0, 0, w, h);
            back.DrawToBitmap(bt, re);
            e.Graphics.DrawImage(bt, re);
            //// تحديد الأبعاد الفعلية للبطاقة (30 mil أو 0.76 ملم)
            //float cardWidthActual = 0.76f * e.Graphics.DpiX / 25.4f; // العرض بالبكسل
            //float cardHeightActual = 0.76f * e.Graphics.DpiY / 25.4f; // الارتفاع بالبكسل

            //// تحديد حجم الصفحة ليكون مطابقًا لأبعاد البطاقة الفعلية
            //e.PageSettings.PaperSize = new PaperSize("back", (int)cardWidthActual, (int)cardHeightActual);

            //// إعادة تحديد أبعاد الصورة (front) لتتناسب مع الحجم الجديد للصفحة
            //int h = e.PageBounds.Height;
            //int w = e.PageBounds.Width;

            //// رسم الصورة في الصفحة باستخدام الأبعاد الجديدة
            //Bitmap bt = new Bitmap(w, h);
            //Rectangle re = new Rectangle(0, 0, w, h);
            //back.DrawToBitmap(bt, re);
            //e.Graphics.DrawImage(bt, re);
        }

        private void Btnsave_Click(object sender, EventArgs e)
        {
            string query;
            query = "Insert into Cards(Card_ID , stu_id  , Expiry_Date ) Values (@id , @idstu, @Expiry_Date )";
            Hashtable ht = new Hashtable();
            ht.Add("@id", lbid.Text);
            ht.Add("@idstu", lbid.Text);
            ht.Add("@Expiry_Date", DateTime.Parse(lbend.Text));
            if (MainClass.SQL(query, ht) > 0)
            {
                guna2MessageDialog1.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
                guna2MessageDialog1.Icon = Guna.UI2.WinForms.MessageDialogIcon.None;
                guna2MessageDialog1.Show("saved successfullly...");
                addtur();
                this.Close();
            }
        }
        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();   
        }
        private void guna2PictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void guna2PictureBox3_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
