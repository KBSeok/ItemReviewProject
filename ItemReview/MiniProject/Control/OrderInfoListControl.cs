﻿using System;
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
    public partial class OrderInfoListControl : UserControl
    {
        public OrderInfoListControl()
        {
            InitializeComponent();
        }
        public void SetDataOrder(List<Order_Detail> order)
        {
            dgvOrder.DataSource = order;
        }

    }
}
