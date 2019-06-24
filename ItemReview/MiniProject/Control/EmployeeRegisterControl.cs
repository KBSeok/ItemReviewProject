using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            //using (ShoppingMallEntities context = new ShoppingMallEntities())
            //{
            //    context.Employees.Add(txbNumber.Text, txbName.Text,cbbLevel.Text,
            //        cbbGender.Text, );

            //    context.SaveChanges();
            //}
        }
    }
}
