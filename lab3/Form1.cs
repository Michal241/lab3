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
                {"Wódka 40%", 40},
                {"Spirytus 96%", 96},
                {"P³yn lugola 5%", 5},
                {"Ocet 10%", 10}
            };
            storageCbox.Items.AddRange(TypoweNaczynia.Keys.ToArray());
            liquidCbox.Items.AddRange(TypoweRoztwory.Keys.ToArray());
            res1Box.Enabled = false;
            res2Box.Enabled = false;
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
            double storageValue = 0;
            double liquidPercentage = 0;
            int count = 1;

            
            if (!string.IsNullOrEmpty(countTbox.Text))
                count = int.Parse(countTbox.Text);

          
            if (storageCbox.SelectedItem != null)
                storageValue = TypoweNaczynia[storageCbox.SelectedItem.ToString()];
            else if (!string.IsNullOrEmpty(storageTbox.Text))
                storageValue = double.Parse(storageTbox.Text);

            
            if (liquidCbox.SelectedItem != null)
                liquidPercentage = TypoweRoztwory[liquidCbox.SelectedItem.ToString()];
            else if (!string.IsNullOrEmpty(liquidTbox.Text))
                liquidPercentage = double.Parse(liquidTbox.Text);

            
            double totalVolume = storageValue * count;
            double percentageVolume = totalVolume * liquidPercentage / 100;

            res1Box.Text = totalVolume.ToString();
            res2Box.Text = percentageVolume.ToString();
        }

        private void storageTbox_TextChanged(object sender, EventArgs e)
        {
            storageCbox.SelectedItem = null;
            liquidCbox.SelectedItem = null;
        }


        private void countTbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void liquidTbox_TextChanged_1(object sender, EventArgs e)
        {
            storageCbox.SelectedItem = null;
            liquidCbox.SelectedItem = null;
        }

        private void storageCbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            storageTbox.Clear();
            liquidTbox.Clear();
            countTbox.Clear();
        }

        private void liquidCbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            storageTbox.Clear();
            liquidTbox.Clear();
            countTbox.Clear();
        }
    }
}
