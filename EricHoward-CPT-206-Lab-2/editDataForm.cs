using EricHoward_CPT_206_Lab_2.StateInfoDataSetTableAdapters;
using StateClassLibary;
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

namespace EricHoward_CPT_206_Lab_2
{
    public partial class editDataForm : Form
    {
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
        public decimal computerJobs { get; set; }
        public int id { get; set; }

        public DataRow selectedRow { get; set; }

        public void populateTextBoxes(DataRow row)
        {
            // Check if the row is not null and contains data
            if (row != null)
            {
                //assign to textbox 
                
                stateNameTextBox.Text = row["StateName"].ToString();
                stateCapitolTextBox.Text = row["StateCapitol"].ToString();
                medianIncomeTextBox.Text = row["MedianIncome"].ToString();
                populationTextBox.Text = row["Population"].ToString();
                stateFlowerTextBox.Text = row["StateFlower"].ToString() ;
                computerJobsTextBox.Text = row["ComputerJobs"].ToString();
                flagDesciptionTextBox.Text = row["FlagDescription"].ToString();
                stateBirdTextBox.Text = row["StateBird"].ToString();
                stateColorsTextBox.Text = row["StateColors"].ToString();
                city1TextBox.Text = row["city1"].ToString();
                city2TextBox.Text = row["city2"].ToString();
                city3TextBox.Text = row["city3"].ToString();
                id = (int)row["ID"];


            }
            else
            {
                ErrorMessage errorMessage = new ErrorMessage();
               MessageBox.Show( errorMessage.noRow());
            }
        }
        public editDataForm()
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
                //intinalize class and use method of said class 
                MessageBox.Show(new ErrorMessage().inValidData("Population"));
                isValid = false;
            }

            //temp variable 
            int med;
            if (int.TryParse(medianIncomeTextBox.Text, out med))
            {
                medianIncome = med;
            }
            else
            {
                MessageBox.Show(new ErrorMessage().inValidData("Median Income"));
                isValid = false;
            }
            //temp variable 
            decimal jobs;

            if (decimal.TryParse(computerJobsTextBox.Text, out jobs))
            {
                computerJobs = jobs;

            }
            else
            {

                MessageBox.Show(new ErrorMessage().inValidData("Computer Jobs "));
                isValid = false;
            }
            if (isValid)
            {
                DialogResult = DialogResult.OK;

            }

        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
