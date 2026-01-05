namespace Project_Programming_WindowsForm
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            PanelMenu = new Panel();
            BtnAddCar = new Button();
            BtnPrice = new Button();
            BtnSearch = new Button();
            BtnHome = new Button();
            panel1 = new Panel();
            label1 = new Label();
            panelContent = new Panel();
            PanelMenu.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // PanelMenu
            // 
            PanelMenu.Controls.Add(BtnAddCar);
            PanelMenu.Controls.Add(BtnPrice);
            PanelMenu.Controls.Add(BtnSearch);
            PanelMenu.Controls.Add(BtnHome);
            PanelMenu.Dock = DockStyle.Right;
            PanelMenu.Location = new Point(1082, 0);
            PanelMenu.Name = "PanelMenu";
            PanelMenu.Size = new Size(250, 653);
            PanelMenu.TabIndex = 0;
            // 
            // BtnAddCar
            // 
            BtnAddCar.FlatAppearance.BorderSize = 0;
            BtnAddCar.FlatStyle = FlatStyle.Flat;
            BtnAddCar.Font = new Font("Cairo", 12F, FontStyle.Bold);
            BtnAddCar.ForeColor = Color.White;
            BtnAddCar.Location = new Point(0, 160);
            BtnAddCar.Name = "BtnAddCar";
            BtnAddCar.Size = new Size(250, 55);
            BtnAddCar.TabIndex = 3;
            BtnAddCar.Text = "اضافة سيارة";
            BtnAddCar.UseVisualStyleBackColor = true;
            BtnAddCar.Click += BtnAddCar_Click;
            // 
            // BtnPrice
            // 
            BtnPrice.FlatAppearance.BorderSize = 0;
            BtnPrice.FlatStyle = FlatStyle.Flat;
            BtnPrice.Font = new Font("Cairo", 12F, FontStyle.Bold);
            BtnPrice.ForeColor = Color.White;
            BtnPrice.Location = new Point(0, 265);
            BtnPrice.Name = "BtnPrice";
            BtnPrice.Size = new Size(250, 55);
            BtnPrice.TabIndex = 2;
            BtnPrice.Text = "أسعار السيارت";
            BtnPrice.UseVisualStyleBackColor = true;
            BtnPrice.Click += BtnPrice_Click;
            // 
            // BtnSearch
            // 
            BtnSearch.FlatAppearance.BorderSize = 0;
            BtnSearch.FlatStyle = FlatStyle.Flat;
            BtnSearch.Font = new Font("Cairo", 12F, FontStyle.Bold);
            BtnSearch.ForeColor = Color.White;
            BtnSearch.Location = new Point(0, 370);
            BtnSearch.Name = "BtnSearch";
            BtnSearch.Size = new Size(250, 55);
            BtnSearch.TabIndex = 1;
            BtnSearch.Text = "بحث";
            BtnSearch.UseVisualStyleBackColor = true;
            BtnSearch.Click += BtnSearch_Click;
            // 
            // BtnHome
            // 
            BtnHome.FlatAppearance.BorderSize = 0;
            BtnHome.FlatStyle = FlatStyle.Flat;
            BtnHome.Font = new Font("Cairo", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnHome.ForeColor = Color.White;
            BtnHome.Location = new Point(0, 55);
            BtnHome.Name = "BtnHome";
            BtnHome.Size = new Size(250, 55);
            BtnHome.TabIndex = 0;
            BtnHome.Text = "الرئيسية";
            BtnHome.UseVisualStyleBackColor = true;
            BtnHome.Click += BtnHome_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1081, 56);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cairo", 12F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(480, 7);
            label1.Name = "label1";
            label1.Size = new Size(281, 37);
            label1.TabIndex = 2;
            label1.Text = "مشروع ادارة معرض بيع سيارات";
            // 
            // panelContent
            // 
            panelContent.Location = new Point(0, 56);
            panelContent.Name = "panelContent";
            panelContent.Size = new Size(1081, 597);
            panelContent.TabIndex = 2;
            panelContent.Paint += panelContent_Paint;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1332, 653);
            Controls.Add(panelContent);
            Controls.Add(panel1);
            Controls.Add(PanelMenu);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            PanelMenu.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel PanelMenu;
        private Button BtnAddCar;
        private Button BtnPrice;
        private Button BtnSearch;
        private Button BtnHome;
        private Panel panel1;
        private Label label1;
        private Panel panelContent;
    }
}
