using Miniproject;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MiniProject.Data
{
    class EntityData<T> where T : class
    {

        public void Insert(T entity)
        {
            using (ShoppingMallEntities context = new ShoppingMallEntities())
            {
                context.Set<T>().Add(entity);
                
                context.SaveChanges();
            }
        }

        public void Update(T entity)
        {
            using (ShoppingMallEntities context = new ShoppingMallEntities())
            {
                context.Entry(entity).State = EntityState.Modified;

                context.SaveChanges();
            }
        }

        public void Delete(T entity)
        {
            using (ShoppingMallEntities context = new ShoppingMallEntities())
            {
                context.Entry(entity).State = EntityState.Deleted;

                context.SaveChanges();
            }
        }
    }
}
