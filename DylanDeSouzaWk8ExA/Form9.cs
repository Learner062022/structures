using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DylanDeSouzaWk8ExA
{
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        // Declare structure
        struct PersonNameAge
        {
            public string first_name, last_name;
            public int age;
        };

        // Delcare structure variables
        List<PersonNameAge> names_people_same_age = new List<PersonNameAge>();
        PersonNameAge person;

        // Declare variables
        int int_age;

        private void btnAcceptEntry_Click(object sender, EventArgs e)
        {
            if (txtFirstName.Text == "")
            {
                MessageBox.Show("The name cannot be blank - Please enter the name", "Data entry error");
                txtFirstName.Focus();
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
                names_people_same_age.Add(person);

                // prepare for the next entry of details for the next person
                txtFirstName.Clear();
                txtLastName.Clear();
                txtAge.Clear();

                if (lstNames.Items.Count == 0)
                {
                    lstNames.Items.Add("First Name\tLast Name\tAges");
                }
            }
        }

        private void btnShowAverage_Click(object sender, EventArgs e)
        {
            int int_number_people = names_people_same_age.Count(), int_age_total = 0, int_number_people_above_average = 0;
            float flt_age_average = 0;
            foreach (PersonNameAge person in names_people_same_age)
            {
                int_age_total += person.age;
            }
            flt_age_average = (float)int_age_total / int_number_people;
            txtAverageAge.Text = flt_age_average.ToString();

            foreach (PersonNameAge person in names_people_same_age)
            {
                if (person.age > flt_age_average)
                {
                    int_number_people_above_average++;
                }
            }
            txtNumberPeople.Text = int_number_people_above_average.ToString();
            
            for (int i = names_people_same_age.Count - 1; i < names_people_same_age.Count; i = ((1 * i) + 1))
            {
                if (names_people_same_age[i].age == names_people_same_age[i].age)
                {
                    lstNames.Items.Add(names_people_same_age[i].first_name + "\t" + names_people_same_age[i].last_name + "\t" + names_people_same_age[i].age);
                }
                else
                {
                    lstNames.Items.Add(person.first_name + "\t" + person.last_name + "\t" + person.age);
                }
            }
        }
    }
}
