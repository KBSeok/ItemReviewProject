namespace Miniproject
{
    partial class StockManagementForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.uscProductInfo = new Miniproject.StockListControl();
            this.uscSearchProduct = new Miniproject.StockSearchControl();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "재고조회";
            // 
            // uscProductInfo
            // 
            this.uscProductInfo.Location = new System.Drawing.Point(16, 207);
            this.uscProductInfo.Name = "uscProductInfo";
            this.uscProductInfo.Size = new System.Drawing.Size(714, 195);
            this.uscProductInfo.TabIndex = 2;
            // 
            // uscSearchProduct
            // 
            this.uscSearchProduct.Location = new System.Drawing.Point(16, 35);
            this.uscSearchProduct.Name = "uscSearchProduct";
            this.uscSearchProduct.Size = new System.Drawing.Size(699, 168);
            this.uscSearchProduct.TabIndex = 3;
            this.uscSearchProduct.ButtonSearchProduct += new System.EventHandler<Miniproject.StockSearchControl.ButtonSearchProductEventArgs>(this.stockSearchControl1_ButtonSearchProduct);
            // 
            // StockManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 426);
            this.Controls.Add(this.uscSearchProduct);
            this.Controls.Add(this.uscProductInfo);
            this.Controls.Add(this.label1);
            this.Name = "StockManagementForm";
            this.Text = "StockManagement";
            this.Load += new System.EventHandler(this.StockManagementForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private StockListControl uscProductInfo;
        private StockSearchControl uscSearchProduct;
    }
}