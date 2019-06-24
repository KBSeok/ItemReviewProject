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
    public partial class CusOrderInfoForm : Form
    {
        public CusOrderInfoForm()
        {
            InitializeComponent();
        }

       

        private void CusOrderInfoForm_Load(object sender, EventArgs e)
        {
            uscSearchCusInfo.LoadCutomerData();
        }

        private void UscSearchCusInfo_OnButtonSearchCusInfo(object sender, CustomerSearchControl.ButtonSearchCusInfoEventArgs e)
        {
            var Customers = DB.customer.SearchInfo(e.Id, e.Grade);

            uscOutputCusInfo.SetDataCustomerData(Customers);
        }
    }
}
