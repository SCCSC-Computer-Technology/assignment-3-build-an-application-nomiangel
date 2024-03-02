using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Noemi_Angeles_CPT_206_LAB_2
{
    public partial class DisplayIndvStateInfo : Form
    {

        private readonly string selectedState;
        //ngl vs gave me this as a potential fix and my code ran and worked after so i just went with it lol
        public DisplayIndvStateInfo(string selectedState)
        {
            InitializeComponent();

            this.selectedState = selectedState;
            
           
        }

        

        

        private void DisplayIndvStateInfo_Load(object sender, EventArgs e)
        {
            //create instance for the db
            StateDBDataContext db = new StateDBDataContext();
            
          

            //query state id
           var stateInfo = from state in db.States
                        where state.State1.Contains(selectedState)
                        select state;
           
            //assig results to textboxes, i was gonna do one by one..but it was taking to long so i tried something new and it worked so yay
            foreach ( var state in stateInfo)
            {
                stateTextBox.Text = state.State1;
                populationTextBox.Text = state.Population.ToString();
                state_Flag_DescriptionTextBox.Text = state.State_Flag_Description;
                state_FlowerTextBox.Text = state.State_Flower;
                state_BirdTextBox.Text = state.State_Bird;
                state_ColorsTextBox.Text = state.State_Colors;
                three_Largest_CitiesTextBox.Text = state.Three_Largest_Cities;
                state_CapitolTextBox.Text = state.State_Capitol;
                median_IncomeTextBox.Text = state.Median_Income;
                percentage_of_Computer_Related_JobsTextBox.Text = state.Percentage_of_Computer_Related_Jobs;
            }
        }

        

        private void statesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.statesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.stateDBDataSet);

        }
    }
}
