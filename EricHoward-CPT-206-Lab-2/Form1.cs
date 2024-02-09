//CPT-206
//Eric Howard
//Lab-2 

using EricHoward_CPT_206_Lab_2.StateInfoDataSetTableAdapters;
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
using System.Diagnostics.Eventing.Reader;

namespace EricHoward_CPT_206_Lab_2
{
 
    public partial class stateForm : Form
    {
        public void updateComboBox()
        {
            // create instance of SatesTableAdapter 
            StatesTableAdapter adapter = new StatesTableAdapter();

            //use the GetData method from StatesTableAdapter 
            DataTable states = adapter.GetData();
            //combobox uses states DataTable as a source 
            stateComboBox.DataSource = states;
            //from that source only display the StateName column
            stateComboBox.DisplayMember = "StateName";
        }
        
        public stateForm()
        {
            InitializeComponent();
            

        }

        private void statesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.statesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.stateInfoDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'stateInfoDataSet.States' table. You can move, or remove it, as needed.
            this.statesTableAdapter.Fill(this.stateInfoDataSet.States);
            updateComboBox();
        }

        private void stateSearchBtn_Click(object sender, EventArgs e)
        {
            //crate new form 
            searchForm searchFormNew = new searchForm();

            //store comboBox into selectedState variable on searchForm
            searchFormNew.selectedState = stateComboBox.Text;

            //Display searchForm 
            searchFormNew.ShowDialog();
        }

