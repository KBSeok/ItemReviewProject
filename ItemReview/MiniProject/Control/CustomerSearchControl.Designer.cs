namespace ItemReview
{
    partial class CustomerSearchControl
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
            this.gbCusSearch = new System.Windows.Forms.GroupBox();
            this.chbCusGrade = new System.Windows.Forms.CheckBox();
            this.cbbGrade = new System.Windows.Forms.ComboBox();
            this.chbCusId = new System.Windows.Forms.CheckBox();
            this.txbCusId = new System.Windows.Forms.TextBox();
            this.gbCusSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbCusSearch
            // 
            this.gbCusSearch.Controls.Add(this.chbCusGrade);
            this.gbCusSearch.Controls.Add(this.cbbGrade);
            this.gbCusSearch.Controls.Add(this.chbCusId);
            this.gbCusSearch.Controls.Add(this.txbCusId);
            this.gbCusSearch.Location = new System.Drawing.Point(9, 4);
            this.gbCusSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbCusSearch.Name = "gbCusSearch";
            this.gbCusSearch.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbCusSearch.Size = new System.Drawing.Size(647, 71);
            this.gbCusSearch.TabIndex = 0;
            this.gbCusSearch.TabStop = false;
            // 
            // chbCusGrade
            // 
            this.chbCusGrade.AutoSize = true;
            this.chbCusGrade.Location = new System.Drawing.Point(293, 30);
            this.chbCusGrade.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chbCusGrade.Name = "chbCusGrade";
            this.chbCusGrade.Size = new System.Drawing.Size(104, 19);
            this.chbCusGrade.TabIndex = 3;
            this.chbCusGrade.Text = "고객등급 : ";
            this.chbCusGrade.UseVisualStyleBackColor = true;
            // 
            // cbbGrade
            // 
            this.cbbGrade.FormattingEnabled = true;
            this.cbbGrade.Location = new System.Drawing.Point(407, 28);
            this.cbbGrade.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbbGrade.Name = "cbbGrade";
            this.cbbGrade.Size = new System.Drawing.Size(122, 23);
            this.cbbGrade.TabIndex = 1;
            // 
            // chbCusId
            // 
            this.chbCusId.AutoSize = true;
            this.chbCusId.Location = new System.Drawing.Point(7, 30);
            this.chbCusId.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chbCusId.Name = "chbCusId";
            this.chbCusId.Size = new System.Drawing.Size(87, 19);
            this.chbCusId.TabIndex = 2;
            this.chbCusId.Text = "회원 ID :";
            this.chbCusId.UseVisualStyleBackColor = true;
            // 
            // txbCusId
            // 
            this.txbCusId.Location = new System.Drawing.Point(91, 26);
            this.txbCusId.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txbCusId.Name = "txbCusId";
            this.txbCusId.Size = new System.Drawing.Size(177, 25);
            this.txbCusId.TabIndex = 0;
            // 
            // CustomerSearchControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbCusSearch);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "CustomerSearchControl";
            this.Size = new System.Drawing.Size(662, 82);
            this.gbCusSearch.ResumeLayout(false);
            this.gbCusSearch.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbCusSearch;
        private System.Windows.Forms.CheckBox chbCusGrade;
        private System.Windows.Forms.ComboBox cbbGrade;
        private System.Windows.Forms.CheckBox chbCusId;
        private System.Windows.Forms.TextBox txbCusId;
    }
}
