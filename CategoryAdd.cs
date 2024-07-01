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
    public partial class CategoryAdd: Form
    {
        public CategoryAdd()
        {
            InitializeComponent();
        }

        public virtual void SaveBtn_Click(object sender, EventArgs e)
        {

        }

        public virtual void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
