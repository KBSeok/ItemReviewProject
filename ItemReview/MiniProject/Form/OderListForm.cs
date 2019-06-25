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

        private void OrderSearchControl1_SearchBottonClicked(object sender, OrderSearchControl.SearchBottonClickedEventArgs e)
        {
            var orders = DB.order.SearchOrderInfo(e.TxbOrderNumber, e.TxbCusId);
            orderInfoListControl11.SetDataOrder(orders);
        }
    }
}
