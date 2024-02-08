using System;
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

        

        public DisplayIndvStateInfo(string stateList, DisplayIndvStateInfo db)
        {
            InitializeComponent();

            
            
           
        }

        

        

        private void DisplayIndvStateInfo_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'stateDBDataSet.States' table. You can move, or remove it, as needed.
            this.statesTableAdapter.Fill(this.stateDBDataSet.States);

            
        }

        

        private void statesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.statesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.stateDBDataSet);

        }
    }
}
