using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniProject.Data
{
    class ParentsCategoryData
    {
        public List<ParentsCategory> GetAll()
        {
            using(ShoppingMallEntities context = new ShoppingMallEntities())
            {
                return context.ParentsCategories.ToList();
            }
        }
    }
}
