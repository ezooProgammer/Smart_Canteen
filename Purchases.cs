using Guna.UI2.WinForms;
using System;
using System.Collections;
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
    public partial class Purchases : Form
    {
        public Purchases()
        {
            InitializeComponent();
          //  loadnamedata();
        }
        public int id = 0;
        public int mainid = 0;
        public int idT = 0;
        private void addtur()
        {
            string tryrype = "buy products";


            string query = "Insert into TransactionID Values (@Acc , @Type , @action , @Date)";

            Hashtable ht = new Hashtable();
            ht.Add("@idt", idT);
            ht.Add("@Acc", MainClass.names);
            ht.Add("@Type", tryrype);
            ht.Add("@action", CalculateTotalAmount());
            ht.Add("@Date", DateTime.Today.Date);

            MainClass.SQL(query, ht);

        }

        
        private void Purchases_Load(object sender, EventArgs e)
        {
            string query = "select Pro_ID 'id', Pro_Name 'name'  from Product";
            SqlCommand cmd = new SqlCommand(query, MainClass.con);
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            AutoCompleteStringCollection datasours = new AutoCompleteStringCollection();
            for (int i = 0; i < dt.Rows.Count; i++)
            {

                datasours.Add(dt.Rows[i]["name"].ToString());
                datasours.Add(dt.Rows[i]["id"].ToString());

            }

            this.textsearch.AutoCompleteCustomSource = datasours;
            this.textsearch.AutoCompleteSource = AutoCompleteSource.CustomSource;
            this.textsearch.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
        }


        private void textsearch_TextChanged(object sender, EventArgs e)
        {
            string query = "SELECT * FROM Product ";
            query += "where Pro_Name like '%" + textsearch.Text + "%'";
           

            SqlCommand cmd = new SqlCommand(query, MainClass.con);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                lid.Text = dt.Rows[0]["Pro_ID"].ToString();
                txtsale.Text = dt.Rows[0]["price"].ToString();
            }
            else
            {
                guna2MessageDialog1.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
                guna2MessageDialog1.Icon = Guna.UI2.WinForms.MessageDialogIcon.Error;
                guna2MessageDialog1.Show("This product does not exist....");
                textsearch.Text = "";

            }

        }


        private void textsearch_Leave(object sender, EventArgs e)
        {
            /*       string query = "SELECT * FROM Product ";
                   query += "where Pro_Name like '%" + textsearch.Text + "%'";
                   query += " OR code like '%" + textsearch.Text + "%' ";

                   SqlCommand cmd = new SqlCommand(query, MainClass.con);
                   DataTable dt = new DataTable();
                   SqlDataAdapter da = new SqlDataAdapter(cmd);
                   da.Fill(dt);

                   if (dt.Rows.Count > 0)
                   {
                       lid.Text = dt.Rows[0]["Pro_ID"].ToString();
                       txtsale.Text = dt.Rows[0]["price"].ToString();
                   }
                   else
                   {
                       MessageBox.Show("This product does not exist", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                       textsearch.Text = "";

                   }*/
        }
        public void total()
        {
            double qu = 0;
            double pricepur = 0;
            double totalqupr = 0;
            double.TryParse(txtqu.Text, out qu);
            double.TryParse(txtpurchase.Text, out pricepur);
            totalqupr = qu * pricepur;
            //  txttotal.Text = totalqupr.ToString();
            totalqupr.ToString();
        }
        private void txtqu_TextChanged(object sender, EventArgs e)
        {
            total();
        }
        private void txtpurchase_TextChanged(object sender, EventArgs e)
        {
            total();
        }
        private void guna2DataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            int count = 0;
            foreach (DataGridViewRow row in gunapur.Rows)
            {
                count++;
                row.Cells[0].Value = count;
            }
        }

        private double CalculateTotalAmount()
        {
            double totalAmount = 0;

            foreach (DataGridViewRow row in gunapur.Rows)
            {
                if (row.Cells["dgvtotal"].Value != null)
                {
                    totalAmount += Convert.ToDouble(row.Cells["dgvtotal"].Value);
                }
            }

            return totalAmount;
        }

        private void dtnsavepur_Click(object sender, EventArgs e)
        {
            //if (MainClass.con.State == ConnectionState.Closed)
            //{
            //    MainClass.con.Open();
            //}
            foreach (DataGridViewRow row in gunapur.Rows)
                {
                    //  string qury = " select pro_id from Purchases pu inner join Product p on p.Pro_ID = pu.pro_id where p.Pro_Name like '% " +textsearch+"%'";
                    int idp = int.Parse(row.Cells["dgvpid"].Value.ToString());
                    string pname = row.Cells["dgvName"].Value.ToString();
                    float pricee = float.Parse(row.Cells["dgvprice"].Value.ToString());
                    float qty = int.Parse(row.Cells["dgvqu"].Value.ToString());
                    float totalz = float.Parse(row.Cells["dgvtotal"].Value.ToString());
                string query = @"insert into Purchases(pro_id , Purchase_price ,  QTY , Total , Purchase_Date ) VALUES(@idp, @pricee, @qty, @totalz, @datet)";
                Hashtable ht = new Hashtable();
                ht.Add("@idp", idp);
                ht.Add("@pricee", pricee);
                ht.Add("@qty", qty);
                ht.Add("@totalz", totalz);
                ht.Add("@datet", DateTime.Today.Date);
                MainClass.SQL(query, ht);
            }            
            guna2MessageDialog1.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
            guna2MessageDialog1.Icon = Guna.UI2.WinForms.MessageDialogIcon.None;
            guna2MessageDialog1.Show("Saved...");
            addtur();
            gunapur.Rows.Clear();
        }
        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {}
        private void Btnadd_Click(object sender, EventArgs e)
        {
            if (txtpurchase.Text == "" || txtqu.Text == "" || txtsale.Text == "")
            {
                guna2MessageDialog1.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
                guna2MessageDialog1.Icon = Guna.UI2.WinForms.MessageDialogIcon.Error;
                guna2MessageDialog1.Show("Please fill in  data...");
                return;
            }
            string pid = lid.Text;
            string pname = textsearch.Text;
          //  var dt = DateTime.Today.Date.ToString("MM/dd/yyy");
         //  string dtt = dt.ToString("MM/dd/yyy"); ;
            float qty = float.Parse(txtqu.Text);
            float pricee = float.Parse(txtpurchase.Text);
            //     float totalz = float.Parse(txttotal.Text);
            float totalz = qty * pricee;
            
            gunapur.Rows.Add(0, 0, pid, pname, pricee, qty, totalz , DateTime.Today.Date.ToString("MM/dd/yyy"));
            //

            //   int qu = 0;
            int qunew = 0;
            int qutotal = 0;
            string quold = "select Quantity from Product ";
            quold += "where Pro_Name like '%" + textsearch.Text + "%'";
            //quold += " OR code like '%" + textsearch.Text + "%' ";
            SqlCommand cmd = new SqlCommand(quold, MainClass.con);
            MainClass.con.Open();
            object quo = cmd.ExecuteScalar();
            int qu = Convert.ToInt32(quo);
            //  int.TryParse(quold, out qu);
            int.TryParse(txtqu.Text, out qunew);
            qutotal = qu + qunew;

            string query = "Update Product Set Pro_Name = @Name , price=@price , Quantity= @Quantity  ";
            query += "where Pro_Name like '%" + textsearch.Text + "%'";
            //query += " OR code like '%" + textsearch.Text + "%' ";


            Hashtable ht = new Hashtable();
            ht.Add("@id", id);
            ht.Add("@Name", textsearch.Text);
            ht.Add("@price", txtsale.Text);
            ht.Add("@quantity", qutotal);


            if (MainClass.SQL(query, ht) > 0)
            {
                textsearch.Text = "";
                txtqu.Text = "";
                txtpurchase.Text = "";
                txtsale.Text = "";
                MainClass.con.Close();
            }
        }
        private void btnclear_Click(object sender, EventArgs e)
        {
            gunapur.Rows.Clear();
        }
    }
}

