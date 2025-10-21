namespace lab3
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
            calcBtn = new Button();
            clearBtn = new Button();
            storageTbox = new TextBox();
            liquidTbox = new TextBox();
            countTbox = new TextBox();
            resTbox = new TextBox();
            res2Tbox = new TextBox();
            storageCbox = new ComboBox();
            liquidCbox = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // calcBtn
            // 
            calcBtn.Location = new Point(313, 190);
            calcBtn.Name = "calcBtn";
            calcBtn.Size = new Size(75, 23);
            calcBtn.TabIndex = 0;
            calcBtn.Text = "Oblicz";
            calcBtn.UseVisualStyleBackColor = true;
            calcBtn.Click += calcBtn_Click;
            // 
            // clearBtn
            // 
            clearBtn.Location = new Point(410, 190);
            clearBtn.Name = "clearBtn";
            clearBtn.Size = new Size(75, 23);
            clearBtn.TabIndex = 1;
            clearBtn.Text = "Wyczyść";
            clearBtn.UseVisualStyleBackColor = true;
            clearBtn.Click += clearBtn_Click;
            // 
            // storageTbox
            // 
            storageTbox.Location = new Point(207, 63);
            storageTbox.Name = "storageTbox";
            storageTbox.Size = new Size(100, 23);
            storageTbox.TabIndex = 2;
            // 
            // liquidTbox
            // 
            liquidTbox.Location = new Point(207, 92);
            liquidTbox.Name = "liquidTbox";
            liquidTbox.Size = new Size(100, 23);
            liquidTbox.TabIndex = 3;
            // 
            // countTbox
            // 
            countTbox.Location = new Point(207, 121);
            countTbox.Name = "countTbox";
            countTbox.Size = new Size(100, 23);
            countTbox.TabIndex = 4;
            // 
            // resTbox
            // 
            resTbox.Location = new Point(642, 63);
            resTbox.Name = "resTbox";
            resTbox.ReadOnly = true;
            resTbox.Size = new Size(100, 23);
            resTbox.TabIndex = 5;
            // 
            // res2Tbox
            // 
            res2Tbox.Location = new Point(642, 92);
            res2Tbox.Name = "res2Tbox";
            res2Tbox.ReadOnly = true;
            res2Tbox.Size = new Size(100, 23);
            res2Tbox.TabIndex = 6;
            // 
            // storageCbox
            // 
            storageCbox.FormattingEnabled = true;
            storageCbox.Items.AddRange(new object[] { "Kieliszek (50ml)", "Szklanka (250ml)", "Butelka (500 ml)", "Dzbanek (800ml)" });
            storageCbox.Location = new Point(313, 63);
            storageCbox.Name = "storageCbox";
            storageCbox.Size = new Size(121, 23);
            storageCbox.TabIndex = 7;
            // 
            // liquidCbox
            // 
            liquidCbox.FormattingEnabled = true;
            liquidCbox.Items.AddRange(new object[] { "Wódka (40%)", "Spirytus (96%)", "Płyn Lugola (5%)", "Ocet (10%)" });
            liquidCbox.Location = new Point(313, 92);
            liquidCbox.Name = "liquidCbox";
            liquidCbox.Size = new Size(121, 23);
            liquidCbox.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 63);
            label1.Name = "label1";
            label1.Size = new Size(173, 15);
            label1.TabIndex = 9;
            label1.Text = "Podaj pojemność naczynia (ml)";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 92);
            label2.Name = "label2";
            label2.Size = new Size(169, 15);
            label2.TabIndex = 10;
            label2.Text = "Podaj zawartość substancji (%)";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(28, 124);
            label3.Name = "label3";
            label3.Size = new Size(148, 15);
            label3.TabIndex = 11;
            label3.Text = "Podaj liczbę naczyń (sztuk)";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(542, 63);
            label4.Name = "label4";
            label4.Size = new Size(94, 15);
            label4.TabIndex = 12;
            label4.Text = "Łączna objętość:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(485, 96);
            label5.Name = "label5";
            label5.Size = new Size(151, 15);
            label5.TabIndex = 13;
            label5.Text = "Objętość czystej substancji:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(liquidCbox);
            Controls.Add(storageCbox);
            Controls.Add(res2Tbox);
            Controls.Add(resTbox);
            Controls.Add(countTbox);
            Controls.Add(liquidTbox);
            Controls.Add(storageTbox);
            Controls.Add(clearBtn);
            Controls.Add(calcBtn);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button calcBtn;
        private Button clearBtn;
        private TextBox storageTbox;
        private TextBox liquidTbox;
        private TextBox countTbox;
        private TextBox resTbox;
        private TextBox res2Tbox;
        private ComboBox storageCbox;
        private ComboBox liquidCbox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}
