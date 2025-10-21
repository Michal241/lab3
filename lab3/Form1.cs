namespace lab3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void clearBtn_Click(object sender, EventArgs e)
        {
            storageTbox.Text = "";
            liquidTbox.Text = "";
            countTbox.Text = "";
            storageCbox.SelectedIndex = default;
            liquidCbox.SelectedIndex = default;
            res2Tbox.Text = "";
        }

        private void calcBtn_Click(object sender, EventArgs e)
        {
            float a = 5;
            float b = 6;
            float c = 1;
        }
    }
}
