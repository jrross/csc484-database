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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.ElectFault' table. You can move, or remove it, as needed.
            this.electFaultTableAdapter.Fill(this.dataSet1.ElectFault);
            // TODO: This line of code loads data into the 'dataSet1.MechFault' table. You can move, or remove it, as needed.
            this.mechFaultTableAdapter.Fill(this.dataSet1.MechFault);
            // TODO: This line of code loads data into the 'dataSet1.Fault' table. You can move, or remove it, as needed.
            this.faultTableAdapter.Fill(this.dataSet1.Fault);
            // TODO: This line of code loads data into the 'dataSet1.EquipmentNumer' table. You can move, or remove it, as needed.
            this.equipmentNumerTableAdapter.Fill(this.dataSet1.EquipmentNumer);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.faultTableAdapter.Update(this.dataSet1.Fault);
            this.mechFaultTableAdapter.Update(this.dataSet1.MechFault);
            this.electFaultTableAdapter.Update(this.dataSet1.ElectFault);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void faultDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void electFaultDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void mechFaultDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
