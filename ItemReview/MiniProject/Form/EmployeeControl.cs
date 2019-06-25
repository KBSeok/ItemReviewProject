using MiniProject.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniProject.Control
{
    public partial class EmployeeControl : Form
    {
        public EmployeeControl()
        {
            InitializeComponent();
        }

        private void employeeSearch1_EnterSearchEmpoyeeInfo(object sender, Miniproject.EmployeeSearch.EnterSearchEmpoyeeInfoEventArgs e)
        {
            var emplyees = DB.employee.SearchInfo(e.Name);
            uscEmployeeInfo.SetDataEmployeeData(emplyees);

        }
    }
}
