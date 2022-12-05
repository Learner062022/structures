namespace DylanDeSouzaWk8ExA
{
    partial class Form4
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
            this.txtAverageAge = new System.Windows.Forms.TextBox();
            this.txtNumberPeople = new System.Windows.Forms.TextBox();
            this.lblAverageAge = new System.Windows.Forms.Label();
            this.lblNumberPeople = new System.Windows.Forms.Label();
            this.btnShowAverage = new System.Windows.Forms.Button();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.lblAge = new System.Windows.Forms.Label();
            this.btnAcceptEntry = new System.Windows.Forms.Button();
            this.lstNames = new System.Windows.Forms.ListBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtAverageAge
            // 
            this.txtAverageAge.Location = new System.Drawing.Point(441, 269);
            this.txtAverageAge.Name = "txtAverageAge";
            this.txtAverageAge.Size = new System.Drawing.Size(100, 20);
            this.txtAverageAge.TabIndex = 24;
            this.txtAverageAge.TabStop = false;
            // 
            // txtNumberPeople
            // 
            this.txtNumberPeople.Location = new System.Drawing.Point(441, 243);
            this.txtNumberPeople.Name = "txtNumberPeople";
            this.txtNumberPeople.Size = new System.Drawing.Size(100, 20);
            this.txtNumberPeople.TabIndex = 23;
            this.txtNumberPeople.TabStop = false;
            // 
            // lblAverageAge
            // 
            this.lblAverageAge.AutoSize = true;
            this.lblAverageAge.Location = new System.Drawing.Point(367, 276);
            this.lblAverageAge.Name = "lblAverageAge";
            this.lblAverageAge.Size = new System.Drawing.Size(68, 13);
            this.lblAverageAge.TabIndex = 22;
            this.lblAverageAge.Text = "Average age";
            // 
            // lblNumberPeople
            // 
            this.lblNumberPeople.AutoSize = true;
            this.lblNumberPeople.Location = new System.Drawing.Point(260, 250);
            this.lblNumberPeople.Name = "lblNumberPeople";
            this.lblNumberPeople.Size = new System.Drawing.Size(175, 13);
            this.lblNumberPeople.TabIndex = 21;
            this.lblNumberPeople.Text = "Number people above average age";
            // 
            // btnShowAverage
            // 
            this.btnShowAverage.Location = new System.Drawing.Point(441, 295);
            this.btnShowAverage.Name = "btnShowAverage";
            this.btnShowAverage.Size = new System.Drawing.Size(100, 23);
            this.btnShowAverage.TabIndex = 20;
            this.btnShowAverage.Text = "Show Average";
            this.btnShowAverage.UseVisualStyleBackColor = true;
            this.btnShowAverage.Click += new System.EventHandler(this.btnShowAverage_Click_1);
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(441, 159);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(100, 20);
            this.txtAge.TabIndex = 19;
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(409, 166);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(26, 13);
            this.lblAge.TabIndex = 17;
            this.lblAge.Text = "Age";
            // 
            // btnAcceptEntry
            // 
            this.btnAcceptEntry.Location = new System.Drawing.Point(441, 185);
            this.btnAcceptEntry.Name = "btnAcceptEntry";
            this.btnAcceptEntry.Size = new System.Drawing.Size(100, 23);
            this.btnAcceptEntry.TabIndex = 15;
            this.btnAcceptEntry.Text = "Accept Entry";
            this.btnAcceptEntry.UseVisualStyleBackColor = true;
            this.btnAcceptEntry.Click += new System.EventHandler(this.btnAcceptEntry_Click_1);
            // 
            // lstNames
            // 
            this.lstNames.FormattingEnabled = true;
            this.lstNames.Items.AddRange(new object[] {
            "First Name Last Name"});
            this.lstNames.Location = new System.Drawing.Point(441, 324);
            this.lstNames.Name = "lstNames";
            this.lstNames.Size = new System.Drawing.Size(120, 95);
            this.lstNames.TabIndex = 25;
            this.lstNames.TabStop = false;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(378, 114);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(57, 13);
            this.lblFirstName.TabIndex = 29;
            this.lblFirstName.Text = "First Nmae";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(441, 107);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(100, 20);
            this.txtFirstName.TabIndex = 28;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(441, 133);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(100, 20);
            this.txtLastName.TabIndex = 27;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(378, 140);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(58, 13);
            this.lblLastName.TabIndex = 26;
            this.lblLastName.Text = "Last Name";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lstNames);
            this.Controls.Add(this.txtAverageAge);
            this.Controls.Add(this.txtNumberPeople);
            this.Controls.Add(this.lblAverageAge);
            this.Controls.Add(this.lblNumberPeople);
            this.Controls.Add(this.btnShowAverage);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.btnAcceptEntry);
            this.Name = "Form4";
            this.Text = "Form4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAverageAge;
        private System.Windows.Forms.TextBox txtNumberPeople;
        private System.Windows.Forms.Label lblAverageAge;
        private System.Windows.Forms.Label lblNumberPeople;
        private System.Windows.Forms.Button btnShowAverage;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Button btnAcceptEntry;
        private System.Windows.Forms.ListBox lstNames;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblLastName;
    }
}