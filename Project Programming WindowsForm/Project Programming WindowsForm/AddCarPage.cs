using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Project_Programming_WindowsForm
{
    public partial class AddCarPage : UserControl
    {
        public AddCarPage()
        {
            InitializeComponent();
        }

        private void TBCarModel_TextChanged(object sender, EventArgs e)
        {
        }

        private void AddCarPage_Load(object sender, EventArgs e)
        {
            TBCarModel.BackColor = Color.FromArgb(60, 63, 70);
            CBColor.BackColor = Color.FromArgb(60, 63, 70);
            CBYear.BackColor = Color.FromArgb(60, 63, 70);
            TBPrice.BackColor = Color.FromArgb(60, 63, 70);
            panel1.BackColor = Color.FromArgb(55, 59, 67);
        }
    }
}
