﻿using Miniproject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniProject.Data
{
    class ProductData
    {
        //public List<Product> SearchProductInfo(string Id, string Grade)
        //{
        //    using (ShoppingMallEntities context = new ShoppingMallEntities())
        //    {
        //        var query = from x in context.Orders
        //                    where x.Customer.UserId == Id &&
        //                    x.Customer.Grade == Grade
        //                    select new
        //                    {
        //                        OrderDate = x.OrderDate,
        //                        OrderID = x.OrderID
        //                    };

        //        var query1 = query.ToList();

        //        var query3 = from x in context.Order_Details
        //                     where x.Order.Customer.UserId == Id &&
        //                     x.Order.Customer.Grade == Grade
        //                     select new
        //                     {
                                 
        //                         OrderID = x.OrderID,
                                 
        //                     };

        //        var query4 = query3.Select(x => x.OrderID).ToList();

        //    }
        //}
    }
}
