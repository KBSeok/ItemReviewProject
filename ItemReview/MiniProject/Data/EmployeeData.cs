using System.Collections.Generic;
using System.Linq;

namespace MiniProject.Data
{
    class EmployeeData
    {
        public List<string> GetEmployeeId()
        {
            using(ShoppingMallEntities context = new ShoppingMallEntities())
            {
                return context.Employees.Select(x => x.LoginID).ToList();
            }
        }

        public List<string> GetEmployeePW()
        {
            using (ShoppingMallEntities context = new ShoppingMallEntities())
            {
                return context.Employees.Select(x => x.LoginPW).ToList();
            }
        }

        
        
    }
}
