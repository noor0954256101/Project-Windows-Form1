using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Project_Programming_WindowsForm
{
    public partial class SearchPage : UserControl
    {
        public SearchPage()
        {
            InitializeComponent();
        }

        private void SearchPage_Load(object sender, EventArgs e)
        {
            TBKeyWords.BackColor = Color.FromArgb(60, 63, 70);
            CBYear.BackColor = Color.FromArgb(60, 63, 70);
            TBPrice.BackColor = Color.FromArgb(60, 63, 70);
            panel1.BackColor = Color.FromArgb(55, 59, 67);
            dataGridView1.BackgroundColor = Color.FromArgb(45, 45, 45);

            dataGridView1.EnableHeadersVisualStyles = false;

            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(37, 201, 210);
            dataGridView1.RowsDefaultCellStyle.BackColor = Color.FromArgb(45, 45, 45);
            dataGridView1.RowsDefaultCellStyle.ForeColor = Color.White;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(60, 60, 60);
            dataGridView1.RowHeadersDefaultCellStyle.BackColor = Color.FromArgb(37, 201, 210);
            dataGridView1.RowHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(37, 201, 210);
            BtnSearch.BackColor = Color.FromArgb(37, 201, 250);
        }
    }
}
