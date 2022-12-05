namespace DylanDeSouzaWk8ExA
{
    partial class Form5
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
            this.txtPriceProduct = new System.Windows.Forms.TextBox();
            this.txtNameProduct = new System.Windows.Forms.TextBox();
            this.lblPriceProduct = new System.Windows.Forms.Label();
            this.lblNameProduct = new System.Windows.Forms.Label();
            this.btnAcceptProduct = new System.Windows.Forms.Button();
            this.btnProductsAbove = new System.Windows.Forms.Button();
            this.lstNamesPricesProducts = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // txtPriceProduct
            // 
            this.txtPriceProduct.Location = new System.Drawing.Point(371, 214);
            this.txtPriceProduct.Name = "txtPriceProduct";
            this.txtPriceProduct.Size = new System.Drawing.Size(100, 20);
            this.txtPriceProduct.TabIndex = 9;
            // 
            // txtNameProduct
            // 
            this.txtNameProduct.Location = new System.Drawing.Point(371, 188);
            this.txtNameProduct.Name = "txtNameProduct";
            this.txtNameProduct.Size = new System.Drawing.Size(100, 20);
            this.txtNameProduct.TabIndex = 8;
            // 
            // lblPriceProduct
            // 
            this.lblPriceProduct.AutoSize = true;
            this.lblPriceProduct.Location = new System.Drawing.Point(295, 221);
            this.lblPriceProduct.Name = "lblPriceProduct";
            this.lblPriceProduct.Size = new System.Drawing.Size(70, 13);
            this.lblPriceProduct.TabIndex = 7;
            this.lblPriceProduct.Text = "Price product";
            // 
            // lblNameProduct
            // 
            this.lblNameProduct.AutoSize = true;
            this.lblNameProduct.Location = new System.Drawing.Point(290, 195);
            this.lblNameProduct.Name = "lblNameProduct";
            this.lblNameProduct.Size = new System.Drawing.Size(74, 13);
            this.lblNameProduct.TabIndex = 6;
            this.lblNameProduct.Text = "Name product";
            // 
            // btnAcceptProduct
            // 
            this.btnAcceptProduct.Location = new System.Drawing.Point(371, 240);
            this.btnAcceptProduct.Name = "btnAcceptProduct";
            this.btnAcceptProduct.Size = new System.Drawing.Size(100, 23);
            this.btnAcceptProduct.TabIndex = 5;
            this.btnAcceptProduct.Text = "Accept Product";
            this.btnAcceptProduct.UseVisualStyleBackColor = true;
            this.btnAcceptProduct.Click += new System.EventHandler(this.btnAcceptProduct_Click);
            // 
            // btnProductsAbove
            // 
            this.btnProductsAbove.Location = new System.Drawing.Point(371, 269);
            this.btnProductsAbove.Name = "btnProductsAbove";
            this.btnProductsAbove.Size = new System.Drawing.Size(120, 23);
            this.btnProductsAbove.TabIndex = 10;
            this.btnProductsAbove.Text = "Products above $10";
            this.btnProductsAbove.UseVisualStyleBackColor = true;
            this.btnProductsAbove.Click += new System.EventHandler(this.btnProductsAbove_Click);
            // 
            // lstNamesPricesProducts
            // 
            this.lstNamesPricesProducts.FormattingEnabled = true;
            this.lstNamesPricesProducts.Location = new System.Drawing.Point(371, 298);
            this.lstNamesPricesProducts.Name = "lstNamesPricesProducts";
            this.lstNamesPricesProducts.Size = new System.Drawing.Size(120, 95);
            this.lstNamesPricesProducts.TabIndex = 11;
            this.lstNamesPricesProducts.TabStop = false;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstNamesPricesProducts);
            this.Controls.Add(this.btnProductsAbove);
            this.Controls.Add(this.txtPriceProduct);
            this.Controls.Add(this.txtNameProduct);
            this.Controls.Add(this.lblPriceProduct);
            this.Controls.Add(this.lblNameProduct);
            this.Controls.Add(this.btnAcceptProduct);
            this.Name = "Form5";
            this.Text = "Form5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPriceProduct;
        private System.Windows.Forms.TextBox txtNameProduct;
        private System.Windows.Forms.Label lblPriceProduct;
        private System.Windows.Forms.Label lblNameProduct;
        private System.Windows.Forms.Button btnAcceptProduct;
        private System.Windows.Forms.Button btnProductsAbove;
        private System.Windows.Forms.ListBox lstNamesPricesProducts;
    }
}