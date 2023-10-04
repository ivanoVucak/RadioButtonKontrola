using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RadioButtonKontrola
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonRezerviraj_Click(object sender, EventArgs e)
        {
            if (radioButtonAutobus.Checked == true) { 
                textBox1.Text = "Odabrani prijevoz je: " + radioButtonAutobus.Text;
            }
            if (radioButtonAvion.Checked == true)
            {
                textBox1.Text = "Odabrani prijevoz je: " + radioButtonAvion.Text;
            }
            if (radioButtonVlastiti.Checked == true)
            {
                textBox1.Text = "Odabrani prijevoz je: " + radioButtonVlastiti.Text;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
