using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMI_Calculator
{
    public partial class frmBMICalc : Form
    {
        public frmBMICalc()
        {
            InitializeComponent();
        }

        private void frmBMICalc_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtInches.Text)) //Error checking for blank Inches field
            {
                txtInches.Text = "0";
            }
            if (string.IsNullOrWhiteSpace(txtFeet.Text)) //Error checking for blank Feet field
            {
                MessageBox.Show("You have to be a bit taller to use this form!");
                txtFeet.Focus();
                return;
            }
        
            short feet = Convert.ToInt16(txtFeet.Text);   //assigning value types to the text boxes in the form
            short inches = Convert.ToInt16(txtInches.Text); //trying to select the types that use the least memory space
            int totalInches = feet * 12 + inches;
            float weight = Convert.ToSingle(txtPounds.Text);
            string bmiDesc = "";        

            double bmi = 703 * weight / Convert.ToUInt16(Math.Pow(totalInches, 2)); //BMI formula
            bmi = Math.Round(bmi, 1); //rounding to 1 decimal

            // the next set of IFs account for wrong values

            if (feet < 3) 
            {
                MessageBox.Show("You have to be a bit taller to use this form!");
                txtFeet.Focus();
                return;
            }
            else if (feet > 8)
            {
                MessageBox.Show("Are you really that tall? If so, exit this application and call Guinness World Records immediately!");
                txtFeet.Focus();
                return;
            }

            if (inches < 0)
            {
                MessageBox.Show("Please enter a valid number into the 'inches' field." + "\n" + "Valid value: 0 to 11");
                txtInches.Clear();
                txtInches.Focus();
                return;
            }
            else if (inches > 11)
            {
                MessageBox.Show("Please enter a valid number into the 'inches' field." + "\n" + "Valid value: 0 to 11");
                txtInches.Clear();
                txtInches.Focus();
                return;
            }

            // BMI scale for Females is different from Males, and the next set of IFs account for that

            if (rbtnFemale.Checked == true) 
            {
                if (bmi < 19.1)
                {
                    bmiDesc = "Underweight";
                }
                else if (bmi >= 19.1 && bmi < 25.8)
                {
                    bmiDesc = "Normal";
                }
                else if (bmi >= 25.8 && bmi < 27.3)
                {
                    bmiDesc = "Marginally Overweight";
                }
                else if (bmi >= 27.3 && bmi <= 32.3)
                {
                    bmiDesc = "Overweight";
                }
                else bmiDesc = "Obese";
            }

            if (rbtnMale.Checked == true)
            {
                if (bmi < 20.7)
                {
                    bmiDesc = "Underweight";
                }
                else if (bmi >= 20.7 && bmi < 26.4)
                {
                    bmiDesc = "Normal";
                }
                else if (bmi >= 26.4 && bmi < 27.8)
                {
                    bmiDesc = "Marginally Overweight";
                }
                else if (bmi >= 27.8 && bmi <= 31.1)
                {
                    bmiDesc = "Overweight";
                }
                else bmiDesc = "Obese";
            }

            txtBMI.Text = bmi.ToString(); // output is displayed
            txtBMIDes.Text = bmiDesc;
        }


    }
}
