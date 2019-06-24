namespace Miniproject
{
    partial class StockSearchControl
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
            this.btnStockSearch = new System.Windows.Forms.Button();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.txbName = new System.Windows.Forms.TextBox();
            this.cbbColor = new System.Windows.Forms.ComboBox();
            this.cbbSize = new System.Windows.Forms.ComboBox();
            this.cbbLCategory = new System.Windows.Forms.ComboBox();
            this.cbbHCategory = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbOrderSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbOrderSearch
            // 
            this.gbOrderSearch.Controls.Add(this.btnStockSearch);
            this.gbOrderSearch.Controls.Add(this.checkBox4);
            this.gbOrderSearch.Controls.Add(this.checkBox3);
            this.gbOrderSearch.Controls.Add(this.checkBox2);
            this.gbOrderSearch.Controls.Add(this.checkBox1);
            this.gbOrderSearch.Controls.Add(this.txbName);
            this.gbOrderSearch.Controls.Add(this.cbbColor);
            this.gbOrderSearch.Controls.Add(this.cbbSize);
            this.gbOrderSearch.Controls.Add(this.cbbLCategory);
            this.gbOrderSearch.Controls.Add(this.cbbHCategory);
            this.gbOrderSearch.Controls.Add(this.label1);
            this.gbOrderSearch.Location = new System.Drawing.Point(3, 3);
            this.gbOrderSearch.Name = "gbOrderSearch";
            this.gbOrderSearch.Size = new System.Drawing.Size(572, 160);
            this.gbOrderSearch.TabIndex = 1;
            this.gbOrderSearch.TabStop = false;
            // 
            // btnStockSearch
            // 
            this.btnStockSearch.Location = new System.Drawing.Point(472, 131);
            this.btnStockSearch.Name = "btnStockSearch";
            this.btnStockSearch.Size = new System.Drawing.Size(75, 23);
            this.btnStockSearch.TabIndex = 1;
            this.btnStockSearch.Text = "검색";
            this.btnStockSearch.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(397, 87);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(15, 14);
            this.checkBox4.TabIndex = 9;
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(195, 89);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(15, 14);
            this.checkBox3.TabIndex = 8;
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(397, 35);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(15, 14);
            this.checkBox2.TabIndex = 7;
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(195, 31);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(15, 14);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // txbName
            // 
            this.txbName.Location = new System.Drawing.Point(68, 30);
            this.txbName.Name = "txbName";
            this.txbName.Size = new System.Drawing.Size(100, 21);
            this.txbName.TabIndex = 5;
            // 
            // cbbColor
            // 
            this.cbbColor.FormattingEnabled = true;
            this.cbbColor.Location = new System.Drawing.Point(427, 86);
            this.cbbColor.Name = "cbbColor";
            this.cbbColor.Size = new System.Drawing.Size(121, 20);
            this.cbbColor.TabIndex = 4;
            // 
            // cbbSize
            // 
            this.cbbSize.FormattingEnabled = true;
            this.cbbSize.Location = new System.Drawing.Point(426, 30);
            this.cbbSize.Name = "cbbSize";
            this.cbbSize.Size = new System.Drawing.Size(121, 20);
            this.cbbSize.TabIndex = 3;
            // 
            // cbbLCategory
            // 
            this.cbbLCategory.FormattingEnabled = true;
            this.cbbLCategory.Location = new System.Drawing.Point(228, 87);
            this.cbbLCategory.Name = "cbbLCategory";
            this.cbbLCategory.Size = new System.Drawing.Size(121, 20);
            this.cbbLCategory.TabIndex = 2;
            // 
            // cbbHCategory
            // 
            this.cbbHCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbHCategory.FormattingEnabled = true;
            this.cbbHCategory.Location = new System.Drawing.Point(228, 31);
            this.cbbHCategory.Name = "cbbHCategory";
            this.cbbHCategory.Size = new System.Drawing.Size(119, 20);
            this.cbbHCategory.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "상품명 :";
            // 
            // StockSearchControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbOrderSearch);
            this.Name = "StockSearchControl";
            this.Size = new System.Drawing.Size(584, 168);
            this.gbOrderSearch.ResumeLayout(false);
            this.gbOrderSearch.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbOrderSearch;
        private System.Windows.Forms.Button btnStockSearch;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox txbName;
        private System.Windows.Forms.ComboBox cbbColor;
        private System.Windows.Forms.ComboBox cbbSize;
        private System.Windows.Forms.ComboBox cbbLCategory;
        private System.Windows.Forms.ComboBox cbbHCategory;
        private System.Windows.Forms.Label label1;
    }
}