        private void insertDataBtn_Click(object sender, EventArgs e)
        {
            //create new form
            insertDataForm insertDataFormNew = new insertDataForm();
            //store what button user slects 
            DialogResult response = insertDataFormNew.ShowDialog();
            // run this if user hits submit on other form
            if (response == DialogResult.OK)
            {
                MessageBox.Show("Data has been entered");
                this.statesTableAdapter.Insert(insertDataFormNew.stateName, insertDataFormNew.population, insertDataFormNew.flagDesciption, insertDataFormNew.stateFlower, insertDataFormNew.stateBird, insertDataFormNew.stateColors, insertDataFormNew.city1, insertDataFormNew.city2, insertDataFormNew.city3, insertDataFormNew.stateCapitol, insertDataFormNew.medianIncome, insertDataFormNew.computerJobs);
                 this.statesTableAdapter.Fill(this.stateInfoDataSet.States);
                updateComboBox();
            }
            else
            {
                MessageBox.Show("No data has been entered" );
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            //Run delete query 
            this.statesTableAdapter.DeleteRow(stateComboBox.Text);
            //update table
            this.statesTableAdapter.Fill(this.stateInfoDataSet.States);
            //run updateComboBox
            updateComboBox();
        }

        //declare toggle variable 
        bool toggleStateSort = true;
        private void sortStateNameBtn_Click(object sender, EventArgs e)
        {
            //Check toggle is true 
            if(toggleStateSort)
            {
                statesTableAdapter.OrderStatesDESC(stateInfoDataSet.States);
                toggleStateSort = false;
            }
            else
            {
                statesTableAdapter.OrderStatesASC(stateInfoDataSet.States);
                toggleStateSort = true;
            }
            
            

        }
        //declare toggle variable 
        bool togglePopSort = true;
        private void sortPopulationBtn_Click(object sender, EventArgs e)
        {
            //Check toggle is true 
            if (togglePopSort)
            {
                statesTableAdapter.OrderPopulationDESC(stateInfoDataSet.States);
                togglePopSort = false;
            }
            else
            {
                statesTableAdapter.OrderPopulationASC(stateInfoDataSet.States);
                togglePopSort = true;
            }

        }
        //declare toggle variable 
        bool toggleMedianSort = true;
        private void sortMedianIncome_Click(object sender, EventArgs e)
        {
            //Check toggle is true 
            if (toggleMedianSort)
            {
                statesTableAdapter.OrderMedianIncomeDESC(stateInfoDataSet.States);
                toggleMedianSort = false;
            }
            else
            {
                statesTableAdapter.OrderMedianIncomeASC(stateInfoDataSet.States);
                toggleMedianSort = true;
            }
        }

        private void editDataBtn_Click(object sender, EventArgs e)
        {
            //create DataRowView object
            DataRowView selectedRow = (DataRowView)stateComboBox.SelectedItem;
            // Pass the selected DataRow to editDataForm
            editDataForm editDataFromNew = new editDataForm();
            editDataFromNew.populateTextBoxes(selectedRow.Row);
            // store response 
            DialogResult response = editDataFromNew.ShowDialog();
            if (response == DialogResult.OK)
            {
                MessageBox.Show("Data has been changed");
                this.statesTableAdapter.UpdateStates(editDataFromNew.stateName, editDataFromNew.population, editDataFromNew.flagDesciption, editDataFromNew.stateFlower, editDataFromNew.stateBird, editDataFromNew.stateColors, editDataFromNew.city1, editDataFromNew.city2, editDataFromNew.city3, editDataFromNew.stateCapitol, editDataFromNew.medianIncome, editDataFromNew.computerJobs, stateComboBox.Text);
                this.statesTableAdapter.Fill(this.stateInfoDataSet.States);
                updateComboBox();
            }
            else
            {
                MessageBox.Show("No data has been changed");

            }
        }

        private void filterSearchBtn_Click(object sender, EventArgs e)
        {
            //Check if state name is in comboBox 
            if(filterComboBox.Text == "StateName")
            {
                statesTableAdapter.FIlterByState(this.stateInfoDataSet.States, filterTextBox.Text);
            }
            //Check if Population name is in comboBox 
            else if (filterComboBox.Text == "Population")
            {
                //set temp number 
                int tempNum ;
                //check to make sure texbox is a number 
                if (int.TryParse(filterTextBox.Text, out tempNum))
                {
                    statesTableAdapter.FilterByPopulation(this.stateInfoDataSet.States, tempNum);
                }
                else
                {
                    MessageBox.Show(new ErrorMessage().inValidData("Population"));
                }
            }
            //Check if FlagDescription name is in comboBox 
            else if (filterComboBox.Text == "FlagDescription")
            {
                statesTableAdapter.FilterByFlagDescription(this.stateInfoDataSet.States, filterTextBox.Text);
            }
            //Check if StateFlower name is in comboBox 
            else if (filterComboBox.Text == "StateFlower")
            {
                statesTableAdapter.FilterByStateFlower (this.stateInfoDataSet.States, filterTextBox.Text);
            }
            //Check if StateBird name is in comboBox 
            else if (filterComboBox.Text == "StateBird")
            {
                statesTableAdapter.FilterByStateBird(this.stateInfoDataSet.States, filterTextBox.Text);
            }
            //Check if StateColors name is in comboBox 
            else if (filterComboBox.Text == "StateColors")
            {
                statesTableAdapter.FilterByStateColors(this.stateInfoDataSet.States, filterTextBox.Text);
            }
            //Check if City1 name is in comboBox 
            else if (filterComboBox.Text == "City1")
            {
                statesTableAdapter.FilterByCity1(this.stateInfoDataSet.States, filterTextBox.Text);
            }
            //Check if City2 name is in comboBox 
            else if (filterComboBox.Text == "City2")
            {
                statesTableAdapter.FilterByCity2(this.stateInfoDataSet.States, filterTextBox.Text);
            }
            //Check if City3 name is in comboBox 
            else if (filterComboBox.Text == "City3")
            {
                statesTableAdapter.FilterByCity3(this.stateInfoDataSet.States, filterTextBox.Text);
            }
            //Check if StateCapitol name is in comboBox 
            else if (filterComboBox.Text == "StateCapitol")
            {
                statesTableAdapter.FilterByStateCapitol(this.stateInfoDataSet.States, filterTextBox.Text);
            }
            //Check if MedianIncome name is in comboBox 
            else if (filterComboBox.Text == "MedianIncome")
            {
                //set temp number
                int tempNum ;
                //check to make sure texbox is a number 
                if (int.TryParse(filterTextBox.Text, out tempNum))
                {
                    statesTableAdapter.FilterByMedianIncome(this.stateInfoDataSet.States, tempNum);
                }
                else
                {
                    MessageBox.Show(new ErrorMessage().inValidData("Population"));
                }
            }
            //Check if ComputerJobs name is in comboBox 
            else if (filterComboBox.Text == "ComputerJobs")
            {
                //set temp number 
                int tempNum ;
                //check to make sure texbox is a number 
                if (int.TryParse(filterTextBox.Text, out tempNum))
                {
                    statesTableAdapter.FilterByComputerJobs(this.stateInfoDataSet.States, tempNum);
                }
                else
                {
                    MessageBox.Show(new ErrorMessage().inValidData("Population"));
                }
            }
            //if user did not select a Column 
            else
            {
                MessageBox.Show(new ErrorMessage().noEntry());
            }


        }

        private void filterResetBtn_Click(object sender, EventArgs e)
        {
            //reset table 
            this.statesTableAdapter.Fill(this.stateInfoDataSet.States);
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            //close form 
            this.Close();
        }
    }
}
