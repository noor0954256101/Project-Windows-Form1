using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Project_Programming_WindowsForm
{
    public partial class HomePage : UserControl
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel1.BackColor = Color.FromArgb(156, 39, 176);

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
            panel4.BackColor = Color.FromArgb(255, 112, 67);

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {
            panel7.BackColor = Color.FromArgb(33, 150, 243);

        }

        private void HomePage_Load(object sender, EventArgs e)
        {
            panel10.BackColor = Color.FromArgb(55, 59, 67);
            panel11.BackColor = Color.FromArgb(55, 59, 67);
            panel12.BackColor = Color.FromArgb(55, 59, 67);
            panel13.BackColor = Color.FromArgb(55, 59, 67);
            panel14.BackColor = Color.FromArgb(55, 59, 67);

        }
    }
}
