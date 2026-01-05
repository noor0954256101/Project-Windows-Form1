namespace Project_Programming_WindowsForm
{
    partial class SearchPage
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            BtnSearch = new Button();
            CBYear = new ComboBox();
            TBKeyWords = new TextBox();
            TBPrice = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(BtnSearch);
            panel1.Controls.Add(CBYear);
            panel1.Controls.Add(TBKeyWords);
            panel1.Controls.Add(TBPrice);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(20, 72);
            panel1.Name = "panel1";
            panel1.Size = new Size(1040, 200);
            panel1.TabIndex = 0;
            // 
            // BtnSearch
            // 
            BtnSearch.FlatAppearance.BorderSize = 0;
            BtnSearch.FlatStyle = FlatStyle.Flat;
            BtnSearch.Font = new Font("Cairo", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnSearch.ForeColor = Color.White;
            BtnSearch.Location = new Point(345, 146);
            BtnSearch.Name = "BtnSearch";
            BtnSearch.Size = new Size(350, 45);
            BtnSearch.TabIndex = 6;
            BtnSearch.Text = "بحث";
            BtnSearch.UseVisualStyleBackColor = true;
            // 
            // CBYear
            // 
            CBYear.FlatStyle = FlatStyle.Flat;
            CBYear.FormattingEnabled = true;
            CBYear.Location = new Point(345, 52);
            CBYear.Name = "CBYear";
            CBYear.Size = new Size(350, 28);
            CBYear.TabIndex = 5;
            // 
            // TBKeyWords
            // 
            TBKeyWords.ForeColor = Color.White;
            TBKeyWords.Location = new Point(345, 3);
            TBKeyWords.Name = "TBKeyWords";
            TBKeyWords.Size = new Size(350, 27);
            TBKeyWords.TabIndex = 4;
            // 
            // TBPrice
            // 
            TBPrice.ForeColor = Color.White;
            TBPrice.Location = new Point(345, 102);
            TBPrice.Name = "TBPrice";
            TBPrice.Size = new Size(350, 27);
            TBPrice.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Cairo", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(837, 52);
            label4.Name = "label4";
            label4.RightToLeft = RightToLeft.Yes;
            label4.Size = new Size(88, 34);
            label4.TabIndex = 2;
            label4.Text = "الموديل :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Cairo", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(837, 102);
            label3.Name = "label3";
            label3.RightToLeft = RightToLeft.Yes;
            label3.Size = new Size(74, 34);
            label3.TabIndex = 1;
            label3.Text = " السعر :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cairo", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(837, 3);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.Yes;
            label2.Size = new Size(114, 34);
            label2.TabIndex = 0;
            label2.Text = "كلمة البحث :";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ControlDarkDark;
            dataGridView1.BorderStyle = BorderStyle.Fixed3D;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5 });
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.Location = new Point(20, 287);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RightToLeft = RightToLeft.Yes;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1040, 292);
            dataGridView1.TabIndex = 1;
            // 
            // Column1
            // 
            Column1.HeaderText = "الرقم ";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 200;
            // 
            // Column2
            // 
            Column2.HeaderText = "الموديل";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 190;
            // 
            // Column3
            // 
            Column3.HeaderText = "السنة";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 190;
            // 
            // Column4
            // 
            Column4.HeaderText = "اللون";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Width = 190;
            // 
            // Column5
            // 
            Column5.HeaderText = "السعر ";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.Width = 214;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.System;
            label1.Font = new Font("Cairo", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(838, 0);
            label1.Name = "label1";
            label1.Size = new Size(243, 64);
            label1.TabIndex = 3;
            label1.Text = "بحث عن سيارة ";
            // 
            // SearchPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Name = "SearchPage";
            Size = new Size(1081, 606);
            Load += SearchPage_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private DataGridView dataGridView1;
        private Label label4;
        private Label label3;
        private Label label2;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private Label label1;
        private Button BtnSearch;
        private ComboBox CBYear;
        private ComboBox comboBox1;
        private TextBox TBKeyWords;
        private TextBox TBPrice;
    }
}
