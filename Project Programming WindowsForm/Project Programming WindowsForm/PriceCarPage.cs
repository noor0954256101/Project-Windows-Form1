using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Project_Programming_WindowsForm
{
    public partial class PriceCarPage : UserControl
    {
        public PriceCarPage()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void PriceCarPage_Load(object sender, EventArgs e)
        {
            dataGridView1.BackgroundColor = Color.FromArgb(45, 45, 45);
            panel1.BackColor = Color.FromArgb(45, 45, 45);

            dataGridView1.EnableHeadersVisualStyles = false;

            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(37, 201, 210); 
            dataGridView1.RowsDefaultCellStyle.BackColor = Color.FromArgb(45, 45, 45);
            dataGridView1.RowsDefaultCellStyle.ForeColor = Color.White; 
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(60, 60, 60); 
            dataGridView1.RowHeadersDefaultCellStyle.BackColor = Color.FromArgb(37, 201, 210);
            dataGridView1.RowHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(37, 201, 210); 

        }
    }
}
