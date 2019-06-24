using System.Collections.Generic;

namespace MiniProject.Data
{
    class ProductData
    {
        public List<Order> SearchProductInfo(string Id, string Grade)
        {
            using (ShoppingMallEntities context = new ShoppingMallEntities())
            {
                var query = from x in context
                            where x.Customer.UserId == Id &&
                            x.Customer.Grade == Grade
                            select new
                            {
                                OrderDate = x.OrderDate,
                                OrderID = x.OrderID
                            };

                var query1 = query.ToList();

                var query3 = from x in context.Order_Details
                             where x.Order.Customer.UserId == Id &&
                             x.Order.Customer.Grade == Grade
                             select new
                             {
                                 OrderData = x.Order.OrderDate,
                                 OrderID = x.OrderID,
                                 Size = x.Product.ParentsCategory.
                             };

                var query4 = query3.Select(x => x.OrderID).ToList();

            }
        }
    }
}
