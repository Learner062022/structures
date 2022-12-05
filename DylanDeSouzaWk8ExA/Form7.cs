using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DylanDeSouzaWk8ExA
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        // Declare structure
        struct tall_peoples_details
        {
            public string first_name, last_name;
            public double height;
        };

        // Declare structure variables
        List<tall_peoples_details> tall_people = new List<tall_peoples_details>();
        tall_peoples_details peoples_details;

        // Declare variables
        double dbl_height;

        private void btnAcceptEntry_Click(object sender, EventArgs e)
        {
            if (txtFirstName.Text == "")
            {
                MessageBox.Show("The first name cannot be blank - Please enter the name", "Data entry error");
                txtFirstName.Focus();
            }
            else if (txtLastName.Text == "")
            {
                MessageBox.Show("The last name cannot be blank - Please enter the name", "Data entry error");
                txtLastName.Focus();
            }
            else if (txtMinHeight.Text == "")
            {
                MessageBox.Show("The minimum height cannot be blank - Please enter a height", "Data entry error");
                txtMinHeight.Focus();
            }
            else if (!double.TryParse(txtMinHeight.Text, out double dblMinHeight))
            {
                MessageBox.Show("Please enter a number for the minimum height", "Data entry error");
                txtMinHeight.Clear();
                txtMinHeight.Focus();
            }
            else if (txtHeight.Text == "")
            {
                MessageBox.Show("The height cannot be blank - Please enter a number for the height", "Data entry error");
                txtHeight.Focus();
            }
            else if (!double.TryParse(txtHeight.Text, out dbl_height))
            {
                MessageBox.Show("Please enter a number for the height", "Data entry error");
                txtHeight.Clear();
                txtHeight.Focus();
            }
            else
            {
                // fill a single structure item
                peoples_details.first_name = txtFirstName.Text;
                peoples_details.last_name = txtLastName.Text;
                peoples_details.height = double.Parse(txtHeight.Text);

                // add the single structure variable to the list
                tall_people.Add(peoples_details);

                // prepare for the next entry of details for the next person
                txtFirstName.Clear();
                txtLastName.Clear();
                txtHeight.Clear();

                if (tall_people.Count >= 2)
                {
                    for (int i = tall_people.Count - 1; i < tall_people.Count; i = ((1 * i) + 1))
                    {
                        if (tall_people[i].height > dblMinHeight)
                        {
                            lstNamesAboveMinHeight.Items.Add(tall_people[i].first_name + "\t" + tall_people[i].last_name);
                        }
                    }
                }
                else if (tall_people.Count < 2)
                {
                    lstNamesAboveMinHeight.Items.Add("First Name\tLast Name");
                    lstNamesAboveMinHeight.Items.Add(peoples_details.first_name + "\t" + peoples_details.last_name);
                }
            }
        }   
    }
}
