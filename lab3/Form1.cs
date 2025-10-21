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
<<<<<<< HEAD
            double pojemnoscNaczynia = double.Parse(storageTbox.Text);
            double zawartoscSubstancji = double.Parse(liquidTbox.Text);
            double iloscNaczyn = double.Parse(countTbox.Text);
            double lacznaObjetosc = double.Parse(resTbox.Text);
            double objetoscCzystejSubstancji = double.Parse(res2Tbox.Text);



=======
            float a = 5;
            float b = 6;
            float c = 1;
>>>>>>> 7cc836587039c9d0176a020ffb5b77794b6544b5
        }
    }
}
