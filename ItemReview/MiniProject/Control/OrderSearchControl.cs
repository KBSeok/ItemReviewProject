using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ItemReview
{
    public partial class OrderSearchControl : UserControl
    {
       
        public OrderSearchControl()
        {
            InitializeComponent();
        }

        private void CbbOrderNumber_CheckedChanged(object sender, EventArgs e)
        {
            txbOrderNumber.Enabled = chbOrderNumber.Checked;
        }

        private void CbbCusId_CheckedChanged(object sender, EventArgs e)
        {
                txbCusId.Enabled = chbCusId.Checked;
        }
        
        private void BtnOrderSearch_Click(object sender, EventArgs e)
        {
            //OnSearchBottonClicked(txbOrderNumber.Text, txbCusId.Text);
        }

        
        #region OnSearchBottonClicked event things for C# 3.0
        public event EventHandler<OnSearchBottonClickedEventArgs> OnSearchBottonClicked;

        protected virtual void OnOnSearchBottonClicked(OnSearchBottonClickedEventArgs e)
        {
            if (OnSearchBottonClicked != null)
                OnSearchBottonClicked(this, e);
        }

        private OnSearchBottonClickedEventArgs OnOnSearchBottonClicked(string orderNumber, string cusId)
        {
            OnSearchBottonClickedEventArgs args = new OnSearchBottonClickedEventArgs(orderNumber, cusId);
            OnOnSearchBottonClicked(args);

            return args;
        }

        private OnSearchBottonClickedEventArgs OnOnSearchBottonClickedForOut()
        {
            OnSearchBottonClickedEventArgs args = new OnSearchBottonClickedEventArgs();
            OnOnSearchBottonClicked(args);

            return args;
        }

        public class OnSearchBottonClickedEventArgs : EventArgs
        {
            public string OrderNumber { get; set; }
            public string CusId { get; set; }

            public OnSearchBottonClickedEventArgs()
            {
            }

            public OnSearchBottonClickedEventArgs(string orderNumber, string cusId)
            {
                OrderNumber = orderNumber;
                CusId = cusId;
            }
        }
        #endregion
    }
}
