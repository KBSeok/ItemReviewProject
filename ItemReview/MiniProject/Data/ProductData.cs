using Miniproject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniProject.Data
{
    class ProductData
    {
        public List<Product> SearchProductInfo(string Id, string Grade)
        {
            using (ShoppingMallEntities context = new ShoppingMallEntities())
            {
                var query = from x in context.Order_Details
                            where x.Order.Customer.UserId == Id &&
                            x.Order.Customer.Grade == Grade
                            select x;

                var query1 = query.Select(x => x.ProductId).ToList();

                var query3 = from x in context.Products
                             where query1.Contains(x.ProductId)
                             select new
                             {
                                 product = x,
                                 parentscategoryname = x.ParentsCategory.ParentsCategoryName
                             };

                var list = query3.ToList();


                foreach(var x in list)
                {
                    x.product.ParentsCategory.ParentsCategoryName = x.parentscategoryname;
                }


                return list.ConvertAll(x => x.product);
            }
        }
    }
}
