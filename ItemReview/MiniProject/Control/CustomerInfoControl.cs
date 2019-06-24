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

namespace Miniproject
{
    public partial class CustomerInfoControl : UserControl
    {
        public CustomerInfoControl()
        {
            InitializeComponent();
        }
        public void SetDataCustomerData(List<Customer> customer)
        {
            dgvCusInfo.DataSource = customer;
        }

        


    }
}
