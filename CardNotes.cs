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
    public partial class CardNotes : Form
    {
        public CardNotes()
        {
            InitializeComponent();
        }
        public int id;
        public int idT;

        private void addtur()
        {
            string tryrype = "Add Note ";


            string query = "Insert into TransactionID Values (@Acc , @Type , @action , @Date)";

            Hashtable ht = new Hashtable();
            ht.Add("@idt", idT);
            ht.Add("@Acc", MainClass.names);
            ht.Add("@Type", tryrype);
            ht.Add("@action", txtnote.Text);
            ht.Add("@Date", DateTime.Today.Date);

            MainClass.SQL(query, ht);

        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (txtnote.Text=="")
            {
                txtnote.BorderColor = Color.Red;
                txtnote.FocusedState.BorderColor = Color.Red;
                txtnote.HoverState.BorderColor = Color.Red;
                guna2MessageDialog1.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
                guna2MessageDialog1.Icon = Guna.UI2.WinForms.MessageDialogIcon.Error;
                guna2MessageDialog1.Show("Please enter a note....");
                txtnote.Focus();
                return;
            }   
            string query = "Update Cards Set Note = @note  where Card_ID = @id";        
             Hashtable ht = new Hashtable();
            ht.Add("@id",id);
            ht.Add("@note", txtnote.Text);
            if (MainClass.SQL(query, ht) > 0)
            {
                guna2MessageDialog1.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
                guna2MessageDialog1.Icon = Guna.UI2.WinForms.MessageDialogIcon.None;
                guna2MessageDialog1.Show("Notes saved successfully...");
                this.Close();
                id = 0;
                txtnote.Text = "";
                txtnote.Focus();
            }
        }
        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void guna2PictureBox7_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void guna2PictureBox6_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        private void forupdateloaddata()
        {
            string query = @"select Note from Cards where Card_ID = " + id + "";
            SqlCommand cmd = new SqlCommand(query, MainClass.con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);


            if (dt.Rows.Count > 0)
            {
                txtnote.Text = dt.Rows[0]["Note"].ToString();
            }
        }

        private void CardNotes_Load(object sender, EventArgs e)
        {
            txtnote.Focus();
            string query = "Select Note from Cards";

            if (id > 0)
            {
                forupdateloaddata();
            }

        }

            }
        }
