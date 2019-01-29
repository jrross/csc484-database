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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.Phone' table. You can move, or remove it, as needed.
            this.phoneTableAdapter.Fill(this.dataSet1.Phone);

        }

        private void phoneBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.phoneBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)  //add button
        {
            if (textBox2.Text == "")
                MessageBox.Show("Please enter a phone number");
            else
            {
                object[] array = new object[2];
                array[1] = textBox1.Text;
                array[0] = textBox2.Text;
                dataSet1.Tables["PHONE"].Rows.Add(array);
                this.phoneTableAdapter.Update(this.dataSet1.Phone);
            }
        }

        private void button3_Click(object sender, EventArgs e)  //save button
        {
            this.phoneTableAdapter.Update(this.dataSet1.Phone);
        }
    }
}
