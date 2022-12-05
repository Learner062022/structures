using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using System.Xml.Linq;

namespace DylanDeSouzaWk8ExA
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        // Declare variables
        double dblPrice;

        // Declare structure
        struct product_details
        {
            public string name;
            public decimal price;
        };

        // Declare structure variables
        List<product_details> products = new List<product_details>();
        product_details product;

        private void btnAcceptProduct_Click(object sender, EventArgs e)
        {
            if (txtNameProduct.Text == "")
            {
                MessageBox.Show("The name cannot be blank - Please enter the name", "Data entry error");
                txtNameProduct.Focus();
            }
            else if (!double.TryParse(txtPriceProduct.Text, out dblPrice))
            {
                MessageBox.Show("The entered age is not a number - please enter it again", "Data Entry Error");
                txtPriceProduct.Clear();
                txtPriceProduct.Focus();
            }
            else
            {
                // fill a single structure item
                product.name = txtNameProduct.Text;
                product.price = int.Parse(txtPriceProduct.Text);

                // add the single structure variable to the list
                products.Add(product);

                // prepare for the next entry of details for the next person
                txtNameProduct.Clear();
                txtPriceProduct.Clear();
            }
        }
        private void btnProductsAbove_Click(object sender, EventArgs e)
        {
            lstNamesPricesProducts.Items.Add("Name\tPrice");
            foreach (product_details product in products)
            {
                if (product.price > 10)
                {
                    lstNamesPricesProducts.Items.Add(product.name + "\t" + product.price.ToString("C"));
                }
            }
        }
    }
}
