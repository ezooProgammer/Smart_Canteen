using CrystalDecisions.CrystalReports.Engine;
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
    public partial class BuyForm : Form
    {
        public BuyForm()
        {
            InitializeComponent();
        }
        public int idT = 0;
        private void addtur()
        {
            string tryrype = "add new invoice";


            string query = "Insert into TransactionID Values (@Acc , @Type , @action , @Date)";

            Hashtable ht = new Hashtable();
            ht.Add("@idt", idT);
            ht.Add("@Acc", MainClass.names);
            ht.Add("@Type", tryrype);
            ht.Add("@action", MainID);
            ht.Add("@Date", DateTime.Today.Date);

            MainClass.SQL(query, ht);

        }

        //رقم الفاتورة..
        public int MainID = 0;

        //دالة لعرض اسماء الاصناف في الواجهة 
        private void AddCategory()
        {
            string qry = "Select * from Category";
            SqlCommand cmd = new SqlCommand(qry, MainClass.con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            FlowCategoeyPanel.Controls.Clear();

            if (dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    Guna.UI2.WinForms.Guna2Button g = new Guna.UI2.WinForms.Guna2Button();
                    g.Font = new Font("Segoe UI", 9F);
                    g.ForeColor = Color.White;
                    g.FillColor = Color.FromArgb(78, 79, 80);
                    g.Size = new Size(156, 48);
                    g.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
                    g.CustomBorderThickness = new Padding(0, 2, 0, 0);
                    g.CheckedState.CustomBorderColor = Color.FromArgb(237, 125, 49);
                    g.CheckedState.FillColor = Color.FromArgb(78, 79, 80);
                    g.Margin.Equals(3);


                    g.Text = row["category_name"].ToString();

                    g.Click += new EventHandler(g_click);

                    FlowCategoeyPanel.Controls.Add(g);
                }
            }
        }
        //عند النقر على أسم الصنف يظهر المنتجات التابعة له
        private void g_click(object sender, EventArgs e)
        {
            Guna.UI2.WinForms.Guna2Button g = (Guna.UI2.WinForms.Guna2Button)sender;
            foreach (var item in productpanal.Controls)
            {
                var pro = (BtnProduct)item;
                pro.Visible = pro.ItemCategory.ToLower().Contains(g.Text.Trim().ToLower());
            }
        }
        // 
        private void AddItems(string id, String proID,  string name, string catid, string price, string isActive)
        {
            var w = new BtnProduct()
            {
                ItemProduct = name,
                ItemCategory = catid,
                ItemPrice = price,
                ItemId = Convert.ToInt32(proID)

            };
            w.Enabled = isActive.ToLower() == "true";
            productpanal.Controls.Add(w);


            w.onselect += (ss, ee) =>
            {

                //هني يتحقق من المنتج كانه موجود في الجدول يزيد كميته عند كل ضغطه و  يتم تعديل السعر
                var wdg = (BtnProduct)ss;
                bool found = false;

                foreach (DataGridViewRow item in BuyingDataGridView.Rows)
                {
                    if (Convert.ToInt32(item.Cells["proID"].Value) == wdg.ItemId)
                    {
                        // إذا وجد المنتج في الجدول، قم بتحديث كميته والقيمة الإجمالية
                        found = true;
                        int quantity = Convert.ToInt32(item.Cells["dgvquantity"].Value) + 1;
                        double pprice = Convert.ToDouble(item.Cells["dgvprice"].Value);
                        double totalAmount = quantity * pprice;

                        item.Cells["dgvquantity"].Value = quantity;
                        item.Cells["dvgAmount"].Value = totalAmount.ToString("N2");

                        break;
                    }
                }

                if (!found)
                {
                    // إذا لم يتم العثور على المنتج، قم بإضافة صف جديد
                    BuyingDataGridView.Rows.Add(0, 0, wdg.ItemId, wdg.ItemProduct, 1, wdg.ItemPrice, wdg.ItemPrice);
                }

                GetTotal();
            };
        }


        //جلب المنتج من الداتابيسس
        private void LoadProducts()
        {
            string qry = "select Pro_ID, Pro_Name, Catid, price, c.category_name, " +
                 "case when Quantity > 0 then 'True' else 'False' end as IsActive " +
                 "from Product p inner join Category c on c.Category_id = p.Catid";
            //    string qry = "select Pro_ID , Pro_Name,Catid, price,  c.category_name from Product p inner join Category c on c.Category_id = p.Catid";
            SqlCommand cmd = new SqlCommand(qry, MainClass.con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            foreach (DataRow item in dt.Rows)
            {
                AddItems("0", item["Pro_ID"].ToString(), item["Pro_Name"].ToString(), item["category_name"].ToString(), item["price"].ToString(), item["IsActive"].ToString());
            }
        }


        private void logoutBtn_Click(object sender, EventArgs e)
        {
            if (MainClass.USER == "Casheir")
            {
                this.Hide();
                DialogResult r = MessageBox.Show("Are you sure to Logout ?", "LOGOUT", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (r == DialogResult.Yes)
                { Application.Exit(); }
            }
            else if (MainClass.USER == "Manager")
            {
                MainForm mf = new MainForm();
                this.Close();
                mf.ShowDialog();

            }
        }

        private void Searchtxt_TextChanged(object sender, EventArgs e)
        {
            foreach (var item in productpanal.Controls)
            {
                var pro = (BtnProduct)item;
                pro.Visible = pro.ItemProduct.ToLower().Contains(Searchtxt.Text.Trim().ToLower());
            }
        }
        private double total = 0;

        private void GetTotal()
        {
            total = 0; // إعادة تهيئة المتغير عند البدء
            TotalLbl.Text = "";

            foreach (DataGridViewRow item in BuyingDataGridView.Rows)
            {
                // تحقق مما إذا كانت القيمة في الخلية غير فارغة
                if (item.Cells["dvgAmount"].Value != null)
                {
                    double amount = 0;
                    // تحقق مما إذا كان بالفعل بالإمكان تحويل القيم0ة إلى double
                    double.TryParse(item.Cells["dvgAmount"].Value.ToString(), out amount);
                    
                        total += amount;
                    
                }
            }
            //خاصيه يلي بين القوسين تحددلي كيفية عرض الرقم 

            TotalLbl.Text = total.ToString("N2");
        }

        private void BuyingDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            int count = 0;
            foreach (DataGridViewRow row in BuyingDataGridView.Rows)
            {
                count++;
                row.Cells[0].Value = count;
            }

        }

        private void AllCategoryBtn_Click(object sender, EventArgs e)
        {
            productpanal.Controls.Clear();
            LoadProducts();
        }

        private void BuyForm_Load(object sender, EventArgs e)
        {
            AddCategory();
            productpanal.Controls.Clear();
            LoadProducts();
            GetTotal();
            GetInvoiceNumber();
            label8.Text = Convert.ToString(DateTime.Now);
        }
        private void GetInvoiceNumber()
        {
            string query = "SELECT MAX(invoice_ID)+1 FROM Invoice";

            using (SqlCommand cmd = new SqlCommand(query, MainClass.con))
            {
                if (MainClass.con.State == ConnectionState.Closed) { MainClass.con.Open(); }
                object result = cmd.ExecuteScalar();
                if (MainClass.con.State == ConnectionState.Open) { MainClass.con.Close(); }

                if (result != null && result != DBNull.Value)
                {
                    lborder.Text = "Order ID: " + result.ToString();
                }
            }
        }
        private void PayBtn_Click(object sender, EventArgs e)
        {
            string qry1 = ""; //invoce
            string qry2 = ""; //sales

            int order_id = 0;

            if (MainID == 0) //insert
            {
                qry1 = @"insert into Invoice(invoice_Date,invoice_time,total,cardId)
                        values(@invoice_Date,@invoice_time,@total, @cardid);
                         Select SCOPE_IDENTITY()";
            }
            SqlCommand cmd = new SqlCommand(qry1, MainClass.con);
            cmd.Parameters.AddWithValue("@ID", MainID);
            cmd.Parameters.AddWithValue("@invoice_Date", Convert.ToDateTime(DateTime.Now.Date));
            cmd.Parameters.AddWithValue("@invoice_time", DateTime.Now.ToShortTimeString());
            cmd.Parameters.AddWithValue("@total", Convert.ToDouble(TotalLbl.Text));
            cmd.Parameters.AddWithValue("@cardid", Convert.ToInt32(textcard.Text));
            if (MainClass.con.State == ConnectionState.Closed) { MainClass.con.Open(); }
            if (MainID == 0)
            { MainID = Convert.ToInt32(cmd.ExecuteScalar());
            } else
            {
                cmd.ExecuteNonQuery();
            }
            if (MainClass.con.State == ConnectionState.Open)
            {
                MainClass.con.Close();
            }

            if (MainClass.con.State == ConnectionState.Closed)
            {
                MainClass.con.Open();
                foreach (DataGridViewRow row in BuyingDataGridView.Rows)
                {

                   
                    int idpro = int.Parse(row.Cells["proid"].Value.ToString());
                    int qty = int.Parse(row.Cells["dgvquantity"].Value.ToString());
                    float pricee = float.Parse(row.Cells["dgvprice"].Value.ToString());
                    float totalz = float.Parse(row.Cells["dvgAmount"].Value.ToString());
                    string query = @"insert into Sales(invoice_id,product_id,Qty,price,amount) VALUES(" + MainID + "," + idpro + "," + qty + "," + pricee + "," + totalz + ")";
                    SqlCommand cmd2 = new SqlCommand(query, MainClass.con);
                    cmd2.ExecuteNonQuery();
                }
            }

            guna2MessageDialog1.Show("saved Successfully..");
            MainClass.con.Close();
            addtur();
            double totalAmount = Convert.ToDouble(TotalLbl.Text); // المبلغ الإجمالي للفاتورة

            // قم بتحديث الحقول في جدول cards
            string updateQuery = @"UPDATE Cards 
                       SET Amount = Amount - @totalAmount";

            // تحقق مما إذا كانت قيمة Withdrawal غير فارغة قبل تضمينها في الاستعلام
            if (!string.IsNullOrEmpty(textcard.Text))
            {
                updateQuery += ", Withdrawal = ISNULL(Withdrawal, 0) + @totalAmount";
            }

            updateQuery += " WHERE Card_ID = @cardId";
                       

            SqlCommand updateCmd = new SqlCommand(updateQuery, MainClass.con);
            updateCmd.Parameters.AddWithValue("@totalAmount", totalAmount);
            updateCmd.Parameters.AddWithValue("@cardId", Convert.ToInt32(textcard.Text));

            if (MainClass.con.State == ConnectionState.Closed)
            {
                MainClass.con.Open();
            }
            updateCmd.ExecuteNonQuery();
            MainClass.con.Close();
            UpdateProductQuantities();
            MainID = 0;
            order_id = 0;
            lborder.Text = "";
            textcard.Text = "";
            BuyingDataGridView.Rows.Clear();
            TotalLbl.Text = "";
        }
        private bool IsDailyLimitExceeded(string cardBarcode)
        {
            string query = "SELECT Daily_limit FROM Cards WHERE Card_ID = @Barcode";

            using (SqlCommand cmd = new SqlCommand(query, MainClass.con))
            {
                cmd.Parameters.AddWithValue("@Barcode", cardBarcode);
                MainClass.con.Open();
                object dailyLimitObj = cmd.ExecuteScalar();
                MainClass.con.Close();

                if (dailyLimitObj != null && dailyLimitObj != DBNull.Value)
                {
                    float dailyLimit = Convert.ToSingle(dailyLimitObj);
                    double totalAmount = CalculateTotalAmount();

                    if (totalAmount > dailyLimit)
                    {
                        MessageBox.Show($"تجاوز الحد المسموح لليوم. الحد اليومي: {dailyLimit}");
                        return true; // تم تجاوز السقف اليومي
                    }
                }
                else // إذا كانت القيمة فارغة (تساوي صفر)
                {
                    return false;// لا تظهر رسالة وتنفذ العملية بشكل طبيعي
                }
                return false; // لم يتم تجاوز السقف اليومي
            }
        }
        private bool IsAmount(string cardBarcode)
        {
            string query = "SELECT Amount FROM Cards WHERE Card_ID = @Barcode";

            using (SqlCommand cmd = new SqlCommand(query, MainClass.con))
            {
                cmd.Parameters.AddWithValue("@Barcode", cardBarcode);
                MainClass.con.Open();
                object Amountobj = cmd.ExecuteScalar();
                MainClass.con.Close();

                if (Amountobj != null)
                {
                    float aamount = Convert.ToSingle(Amountobj);
                    double totalAmounts = CalculateTotalAmount();

                    if (totalAmounts > aamount)
                    {
                        MessageBox.Show($"الرصيد غير كافي : {aamount}");
                        return true; // الرصيد غير كافي
                    }
                }

                return false; // الرصي كافي
            }
        }


        private double CalculateTotalAmount()
        {
            double totalAmount = 0;

            foreach (DataGridViewRow row in BuyingDataGridView.Rows)
            {
                if (row.Cells["dvgAmount"].Value != null)
                {
                    totalAmount += Convert.ToDouble(row.Cells["dvgAmount"].Value);
                }
            }

            return totalAmount;
        }
        //الممنوعات 
        private bool IsProductNotAllowed(string cardBarcode)
        {
            foreach (DataGridViewRow row in BuyingDataGridView.Rows)
            {
                int productId = Convert.ToInt32(row.Cells["proID"].Value);
                string query = "SELECT * FROM Not_Allowed WHERE ID_Card = @CardBarcode AND ID_Pro = @ProductId";

                using (SqlCommand cmd = new SqlCommand(query, MainClass.con))
                {
                    cmd.Parameters.AddWithValue("@CardBarcode", cardBarcode);
                    cmd.Parameters.AddWithValue("@ProductId", productId);
                    MainClass.con.Open();
                    object result = cmd.ExecuteScalar();
                    MainClass.con.Close();

                    if (result != null)
                    {
                        string productName = GetProductName(productId);
                        MessageBox.Show($"المنتج '{productName}' ممنوع على هذه البطاقة.");
                        return true; // المنتج ممنوع على هذه البطاقة
                    }
                }
            }

            return false; // لا يوجد منتجات ممنوعة
        }

        private string GetProductName(int productId)
        {
            string query = "SELECT Pro_Name FROM Product WHERE Pro_ID = @ProductId";

            using (SqlCommand cmd = new SqlCommand(query, MainClass.con))
            {
                cmd.Parameters.AddWithValue("@ProductId", productId);
                MainClass.con.Open();
                object result = cmd.ExecuteScalar();
                MainClass.con.Close();

                if (result != null)
                {
                    return result.ToString();
                }
                else
                {
                    return string.Empty;
                }
            }
        }
        private bool IsCardValid(string cardBarcode)
        {
            string query = "SELECT Expiry_Date FROM Cards WHERE Card_ID = @Barcode";

            using (SqlCommand cmd = new SqlCommand(query, MainClass.con))
            {
                cmd.Parameters.AddWithValue("@Barcode", cardBarcode);
                MainClass.con.Open();
                object expDate = cmd.ExecuteScalar();
                MainClass.con.Close();

                if (expDate != null && (DateTime)expDate >= DateTime.Today)
                {
                    return true; // البطاقة صالحة
                }
                else
                {
                    MessageBox.Show("عذرا..البطاقة منتهية الصلاحية");
                    return false; // البطاقة منتهية الصلاحية
                }
            }
        }
        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void BuyingDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == BuyingDataGridView.Columns["delete"].Index && e.RowIndex >= 0)
            {
                // الحصول على الصف الذي تم النقر عليه
                DataGridViewRow row = BuyingDataGridView.Rows[e.RowIndex];

                // مسح الصف
                BuyingDataGridView.Rows.Remove(row);

                // تحديث الإجمالي بعد حذف الصف
                GetTotal();
            }
        }
        private void GetTotals()
        {
            double totalAmount = 0;

            foreach (DataGridViewRow row in BuyingDataGridView.Rows)
            {
                // تحقق مما إذا كانت القيمة في الخلية غير فارغة
                if (row.Cells["dvgAmount"].Value != null)
                {
                    double amount = 0;
                    // تحقق مما إذا كان بالفعل بالإمكان تحويل القيمة إلى double
                    double.TryParse(row.Cells["dvgAmount"].Value.ToString(), out amount);

                    totalAmount += amount;
                }
            }

            // تحديث قيمة TotalLbl بعد حساب الإجمالي
            TotalLbl.Text = totalAmount.ToString("N2");
        }

        private void BuyingDataGridView_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            GetTotals();
        }
        private void UpdateProductQuantities()
        {
            // فتح الاتصال بقاعدة البيانات إذا لم يكن مفتوحًا بالفعل
            if (MainClass.con.State == ConnectionState.Closed)
            {
                MainClass.con.Open();
            }

            // الجملة SQL لتحديث كميات المنتجات
            string updateQuery = "UPDATE Product SET Quantity = Quantity - @SoldQuantity WHERE Pro_ID = @ProductId";

            // تحديث كميات المنتجات في جدول المنتجات
            foreach (DataGridViewRow row in BuyingDataGridView.Rows)
            {
                int productId = Convert.ToInt32(row.Cells["proID"].Value);
                int soldQuantity = Convert.ToInt32(row.Cells["dgvquantity"].Value);

                SqlCommand updateCommand = new SqlCommand(updateQuery, MainClass.con);
                updateCommand.Parameters.AddWithValue("@SoldQuantity", soldQuantity);
                updateCommand.Parameters.AddWithValue("@ProductId", productId);
                updateCommand.ExecuteNonQuery();
            }

            // إغلاق الاتصال بقاعدة البيانات بعد الانتهاء من التحديث
            MainClass.con.Close();
        }
        private void label8_Click(object sender, EventArgs e)
        {
            
        }

        private void textcard_TextChanged(object sender, EventArgs e)
        {
            string scannedBarcode = textcard.Text;
            string query = @"select Card_ID from Cards where Card_ID = '" + scannedBarcode + "'";
            SqlCommand cmd = new SqlCommand(query, MainClass.con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            bool isTextBoxEmpty = string.IsNullOrWhiteSpace(textcard.Text);
            if (dt.Rows.Count == 0)
            {
                if (!isTextBoxEmpty)
                {
                    guna2MessageDialog1.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
                    guna2MessageDialog1.Icon = Guna.UI2.WinForms.MessageDialogIcon.Error;
                    guna2MessageDialog1.Show("This Card does not exist..");
                }

                // استخدم BeginInvoke لتعيين قيمة النص بعد عرض الرسالة
                BeginInvoke((MethodInvoker)delegate
                {
                    textcard.Text = "";
                });

                return;
            }

            //if (isTextBoxEmpty)
            //{
            //    // إذا كانت TextBox فارغة، عرض رسالة وتعطيل زر الدفع
            //    MessageBox.Show("TextBox is empty.");
            //    PayBtn.Enabled = false;
            //}

            else
            {
                if (!isTextBoxEmpty)
                {
                    string cardBarcode = textcard.Text.Trim();
                    // التحقق من صلاحية البطاقة
                    bool isCardValid = IsCardValid(cardBarcode);
                    // التحقق من تجاوز السقف اليومي
                    bool isDailyLimitExceeded = IsDailyLimitExceeded(cardBarcode);
                    // التحقق من المنتجات الممنوعة
                    bool isProductNotAllowed = IsProductNotAllowed(cardBarcode);
                    // التحقق من الرصيد المتبقي
                    bool isAmount = IsAmount(cardBarcode);
                    // إذا كانت جميع الشروط تمامًا، فقم بعرض زر البيع
                    if (isCardValid && !isDailyLimitExceeded && !isProductNotAllowed && !isAmount)
                    {
                        PayBtn.Enabled = true;
                    }
                    else
                    {
                        PayBtn.Enabled = false;
                    }
                }
            }


        }

        private void textcard_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

        }


        private void btnclear_Click_1(object sender, EventArgs e)
        {
            BuyingDataGridView.Rows.Clear();
        }
    }
}
