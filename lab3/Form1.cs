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
            storageTbox.Text = "2";
            liquidTbox.Text = "2";
            countTbox.Text = "";
            storageCbox.SelectedIndex = default;
            liquidCbox.SelectedIndex = default;
            res2Tbox.Text = "";
        }
    }
}
