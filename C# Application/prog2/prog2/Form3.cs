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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.Equipment' table. You can move, or remove it, as needed.
            this.equipmentTableAdapter.Fill(this.dataSet1.Equipment);

        }

        private void equipmentBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.equipmentBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Form6 frmC = new Form6();

                frmC.ShowDialog(this);
                frmC.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in Main Form - " + ex.Message);
            }
        }

        private void equipmentDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
