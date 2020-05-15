using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EmployeeLibrary;

namespace EmployeeInformation
{
    public partial class Form1 : Form
    {
        private EmployeeHandler employeeHandler = new EmployeeHandler();
        private static int MIN_AGE = 18;
        private static int MAX_AGE = 60;
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// To be called on when user clicks OK. Attempts to add a new employee given the values entered in the boxes.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOK_Click(object sender, EventArgs e)
        {
            multiListBox.Visible = false;

            if (!radMale.Checked && !radFemale.Checked)
            {
                MessageBox.Show("Please enter gender.");
                return;
            }

            //Calculates age based on given date of birth
            DateTime zeroTime = new DateTime(1, 1, 1);
            TimeSpan age = DateTime.Now - dtpDOB.Value;
            int years = (zeroTime + age).Year - 1;
            //If the calculated age don't correlate with input age, an error must be thrown
            if(years != (int)numAge.Value)
            {
                //Employees must be between 18 and 60 years old, according to client specifications
                if (years >= MIN_AGE && years <= MAX_AGE)
                {
                    DialogResult answer = MessageBox.Show(
                        $"Liar. According to date of birth, {txtName.Text} isn't {numAge.Value} years, " +
                        $"{(radMale.Checked? "he" : "she")} is {years} years old.\n" +
                        $"Change age to {years}?\n" +
                        $"(If no, employee will NOT be added)", 
                        "Age error", MessageBoxButtons.YesNo);
                    if (answer == DialogResult.Yes)
                    {
                        numAge.Value = years;
                    }
                    else
                    {
                        return;
                    }
                }
                else
                {
                    MessageBox.Show(
                        $"Liar. according to date of birth, {txtName.Text} is {years} years old. Please try again.\n" +
                        $"Please note that employees must be between {MIN_AGE} and {MAX_AGE}.");
                    return;
                }
            }
            //Adds all checked hobbies to the hobby-list
            List<Hobby> hob = new List<Hobby>();
            foreach (Hobby h in chkLstHobbies.CheckedItems)
            {
                hob.Add(h);
            }
            //if the new employee is null, just return
            EmployeeInfo emp = CreateEmployee();
            if (emp == null)
            {
                return;
            }

            //Tries to add the new employee. If that fails, Prompt the user that the given employeenumber already exists
            if (!employeeHandler.AddEmployee(emp))
            {
                MessageBox.Show($"Employee-number {mskTxtEmpNo.Text} already exists.");
                return;
            }
            txtDetails.Text = emp.ToLongString();
            
        }

        /// <summary>
        /// To be called on when user clicks Reset. Clears input data
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReset_Click(object sender, EventArgs e)
        {
            multiListBox.Visible = false;
            mskTxtEmpNo.Text = "";
            txtName.Text = "";
            txtAdress.Text = "";
            cmbCity.SelectedIndex = -1;
            lstState.SelectedIndex = -1;
            dtpDOB.Value = DateTime.Now;
            numAge.Value = numAge.Minimum;
            radMale.Checked = false;
            radFemale.Checked = false;
            for (int i = 0; i < chkLstHobbies.Items.Count; i++)
            {
                chkLstHobbies.SetItemChecked(i, false);
            }
            txtDetails.Text = "";
            mskTxtEmpNo.Focus();

        }

