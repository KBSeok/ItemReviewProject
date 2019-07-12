using Miniproject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniProject.Data
{
    class ProductData : EntityData<Product>
    {
        public List<Product> SearchInfo(string Name, string Parents, string Sub,
            string Size, string Color)
        {
            using(ShoppingMallEntities context = new ShoppingMallEntities())
            {
                var query = from x in context.Products
                            select x;
                query.ToList();

                if (string.IsNullOrEmpty(Name) == false)
                {
                    query = from x in query
                            where x.ProductName == Name
                            select x;
                    query.ToList();
                }

                if (string.IsNullOrEmpty(Parents) == false)
                {
                    query = from x in query
                            where x.ParentsCategory.ParentsCategoryName == Parents
                            select x;
                    query.ToList();
                }

                if(string.IsNullOrEmpty(Sub) == false)
                {
                    query = from x in query
                            where x.SubCategory.SubCategoryName == Sub
                            select x;
                    query.ToList();
                }
                if (string.IsNullOrEmpty(Size) == false)
                {
                    query = from x in query
                            where x.Size == Size
                            select x;
                    query.ToList();
                }

                if (string.IsNullOrEmpty(Color) == false)
                {
                    query = from x in query
                            where x.Color == Color
                            select x;
                    query.ToList();
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

        public List<Product> GetProductName()
        {
            using(ShoppingMallEntities context = new ShoppingMallEntities())
            {
                var query = from x in context.Products
                            select x;

                var list = query.Select(x=>x.ProductName).Distinct().ToList();

                return list;
                    
            }
        }

        public List<string> GetColor(string ParentsName, string SubName)
        {
            using (ShoppingMallEntities context = new ShoppingMallEntities())
            {
                var query = from x in context.Products
                            from y in context.SubCategories
                            where (x.ParentsCategoryId == y.ParentsCategoryId 
                            && x.SubCategoryId == y.SubCategoryId)
                            && x.ParentsCategory.ParentsCategoryName == ParentsName 
                            && x.SubCategory.SubCategoryName == SubName
                            select x;

                var query1 = query.Select(x => x.Color).Distinct().ToList();

                return query1;
            }
        }

        public List<string> GetSize(string ParentsName, string SubName, string Color)
        {
            using (ShoppingMallEntities context = new ShoppingMallEntities())
            {
                var query = from x in context.Products
                            from y in context.SubCategories
                            where (x.ParentsCategoryId == y.ParentsCategoryId
                            && x.SubCategoryId == y.SubCategoryId)
                            && x.ParentsCategory.ParentsCategoryName == ParentsName
                            && x.SubCategory.SubCategoryName == SubName
                            && x.Color == Color
                            select x;

                var query1 = query.Select(x => x.Size).Distinct().ToList();

                return query1;
            }
        }

        public Product GetByPK(int productId)
        {
            using (ShoppingMallEntities context = new ShoppingMallEntities())
            {
                return context.Products.FirstOrDefault(x => x.ProductId == productId);
            }
        }
    }
}
