using SmartCanteen.model;

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
using System.Web.UI;
using System.Windows.Forms;

namespace SmartCanteen
{
    public partial class SmartCard : Form
    {

        public static string textsearch = "";
        public SmartCard()
        {
            InitializeComponent();
        }

        public void GetData()
        {
            string query = "select Card_ID ,stu_id , s.Student_Name ,Daily_limit , Balance, Amount , Withdrawal  , Expiry_Date ,  Note , Deposit, Deposit_Date from Cards c inner join Student s on s.Student_ID = c.stu_id ";
            query += " where Card_ID like '%" + texcards.Text + "%' ";
            ListBox lb = new ListBox();
            lb.Items.Add(dgvid);
            lb.Items.Add(dgvidstu);
            lb.Items.Add(dgvName);
            lb.Items.Add(dgvdailyLimit);
            lb.Items.Add(dgvbalance);
            lb.Items.Add(dgvamount);
            lb.Items.Add(dgvWithdrawal);
            lb.Items.Add(dgvdate);
            lb.Items.Add(dgvnote);
            lb.Items.Add(dgvdeposit);
            lb.Items.Add(dvgshipping);
            MainClass.LoadData(query, SmartCardGridView, lb);
        }
        private void Enabledbtn()
        {
            NotAllowedd.Enabled = true;
            NoteBtn.Enabled = true;
            DailyLimitBtn.Enabled = true;
            DepositBtn.Enabled = true;
        }
        private void Deeabledbtn()
        {
            NotAllowedd.Enabled = false;
            NoteBtn.Enabled = false;
            DailyLimitBtn.Enabled = false;
            DepositBtn.Enabled = false;
        }
        private void NotAllowedd_Click(object sender, EventArgs e)
        {
           textsearch= texcards.Text;
            NotAllowed NA = new NotAllowed();
            NA.id = Convert.ToInt32(SmartCardGridView.CurrentRow.Cells["dgvid"].Value);
            MainClass.BlueBackGround(NA);
            GetData();
        }

        private void NoteBtn_Click(object sender, EventArgs e)
        {
            
            CardNotes cd = new CardNotes();
            cd.id = Convert.ToInt32(SmartCardGridView.CurrentRow.Cells["dgvid"].Value);
            MainClass.BlueBackGround(cd);
            GetData();
        }

        private void DailyLimitBtn_Click(object sender, EventArgs e)
        {
            DailyLimit dl = new DailyLimit();
            dl.id = Convert.ToInt32(SmartCardGridView.CurrentRow.Cells["dgvid"].Value);
            MainClass.BlueBackGround( dl);
            GetData();

        }

        private void DepositBtn_Click(object sender, EventArgs e)
        {
            int cardId = Convert.ToInt32(SmartCardGridView.CurrentRow.Cells["dgvid"].Value);

            CardDeposit cardDepositForm = new CardDeposit(cardId);

            MainClass.BlueBackGround(cardDepositForm);
            GetData();
            CalculateAmount();
        }
        private void SmartCardGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            

        }
        private void CalculateAmount()
        {
            {
                foreach (DataGridViewRow row in SmartCardGridView.Rows)
                {
                    string balanceStr = row.Cells["dgvbalance"].Value.ToString();
                    float balances;
                    if (!float.TryParse(balanceStr, out balances))
                    {
                        balances = 0;
                        // لم يتم التحويل بنجاح، يمكنك التعامل مع هذه الحالة كما تشاء
                        // هنا يمكنك تعيين قيمة افتراضية للرصيد أو تتركها كما هي
                        // هذا يعتمد على كيفية تحديد السلوك المناسب في حالة عدم وجود قيمة
                    }
                    float withdrawals;
                    if (!float.TryParse(row.Cells["dgvWithdrawal"].Value?.ToString(), out withdrawals))
                    {
                        // في حالة عدم نجاح تحويل القيمة، يمكنك التعامل مع هذه الحالة كما ترغب
                        // في هذا المثال، سنقوم بتعيين قيمة صفر كقيمة افتراضية للسحب
                        withdrawals = 0;
                    }
                    float amount = balances - withdrawals;
                    row.Cells["dgvamount"].Value = amount;
                    string query = "Update Cards  Set Amount= @amount  where Card_ID = @id";
                    Hashtable ht = new Hashtable();
                    ht.Add("@id", texcards.Text);
                    ht.Add("@amount", amount);
                    MainClass.SQL(query, ht);

                }

            }
        }
            private void SmartCard_Load(object sender, EventArgs e)
        {
            //CalculateAmount();
            texcards.Focus();
        }

       

       

        private void texcards_TextChanged(object sender, EventArgs e)
        {
            string scannedBarcode = texcards.Text;
            string query = @"select Card_ID from Cards where Card_ID = '" + scannedBarcode + "'";
            SqlCommand cmd = new SqlCommand(query, MainClass.con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            bool isTextBoxEmpty = string.IsNullOrWhiteSpace(texcards.Text);

            if (dt.Rows.Count == 0)
            {
                if (!isTextBoxEmpty)
                {
                    Deeabledbtn();
                    guna2MessageDialog1.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
                    guna2MessageDialog1.Icon = Guna.UI2.WinForms.MessageDialogIcon.Error;
                    guna2MessageDialog1.Show("This Card does not exist..");
                }
                // استخدم BeginInvoke لتعيين قيمة النص بعد عرض الرسالة
                BeginInvoke((MethodInvoker)delegate
                {
                    texcards.Text = "";
                });

                return;
            }
            else
            {
                if (!isTextBoxEmpty)
                {
                    Enabledbtn();
                    GetData();
                    CalculateAmount();
                }
            }

        }

        private void texcards_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

        }
    }
    }


