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
            OnOnSearchBottonClicked(txbOrderNumber.Text, txbCusId.Text);
        }
        #region OnSearchBottonClicked event things for C# 3.0
        public event EventHandler<OnSearchBottonClickedEventArgs> OnSearchBottonClicked;

        protected virtual void OnOnSearchBottonClicked(OnSearchBottonClickedEventArgs e)
        {
            if (OnSearchBottonClicked != null)
                OnSearchBottonClicked(this, e);
        }

        private OnSearchBottonClickedEventArgs OnOnSearchBottonClicked(string txbOrderNumber, string txbCusId)
        {
            OnSearchBottonClickedEventArgs args = new OnSearchBottonClickedEventArgs(txbOrderNumber, txbCusId);
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
            public string TxbOrderNumber { get; set; }
            public string TxbCusId { get; set; }

            public OnSearchBottonClickedEventArgs()
            {
            }

            public OnSearchBottonClickedEventArgs(string txbOrderNumber, string txbCusId)
            {
                TxbOrderNumber = txbOrderNumber;
                TxbCusId = txbCusId;
            }
        }
        #endregion


    }
}
