using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MiniProject.Data;

namespace MiniProject
{
    public partial class CustomerOrder : UserControl
    {
        public CustomerOrder()
        {
            InitializeComponent();
        }

        public void LoadProductData()
        {
            dgvProduct.DataSource = DB.Product.GetProductName();
        }
    }
}
