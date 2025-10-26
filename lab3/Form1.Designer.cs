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
            clearBtn = new Button();
            calcBtn = new Button();
            storageTbox = new TextBox();
            liquidTbox = new TextBox();
            countTbox = new TextBox();
            res1Box = new TextBox();
            res2Box = new TextBox();
            storageCbox = new ComboBox();
            liquidCbox = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // clearBtn
            // 
            clearBtn.Location = new Point(429, 150);
            clearBtn.Name = "clearBtn";
            clearBtn.Size = new Size(75, 23);
            clearBtn.TabIndex = 1;
            clearBtn.Text = "Wyczyść";
            clearBtn.UseVisualStyleBackColor = true;
            clearBtn.Click += clearBtn_Click;
            // 
            // calcBtn
            // 
            calcBtn.Location = new Point(348, 151);
            calcBtn.Name = "calcBtn";
            calcBtn.Size = new Size(75, 23);
            calcBtn.TabIndex = 2;
            calcBtn.Text = "Oblicz";
            calcBtn.UseVisualStyleBackColor = true;
            calcBtn.Click += calcBtn_Click;
            // 
            // storageTbox
            // 
            storageTbox.Location = new Point(185, 49);
            storageTbox.Name = "storageTbox";
            storageTbox.Size = new Size(100, 23);
            storageTbox.TabIndex = 3;
            // 
            // liquidTbox
            // 
            liquidTbox.Location = new Point(185, 78);
            liquidTbox.Name = "liquidTbox";
            liquidTbox.Size = new Size(100, 23);
            liquidTbox.TabIndex = 4;
            // 
            // countTbox
            // 
            countTbox.Location = new Point(185, 107);
            countTbox.Name = "countTbox";
            countTbox.Size = new Size(100, 23);
            countTbox.TabIndex = 5;
            // 
            // res1Box
            // 
            res1Box.Location = new Point(636, 51);
            res1Box.Name = "res1Box";
            res1Box.Size = new Size(100, 23);
            res1Box.TabIndex = 6;
            // 
            // res2Box
            // 
            res2Box.Location = new Point(636, 78);
            res2Box.Name = "res2Box";
            res2Box.Size = new Size(100, 23);
            res2Box.TabIndex = 7;
            res2Box.TextChanged += res2Box_TextChanged;
            // 
            // storageCbox
            // 
            storageCbox.AutoCompleteCustomSource.AddRange(new string[] { "Kieliszek (50ml)", "Szklanka (250ml)", "Butelka (500 ml)", "Dzbanek (800ml)" });
            storageCbox.FormattingEnabled = true;
            storageCbox.Location = new Point(302, 49);
            storageCbox.Name = "storageCbox";
            storageCbox.Size = new Size(121, 23);
            storageCbox.TabIndex = 8;
            // 
            // liquidCbox
            // 
            liquidCbox.FormattingEnabled = true;
            liquidCbox.Location = new Point(302, 78);
            liquidCbox.Name = "liquidCbox";
            liquidCbox.Size = new Size(121, 23);
            liquidCbox.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 54);
            label1.Name = "label1";
            label1.Size = new Size(173, 15);
            label1.TabIndex = 10;
            label1.Text = "Podaj pojemność naczynia (ml)";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 81);
            label2.Name = "label2";
            label2.Size = new Size(169, 15);
            label2.TabIndex = 11;
            label2.Text = "Podaj zawartość substancji (%)";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 110);
            label3.Name = "label3";
            label3.Size = new Size(148, 15);
            label3.TabIndex = 12;
            label3.Text = "Podaj liczbę naczyń (sztuk)";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(536, 54);
            label4.Name = "label4";
            label4.Size = new Size(94, 15);
            label4.TabIndex = 13;
            label4.Text = "Łączna objętość:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(479, 81);
            label5.Name = "label5";
            label5.Size = new Size(151, 15);
            label5.TabIndex = 14;
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
            Controls.Add(res2Box);
            Controls.Add(res1Box);
            Controls.Add(countTbox);
            Controls.Add(liquidTbox);
            Controls.Add(storageTbox);
            Controls.Add(calcBtn);
            Controls.Add(clearBtn);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button clearBtn;
        private Button calcBtn;
        private TextBox storageTbox;
        private TextBox liquidTbox;
        private TextBox countTbox;
        private TextBox res1Box;
        private TextBox res2Box;
        private ComboBox storageCbox;
        private ComboBox liquidCbox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}
