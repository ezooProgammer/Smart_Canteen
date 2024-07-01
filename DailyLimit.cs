using System;
using System.Collections;
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
    public partial class DailyLimit : Form
    {
        public DailyLimit()
        {
            InitializeComponent();
        }
        public int id;
        public int idT = 0;
        private void addtur()
        {
            string tryrype = " Add daily limit ";


            string query = "Insert into TransactionID Values (@Acc , @Type , @action , @Date)";

            Hashtable ht = new Hashtable();
            ht.Add("@idt", idT);
            ht.Add("@Acc", MainClass.names);
            ht.Add("@Type", tryrype);
            ht.Add("@action", txtlimit.Text);
            ht.Add("@Date", DateTime.Today.Date);

            MainClass.SQL(query, ht);

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

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (txtlimit.Text=="")
            {
                txtlimit.BorderColor = Color.Red;
                txtlimit.FocusedState.BorderColor = Color.Red;
                txtlimit.HoverState.BorderColor = Color.Red;
                guna2MessageDialog1.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
                guna2MessageDialog1.Icon = Guna.UI2.WinForms.MessageDialogIcon.Error;
                guna2MessageDialog1.Show("Please enter the daily limiting for the student.");
                txtlimit.Focus();
                return;
            }
            string query = "Update Cards  Set Daily_limit = @Daily_limit  where Card_ID = @id";
            Hashtable ht = new Hashtable();
            ht.Add("@id", id);
            ht.Add("@Daily_limit", txtlimit.Text);
            if (MainClass.SQL(query, ht) > 0)
            {
                guna2MessageDialog1.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
                guna2MessageDialog1.Icon = Guna.UI2.WinForms.MessageDialogIcon.None;
                guna2MessageDialog1.Show("saved successfullly...");
                id = 0;
                txtlimit.Text = "";
                this.Close();
            }
        }

        private void txtlimit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

        }
    }
}

