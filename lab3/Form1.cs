using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

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
                {"W�dka 40%", 40},
                {"Spirytus 96%", 96},
                {"P�yn Lugola 5%", 5},
                {"Ocet 10%", 10}
            };

            storageCbox.Items.AddRange(TypoweNaczynia.Keys.ToArray());
            liquidCbox.Items.AddRange(TypoweRoztwory.Keys.ToArray());

            storageCbox.DropDownStyle = ComboBoxStyle.DropDownList;
            liquidCbox.DropDownStyle = ComboBoxStyle.DropDownList;

            res1Box.Enabled = false;
            res2Box.Enabled = false;

            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;

        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            storageTbox.Clear();
            liquidTbox.Clear();
            countTbox.Clear();

            // tymczasowo od��czamy eventy �eby unikn�� niechcianych wywo�a�
            storageCbox.SelectedIndexChanged -= storageCbox_SelectedIndexChanged;
            liquidCbox.SelectedIndexChanged -= liquidCbox_SelectedIndexChanged;

            storageCbox.SelectedItem = null;
            liquidCbox.SelectedItem = null;

            storageCbox.SelectedIndexChanged += storageCbox_SelectedIndexChanged;
            liquidCbox.SelectedIndexChanged += liquidCbox_SelectedIndexChanged;

            res1Box.Clear();
            res2Box.Clear();
        }

        private void calcBtn_Click(object sender, EventArgs e)
        {
            try
            {
                double storageValue = 0;
                double liquidPercentage = 0;
                int count = 1;

                if (!string.IsNullOrEmpty(countTbox.Text))
                {
                    if (!int.TryParse(countTbox.Text, out count) || count <= 0)
                    {
                        MessageBox.Show("Podaj poprawn� dodatni� liczb� sztuk!");
                        return;
                    }
                }

                if (storageCbox.SelectedItem != null)
                {
                    storageValue = TypoweNaczynia[storageCbox.SelectedItem.ToString()];
                }
                else if (!string.IsNullOrEmpty(storageTbox.Text))
                {
                    if (!double.TryParse(storageTbox.Text.Replace(',', '.'), System.Globalization.NumberStyles.Any,
                        System.Globalization.CultureInfo.InvariantCulture, out storageValue) || storageValue <= 0)
                    {
                        MessageBox.Show("Podaj poprawn� dodatni� obj�to�� naczynia!");
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Wprowad� obj�to�� naczynia lub wybierz z listy!");
                    return;
                }

                if (liquidCbox.SelectedItem != null)
                {
                    liquidPercentage = TypoweRoztwory[liquidCbox.SelectedItem.ToString()];
                }
                else if (!string.IsNullOrEmpty(liquidTbox.Text))
                {
                    if (!double.TryParse(liquidTbox.Text.Replace(',', '.'), System.Globalization.NumberStyles.Any,
                        System.Globalization.CultureInfo.InvariantCulture, out liquidPercentage)
                        || liquidPercentage <= 0 || liquidPercentage > 100)
                    {
                        MessageBox.Show("Podaj poprawny procent roztworu (0�100)!");
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Wprowad� procent roztworu lub wybierz z listy!");
                    return;
                }

                double totalVolume = storageValue * count;
                double percentageVolume = totalVolume * liquidPercentage / 100;

                res1Box.Text = totalVolume.ToString("F2");
                res2Box.Text = percentageVolume.ToString("F2");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Wyst�pi� b��d: " + ex.Message);
            }
        }

      

        private void storageTbox_TextChanged(object sender, EventArgs e)
        {
           
            if (storageCbox.SelectedItem != null)
            {
                storageCbox.SelectedIndexChanged -= storageCbox_SelectedIndexChanged;
                storageCbox.SelectedItem = null;
                storageCbox.SelectedIndexChanged += storageCbox_SelectedIndexChanged;
            }
        }

        private void liquidTbox_TextChanged(object sender, EventArgs e)
        {
      
            if (liquidCbox.SelectedItem != null)
            {
                liquidCbox.SelectedIndexChanged -= liquidCbox_SelectedIndexChanged;
                liquidCbox.SelectedItem = null;
                liquidCbox.SelectedIndexChanged += liquidCbox_SelectedIndexChanged;
            }
        }

        private void storageCbox_SelectedIndexChanged(object sender, EventArgs e)
        {

            storageTbox.TextChanged -= storageTbox_TextChanged;
            storageTbox.Clear();
            storageTbox.TextChanged += storageTbox_TextChanged;
        }

        private void liquidCbox_SelectedIndexChanged(object sender, EventArgs e)
        {

            liquidTbox.TextChanged -= liquidTbox_TextChanged;
            liquidTbox.Clear();
            liquidTbox.TextChanged += liquidTbox_TextChanged;
        }
    }
}
