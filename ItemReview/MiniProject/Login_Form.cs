using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;




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
            //var Conn = new SqlConnection(Constr);
            //Conn.Open();

            //var Comm = new SqlCommand("Select userPWD from t_login" + "where userid='" + this.Text + "'", Conn);

            //var myRead = Comm.ExecuteReader();

            //if(myRead.Read())
            //{
            //    string strpwd = myRead[0].ToString();
            //    if(strpwd == this.txbPassword.Text)
            //    {
            //        myRead.Close();
            //        Conn.Close();

            //        MainmenuForm frm2 = new MainmenuForm();
            //        frm2.Show();
            //        this.Close();
            //    }
            //}

            MainmenuForm form1 = new MainmenuForm();
            form1.ShowDialog();
            
        }
    }
}
