using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniProject.Data
{
    class SubCategoryData
    {
        public List<SubCategory> GetAll()
        {
            using(ShoppingMallEntities context = new ShoppingMallEntities())
            {
                return context.SubCategories.Distinct().ToList();
            }
        }
    }
}
