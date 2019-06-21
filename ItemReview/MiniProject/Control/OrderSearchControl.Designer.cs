namespace ItemReview
{
    partial class OrderSearchControl
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

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbOrderSearch = new System.Windows.Forms.GroupBox();
            this.cbbOrderNumber = new System.Windows.Forms.CheckBox();
            this.cbbCusId = new System.Windows.Forms.CheckBox();
            this.txbOrderNumber = new System.Windows.Forms.TextBox();
            this.txbCusId = new System.Windows.Forms.TextBox();
            this.btnOrderSearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.gbOrderSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbOrderSearch
            // 
            this.gbOrderSearch.Controls.Add(this.btnOrderSearch);
            this.gbOrderSearch.Controls.Add(this.txbCusId);
            this.gbOrderSearch.Controls.Add(this.txbOrderNumber);
            this.gbOrderSearch.Controls.Add(this.cbbCusId);
            this.gbOrderSearch.Controls.Add(this.cbbOrderNumber);
            this.gbOrderSearch.Location = new System.Drawing.Point(9, 24);
            this.gbOrderSearch.Name = "gbOrderSearch";
            this.gbOrderSearch.Size = new System.Drawing.Size(571, 67);
            this.gbOrderSearch.TabIndex = 0;
            this.gbOrderSearch.TabStop = false;
            // 
            // cbbOrderNumber
            // 
            this.cbbOrderNumber.AutoSize = true;
            this.cbbOrderNumber.Location = new System.Drawing.Point(27, 36);
            this.cbbOrderNumber.Name = "cbbOrderNumber";
            this.cbbOrderNumber.Size = new System.Drawing.Size(80, 16);
            this.cbbOrderNumber.TabIndex = 0;
            this.cbbOrderNumber.Text = "주문번호 :";
            this.cbbOrderNumber.UseVisualStyleBackColor = true;
            // 
            // cbbCusId
            // 
            this.cbbCusId.AutoSize = true;
            this.cbbCusId.Location = new System.Drawing.Point(253, 35);
            this.cbbCusId.Name = "cbbCusId";
            this.cbbCusId.Size = new System.Drawing.Size(71, 16);
            this.cbbCusId.TabIndex = 1;
            this.cbbCusId.Text = "고객 ID :";
            this.cbbCusId.UseVisualStyleBackColor = true;
            // 
            // txbOrderNumber
            // 
            this.txbOrderNumber.Location = new System.Drawing.Point(120, 30);
            this.txbOrderNumber.Name = "txbOrderNumber";
            this.txbOrderNumber.Size = new System.Drawing.Size(118, 21);
            this.txbOrderNumber.TabIndex = 2;
            // 
            // txbCusId
            // 
            this.txbCusId.Location = new System.Drawing.Point(330, 30);
            this.txbCusId.Name = "txbCusId";
            this.txbCusId.Size = new System.Drawing.Size(115, 21);
            this.txbCusId.TabIndex = 3;
            // 
            // btnOrderSearch
            // 
            this.btnOrderSearch.Location = new System.Drawing.Point(475, 28);
            this.btnOrderSearch.Name = "btnOrderSearch";
            this.btnOrderSearch.Size = new System.Drawing.Size(75, 23);
            this.btnOrderSearch.TabIndex = 4;
            this.btnOrderSearch.Text = "검색";
            this.btnOrderSearch.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(11, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "주문조회";
            // 
            // OrderSearchControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gbOrderSearch);
            this.Name = "OrderSearchControl";
            this.Size = new System.Drawing.Size(586, 95);
            this.gbOrderSearch.ResumeLayout(false);
            this.gbOrderSearch.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbOrderSearch;
        private System.Windows.Forms.Button btnOrderSearch;
        private System.Windows.Forms.TextBox txbCusId;
        private System.Windows.Forms.TextBox txbOrderNumber;
        private System.Windows.Forms.CheckBox cbbCusId;
        private System.Windows.Forms.CheckBox cbbOrderNumber;
        private System.Windows.Forms.Label label1;
    }
}
