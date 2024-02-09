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

namespace EricHoward_CPT_206_Lab_2
{
    public partial class searchForm : Form
    {
        public string selectedState { get; set; }
        public searchForm()
        {
            InitializeComponent();

        }
        
        private void searchForm_Load(object sender, EventArgs e)
        {
                //display search results of selected state 
                statesTableAdapter.SearchState(stateInfoDataSet.States, selectedState);


             
        }

        private void statesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.statesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.stateInfoDataSet);

        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            //close this form
            this.Close();
        }
    }
}
