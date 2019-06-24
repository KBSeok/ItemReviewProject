using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniProject.Data
{
    class DB
    {
        public static EmployeeData employee { get; } = new EmployeeData();

        public static CustomerData customer { get; } = new CustomerData();

        public static ProductData product { get; } = new ProductData();

        public static OrderData order { get; set; } = new OrderData();
    }
}   
