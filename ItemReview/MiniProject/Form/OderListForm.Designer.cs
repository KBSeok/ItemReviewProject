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
            this.label1 = new System.Windows.Forms.Label();
            this.orderInfoListControl11 = new Miniproject.OrderInfoListControl1();
            this.orderSearchControl1 = new Miniproject.OrderSearchControl();
            this.insertDeleteControl1 = new Miniproject.InsertDeleteControl();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(33, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "주문관리";
            // 
            // orderInfoListControl11
            // 
            this.orderInfoListControl11.Location = new System.Drawing.Point(50, 161);
            this.orderInfoListControl11.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.orderInfoListControl11.Name = "orderInfoListControl11";
            this.orderInfoListControl11.Size = new System.Drawing.Size(732, 224);
            this.orderInfoListControl11.TabIndex = 2;
            // 
            // orderSearchControl1
            // 
            this.orderSearchControl1.Location = new System.Drawing.Point(94, 59);
            this.orderSearchControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.orderSearchControl1.Name = "orderSearchControl1";
            this.orderSearchControl1.Size = new System.Drawing.Size(589, 95);
            this.orderSearchControl1.TabIndex = 1;
            this.orderSearchControl1.SearchBottonClicked += new System.EventHandler<Miniproject.OrderSearchControl.SearchBottonClickedEventArgs>(this.OrderSearchControl_SearchBottonClicked);
            // 
            // insertDeleteControl1
            // 
            this.insertDeleteControl1.Location = new System.Drawing.Point(522, 394);
            this.insertDeleteControl1.Name = "insertDeleteControl1";
            this.insertDeleteControl1.Size = new System.Drawing.Size(223, 45);
            this.insertDeleteControl1.TabIndex = 3;
            // 
            // OderListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 450);
            this.Controls.Add(this.insertDeleteControl1);
            this.Controls.Add(this.orderInfoListControl11);
            this.Controls.Add(this.orderSearchControl1);
            this.Controls.Add(this.label1);
            this.Name = "OderListForm";
            this.Text = "OderListForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private OrderSearchControl orderSearchControl1;
        private OrderInfoListControl1 orderInfoListControl11;
        private InsertDeleteControl insertDeleteControl1;
    }
}