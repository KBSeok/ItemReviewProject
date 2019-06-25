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

namespace MiniProject
{
    public partial class Register_LoginControl : UserControl
    {
        public Register_LoginControl()
        {
            InitializeComponent();
        }

        #region ButtonCloseForm event things for C# 3.0
        public event EventHandler<ButtonCloseFormEventArgs> ButtonCloseForm;

        protected virtual void OnButtonCloseForm(ButtonCloseFormEventArgs e)
        {
            if (ButtonCloseForm != null)
                ButtonCloseForm(this, e);
        }

        private ButtonCloseFormEventArgs OnButtonCloseForm()
        {
            ButtonCloseFormEventArgs args = new ButtonCloseFormEventArgs();
            OnButtonCloseForm(args);

            return args;
        }

        /*private ButtonCloseFormEventArgs OnButtonCloseFormForOut()
        {
            ButtonCloseFormEventArgs args = new ButtonCloseFormEventArgs();
            OnButtonCloseForm(args);

            return args;
        }*/

        public class ButtonCloseFormEventArgs : EventArgs
        {


            /*public ButtonCloseFormEventArgs()
            {
            }

            public ButtonCloseFormEventArgs()
            {

            }*/
        }

        #endregion

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            OnButtonCloseForm();
        }

        private void BtnNumberCheck_Click(object sender, EventArgs e)
        {
            using(ShoppingMallEntities context = new ShoppingMallEntities())
            {
                int number = Convert.ToInt32(txbNumber.Text);

                if(context.Employees.Count(x => x.EmployeeID == number) == 1)
                {

                    MessageBox.Show("회원가입이 가능한 사번입니다.", "알림", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }

                if (context.Employees.Count(x => x.EmployeeID == number) == 0)
                {
                    MessageBox.Show("등록되지 않은 사번입니다.", "알림", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }

        private void BtnIdCheck_Click(object sender, EventArgs e)
        {
            using (ShoppingMallEntities context = new ShoppingMallEntities())
            {
                string Id = txbId.Text;
                if (context.Employees.Count(x => x.LoginID == Id) == 1)
                {
                    MessageBox.Show("등록된 아이디입니다.", "알림", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
                if (context.Employees.Count(x => x.LoginID == Id) == 0)
                {
                    MessageBox.Show("등록가능한 아이디 입니다.", "알림", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }
        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            if(txbPW.Text != txbPWCheck.Text)
            {
                MessageBox.Show("비밀번호가 일치하지 않습니다.", "알림", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
            }
            else
            {
                Employee employee = new Employee();

                employee.LoginID = txbId.Text;
                employee.LoginPW = txbPW.Text;
                employee.EmployeeID = Convert.ToInt32(txbNumber.Text);

                DB.employee.Update(employee);
            }
        }
    }
}
