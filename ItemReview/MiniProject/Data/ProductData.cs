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
        public List<Product> SearchInfo(string Name, int Parents, int Sub,
            string Size, string Color)
        {
            using(ShoppingMallEntities context = new ShoppingMallEntities())
            {
                var query = from x in context.Products
                            select x;

                if (string.IsNullOrEmpty(Name)==false)
                    query = from x in query
                            where x.ProductName == Name
                            select x;

                query = from y in query
                        where y.ParentsCategory.ParentsCategoryId == Parents
                        select y;

                            //x.ParentsCategory.ParentsCategoryId == Parents &&
                            //x.Size == Size && x.Color == Color &&
                            //x.SubCategoryId == Sub
                            //select x;

                return query.ToList();
            }
        }
        public List<Product> GetAll()
        {
            using(ShoppingMallEntities context = new ShoppingMallEntities())
            {
                return context.Products.ToList();
            }
        }

        public List<string> GetColor()
        {
            using (ShoppingMallEntities context = new ShoppingMallEntities())
            {
                return context.Products.Select(x => x.Color).Distinct().ToList();
            }
        }

        public List<string> GetSize()
        {
            using (ShoppingMallEntities context = new ShoppingMallEntities())
            {
                return context.Products.Select(x => x.Size).Distinct().ToList();
            }
        }
    }
}
