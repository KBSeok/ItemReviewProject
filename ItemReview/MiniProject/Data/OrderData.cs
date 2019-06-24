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
                            select x;

                return query.ToList();
            }
        }

    }
}
