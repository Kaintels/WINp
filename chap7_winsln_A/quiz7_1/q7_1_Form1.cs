using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quiz7_1
{
    public partial class q7_1_Form1 : Form
    {
        public q7_1_Form1()
        {
            InitializeComponent();
            MessageBox.Show("Form Start!");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Button Start!");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
