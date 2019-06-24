using MiniProject.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ItemReview
{
    public partial class OderListForm : Form
    {
        public OderListForm()
        {
            InitializeComponent();
        }

        private void OrderSearchControl2_OnSearchBottonClicked(object sender, OrderSearchControl.OnSearchBottonClickedEventArgs e)
        {
            var Orders = DB.Order.Search(e.TxbOrderNumber);
            bdsOrder.DataSource = Orders;

            //MessageBox.Show($"{e.TxbOrderNumber}/{e.TxbCusId}");
        }
    }
}

