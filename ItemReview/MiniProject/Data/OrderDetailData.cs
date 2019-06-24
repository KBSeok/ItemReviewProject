using System.Collections.Generic;
using System.Linq;

namespace MiniProject.Data
{
    class OrderDetailData
    {
        public List<Order_Detail> SearchProductInfo(string Id, string Grade)
        {
            using (ShoppingMallEntities context = new ShoppingMallEntities())
            {
                var query = from x in context.Order_Details
                            where x.Order.Customer.UserId == Id &&
                            x.Order.Customer.Grade == Grade
                            select new
                            {
                                order_detail = x,
                                product = x.Product,
                                orderdate = x.Order.OrderDate,
                                parentscategotyname = x.Product.ParentsCategory.ParentsCategoryName,

                            };

                var list = query.ToList();

                foreach (var x in list)
                {
                    x.order_detail.OrderDate = x.orderdate;
                    x.order_detail.ParentsCategoryName = x.parentscategotyname;
                 
                }


                return list.ConvertAll(x => x.order_detail);
            }
        }
    }
}