        /// <summary>
        /// To be called when user clicks Exit. Prompts user if they want to quit
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExit_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure you want to Exit?", "Closing Application", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                return;
            }
            this.Close();
        }

        /// <summary>
        /// To be called whjen user clicks search. Searches for employees with given employeeNumber, or, if that is empty, by the Name parameter.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSearch_Click(object sender, EventArgs e)
        {
            multiListBox.Visible = false;
            //First, check if a number is input in the empNumber-field
            if  (mskTxtEmpNo.Text != "")
            {
                if (employeeHandler.EmployeeNumberIsValid(mskTxtEmpNo.Text))
                {
                    EmployeeInfo employee = employeeHandler.SearchByEmployeeNumber(mskTxtEmpNo.Text);
                    if(employee != null)
                    {
                        txtDetails.Text = employee.ToLongString();
                    }
                    else
                    {
                        MessageBox.Show($"No employee found with employee number {mskTxtEmpNo.Text}.");
                    }
                }
                else
                {
                    MessageBox.Show($"{mskTxtEmpNo.Text} is not a valid employee number.\nIt needs to be 4 digits(0000-9999).");
                }
            }
            //Else, check if a name is input
            else if  (txtName.Text != "")
            {
                List<EmployeeInfo> employeesFound = employeeHandler.SearchByName(txtName.Text);
                if (employeesFound.Count > 1)
                {
                    multiListBox.Visible = true;
                    multiListBox.Items.Clear();
                    foreach (EmployeeInfo emp in employeesFound)
                    {
                        multiListBox.Items.Add(emp);
                    }
                    multiListBox.SelectedIndex = 0;
                }
                else if (employeesFound.Count == 1)
                {
                    txtDetails.Text = employeesFound[0].ToLongString();
                }
                else
                {
                    MessageBox.Show($"Searching with the name-term \"{txtName.Text}\" returns 0 results.");
                }
            }
            //If neither name nor empnum is input, tell user how to search
            else
            {
                MessageBox.Show("Search function only works if you enter either a employee number, or a name");
            }


        }

        /// <summary>
        /// To be called when user clicks Update. Updates the given employee with the new given data (Employee is found using employeeNumber)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //If the employee created is null, just return
            EmployeeInfo newEmployeeInfo = CreateEmployee();
            if(newEmployeeInfo == null)
            {
                return;
            }

            bool updateSuccess = employeeHandler.UpdateEmployee(newEmployeeInfo);
            if (updateSuccess)
            {
                MessageBox.Show($"Employee number {newEmployeeInfo.EmpNum} is updated with the new information.", "Update success", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show($"No employee found with employee number {newEmployeeInfo.EmpNum}", "Something went wrong", MessageBoxButtons.OK);
            }
        }

        /// <summary>
        /// To be called on when the index is changed in the multiListBox, to update the txtDetails-textbox with appropriate data
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void multiListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            EmployeeInfo tempEmp = (EmployeeInfo)multiListBox.SelectedItem;
            txtDetails.Text = tempEmp.ToLongString();
        }

        /// <summary>
        /// Takes the data input by user and tries to create an employeeInfo with the given data.
        /// </summary>
        /// <returns></returns>
        private EmployeeInfo CreateEmployee()
        {
            List<Hobby> hob = new List<Hobby>();
            foreach (Hobby h in chkLstHobbies.CheckedItems)
            {
                hob.Add(h);
            }
            if (cmbCity.SelectedItem == null)
            {
                cmbCity.SelectedItem = City.Nagpur;
            }
            EmployeeInfo newEmployeeInfo = new EmployeeInfo();
            try
            {
                newEmployeeInfo.EmpNum = mskTxtEmpNo.Text;
                newEmployeeInfo.Name = txtName.Text;
                newEmployeeInfo.Adress = txtAdress.Text;
                newEmployeeInfo.City = (City)cmbCity.SelectedItem;
                newEmployeeInfo.State = (State)lstState.SelectedItem;
                newEmployeeInfo.DateOfBirth = dtpDOB.Value;
                newEmployeeInfo.Age = (int)numAge.Value;
                newEmployeeInfo.Gender = radMale.Checked ? Gender.Male : Gender.Female;
                newEmployeeInfo.Hobbies = hob;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
            return newEmployeeInfo;
        }

        /// <summary>
        /// To be called on when user clicks the Add test Data-button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addTestDataButton_Click(object sender, EventArgs e)
        {
            addTestDataButton.Enabled = false;
            employeeHandler.AddManualTestEmployees();
        }

        /// <summary>
        /// If user enters something that does not correlate with the given enum, set it to the first one
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbCity_Leave(object sender, EventArgs e)
        {
            if(cmbCity.SelectedItem == null)
            {
                cmbCity.SelectedItem = City.Nagpur;
            }
        }
    }
}
