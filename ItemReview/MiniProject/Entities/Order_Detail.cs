using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniProject
{
    partial class Order_Detail
    {
        public string OrderDate { get; set; }
        public string ParentsCategoryName { get; set; }
        public string Size { get; set; }
        public string Color { get; set; }
        public int Amount { get; set; }
        
        public string OrderNumber { get; set; }
        public int Price { get; set; }
        public string ProductName { get; set; }
        public string UserId { get; set; }
    }
}
