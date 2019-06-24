using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MiniProject.Data
{
    class CustomerData
    {
        public List<Customer> GetAll()
        {
            using (ShoppingMallEntities context = new ShoppingMallEntities())
            {
                return context.Customers.ToList();
            }
        }

        public List<Customer> SearchInfo(string Id, string Grade)
        {
            using (ShoppingMallEntities context = new ShoppingMallEntities())
            {
                var query = from x in context.Customers
                            where x.UserId == Id && x.Grade == Grade
                            select x;

                return query.ToList();
            }
        }
    }
}
