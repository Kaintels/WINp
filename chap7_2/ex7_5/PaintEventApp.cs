using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex7_5
{
    public partial class PaintEventApp : Form
    {
        public PaintEventApp()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Invalidate();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Random r = new Random();
            Color c = Color.FromArgb(r.Next(256), r.Next(256), r.Next(256));
            g.FillRectangle(new SolidBrush(c), e.ClipRectangle);
        }
    }
}
