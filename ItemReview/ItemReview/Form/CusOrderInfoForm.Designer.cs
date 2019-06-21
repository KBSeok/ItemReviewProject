namespace ItemReview
{
    partial class CusOrderInfoForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.customerInfoControl1 = new ItemReview.CustomerInfoControl();
            this.customerSearchControl1 = new ItemReview.CustomerSearchControl();
            this.customerOrderListControl1 = new ItemReview.CustomerOrderListControl();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(18, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "회원관리";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // customerInfoControl1
            // 
            this.customerInfoControl1.Location = new System.Drawing.Point(22, 87);
            this.customerInfoControl1.Name = "customerInfoControl1";
            this.customerInfoControl1.Size = new System.Drawing.Size(717, 99);
            this.customerInfoControl1.TabIndex = 2;
            // 
            // customerSearchControl1
            // 
            this.customerSearchControl1.Location = new System.Drawing.Point(158, 12);
            this.customerSearchControl1.Name = "customerSearchControl1";
            this.customerSearchControl1.Size = new System.Drawing.Size(579, 66);
            this.customerSearchControl1.TabIndex = 0;
            // 
            // customerOrderListControl1
            // 
            this.customerOrderListControl1.Location = new System.Drawing.Point(22, 198);
            this.customerOrderListControl1.Name = "customerOrderListControl1";
            this.customerOrderListControl1.Size = new System.Drawing.Size(713, 238);
            this.customerOrderListControl1.TabIndex = 3;
            // 
            // CusOrderInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 448);
            this.Controls.Add(this.customerOrderListControl1);
            this.Controls.Add(this.customerInfoControl1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.customerSearchControl1);
            this.Name = "CusOrderInfoForm";
            this.Text = "회원관리";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomerSearchControl customerSearchControl1;
        private System.Windows.Forms.Label label1;
        private CustomerInfoControl customerInfoControl1;
        private CustomerOrderListControl customerOrderListControl1;
    }
}

