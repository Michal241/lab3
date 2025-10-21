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
            double pojemnoscNaczynia, zawartoscSubstancji, iloscNaczyn, lacznaObjetosc, objetoscCzystejSubstancji;

            if (!double.TryParse(storageTbox.Text, out pojemnoscNaczynia))
            {
                MessageBox.Show("Pole 'Pojemnoœæ naczynia' zawiera nieprawid³ow¹ wartoœæ.\nProszê wpisz liczbê.",
                                "B³¹d wprowadzania danych", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!double.TryParse(liquidTbox.Text, out zawartoscSubstancji))
            {
                MessageBox.Show("Pole 'Zawartoœæ substancji' zawiera nieprawid³ow¹ wartoœæ.\nProszê wpisz liczbê.",
                                "B³¹d wprowadzania danych", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!double.TryParse(countTbox.Text, out iloscNaczyn))
            {
                MessageBox.Show("Pole 'Iloœæ naczyñ' zawiera nieprawid³ow¹ wartoœæ.\nProszê wpisz liczbê ca³kowit¹ lub dziesiêtn¹.",
                                "B³¹d wprowadzania danych", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!double.TryParse(resTbox.Text, out lacznaObjetosc))
            {
                MessageBox.Show("Pole '£¹czna objêtoœæ' zawiera nieprawid³ow¹ wartoœæ.\nProszê wpisz liczbê.",
                                "B³¹d wprowadzania danych", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!double.TryParse(res2Tbox.Text, out objetoscCzystejSubstancji))
            {
                MessageBox.Show("Pole 'Objêtoœæ czystej substancji' zawiera nieprawid³ow¹ wartoœæ.\nProszê wpisz liczbê.",
                                "B³¹d wprowadzania danych", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }
    }
}
