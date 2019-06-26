using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniProject.Data
{
    class DB
    {
        public static EmployeeData Employee { get; } = new EmployeeData();

        public static CustomerData Customer { get; } = new CustomerData();

        public static ProductData Product { get; } = new ProductData();

        public static OrderDetailData Orderdetail { get; } = new OrderDetailData();
        public static ParentsCategoryData Parentscategorydata { get; } =
            new ParentsCategoryData();
        public static SubCategoryData Subcategorydata { get; } =
            new SubCategoryData();


        //public static OrderDetailData orderdetaill { get; set; }
    }
}
