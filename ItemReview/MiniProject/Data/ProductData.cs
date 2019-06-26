using Miniproject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniProject.Data
{
    class ProductData
    {
        public List<Product> SearchInfo(string Name, string Parents, string Sub,
            string Size, string Color)
        {
            using(ShoppingMallEntities context = new ShoppingMallEntities())
            {
                var query = from x in context.Products
                            select x;

                if (string.IsNullOrEmpty(Name) == false)
                {
                    query = from x in query
                            where x.ProductName == Name
                            select x;
                }

                if (string.IsNullOrEmpty(Parents) == false)
                {
                    query = from x in query
                            where x.ParentsCategory.ParentsCategoryName == Parents
                            select x;
                }

                if(string.IsNullOrEmpty(Sub) == false)
                {
                    query = from x in query
                            where x.SubCategory.SubCategoryName == Sub && 
                            x.ParentsCategory.ParentsCategoryName == Parents
                            select x;
                }
                if (string.IsNullOrEmpty(Size) == false)
                {
                    query = from x in query
                            where x.Size == Size
                            select x;
                }

                if (string.IsNullOrEmpty(Color) == false)
                {
                    query = from x in query
                            where x.Color == Color
                            select x;
                }

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

        public List<Product> Search(string ParentsName)
        {
            using(ShoppingMallEntities context = new ShoppingMallEntities())
            {
                var query = from x in context.Products
                            where x.ParentsCategory.ParentsCategoryName == ParentsName
                            select x;

                return query.ToList();
            }
        }
    }
}
