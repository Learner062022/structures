using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DylanDeSouzaWk8ExA
{
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        // Declare variables
        double dblMinimumHours = 0;
        const uint HOURLY_RATE = 25U;

        // Declare structure
        struct employees_name_hours_worked
        {
            public string first_name, last_name;
            public double hours_worked, weekly_pay;
        };

        // Declare structure variables
        employees_name_hours_worked name_hours_worked;
        double dbl_hours_worked = 0, dbl_weekly_pay = 0;
        List<employees_name_hours_worked> employees = new List<employees_name_hours_worked>();

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtHoursWorked.Text, out dbl_hours_worked))
            {
                dbl_hours_worked = double.Parse(txtHoursWorked.Text);
            }
            else if (txtHoursWorked.Text == "")
            {
                MessageBox.Show("Enter the amount of hours worked");
            }
            else if (!double.TryParse(txtHoursWorked.Text, out dbl_hours_worked))
            {
                MessageBox.Show("Enter a numeric value");
            }
            else if (double.TryParse(txtMinimumHours.Text, out dblMinimumHours))
            {
                dblMinimumHours = double.Parse(txtMinimumHours.Text);
            }
            else if (!double.TryParse(txtMinimumHours.Text, out dblMinimumHours))
            {
                MessageBox.Show("Enter a numeric value");
            }
            else if (txtMinimumHours.Text == "")
            {
                MessageBox.Show("Enter a minimal amount of hours worked");
            }
            else
            {
                dbl_weekly_pay = HOURLY_RATE * dbl_hours_worked;

                // Reference structure's items
                name_hours_worked.hours_worked = dbl_hours_worked;
                name_hours_worked.first_name = txtFirstName.Text;
                name_hours_worked.last_name = txtSurname.Text;
                name_hours_worked.weekly_pay = dbl_weekly_pay;

                // Add complete structure items to structure's list
                employees.Add(name_hours_worked);

                // I don't know why the structure items aren't being added to the list
                txtFirstName.Clear();
                txtSurname.Clear();
                txtSurname.Clear();
                txtHoursWorked.Clear();
            }
        }
    }
}
