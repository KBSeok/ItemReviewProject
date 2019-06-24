﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MiniProject;
using MiniProject.Data;

namespace ItemReview
{
    public partial class Login_Form : Form
    {
        private string Constr = "server=210.119.12.52;uid=sa;pwd=1;database=Management";


        public Login_Form()
        {
            InitializeComponent();
        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            using (ShoppingMallEntities context = new ShoppingMallEntities())
            {
                if (DB.employee.GetEmployeeId().Contains(txbId.Text) == true)
                {
                    if (DB.employee.GetEmployeePW().Contains(txbPassword.Text) == true)
                    {
                        MainmenuForm form1 = new MainmenuForm();
                        form1.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("비밀번호가 잘못입력되었습니다", "알림", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                else
                    MessageBox.Show("아이디가 잘못되었습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }
    }
}
