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
            string orderNumber = txbOrderNumber.Text;
            string cusId = txbCusId.Text;


        }
    }
}
