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

namespace Miniproject
{
    public partial class CustomerSearchControl : UserControl
    {
        public CustomerSearchControl()
        {
            InitializeComponent();
        }

        public void LoadCutomerData()
        {
            cusData.DataSource = DB.customer.GetAll();
        }
        

        private void btnCusSearch_Click(object sender, EventArgs e)
        {
            string Id = txbCusId.Text;
            string Grade = cbbGrade.Text;

            OnOnButtonSearchCusInfo(Id, Grade);
        }

        #region OnButtonSearchCusInfo event things for C# 3.0
        public event EventHandler<OnButtonSearchCusInfoEventArgs> OnButtonSearchCusInfo;

        protected virtual void OnOnButtonSearchCusInfo(OnButtonSearchCusInfoEventArgs e)
        {
            if (OnButtonSearchCusInfo != null)
                OnButtonSearchCusInfo(this, e);
        }

        private OnButtonSearchCusInfoEventArgs OnOnButtonSearchCusInfo(string id, string grade)
        {
            OnButtonSearchCusInfoEventArgs args = new OnButtonSearchCusInfoEventArgs(id, grade);
            OnOnButtonSearchCusInfo(args);

            return args;
        }

        private OnButtonSearchCusInfoEventArgs OnOnButtonSearchCusInfoForOut()
        {
            OnButtonSearchCusInfoEventArgs args = new OnButtonSearchCusInfoEventArgs();
            OnOnButtonSearchCusInfo(args);

            return args;
        }

        public class OnButtonSearchCusInfoEventArgs : EventArgs
        {
            public string Id { get; set; }
            public string Grade { get; set; }

            public OnButtonSearchCusInfoEventArgs()
            {
            }

            public OnButtonSearchCusInfoEventArgs(string id, string grade)
            {
                Id = id;
                Grade = grade;
            }
        }
        #endregion
    }
}
