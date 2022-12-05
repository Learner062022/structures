namespace DylanDeSouzaWk8ExA
{
    partial class Form8
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
            this.btnDisplay = new System.Windows.Forms.Button();
            this.txtMinimumHours = new System.Windows.Forms.TextBox();
            this.lstEmployeesNameWeeklyPay = new System.Windows.Forms.ListBox();
            this.lblMinimumHours = new System.Windows.Forms.Label();
            this.txtHoursWorked = new System.Windows.Forms.TextBox();
            this.lblHoursWorked = new System.Windows.Forms.Label();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnDisplay
            // 
            this.btnDisplay.Location = new System.Drawing.Point(295, 178);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(120, 23);
            this.btnDisplay.TabIndex = 0;
            this.btnDisplay.Text = "Display";
            this.btnDisplay.UseVisualStyleBackColor = true;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // txtMinimumHours
            // 
            this.txtMinimumHours.Location = new System.Drawing.Point(295, 152);
            this.txtMinimumHours.Name = "txtMinimumHours";
            this.txtMinimumHours.Size = new System.Drawing.Size(120, 20);
            this.txtMinimumHours.TabIndex = 1;
            // 
            // lstEmployeesNameWeeklyPay
            // 
            this.lstEmployeesNameWeeklyPay.FormattingEnabled = true;
            this.lstEmployeesNameWeeklyPay.Location = new System.Drawing.Point(295, 207);
            this.lstEmployeesNameWeeklyPay.Name = "lstEmployeesNameWeeklyPay";
            this.lstEmployeesNameWeeklyPay.Size = new System.Drawing.Size(120, 95);
            this.lstEmployeesNameWeeklyPay.TabIndex = 2;
            // 
            // lblMinimumHours
            // 
            this.lblMinimumHours.AutoSize = true;
            this.lblMinimumHours.Location = new System.Drawing.Point(210, 159);
            this.lblMinimumHours.Name = "lblMinimumHours";
            this.lblMinimumHours.Size = new System.Drawing.Size(79, 13);
            this.lblMinimumHours.TabIndex = 3;
            this.lblMinimumHours.Text = "Minimum Hours";
            // 
            // txtHoursWorked
            // 
            this.txtHoursWorked.Location = new System.Drawing.Point(295, 126);
            this.txtHoursWorked.Name = "txtHoursWorked";
            this.txtHoursWorked.Size = new System.Drawing.Size(120, 20);
            this.txtHoursWorked.TabIndex = 4;
            // 
            // lblHoursWorked
            // 
            this.lblHoursWorked.AutoSize = true;
            this.lblHoursWorked.Location = new System.Drawing.Point(213, 133);
            this.lblHoursWorked.Name = "lblHoursWorked";
            this.lblHoursWorked.Size = new System.Drawing.Size(76, 13);
            this.lblHoursWorked.TabIndex = 5;
            this.lblHoursWorked.Text = "Hours Worked";
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(295, 100);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(120, 20);
            this.txtSurname.TabIndex = 6;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(295, 74);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(120, 20);
            this.txtFirstName.TabIndex = 7;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(232, 81);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(57, 13);
            this.lblFirstName.TabIndex = 8;
            this.lblFirstName.Text = "First Name";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Location = new System.Drawing.Point(240, 107);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(49, 13);
            this.lblSurname.TabIndex = 9;
            this.lblSurname.Text = "Surname";
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblSurname);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.lblHoursWorked);
            this.Controls.Add(this.txtHoursWorked);
            this.Controls.Add(this.lblMinimumHours);
            this.Controls.Add(this.lstEmployeesNameWeeklyPay);
            this.Controls.Add(this.txtMinimumHours);
            this.Controls.Add(this.btnDisplay);
            this.Name = "Form8";
            this.Text = "Form8";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.TextBox txtMinimumHours;
        private System.Windows.Forms.ListBox lstEmployeesNameWeeklyPay;
        private System.Windows.Forms.Label lblMinimumHours;
        private System.Windows.Forms.TextBox txtHoursWorked;
        private System.Windows.Forms.Label lblHoursWorked;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblSurname;
    }
}