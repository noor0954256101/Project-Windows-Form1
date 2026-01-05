namespace Project_Programming_WindowsForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        Color normalColor = Color.FromArgb(60, 65, 110);
        Color activeColor = Color.FromArgb(37, 201, 210);
        private void SetActiveButton(Button activeBtn)
        {
            foreach (Control ctrl in PanelMenu.Controls)
            {
                if (ctrl is Button btn)
                {
                    btn.BackColor = normalColor;
                    btn.ForeColor = Color.White;
                }
            }

            activeBtn.BackColor = activeColor;
            activeBtn.ForeColor = Color.Black;
        }

        private void addUserControl(UserControl userControl)
        {

            panelContent.Controls.Clear(); // مسح الصفحة القديمة
            panelContent.Controls.Add(userControl); // إضافة الصفحة الجديدة
            userControl.BringToFront();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(25, 28, 36);
            BtnHome.BackColor = Color.FromArgb(60, 65, 110);
            BtnAddCar.BackColor = Color.FromArgb(60, 65, 110);
            BtnPrice.BackColor = Color.FromArgb(60, 65, 110);
            BtnSearch.BackColor = Color.FromArgb(60, 65, 110);
            PanelMenu.BackColor = Color.FromArgb(28, 35, 65);
        }

        private void BtnHome_Click(object sender, EventArgs e)
        {
            SetActiveButton(BtnHome);
            HomePage uc = new HomePage();
            addUserControl(uc);
        }

        private void BtnAddCar_Click(object sender, EventArgs e)
        {
            SetActiveButton(BtnAddCar);
            AddCarPage uc = new AddCarPage();
            addUserControl(uc);
        }

        private void BtnPrice_Click(object sender, EventArgs e)
        {
            SetActiveButton(BtnPrice);
            PriceCarPage uc = new PriceCarPage();
            addUserControl(uc);
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            SetActiveButton(BtnSearch);
            SearchPage uc = new SearchPage();
            addUserControl(uc);
        }

        private void panelContent_Paint(object sender, PaintEventArgs e)
        {
            panelContent.BackColor = Color.FromArgb(40, 44, 52);
        }
    }
}
