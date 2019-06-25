namespace MiniProject.Control
{
    partial class EmployeeControl
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.registerEmployeeControl1 = new Miniproject.RegisterEmployeeControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.uscEmployeeInfo = new Miniproject.EmployeeInfoControl();
            this.employeeSearch1 = new Miniproject.EmployeeSearch();
            this.employeeUpdateDelete1 = new MiniProject.EmployeeUpdateDelete();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(3, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(793, 439);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.registerEmployeeControl1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(785, 413);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "정보등록";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // registerEmployeeControl1
            // 
            this.registerEmployeeControl1.Location = new System.Drawing.Point(6, 6);
            this.registerEmployeeControl1.Name = "registerEmployeeControl1";
            this.registerEmployeeControl1.Size = new System.Drawing.Size(773, 319);
            this.registerEmployeeControl1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.employeeUpdateDelete1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(785, 413);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "삭제 및 제거";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.uscEmployeeInfo);
            this.tabPage4.Controls.Add(this.employeeSearch1);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(785, 413);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "조회";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // uscEmployeeInfo
            // 
            this.uscEmployeeInfo.Location = new System.Drawing.Point(14, 77);
            this.uscEmployeeInfo.Name = "uscEmployeeInfo";
            this.uscEmployeeInfo.Size = new System.Drawing.Size(755, 303);
            this.uscEmployeeInfo.TabIndex = 1;
            // 
            // employeeSearch1
            // 
            this.employeeSearch1.Location = new System.Drawing.Point(14, 14);
            this.employeeSearch1.Name = "employeeSearch1";
            this.employeeSearch1.Size = new System.Drawing.Size(267, 34);
            this.employeeSearch1.TabIndex = 0;
            this.employeeSearch1.EnterSearchEmpoyeeInfo += new System.EventHandler<Miniproject.EmployeeSearch.EnterSearchEmpoyeeInfoEventArgs>(this.employeeSearch1_EnterSearchEmpoyeeInfo);
            // 
            // employeeUpdateDelete1
            // 
            this.employeeUpdateDelete1.Location = new System.Drawing.Point(33, 47);
            this.employeeUpdateDelete1.Name = "employeeUpdateDelete1";
            this.employeeUpdateDelete1.Size = new System.Drawing.Size(732, 307);
            this.employeeUpdateDelete1.TabIndex = 0;
            // 
            // EmployeeControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "EmployeeControl";
            this.Text = "EmployeeControl";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private Miniproject.RegisterEmployeeControl registerEmployeeControl1;
        private System.Windows.Forms.TabPage tabPage4;
        private Miniproject.EmployeeSearch employeeSearch1;
        private Miniproject.EmployeeInfoControl uscEmployeeInfo;
        private EmployeeUpdateDelete employeeUpdateDelete1;
    }
}