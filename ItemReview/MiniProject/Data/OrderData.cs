using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniProject.Data
{
    class OrderData
    {
        public List<Order> Search(string OrderNumber)
        {
            using (ShoppingMallEntities1 context = new ShoppingMallEntities1())
            {
                var query = from x in context.Orders
                            where x.OrderNumber.Contains(OrderNumber)
                            select x;

                List<Order> orders = query.ToList();

                return orders;
                            
            }
        }
    }
}
