using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO.Pipes;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace DylanDeSouzaWk8ExA
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        // Declare structure
        struct PersonNameAge 
        {
            public string first_name;
            public string last_name;
            public int age;
        };

        // Delcare structure variables
        List<PersonNameAge> people = new List<PersonNameAge>();
        PersonNameAge person;

        // Declare variables
        int int_age;

        private void btnAcceptEntry_Click_1(object sender, EventArgs e)
        {
            if (txtFirstName.Text == "")
            {
                MessageBox.Show("The name cannot be blank - Please enter the name", "Data entry error");
                txtFirstName.Focus();
            }
            else if (txtLastName.Text == "")
            {
                MessageBox.Show("The name cannot be blank - Please enter the name", "Data entry error");
                txtLastName.Focus();
            }
            else if (!int.TryParse(txtAge.Text, out int_age))
            {
                MessageBox.Show("The entered age is not a number - please enter it again", "Data Entry Error");
                txtAge.Clear();
                txtAge.Focus();
            }
            else
            {
                // fill a single structure item
                person.first_name = txtFirstName.Text;
                person.last_name = txtLastName.Text;
                person.age = int_age;

                // add the single structure variable to the list
                people.Add(person);

                // prepare for the next entry of details for the next person
                txtLastName.Clear();
                txtAge.Clear();
            }
        }

        private void btnShowAverage_Click_1(object sender, EventArgs e)
        {
            int int_number_people = people.Count(), int_age_total = 0, int_number_people_above_average = 0;
            float flt_age_average = 0;
            foreach (PersonNameAge person in people)
            {
                int_age_total += person.age;
            }
            flt_age_average = (float)int_age_total / int_number_people;
            txtAverageAge.Text = flt_age_average.ToString();
            foreach (PersonNameAge person in people)
            {
                if (person.age > flt_age_average)
                {
                    int_number_people_above_average++;
                    lstNames.Items.Add(person.first_name + "\t" + person.last_name);
                }
            }
            txtNumberPeople.Text = int_number_people.ToString();
        }
    }
}
