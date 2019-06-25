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
            cbbHCategory.Enabled = false;
            cbbLCategory.Enabled = false;
            cbbColor.Enabled = false;
            cbbSize.Enabled = false;
            chbSubCategory.Enabled = false;
            chbColor.Enabled = false;
            chbSize.Enabled = false;
        }

        public void LoadProductData()
        {
            SubCategoryData subcategorydata = new SubCategoryData();
            List<string> names = subcategorydata.GetSubName();
            foreach (var name in names)
                cbbLCategory.Items.Add(name);

            ProductData product = new ProductData();
            List<string> colors = product.GetColor();
            foreach (var color in colors)
                cbbColor.Items.Add(color);

            List<string> sizes = product.GetSize();
            foreach (var size in sizes)
                cbbSize.Items.Add(size);

            parentsCategoryData.DataSource = DB.Parentscategorydata.GetAll();
        }

        private void chbParentsCategory_CheckedChanged(object sender, EventArgs e)
        {
            if (chbParentsCategory.Checked == true)
            {
                cbbHCategory.Enabled = false;
                cbbLCategory.Enabled = false;
                cbbColor.Enabled = false;
                cbbSize.Enabled = false;
                chbSubCategory.Enabled = false;
                chbColor.Enabled = false;
                chbSize.Enabled = false;
                chbSubCategory.Checked = true;
                chbColor.Checked = true;
                chbSize.Checked = true;
            }

            else
            {
                cbbHCategory.Enabled = true;
                chbSubCategory.Enabled = true;
            }
        }

        private void chbSubCategory_CheckedChanged(object sender, EventArgs e)
        {
            if (chbSubCategory.Checked == true)
            {
                cbbLCategory.Enabled = false;
                chbColor.Enabled = false;
                chbColor.Checked = true;
                chbSize.Enabled = false;
                chbSize.Checked = true;
            }
            else
            {
                cbbLCategory.Enabled = true;
                chbColor.Enabled = true;
                chbSize.Enabled = true;
            }
        }

        private void chbColor_CheckedChanged(object sender, EventArgs e)
        {
            if (chbColor.Checked == true)
                cbbColor.Enabled = false;
                
            else
                cbbColor.Enabled = true;
        }

        private void chbSize_CheckedChanged(object sender, EventArgs e)
        {
            if (chbSize.Checked == true)
                cbbSize.Enabled = false;
            else
                cbbSize.Enabled = true;
        }

        private void btnStockSearch_Click(object sender, EventArgs e)
        {
            string Name = txbName.Text;
            int ParentsCategory = (int)cbbHCategory.SelectedValue;
            int SubCategory = (int)cbbColor.SelectedValue;
            string Color = cbbSize.Text;
            string Size = cbbLCategory.Text;

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
