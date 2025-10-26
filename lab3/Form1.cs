namespace lab3
{
    public partial class Form1 : Form
    {
        private Dictionary<string, double> TypoweNaczynia;
        private Dictionary<string, double> TypoweRoztwory;
        public Form1()
        {
            InitializeComponent();
            TypoweNaczynia = new Dictionary<string, double>()
            {
                {"Kieliszek (50 ml)", 50},
                {"Szklanka (250 ml)", 250},
                {"Butelka (500 ml)", 500},
                {"Dzbanek (800 ml)", 800}
            };

            TypoweRoztwory = new Dictionary<string, double>()
            {
                {"Wóka 40%", 40},
                {"Spirytus 96%", 96},
                {"P³yn lugola 5%", 5},
                {"Ocet 10%", 10}
            };
            storageCbox.Items.AddRange(TypoweNaczynia.Keys.ToArray());
            liquidCbox.Items.AddRange(TypoweRoztwory.Keys.ToArray());
        }

        private void res2Box_TextChanged(object sender, EventArgs e)
        {

        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            storageTbox.Clear();
            liquidTbox.Clear();
            countTbox.Clear();
            storageCbox.SelectedItem = null;
            liquidCbox.SelectedItem = null;
            res1Box.Clear();
            res2Box.Clear();
            res1Box.Enabled = false;
            res2Box.Enabled = false;
        }

        private void calcBtn_Click(object sender, EventArgs e)
        {
            double totalVolume = double.Parse(storageTbox.Text) * double.Parse(countTbox.Text);
            res1Box.Text = totalVolume.ToString();
            double percentageVolume = totalVolume * double.Parse(liquidTbox.Text)/100;
            res2Box.Text = percentageVolume.ToString();
        }
    }
}
