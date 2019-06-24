namespace ItemReview
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.orderSearchControl2 = new ItemReview.OrderSearchControl();
            this.customerOrderListControl1 = new ItemReview.CustomerOrderListControl();
            this.bdsOrder = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bdsOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gulim", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(38, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "주문관리";
            // 
            // orderSearchControl2
            // 
            this.orderSearchControl2.Location = new System.Drawing.Point(46, 49);
            this.orderSearchControl2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.orderSearchControl2.Name = "orderSearchControl2";
            this.orderSearchControl2.Size = new System.Drawing.Size(702, 132);
            this.orderSearchControl2.TabIndex = 2;
            this.orderSearchControl2.OnSearchBottonClicked += new System.EventHandler<ItemReview.OrderSearchControl.OnSearchBottonClickedEventArgs>(this.OrderSearchControl2_OnSearchBottonClicked);
            // 
            // customerOrderListControl1
            // 
            this.customerOrderListControl1.Location = new System.Drawing.Point(25, 189);
            this.customerOrderListControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.customerOrderListControl1.Name = "customerOrderListControl1";
            this.customerOrderListControl1.Size = new System.Drawing.Size(811, 294);
            this.customerOrderListControl1.TabIndex = 1;
            // 
            // bdsOrder
            // 
            this.bdsOrder.DataSource = typeof(MiniProject.Order);
            // 
            // OderListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 562);
            this.Controls.Add(this.orderSearchControl2);
            this.Controls.Add(this.customerOrderListControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "OderListForm";
            this.Text = "OderListForm";
            ((System.ComponentModel.ISupportInitialize)(this.bdsOrder)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private OrderSearchControl orderSearchControl1;
        private OrderInfoListControl1 orderInfoListControl11;
        private InsertDeleteControl insertDeleteControl1;
        private CustomerOrderListControl customerOrderListControl1;
        private OrderSearchControl orderSearchControl2;
        private System.Windows.Forms.BindingSource bdsOrder;
    }
}