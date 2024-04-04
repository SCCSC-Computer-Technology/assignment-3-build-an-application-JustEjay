using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StateClassLibary;

namespace EricHoward_CPT_206_Lab_2
{
    public partial class insertDataForm : Form
    {
        //declare all variables 
        public string stateName { get; set; }
        public int population { get; set; }
        public string flagDesciption { get; set; }
        public string stateFlower { get; set; }
        public string stateBird { get; set; }
        public string stateColors { get; set; }
        public string city1 { get; set; }
        public string city2 { get; set; }
        public string city3 { get; set; }
        public string stateCapitol { get; set; }
        public int medianIncome { get; set; }
        public double computerJobs { get; set; }


        public insertDataForm()
        {
            InitializeComponent();
            
            
        }



        private void submitBtn_Click(object sender, EventArgs e)
        {
            bool isValid = true; 
            //Assign variables 
            stateName = stateNameTextBox.Text;
            flagDesciption = flagDesciptionTextBox.Text;
            stateFlower = stateFlowerTextBox.Text;
            stateBird = stateBirdTextBox.Text;
            stateColors = stateColorsTextBox.Text;
            city1 = city1TextBox.Text;
            city2 = city2TextBox.Text;
            city3 = city3TextBox.Text;
            stateCapitol = stateCapitolTextBox.Text;
            //temp var to check population input
            int pop;
            //make sure int data type was entered 
            if (int.TryParse(populationTextBox.Text, out pop))
            {
                population = pop;

            }
            else
            {
                //if it can't be parsed run this 
                MessageBox.Show(new ErrorMessage().inValidData("Population"));
                isValid =false;
            }

            //temp variable 
            int med;
            if (int.TryParse(medianIncomeTextBox.Text, out med))
            {
                medianIncome = med;
            }
            else
            {
                //if it can't be parsed run this 
                MessageBox.Show(new ErrorMessage().inValidData("Median Income"));
                isValid =false;
            }
            //temp variable 
            double jobs; 

            if(double.TryParse(computerJobsTextBox.Text, out jobs))
            {
                computerJobs = jobs;
                
            }
            else
            {
                //if it can't be parsed run this 
                MessageBox.Show(new ErrorMessage().inValidData("Computer Jobs "));
                isValid=false;
            }
            if (isValid)
            {
                DialogResult = DialogResult.OK;
                
            }

            
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
           //Close this form
            this.Close();

        }



        private void stateNameTextBox_KeyPress(object sender, KeyPressEventArgs e)

            //Make sure only letters are entered 
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void stateCapitolTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Make sure only letters are entered 
            {
                if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
                {
                    e.Handled = true; 
                }
            }
        }

        private void stateFlowerTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Make sure only letters are entered 
            {
                if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
                {
                    e.Handled = true; 
                }
            }
        }

        private void stateBirdTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Make sure only letters are entered 
            {
                if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
        }

        private void stateColorsTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Make sure only letters are entered 
            {
                if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
                {
                    e.Handled = true; 
                }
            }
        }

        private void flagDesciptionTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Make sure only letters are entered 
            {
                if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
                {
                    e.Handled = true; 
                }
            }
        }

        private void city1TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Make sure only letters are entered 
            {
                if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
                {
                    e.Handled = true; 
                }
            }
        }

        private void city2TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Make sure only letters are entered 
            {
                if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
        }

        private void city3TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Make sure only letters are entered 
            {
                if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
                {
                    e.Handled = true; 
                }
            }
        }

        private void populationTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {

            //Make sure only numbers are entered 
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b' && e.KeyChar != 127 && e.KeyChar != 0x1b)
            {
               
                e.Handled = true;
            }
        }

        private void medianIncomeTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Make sure only numbers are entered 

            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b' && e.KeyChar != 127 && e.KeyChar != 0x1b)
            {
                
                e.Handled = true;
            }
        }

        private void computerJobsTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Make sure only numbers are entered 
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b' && e.KeyChar != 127 && e.KeyChar != 0x1b)
            {

                e.Handled = true;
            }
        }


    }
}
