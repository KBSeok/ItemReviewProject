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
            List<string> subnames = subcategorydata.GetSubName();
            foreach (var subname in subnames)
                cbbLCategory.Items.Add(subname);

            ProductData product = new ProductData();
            List<string> colors = product.GetColor();
            foreach (var color in colors)
                cbbColor.Items.Add(color);

            List<string> sizes = product.GetSize();
            foreach (var size in sizes)
                cbbSize.Items.Add(size);

            ParentsCategoryData parentscategorydata = new ParentsCategoryData();
            List<string> parentsnames = parentscategorydata.GetParentsCategoryName();
            foreach (var parentsname in parentsnames)
                cbbHCategory.Items.Add(parentsname);

            //parentsCategoryData.DataSource = DB.Parentscategorydata.GetAll();
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
            string ParentsCategory = cbbHCategory.Text;
            string SubCategory = cbbLCategory.Text;
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

        private ButtonSearchProductEventArgs OnButtonSearchProduct(string name, string parentsName, string subName, string size, string color)
        {
            ButtonSearchProductEventArgs args = new ButtonSearchProductEventArgs(name, parentsName, subName, size, color);
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
            public string ParentsName { get; set; }
            public string SubName { get; set; }
            public string Size { get; set; }
            public string Color { get; set; }

            public ButtonSearchProductEventArgs()
            {
            }

            public ButtonSearchProductEventArgs(string name, string parentsName, string subName, string size, string color)
            {
                Name = name;
                ParentsName = parentsName;
                SubName = subName;
                Size = size;
                Color = color;
            }
        }
        #endregion
    }
}
