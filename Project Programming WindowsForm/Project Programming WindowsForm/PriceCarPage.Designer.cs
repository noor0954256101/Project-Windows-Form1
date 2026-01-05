namespace Project_Programming_WindowsForm
{
    partial class PriceCarPage
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
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            label1 = new Label();
            BtnRefresh = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(dataGridView1);
            panel1.ForeColor = Color.White;
            panel1.Location = new Point(20, 110);
            panel1.Name = "panel1";
            panel1.Size = new Size(1041, 380);
            panel1.TabIndex = 3;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ControlDarkDark;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5 });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RightToLeft = RightToLeft.Yes;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1037, 376);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
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
            Column5.Width = 215;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cairo", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(811, 24);
            label1.Name = "label1";
            label1.Size = new Size(250, 64);
            label1.TabIndex = 2;
            label1.Text = "أسعار السيارات";
            label1.Click += label1_Click;
            // 
            // BtnRefresh
            // 
            BtnRefresh.BackColor = Color.FromArgb(244, 140, 36);
            BtnRefresh.FlatAppearance.BorderSize = 0;
            BtnRefresh.FlatStyle = FlatStyle.Flat;
            BtnRefresh.Font = new Font("Cairo", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnRefresh.ForeColor = Color.White;
            BtnRefresh.Location = new Point(440, 500);
            BtnRefresh.Name = "BtnRefresh";
            BtnRefresh.Size = new Size(200, 45);
            BtnRefresh.TabIndex = 4;
            BtnRefresh.Text = "تحديث الاسعار";
            BtnRefresh.UseVisualStyleBackColor = false;
            // 
            // PriceCarPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(BtnRefresh);
            Controls.Add(panel1);
            Controls.Add(label1);
            Name = "PriceCarPage";
            Size = new Size(1081, 606);
            Load += PriceCarPage_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private DataGridView dataGridView1;
        private Button BtnRefresh;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
    }
}
