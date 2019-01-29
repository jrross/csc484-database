using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prog2
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.Engineer' table. You can move, or remove it, as needed.
            this.engineerTableAdapter.Fill(this.dataSet1.Engineer);

        }

        private void engineerBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.engineerBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void engineerDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form8 frmC = new Form8();
            try
            {
                frmC.ShowDialog(this);
                frmC.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in Main Form - " + ex.Message);
            }
        }
    }
}
