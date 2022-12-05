namespace DylanDeSouzaWk8ExA
{
    partial class Form6
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
            this.txtMaxPrice = new System.Windows.Forms.TextBox();
            this.lblMaximumPrice = new System.Windows.Forms.Label();
            this.lstNamesPricesProducts = new System.Windows.Forms.ListBox();
            this.btnProductsBelowEnteredPrice = new System.Windows.Forms.Button();
            this.txtPriceProduct = new System.Windows.Forms.TextBox();
            this.txtNameProduct = new System.Windows.Forms.TextBox();
            this.lblPriceProduct = new System.Windows.Forms.Label();
            this.lblNameProduct = new System.Windows.Forms.Label();
            this.btnAcceptProduct = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtMaxPrice
            // 
            this.txtMaxPrice.Location = new System.Drawing.Point(371, 162);
            this.txtMaxPrice.Name = "txtMaxPrice";
            this.txtMaxPrice.Size = new System.Drawing.Size(100, 20);
            this.txtMaxPrice.TabIndex = 10;
            // 
            // lblMaximumPrice
            // 
            this.lblMaximumPrice.AutoSize = true;
            this.lblMaximumPrice.Location = new System.Drawing.Point(287, 169);
            this.lblMaximumPrice.Name = "lblMaximumPrice";
            this.lblMaximumPrice.Size = new System.Drawing.Size(78, 13);
            this.lblMaximumPrice.TabIndex = 11;
            this.lblMaximumPrice.Text = "Maximum Price";
            // 
            // lstNamesPricesProducts
            // 
            this.lstNamesPricesProducts.FormattingEnabled = true;
            this.lstNamesPricesProducts.Location = new System.Drawing.Point(371, 298);
            this.lstNamesPricesProducts.Name = "lstNamesPricesProducts";
            this.lstNamesPricesProducts.Size = new System.Drawing.Size(120, 95);
            this.lstNamesPricesProducts.TabIndex = 18;
            // 
            // btnProductsBelowEnteredPrice
            // 
            this.btnProductsBelowEnteredPrice.Location = new System.Drawing.Point(371, 269);
            this.btnProductsBelowEnteredPrice.Name = "btnProductsBelowEnteredPrice";
            this.btnProductsBelowEnteredPrice.Size = new System.Drawing.Size(179, 23);
            this.btnProductsBelowEnteredPrice.TabIndex = 17;
            this.btnProductsBelowEnteredPrice.Text = "Products below the entered Price";
            this.btnProductsBelowEnteredPrice.UseVisualStyleBackColor = true;
            this.btnProductsBelowEnteredPrice.Click += new System.EventHandler(this.btnProductsAbove_Click);
            // 
            // txtPriceProduct
            // 
            this.txtPriceProduct.Location = new System.Drawing.Point(371, 214);
            this.txtPriceProduct.Name = "txtPriceProduct";
            this.txtPriceProduct.Size = new System.Drawing.Size(100, 20);
            this.txtPriceProduct.TabIndex = 16;
            // 
            // txtNameProduct
            // 
            this.txtNameProduct.Location = new System.Drawing.Point(371, 188);
            this.txtNameProduct.Name = "txtNameProduct";
            this.txtNameProduct.Size = new System.Drawing.Size(100, 20);
            this.txtNameProduct.TabIndex = 15;
            // 
            // lblPriceProduct
            // 
            this.lblPriceProduct.AutoSize = true;
            this.lblPriceProduct.Location = new System.Drawing.Point(295, 221);
            this.lblPriceProduct.Name = "lblPriceProduct";
            this.lblPriceProduct.Size = new System.Drawing.Size(70, 13);
            this.lblPriceProduct.TabIndex = 14;
            this.lblPriceProduct.Text = "Price product";
            // 
            // lblNameProduct
            // 
            this.lblNameProduct.AutoSize = true;
            this.lblNameProduct.Location = new System.Drawing.Point(291, 195);
            this.lblNameProduct.Name = "lblNameProduct";
            this.lblNameProduct.Size = new System.Drawing.Size(74, 13);
            this.lblNameProduct.TabIndex = 13;
            this.lblNameProduct.Text = "Name product";
            // 
            // btnAcceptProduct
            // 
            this.btnAcceptProduct.Location = new System.Drawing.Point(371, 240);
            this.btnAcceptProduct.Name = "btnAcceptProduct";
            this.btnAcceptProduct.Size = new System.Drawing.Size(100, 23);
            this.btnAcceptProduct.TabIndex = 12;
            this.btnAcceptProduct.Text = "Accept Product";
            this.btnAcceptProduct.UseVisualStyleBackColor = true;
            this.btnAcceptProduct.Click += new System.EventHandler(this.btnAcceptProduct_Click);
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstNamesPricesProducts);
            this.Controls.Add(this.btnProductsBelowEnteredPrice);
            this.Controls.Add(this.txtPriceProduct);
            this.Controls.Add(this.txtNameProduct);
            this.Controls.Add(this.lblPriceProduct);
            this.Controls.Add(this.lblNameProduct);
            this.Controls.Add(this.btnAcceptProduct);
            this.Controls.Add(this.lblMaximumPrice);
            this.Controls.Add(this.txtMaxPrice);
            this.Name = "Form6";
            this.Text = "Form6";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMaxPrice;
        private System.Windows.Forms.Label lblMaximumPrice;
        private System.Windows.Forms.ListBox lstNamesPricesProducts;
        private System.Windows.Forms.Button btnProductsBelowEnteredPrice;
        private System.Windows.Forms.TextBox txtPriceProduct;
        private System.Windows.Forms.TextBox txtNameProduct;
        private System.Windows.Forms.Label lblPriceProduct;
        private System.Windows.Forms.Label lblNameProduct;
        private System.Windows.Forms.Button btnAcceptProduct;
    }
}