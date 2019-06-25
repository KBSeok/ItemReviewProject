using Miniproject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniProject.Data
{
    class ProductData
    {
        public List<Product> SearchInfo(string Name, int Parents, int Subname,
            string Size, string Color)
        {
            using(ShoppingMallEntities context = new ShoppingMallEntities())
            {
                var query = from x in context.Products
                            where x.ProductName == Name && 
                            x.ParentsCategory.ParentsCategoryId == Parents &&
                            x.Size == Size && x.Color == Color
                            select x;

                return query.ToList();
            }
        }
        public List<Product> GetAll()
        {
            using(ShoppingMallEntities context = new ShoppingMallEntities())
            {
                return context.Products.Distinct().ToList();
            }
        }
    }
}
