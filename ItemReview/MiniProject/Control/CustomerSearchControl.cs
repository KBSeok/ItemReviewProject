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

namespace ItemReview
{
    public partial class CustomerSearchControl : UserControl
    {
        public CustomerSearchControl()
        {
            InitializeComponent();
            cbbGrade.Text = "";
        }

        public void LoadCutomerData()
        {
            cusData.DataSource = DB.customer.GetAll();
        }

        private void BtnCusSearch_Click(object sender, EventArgs e)
        {
            string Id = txbCusId.Text;
            string Grade = cbbGrade.Text;

            OnButtonSearchCusInfo(Id, Grade);
        }

        #region ButtonSearchCusInfo event things for C# 3.0
        public event EventHandler<ButtonSearchCusInfoEventArgs> ButtonSearchCusInfo;

        protected virtual void OnButtonSearchCusInfo(ButtonSearchCusInfoEventArgs e)
        {
            if (ButtonSearchCusInfo != null)
                ButtonSearchCusInfo(this, e);
        }

        private ButtonSearchCusInfoEventArgs OnButtonSearchCusInfo(string id, string grade)
        {
            ButtonSearchCusInfoEventArgs args = new ButtonSearchCusInfoEventArgs(id, grade);
            OnButtonSearchCusInfo(args);

            return args;
        }

        private ButtonSearchCusInfoEventArgs OnButtonSearchCusInfoForOut()
        {
            ButtonSearchCusInfoEventArgs args = new ButtonSearchCusInfoEventArgs();
            OnButtonSearchCusInfo(args);

            return args;
        }

        public class ButtonSearchCusInfoEventArgs : EventArgs
        {
            public string Id { get; set; }
            public string Grade { get; set; }

            public ButtonSearchCusInfoEventArgs()
            {
            }

            public ButtonSearchCusInfoEventArgs(string id, string grade)
            {
                Id = id;
                Grade = grade;
            }
        }
        #endregion
    }
}
