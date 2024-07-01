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
    public partial class BtnProduct : UserControl
    {

        public BtnProduct()
        {
            InitializeComponent();
        }
        //حدث يتم تن\يطه عند النقر على الزر
        public event EventHandler onselect = null;
        public int ItemId { get; set; }

        public string ItemCategory
        {
            get { return CategoryLbl.Text; }
            set { CategoryLbl.Text = value; }
        }
        public string ItemProduct
        {
            get { return ProductLbl.Text; }
            set { ProductLbl.Text = value; }
        }
        public string ItemPrice
        {
            get { return PriceLbl.Text; }
            set { PriceLbl.Text = value; }
        }

        private void ProductLbl_Click(object sender, EventArgs e)
        {
            onselect?.Invoke(this, e);
        }
    }
}
