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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //exit
        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //Company
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Form2 frmC = new Form2();

                frmC.ShowDialog(this);
                frmC.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in Main Form - " + ex.Message);
            }

        }
        //Equipment
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Form3 frmC = new Form3();

                frmC.ShowDialog(this);
                frmC.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in Main Form - " + ex.Message);
            }
        }
        //Engineers
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                Form4 frmC = new Form4();

                frmC.ShowDialog(this);
                frmC.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in Main Form - " + ex.Message);
            }
        }
        //Faults
        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                Form5 frmC = new Form5();

                frmC.ShowDialog(this);
                frmC.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in Main Form - " + ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
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
    }
}
