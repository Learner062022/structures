using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace DylanDeSouzaWk8ExA
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        struct PeoplesNamesAges // Defining structure type
        {
            public string name; 
            public int age;
        };

        List<PeoplesNamesAges> people = new List<PeoplesNamesAges>(); // Structure list

        private void btnAcceptEntry_Click(object sender, EventArgs e)
        {
            PeoplesNamesAges person; // Declaring structure variables
            int int_age;

            if (txtLastName.Text == "")
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
                person.name = txtLastName.Text;
                person.age = int.Parse(txtAge.Text);

                // add the single structure variable to the list
                people.Add(person);

                // prepare for the next entry of details for the next person
                txtLastName.Clear();
                txtAge.Clear();
            }
        }
        private void btnShowAverage_Click(object sender, EventArgs e)
        {
            int int_number_people = people.Count(), int_age_total = 0, int_number_people_above_average = 0;
            float flt_age_average = 0;
            foreach (PeoplesNamesAges person in people)
            {
                int_age_total += person.age;
            }
            flt_age_average = (float)int_age_total / int_number_people;
            txtAverageAge.Text = flt_age_average.ToString();
            foreach (PeoplesNamesAges person in people)
            {
                if (person.age > flt_age_average)
                {
                    int_number_people_above_average ++;
                }
            }
            txtNumberPeople.Text = int_number_people_above_average.ToString();
        }
    }
}

