using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MiniProject;
using MiniProject.Data;

namespace Miniproject
{
    public partial class OrderInfoListControl1 : UserControl
    {
        public OrderInfoListControl1()
        {
            InitializeComponent();
        }

        public void SetDataOrder(List<Order_Detail> order)
        {
            dgvOrderList.DataSource = order;
        }

        private void DgvOrderList_DoubleClick(object sender, EventArgs e)
        {
            Order_Detail order = dgvOrderList.CurrentRow.DataBoundItem as Order_Detail;

            if (order == null)
                return;

            OnDoubleClick(order);
        }

        #region DoubleClick event things for C# 3.0
        public event EventHandler<DoubleClickEventArgs> DoubleClick;

        protected virtual void OnDoubleClick(DoubleClickEventArgs e)
        {
            if (DoubleClick != null)
                DoubleClick(this, e);
        }

        private DoubleClickEventArgs OnDoubleClick(Order_Detail order)
        {
            DoubleClickEventArgs args = new DoubleClickEventArgs(order);
            OnDoubleClick(args);

            return args;
        }

        private DoubleClickEventArgs OnDoubleClickForOut()
        {
            DoubleClickEventArgs args = new DoubleClickEventArgs();
            OnDoubleClick(args);

            return args;
        }

        public class DoubleClickEventArgs : EventArgs
        {
            public Order_Detail Order { get; set; }

            public DoubleClickEventArgs()
            {
            }

            public DoubleClickEventArgs(Order_Detail order)
            {
                Order = order;
            }
        }

        #endregion

        private void DgvOrderList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            UPdataDeleteForm frm = new UPdataDeleteForm();
            frm.Show();
        }
    }
}
