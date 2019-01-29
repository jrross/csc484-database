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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void repairsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.repairsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void Form6_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.Repairs' table. You can move, or remove it, as needed.
            this.repairsTableAdapter.Fill(this.dataSet1.Repairs);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
