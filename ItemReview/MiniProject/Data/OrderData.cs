using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniProject.Data
{
    class OrderData
    {
       public List<Order> SearchOrderInfo(string orderNumber, string cusId)
        {
            using(ShoppingMallEntities context = new ShoppingMallEntities())
            {
                var query = from x in context.Orders
                            where x.OrderNumber == orderNumber && x.Customer.UserId == cusId
                            select new
                            {
                                oder = x,
                                userId = x.UserID,
                                productName = x.ProductName,
                                price = x.Price,
                                size = x.Size,
                                color = x.Color
                            };

                var list = query.ToList();

                foreach(var x in list)
                {
                    x.oder.UserID = x.userId;
                    x.oder.Price = x.price;
                    x.oder.ProductName = x.productName;
                    x.oder.Size = x.size;
                    x.oder.Color = x.color;
                }
                return list.ConvertAll(x => x.oder);
            }
         
        }

         
    }
}
