using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniProject.Data
{
    class DB
    {
        static DB()
        {
            Customer = new CustomerData();
            Order = new OrderData();

        }


        public static OrderData Order { get; set; }

        public static CustomerData Customer { get; set; }
    }
}
