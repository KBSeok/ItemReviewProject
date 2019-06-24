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
            this.stockSearchControl1 = new Miniproject.StockSearchControl();
            this.label1 = new System.Windows.Forms.Label();
            this.stockListControl1 = new Miniproject.StockListControl();
            this.SuspendLayout();
            // 
            // stockSearchControl1
            // 
            this.stockSearchControl1.Location = new System.Drawing.Point(72, 35);
            this.stockSearchControl1.Name = "stockSearchControl1";
            this.stockSearchControl1.Size = new System.Drawing.Size(592, 175);
            this.stockSearchControl1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "재고관리";
            // 
            // stockListControl1
            // 
            this.stockListControl1.Location = new System.Drawing.Point(16, 207);
            this.stockListControl1.Name = "stockListControl1";
            this.stockListControl1.Size = new System.Drawing.Size(714, 195);
            this.stockListControl1.TabIndex = 2;
            // 
            // StockManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 426);
            this.Controls.Add(this.stockListControl1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.stockSearchControl1);
            this.Name = "StockManagementForm";
            this.Text = "StockManagement";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private StockSearchControl stockSearchControl1;
        private System.Windows.Forms.Label label1;
        private StockListControl stockListControl1;
    }
}