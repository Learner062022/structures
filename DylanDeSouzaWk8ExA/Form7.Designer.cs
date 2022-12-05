namespace DylanDeSouzaWk8ExA
{
    partial class Form7
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
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.btnTalls = new System.Windows.Forms.Button();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.lblHeight = new System.Windows.Forms.Label();
            this.txtMinHeight = new System.Windows.Forms.TextBox();
            this.lblMinimumHeight = new System.Windows.Forms.Label();
            this.lstNamesAboveMinHeight = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(371, 214);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(100, 20);
            this.txtLastName.TabIndex = 9;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(371, 188);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(100, 20);
            this.txtFirstName.TabIndex = 8;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(309, 221);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(52, 13);
            this.lblLastName.TabIndex = 7;
            this.lblLastName.Text = "last name";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(308, 195);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(52, 13);
            this.lblFirstName.TabIndex = 6;
            this.lblFirstName.Text = "first name";
            // 
            // btnTalls
            // 
            this.btnTalls.Location = new System.Drawing.Point(371, 272);
            this.btnTalls.Name = "btnTalls";
            this.btnTalls.Size = new System.Drawing.Size(85, 23);
            this.btnTalls.TabIndex = 5;
            this.btnTalls.Text = "Talls";
            this.btnTalls.UseVisualStyleBackColor = true;
            this.btnTalls.Click += new System.EventHandler(this.btnAcceptEntry_Click);
            // 
            // txtHeight
            // 
            this.txtHeight.Location = new System.Drawing.Point(371, 240);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(100, 20);
            this.txtHeight.TabIndex = 10;
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.Location = new System.Drawing.Point(327, 247);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(36, 13);
            this.lblHeight.TabIndex = 11;
            this.lblHeight.Text = "height";
            // 
            // txtMinHeight
            // 
            this.txtMinHeight.Location = new System.Drawing.Point(371, 162);
            this.txtMinHeight.Name = "txtMinHeight";
            this.txtMinHeight.Size = new System.Drawing.Size(100, 20);
            this.txtMinHeight.TabIndex = 12;
            // 
            // lblMinimumHeight
            // 
            this.lblMinimumHeight.AutoSize = true;
            this.lblMinimumHeight.Location = new System.Drawing.Point(283, 169);
            this.lblMinimumHeight.Name = "lblMinimumHeight";
            this.lblMinimumHeight.Size = new System.Drawing.Size(79, 13);
            this.lblMinimumHeight.TabIndex = 13;
            this.lblMinimumHeight.Text = "minimum height";
            // 
            // lstNamesAboveMinHeight
            // 
            this.lstNamesAboveMinHeight.FormattingEnabled = true;
            this.lstNamesAboveMinHeight.Location = new System.Drawing.Point(371, 301);
            this.lstNamesAboveMinHeight.Name = "lstNamesAboveMinHeight";
            this.lstNamesAboveMinHeight.Size = new System.Drawing.Size(271, 95);
            this.lstNamesAboveMinHeight.TabIndex = 14;
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstNamesAboveMinHeight);
            this.Controls.Add(this.lblMinimumHeight);
            this.Controls.Add(this.txtMinHeight);
            this.Controls.Add(this.lblHeight);
            this.Controls.Add(this.txtHeight);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.btnTalls);
            this.Name = "Form7";
            this.Text = "Form7";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Button btnTalls;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.TextBox txtMinHeight;
        private System.Windows.Forms.Label lblMinimumHeight;
        private System.Windows.Forms.ListBox lstNamesAboveMinHeight;
    }
}