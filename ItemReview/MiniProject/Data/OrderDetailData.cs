using System.Collections.Generic;
using System.Linq;

namespace MiniProject.Data
{
    class OrderDetailData : EntityData<Order_Detail>
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
                                    amount = x.Order.Amount

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
    }
}
