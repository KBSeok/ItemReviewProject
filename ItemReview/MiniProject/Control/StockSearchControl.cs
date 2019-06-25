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
    public partial class StockSearchControl : UserControl
    {
        public StockSearchControl()
        {
            InitializeComponent();
            cbbColor.Text = "";
            
        }

        public void LoadProductData()
        {
            productData.DataSource = DB.product.GetAll();
            parentsCategoryData.DataSource = DB.parentscategorydata.GetAll();
            subCategoryData.DataSource = DB.subcategorydata.GetAll();
        }

        private void chbParentsCategory_CheckedChanged(object sender, EventArgs e)
        {
            cbbHCategory.Enabled = chbParentsCategory.Checked;
        }

        private void chbSubCategory_CheckedChanged(object sender, EventArgs e)
        {
            if (chbSubCategory.Checked == false)
                chbSubCategory.Enabled = true;
            else
                chbSubCategory.Enabled = false;
        }

        private void chbColor_CheckedChanged(object sender, EventArgs e)
        {
            if (chbColor.Checked == false)
                chbColor.Enabled = true;
            else
                chbColor.Enabled = false;
        }

        private void chbSize_CheckedChanged(object sender, EventArgs e)
        {
            if (chbSize.Checked == false)
                chbSize.Enabled = true;
            else
                chbSize.Enabled = false;
        }

        private void btnStockSearch_Click(object sender, EventArgs e)
        {
            string Name = txbName.Text;
            int ParentsCategory = (int)cbbHCategory.SelectedValue;
            int SubCategory = (int)cbbLCategory.SelectedValue;
            string Color = cbbColor.Text;
            string Size = cbbSize.Text;

            OnButtonSearchProduct(Name, ParentsCategory, SubCategory, Size, Color);
        }

        #region ButtonSearchProduct event things for C# 3.0
        public event EventHandler<ButtonSearchProductEventArgs> ButtonSearchProduct;

        protected virtual void OnButtonSearchProduct(ButtonSearchProductEventArgs e)
        {
            if (ButtonSearchProduct != null)
                ButtonSearchProduct(this, e);
        }

        private ButtonSearchProductEventArgs OnButtonSearchProduct(string name, int parentsId, int subId, string color, string size)
        {
            ButtonSearchProductEventArgs args = new ButtonSearchProductEventArgs(name, parentsId, subId, color, size);
            OnButtonSearchProduct(args);

            return args;
        }

        private ButtonSearchProductEventArgs OnButtonSearchProductForOut()
        {
            ButtonSearchProductEventArgs args = new ButtonSearchProductEventArgs();
            OnButtonSearchProduct(args);

            return args;
        }

        public class ButtonSearchProductEventArgs : EventArgs
        {
            public string Name { get; set; }
            public int ParentsId { get; set; }
            public int SubId { get; set; }
            public string Color { get; set; }
            public string Size { get; set; }

            public ButtonSearchProductEventArgs()
            {
            }

            public ButtonSearchProductEventArgs(string name, int parentsId, int subId, string color, string size)
            {
                Name = name;
                ParentsId = parentsId;
                SubId = subId;
                Color = color;
                Size = size;
            }
        }
        #endregion
    }
}
