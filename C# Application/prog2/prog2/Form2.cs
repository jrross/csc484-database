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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'views.comp' table. You can move, or remove it, as needed.
            this.compTableAdapter.Fill(this.views.comp);

        }

        private void button1_Click(object sender, EventArgs e)
        {
           this.Close();
        }

        private void compDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            object temp = compDataGridView.CurrentRow.Cells[0].Value;   //get the value of the currently selected company
            Form7 frmC = new Form7();
            try
            {
                frmC.textBox1.Text = temp.ToString();    //save value into company
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
