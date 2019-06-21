namespace ItemReview
{
    partial class EmployeeInfoForm
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
            this.employeeSearch1 = new ItemReview.EmployeeSearch();
            this.employeeInfoControl1 = new ItemReview.EmployeeInfoControl();
            this.registerEmployeeControl1 = new ItemReview.RegisterEmployeeControl();
            this.SuspendLayout();
            // 
            // employeeSearch1
            // 
            this.employeeSearch1.Location = new System.Drawing.Point(454, 212);
            this.employeeSearch1.Name = "employeeSearch1";
            this.employeeSearch1.Size = new System.Drawing.Size(267, 34);
            this.employeeSearch1.TabIndex = 2;
            // 
            // employeeInfoControl1
            // 
            this.employeeInfoControl1.Location = new System.Drawing.Point(14, 252);
            this.employeeInfoControl1.Name = "employeeInfoControl1";
            this.employeeInfoControl1.Size = new System.Drawing.Size(707, 169);
            this.employeeInfoControl1.TabIndex = 1;
            // 
            // registerEmployeeControl1
            // 
            this.registerEmployeeControl1.Location = new System.Drawing.Point(13, 13);
            this.registerEmployeeControl1.Name = "registerEmployeeControl1";
            this.registerEmployeeControl1.Size = new System.Drawing.Size(726, 177);
            this.registerEmployeeControl1.TabIndex = 0;
            // 
            // EmployeeInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 450);
            this.Controls.Add(this.employeeSearch1);
            this.Controls.Add(this.employeeInfoControl1);
            this.Controls.Add(this.registerEmployeeControl1);
            this.Name = "EmployeeInfoForm";
            this.Text = "EmployeeInfo";
            this.ResumeLayout(false);

        }

        #endregion

        private RegisterEmployeeControl registerEmployeeControl1;
        private EmployeeInfoControl employeeInfoControl1;
        private EmployeeSearch employeeSearch1;
    }
}