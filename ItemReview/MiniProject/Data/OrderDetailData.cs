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

                if (string.IsNullOrEmpty(Id) == true &&
                    string.IsNullOrEmpty(Grade) == true)
                {
                    var query = from x in context.Order_Details
                                select new
                                {
                                    order_detail = x,
                                    product = x.Product,
                                    orderdate = x.Order.OrderDate,
                                    parentscategotyname = x.Product.ParentsCategory.ParentsCategoryName,
                                    productname = x.Product.ProductName,
                                    size = x.Product.Size,
                                    color = x.Product.Color,
                                    amount = x.Product.StockAmount

                                };

                    var list = query.ToList();

                    foreach (var x in list)
                    {
                        x.order_detail.OrderDate = x.orderdate;
                        x.order_detail.ParentsCategoryName = x.parentscategotyname;
                        x.order_detail.PuductorName = x.productname;
                        x.order_detail.Amount = x.amount;
                        x.order_detail.Size = x.size;
                        x.order_detail.Color = x.color;
                    }
                    return list.ConvertAll(x => x.order_detail);
                }

                else if (string.IsNullOrEmpty(Id) == true)
                {
                    var query = from x in context.Order_Details
                                where x.Order.Customer.Grade == Grade
                                select new
                                {
                                    order_detail = x,
                                    product = x.Product,
                                    orderdate = x.Order.OrderDate,
                                    parentscategotyname = x.Product.ParentsCategory.ParentsCategoryName,
                                    productname = x.Product.ProductName,
                                    size = x.Product.Size,
                                    color = x.Product.Color,
                                    amount = x.Product.StockAmount

                                };

                    var list = query.ToList();

                    foreach (var x in list)
                    {
                        x.order_detail.OrderDate = x.orderdate;
                        x.order_detail.ParentsCategoryName = x.parentscategotyname;
                        x.order_detail.PuductorName = x.productname;
                        x.order_detail.Amount = x.amount;
                        x.order_detail.Size = x.size;
                        x.order_detail.Color = x.color;
                    }
                    return list.ConvertAll(x => x.order_detail);


                }
                else if (string.IsNullOrEmpty(Grade) == true)
                {
                    var query = from x in context.Order_Details
                                where x.Order.Customer.UserId == Id
                                select new
                                {
                                    order_detail = x,
                                    product = x.Product,
                                    orderdate = x.Order.OrderDate,
                                    parentscategotyname = x.Product.ParentsCategory.ParentsCategoryName,
                                    productname = x.Product.ProductName,
                                    size = x.Product.Size,
                                    color = x.Product.Color,
                                    amount = x.Product.StockAmount

                                };

                    var list = query.ToList();

                    foreach (var x in list)
                    {
                        x.order_detail.OrderDate = x.orderdate;
                        x.order_detail.ParentsCategoryName = x.parentscategotyname;
                        x.order_detail.PuductorName = x.productname;
                        x.order_detail.Amount = x.amount;
                        x.order_detail.Size = x.size;
                        x.order_detail.Color = x.color;
                    }
                    return list.ConvertAll(x => x.order_detail);
                }
                else
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
                                    productname = x.Product.ProductName,
                                    size = x.Product.Size,
                                    color = x.Product.Color,
                                    amount = x.Product.StockAmount

                                };

                    var list = query.ToList();

                    foreach (var x in list)
                    {
                        x.order_detail.OrderDate = x.orderdate;
                        x.order_detail.ParentsCategoryName = x.parentscategotyname;
                        x.order_detail.PuductorName = x.productname;
                        x.order_detail.Amount = x.amount;
                        x.order_detail.Size = x.size;
                        x.order_detail.Color = x.color;
                    }
                    return list.ConvertAll(x => x.order_detail);
                }
            }
        }

        public List<Order_Detail> SearchOrderInfo(string orderNumber, string cusId)
        {
            using (ShoppingMallEntities context = new ShoppingMallEntities())
            {
               var query = from x in context.Order_Details
                            where x.Order.OrderNumber == orderNumber && x.Order.Customer.UserId == cusId
                            select new
                            {
                                orderdetail = x,
                                //order = x.Order,
                                //product = x.Product,                                
                                //customer = x.Order.Customer,
                                ordernumber = x.Order.OrderNumber,
                                userId = x.Order.Customer.UserId,
                                price = x.Product.Price,
                                productorName = x.Product.ProductName,
                                size = x.Product.Size,
                                color = x.Product.Color,
                                amount = x.Order.Amount,
                                orderdate = x.Order.OrderDate

                            };

                var list = query.ToList();

                foreach (var x in list)
                {
                    x.orderdetail.OrderNumber = x.ordernumber;
                    x.orderdetail.UserId = x.userId;
                    x.orderdetail.Price = x.price;
                    x.orderdetail.PuductorName = x.productorName;
                    x.orderdetail.Color = x.color;
                    x.orderdetail.Size = x.size;
                    x.orderdetail.Amount = x.amount;
                    x.orderdetail.OrderDate = x.orderdate;
                }
                return list.ConvertAll(x => x.orderdetail);
            }

        }
    }
}
