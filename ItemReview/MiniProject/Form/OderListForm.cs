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

namespace Miniproject
{
    public partial class OderListForm : Form
    {
        public OderListForm()
        {
            InitializeComponent();
        }

        private void OrderSearchControl_SearchBottonClicked(object sender, OrderSearchControl.SearchBottonClickedEventArgs e)
        {
            var orders = DB.Orderdetail.SearchOrderInfo(e.TxbOrderNumber, e.TxbCusId);
            uscOrderList.SetDataOrder(orders);
        }

        private void InsertDeleteControl1_SearchBottonClicked(object sender, InsertDeleteControl.SearchBottonClickedEventArgs e)
        {
            var orders = DB.Orderdetail.SearchOrderInfo(e.TxbOrderNumber, e.TxbCusId);
            uscOrderList.SetDataOrder(orders);
        }
    }
}
