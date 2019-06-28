using System.Linq;

namespace MiniProject.Data
{
    class OrderData : EntityData<Order>
    {
        public Order GetByPK(int orderId)
        {
            using (ShoppingMallEntities context = new ShoppingMallEntities())
            {
                return context.Orders.FirstOrDefault(x => x.OrderID == orderId);
            }
        }
    }
}
