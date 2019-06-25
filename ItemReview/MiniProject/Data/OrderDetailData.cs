using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniProject.Data
{
    class OrderDetailData
    {
        public List<Order_Detail> SearchOrderInfo(string orderNumber, string cusId)
        {
            using (ShoppingMallEntities context = new ShoppingMallEntities())
            {
                var query = from x in context.Order_Details
                            where x.Order.OrderNumber == orderNumber && x.Order.Customer.UserId == cusId
                            select new
                            {
                               orderdetail = x,
                               product = x.Product,
                               customer = x.Order.Customer,
                               userId = x.Order.Customer.UserId,
                               productName = x.Product.ProductName,
                               size = x.Product.Size,
                               color = x.Product.Color

                            };

                var list = query.ToList();

                foreach (var x in list)
                {

                    x.orderdetail.Order.Customer.UserId = x.userId;
                    x.orderdetail.ProductName= x.productName;
                    x.orderdetail.Color = x.color;
                    x.orderdetail.Size = x.size;
                }
                return list.ConvertAll(x => x.orderdetail);
            }

        }

    }

}
