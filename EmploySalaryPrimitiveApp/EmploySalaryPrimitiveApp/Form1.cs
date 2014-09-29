using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmploySalaryPrimitiveApp
{
    public partial class EmpleySalaryApp : Form
    {
        public EmpleySalaryApp()
        {
            InitializeComponent();
        }

        private string id;
        private string name;
        private double salary;
        private void saveButton_Click(object sender, EventArgs e)
        {
            id = idTextBox.Text;
            name = nameTextBox.Text;
            salary = Convert.ToDouble(salaryTextBox.Text);

            string mesg = "id" + " " + id + "\nname" + " " + name + "\nsalary" + salary;

            MessageBox.Show(mesg);

        }

        private void retriveButton_Click(object sender, EventArgs e)
        {
            idTextBox.Text = id;
            nameTextBox.Text = name;
            salaryTextBox.Text = salary.ToString();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {

            idTextBox.Text = string.Empty;
            nameTextBox.Text = string.Empty;
            salaryTextBox.Text = string.Empty;
        }
    }
}
