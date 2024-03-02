using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.Linq;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Noemi_Angeles_CPT_206_LAB_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void statesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.statesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.stateDBDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'stateDBDataSet.States' table. You can move, or remove it, as needed.
            this.statesTableAdapter.Fill(this.stateDBDataSet.States);
           
        StateDBDataContext db = new StateDBDataContext();

            
            var stateList = from s in db.States
                            select s;




            foreach (var state in stateList)
            {
                stateComboBox1.Items.Add(state.State1);
            }



        }




        private void stateComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            


        }

        private void getResultsTextBox_Click(object sender, EventArgs e)
        {
            
        }

        private void alphaButton_Click(object sender, EventArgs e)
        {
            StateDBDataContext db = new StateDBDataContext();

            
            var sortedStates = from state in db.States
                               orderby state.State1
                               select state;

            
            statesDataGridView.DataSource = sortedStates.ToList();
        }

        private void populationASCButton_Click(object sender, EventArgs e)
        {
            StateDBDataContext db = new StateDBDataContext();

           
            var sortedStates = from state in db.States
                               orderby state.Population
                               select state; 
                  

           
            statesDataGridView.DataSource = sortedStates.ToList();

        }

        private void birdsButton_Click(object sender, EventArgs e)
        {
            StateDBDataContext db = new StateDBDataContext();

            var sort = from state in db.States.OrderBy((state) => state.State_Bird)
                       select state;
                                                
                      

            statesDataGridView.DataSource = sort;

            
        }

        private void flowersButton_Click(object sender, EventArgs e)
        {
            StateDBDataContext db = new StateDBDataContext();

            var sort = from state in db.States.OrderBy((state) => state.State_Flower)
                       select state;



            statesDataGridView.DataSource = sort;
        }

       

        private void incomeButton_Click(object sender, EventArgs e)
        {
            StateDBDataContext db = new StateDBDataContext();

            var sort = from state in db.States.OrderBy((state) => state.Median_Income)
                       select state;



            statesDataGridView.DataSource = sort;
        }

        private void percentButton_Click(object sender, EventArgs e)
        {
            StateDBDataContext db = new StateDBDataContext();

            var sort = from state in db.States.OrderBy((state) => state.Percentage_of_Computer_Related_Jobs)
                       select state;



            statesDataGridView.DataSource = sort;
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            StateDBDataContext db = new StateDBDataContext();

            // Retrieve values from text boxes
            
            string name =nameTextBox.Text;
            string capital = capitaltextBox3.Text;
            string bird = birdtextBox5.Text;
            string flower = flowertextBox4.Text;


            // build  query based on values in text boxes
            var query = db.States.AsQueryable();

            if (!string.IsNullOrEmpty(name))
            {
                query = query.Where(state => state.State1.Contains(name));
            }

            if (!string.IsNullOrEmpty(capital))
            {
                query = query.Where(state => state.State_Capitol.Contains(capital));
            }

           

            if (!string.IsNullOrEmpty(bird))
            {
                query = query.Where(state => state.State_Bird.Contains(bird));
            }

            if (!string.IsNullOrEmpty(flower))
            {
                query = query.Where(state => state.State_Flower.Contains(flower));
            }

            // Execute the query
            var results = query.ToList();

            // Set the DataSource of DataGridView
            statesDataGridView.DataSource = results;
        }
        private void ResetDataGrid()
        {
            //reload the datagrid with original data
            this.statesTableAdapter.Fill(this.stateDBDataSet.States);
            //set datatable as the datasource  for the data grid view
            statesDataGridView.DataSource = this.stateDBDataSet.States;
        }
        private void clearbutton1_Click(object sender, EventArgs e)
        {
            ResetDataGrid();
            nameTextBox.Clear();
             capitaltextBox3.Clear();
           birdtextBox5.Clear();
             flowertextBox4.Clear();
        }
    }
}
