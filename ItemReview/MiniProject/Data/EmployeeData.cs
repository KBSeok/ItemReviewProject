
using Miniproject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniProject.Data
{
    class EmployeeData : EntityData<Employee>
    {
        public Employee GetByPK(int employeeId)
        {
            using (ShoppingMallEntities context = new ShoppingMallEntities())
            {
                return context.Employees.FirstOrDefault(x => x.EmployeeID == employeeId);
            }
        }

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

        public List<Employee> SearchInfo(string Name)
        {
            using(ShoppingMallEntities context = new ShoppingMallEntities())
            {
                var query = from x in context.Employees
                            where x.Name == Name
                            select x;

                return query.ToList();
            }
        }

        
        
    }
}
