using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MiniProject.Data;
using MiniProject;

namespace Miniproject
{
    public partial class RegisterEmployeeControl : UserControl
    {
        public RegisterEmployeeControl()
        {
            InitializeComponent();
            string[] rank = { "사장", "부장", "과장", "대리", "사원" };
            cbbLevel.Items.AddRange(rank);
            string[] gender = { "남", "여" };
            cbbGender.Items.AddRange(gender);
        }
        
        private void BtnRegister_Click(object sender, EventArgs e)
        {
            using (ShoppingMallEntities context = new ShoppingMallEntities())
            {
                Employee employee = new Employee();

                employee.EmployeeID = Convert.ToInt32(txbNumber.Text);
                employee.Name = txbName.Text;
                employee.rank = cbbLevel.SelectedText;
                employee.Gender = cbbGender.SelectedText;
                employee.BirthDate = txbBirth.Text;
                employee.HireDate = DateTime.Now.ToString("yyyy-mm-dd");
                employee.Address = txbAddress.Text;
                employee.HomePhone = txbNumber.Text;

                DB.employee.Insert(employee);
            }
        }
    }
}
