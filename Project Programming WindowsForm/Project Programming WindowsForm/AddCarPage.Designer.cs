namespace Project_Programming_WindowsForm
{
    partial class AddCarPage
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
            label1 = new Label();
            panel1 = new Panel();
            TBPrice = new TextBox();
            TBCarModel = new TextBox();
            BtnSave = new Button();
            BtnDelete = new Button();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            CBYear = new ComboBox();
            CBColor = new ComboBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cairo", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(768, 24);
            label1.Name = "label1";
            label1.Size = new Size(313, 64);
            label1.TabIndex = 0;
            label1.Text = "أضافة سيارة جديدة";
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(TBPrice);
            panel1.Controls.Add(TBCarModel);
            panel1.Controls.Add(BtnSave);
            panel1.Controls.Add(BtnDelete);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(CBYear);
            panel1.Controls.Add(CBColor);
            panel1.ForeColor = Color.White;
            panel1.Location = new Point(50, 100);
            panel1.Name = "panel1";
            panel1.Size = new Size(981, 460);
            panel1.TabIndex = 1;
            // 
            // TBPrice
            // 
            TBPrice.ForeColor = Color.White;
            TBPrice.Location = new Point(425, 282);
            TBPrice.Name = "TBPrice";
            TBPrice.Size = new Size(374, 27);
            TBPrice.TabIndex = 9;
            // 
            // TBCarModel
            // 
            TBCarModel.BackColor = Color.White;
            TBCarModel.ForeColor = Color.White;
            TBCarModel.Location = new Point(425, 24);
            TBCarModel.Name = "TBCarModel";
            TBCarModel.Size = new Size(374, 27);
            TBCarModel.TabIndex = 8;
            TBCarModel.TextChanged += TBCarModel_TextChanged;
            // 
            // BtnSave
            // 
            BtnSave.BackColor = Color.FromArgb(46, 125, 50);
            BtnSave.FlatAppearance.BorderSize = 0;
            BtnSave.FlatStyle = FlatStyle.Flat;
            BtnSave.Font = new Font("Cairo", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnSave.ForeColor = Color.White;
            BtnSave.Location = new Point(425, 407);
            BtnSave.Name = "BtnSave";
            BtnSave.Size = new Size(125, 39);
            BtnSave.TabIndex = 7;
            BtnSave.Text = "حفظ البيانات";
            BtnSave.TextAlign = ContentAlignment.TopCenter;
            BtnSave.UseVisualStyleBackColor = false;
            // 
            // BtnDelete
            // 
            BtnDelete.BackColor = Color.FromArgb(211, 47, 47);
            BtnDelete.FlatAppearance.BorderSize = 0;
            BtnDelete.FlatStyle = FlatStyle.Flat;
            BtnDelete.Font = new Font("Cairo", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnDelete.ForeColor = Color.White;
            BtnDelete.Location = new Point(602, 407);
            BtnDelete.Name = "BtnDelete";
            BtnDelete.RightToLeft = RightToLeft.Yes;
            BtnDelete.Size = new Size(125, 39);
            BtnDelete.TabIndex = 6;
            BtnDelete.Text = "مسح الحقول";
            BtnDelete.TextAlign = ContentAlignment.TopCenter;
            BtnDelete.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Cairo", 13.7999992F, FontStyle.Bold);
            label5.ForeColor = Color.White;
            label5.Location = new Point(814, 24);
            label5.Name = "label5";
            label5.Size = new Size(133, 43);
            label5.TabIndex = 5;
            label5.Text = "نوع السيارة";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Cairo", 13.7999992F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(814, 112);
            label4.Name = "label4";
            label4.Size = new Size(164, 43);
            label4.TabIndex = 4;
            label4.Text = "موديل السيارة";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Cairo", 13.7999992F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(814, 202);
            label3.Name = "label3";
            label3.Size = new Size(136, 43);
            label3.TabIndex = 3;
            label3.Text = "لون السيارة";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cairo", 13.7999992F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(814, 282);
            label2.Name = "label2";
            label2.Size = new Size(143, 43);
            label2.TabIndex = 2;
            label2.Text = "سعر السيارة";
            // 
            // CBYear
            // 
            CBYear.FlatStyle = FlatStyle.Flat;
            CBYear.FormattingEnabled = true;
            CBYear.Location = new Point(425, 112);
            CBYear.Name = "CBYear";
            CBYear.Size = new Size(374, 28);
            CBYear.TabIndex = 1;
            // 
            // CBColor
            // 
            CBColor.FlatStyle = FlatStyle.Flat;
            CBColor.FormattingEnabled = true;
            CBColor.Location = new Point(425, 202);
            CBColor.Name = "CBColor";
            CBColor.Size = new Size(374, 28);
            CBColor.TabIndex = 0;
            // 
            // AddCarPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Controls.Add(label1);
            Name = "AddCarPage";
            Size = new Size(1081, 606);
            Load += AddCarPage_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Button BtnSave;
        private Button BtnDelete;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;

        private ComboBox CBColor;
        private ComboBox CBYear;

        private TextBox TBCarModel;
        private TextBox TBPrice;


    }
}
