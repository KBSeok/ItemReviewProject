using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Miniproject
{
    public partial class OrderSearchControl : UserControl
    {
        public OrderSearchControl()
        {
            InitializeComponent();
        }

        private void ChbOrderNumber_CheckedChanged(object sender, EventArgs e)
        {
            txbOrderNumber.Enabled = chbOrderNumber.Checked;
        }

        private void ChbCusId_CheckedChanged(object sender, EventArgs e)
        {
            txbCusId.Enabled = chbCusId.Checked;
        }

        private void BtnOrderSearch_Click(object sender, EventArgs e)
        {
            OnSearchBottonClicked(txbOrderNumber.Text, txbCusId.Text);
        }
        #region SearchBottonClicked event things for C# 3.0
        public event EventHandler<SearchBottonClickedEventArgs> SearchBottonClicked;

        protected virtual void OnSearchBottonClicked(SearchBottonClickedEventArgs e)
        {
            if (SearchBottonClicked != null)
                SearchBottonClicked(this, e);
        }

        private SearchBottonClickedEventArgs OnSearchBottonClicked(string txbOrderNumber, string txbCusId)
        {
            SearchBottonClickedEventArgs args = new SearchBottonClickedEventArgs(txbOrderNumber, txbCusId);
            OnSearchBottonClicked(args);

            return args;
        }

        private SearchBottonClickedEventArgs OnSearchBottonClickedForOut()
        {
            SearchBottonClickedEventArgs args = new SearchBottonClickedEventArgs();
            OnSearchBottonClicked(args);

            return args;
        }

        public class SearchBottonClickedEventArgs : EventArgs
        {
            public string TxbOrderNumber { get; set; }
            public string TxbCusId { get; set; }

            public SearchBottonClickedEventArgs()
            {
            }

            public SearchBottonClickedEventArgs(string txbOrderNumber, string txbCusId)
            {
                TxbOrderNumber = txbOrderNumber;
                TxbCusId = txbCusId;
            }
        }
        #endregion
    }
}
