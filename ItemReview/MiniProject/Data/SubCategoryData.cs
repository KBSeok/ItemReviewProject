using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniProject.Data
{
    class SubCategoryData
    {
        public List<String> GetSubName()
        {
            using(ShoppingMallEntities context = new ShoppingMallEntities())
            {
                return context.SubCategories.Select(x => x.SubCategoryName)
                    .Distinct().ToList();
            }
        }
    }
}
