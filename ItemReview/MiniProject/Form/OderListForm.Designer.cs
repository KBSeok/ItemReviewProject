namespace Miniproject
{
    partial class OderListForm
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
            this.orderSearchControl2 = new Miniproject.OrderSearchControl();
            this.orderInfoListControl = new Miniproject.OrderInfoListControl();
            this.SuspendLayout();
            // 
            // orderSearchControl2
            // 
            this.orderSearchControl2.Location = new System.Drawing.Point(107, 151);
            this.orderSearchControl2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.orderSearchControl2.Name = "orderSearchControl2";
            this.orderSearchControl2.Size = new System.Drawing.Size(670, 119);
            this.orderSearchControl2.TabIndex = 1;
            this.orderSearchControl2.SearchBottonClicked += new System.EventHandler<Miniproject.OrderSearchControl.SearchBottonClickedEventArgs>(this.OrderSearchControl_SearchBottonClicked);
            // 
            // orderInfoListControl
            // 
            this.orderInfoListControl.AutoSize = true;
            this.orderInfoListControl.Location = new System.Drawing.Point(33, 361);
            this.orderInfoListControl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.orderInfoListControl.Name = "orderInfoListControl";
            this.orderInfoListControl.Size = new System.Drawing.Size(830, 137);
            this.orderInfoListControl.TabIndex = 0;
            // 
            // OderListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 562);
            this.Controls.Add(this.orderSearchControl2);
            this.Controls.Add(this.orderInfoListControl);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "OderListForm";
            this.Text = "OderListForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private OrderSearchControl orderSearchControl1;
        private InsertDeleteControl insertDeleteControl1;
        private OrderInfoListControl orderInfoListControl11;
        private OrderInfoListControl orderInfoListControl;
        private OrderSearchControl orderSearchControl2;
    }
}