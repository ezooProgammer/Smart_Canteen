using SmartCanteen.model;
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
    public partial class StudentForm : Form
    {
        public static string studentname;
        public static string barcodeid;
        public static string studentid;
        public static string barcodeimge;
        public static Image barcodimage;
        public static byte[] studentimage;
        public StudentForm()
        {
            InitializeComponent();
        }
        public void GetData()
        {
            string query = "select * From Student ";
            query += " where Student_Name like '%" + Searchtxt.Text + "%' ";
            query += " OR Student_ID like '%" + Searchtxt.Text + "%' ";
            ListBox lb = new ListBox();
            lb.Items.Add(dgvid);
            lb.Items.Add(dgvName);
            lb.Items.Add(dgvGrade);
            lb.Items.Add(dgvParentNumber);
            lb.Items.Add(dgvimage);
            MainClass.LoadData(query, guna2DataGridView1, lb);
        }
        private void AddBtn_Click(object sender, EventArgs e)
        {
            MainClass.BlueBackGround(new AddStudent());
            GetData();
        }
        private void ProductsBtn_Click(object sender, EventArgs e)
        {
            if (guna2DataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = guna2DataGridView1.SelectedRows[0];
                studentid = selectedRow.Cells["dgvid"].Value.ToString();
                studentname = selectedRow.Cells["dgvName"].Value.ToString();
                studentimage = (byte[])selectedRow.Cells["dgvimage"].Value;
                string cardQuery = "SELECT * FROM Cards WHERE stu_id = '" + studentid + "'";
                DataTable cardDataTable = MainClass.RetriveData(cardQuery);

                if (cardDataTable.Rows.Count > 0)
                {
                    // Student already has a card
                    guna2MessageDialog1.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
                    guna2MessageDialog1.Icon = Guna.UI2.WinForms.MessageDialogIcon.Information;
                    guna2MessageDialog1.Show("This student already has a card");
                }
                else
                {
                    barcodeid = studentid;
                    Zen.Barcode.Code128BarcodeDraw barcode = Zen.Barcode.BarcodeDrawFactory.Code128WithChecksum;
                    NewCardForm ncard = new NewCardForm();
                    ncard.imagebarcode.Image = barcode.Draw(barcodeid, 1000);
                    MainClass.BlueBackGround(ncard);
                }
            }
            else
            {
                guna2MessageDialog1.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
                guna2MessageDialog1.Icon = Guna.UI2.WinForms.MessageDialogIcon.Error;
                guna2MessageDialog1.Show("There is an error in the student data, please confirm!..");
            }
        }

        private void Searchtxt_TextChanged(object sender, EventArgs e)
        {
            GetData();
        }
        private void StudentForm_Load(object sender, EventArgs e)
        {
            GetData();
            Searchtxt.Focus();
        }

        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (guna2DataGridView1.CurrentCell.OwningColumn.Name == "dgvEdit")
            {
                AddStudent astu = new AddStudent();
                astu.id = Convert.ToInt32(guna2DataGridView1.CurrentRow.Cells["dgvid"].Value);
                MainClass.BlueBackGround(astu);
                GetData();
            }
        }
        private void guna2DataGridView1_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
  
        }
    }
}
