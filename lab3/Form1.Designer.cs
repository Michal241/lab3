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
            label6 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            SuspendLayout();
            // 
            // clearBtn
            // 
            clearBtn.BackColor = Color.FromArgb(248, 247, 255);
            clearBtn.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            clearBtn.Location = new Point(436, 224);
            clearBtn.Name = "clearBtn";
            clearBtn.Size = new Size(112, 34);
            clearBtn.TabIndex = 1;
            clearBtn.Text = "Wyczyść";
            clearBtn.UseVisualStyleBackColor = false;
            clearBtn.Click += clearBtn_Click;
            // 
            // calcBtn
            // 
            calcBtn.BackColor = Color.FromArgb(248, 247, 255);
            calcBtn.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            calcBtn.Location = new Point(309, 224);
            calcBtn.Name = "calcBtn";
            calcBtn.Size = new Size(112, 34);
            calcBtn.TabIndex = 2;
            calcBtn.Text = "Oblicz";
            calcBtn.UseVisualStyleBackColor = false;
            calcBtn.Click += calcBtn_Click;
            // 
            // storageTbox
            // 
            storageTbox.Location = new Point(220, 99);
            storageTbox.Name = "storageTbox";
            storageTbox.Size = new Size(100, 23);
            storageTbox.TabIndex = 3;
            storageTbox.TextChanged += storageTbox_TextChanged;
            // 
            // liquidTbox
            // 
            liquidTbox.Location = new Point(220, 128);
            liquidTbox.Name = "liquidTbox";
            liquidTbox.Size = new Size(100, 23);
            liquidTbox.TabIndex = 4;
            liquidTbox.TextChanged += liquidTbox_TextChanged_1;
            // 
            // countTbox
            // 
            countTbox.Location = new Point(220, 157);
            countTbox.Name = "countTbox";
            countTbox.Size = new Size(100, 23);
            countTbox.TabIndex = 5;
            countTbox.TextChanged += countTbox_TextChanged;
            // 
            // res1Box
            // 
            res1Box.Location = new Point(683, 101);
            res1Box.Name = "res1Box";
            res1Box.Size = new Size(100, 23);
            res1Box.TabIndex = 6;
            // 
            // res2Box
            // 
            res2Box.Location = new Point(683, 128);
            res2Box.Name = "res2Box";
            res2Box.Size = new Size(100, 23);
            res2Box.TabIndex = 7;
            res2Box.TextChanged += res2Box_TextChanged;
            // 
            // storageCbox
            // 
            storageCbox.AutoCompleteCustomSource.AddRange(new string[] { "Kieliszek (50ml)", "Szklanka (250ml)", "Butelka (500 ml)", "Dzbanek (800ml)" });
            storageCbox.FormattingEnabled = true;
            storageCbox.Location = new Point(337, 99);
            storageCbox.Name = "storageCbox";
            storageCbox.Size = new Size(121, 23);
            storageCbox.TabIndex = 8;
            storageCbox.Text = "-Wybierz-";
            storageCbox.SelectedIndexChanged += storageCbox_SelectedIndexChanged;
            // 
            // liquidCbox
            // 
            liquidCbox.FormattingEnabled = true;
            liquidCbox.Location = new Point(337, 128);
            liquidCbox.Name = "liquidCbox";
            liquidCbox.Size = new Size(121, 23);
            liquidCbox.TabIndex = 9;
            liquidCbox.Text = "-Wybierz-";
            liquidCbox.SelectedIndexChanged += liquidCbox_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label1.Location = new Point(34, 104);
            label1.Name = "label1";
            label1.Size = new Size(179, 14);
            label1.TabIndex = 10;
            label1.Text = "Podaj pojemność naczynia (ml):";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label2.Location = new Point(31, 132);
            label2.Name = "label2";
            label2.Size = new Size(182, 14);
            label2.TabIndex = 11;
            label2.Text = "Podaj zawartość substancji (%):";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label3.Location = new Point(57, 160);
            label3.Name = "label3";
            label3.Size = new Size(156, 14);
            label3.TabIndex = 12;
            label3.Text = "Podaj liczbę naczyń (sztuk):";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label4.Location = new Point(540, 104);
            label4.Name = "label4";
            label4.Size = new Size(137, 14);
            label4.TabIndex = 13;
            label4.Text = "Łączna objętość (w ml):";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label5.Location = new Point(480, 132);
            label5.Name = "label5";
            label5.Size = new Size(197, 14);
            label5.TabIndex = 14;
            label5.Text = "Objętość czystej substancji (w ml):";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BorderStyle = BorderStyle.FixedSingle;
            label6.Font = new Font("Constantia", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label6.ForeColor = Color.FromArgb(93, 46, 70);
            label6.Location = new Point(102, 21);
            label6.Name = "label6";
            label6.Size = new Size(605, 47);
            label6.TabIndex = 15;
            label6.Text = "《 KAKLULATOR PROCENTOWY 》";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(181, 141, 182);
            panel1.Location = new Point(1, 336);
            panel1.Name = "panel1";
            panel1.Size = new Size(826, 18);
            panel1.TabIndex = 16;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(181, 141, 182);
            panel2.Location = new Point(1, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(826, 18);
            panel2.TabIndex = 17;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(181, 141, 182);
            panel3.Location = new Point(804, 12);
            panel3.Name = "panel3";
            panel3.Size = new Size(23, 329);
            panel3.TabIndex = 18;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(181, 141, 182);
            panel4.Location = new Point(1, 12);
            panel4.Name = "panel4";
            panel4.Size = new Size(23, 329);
            panel4.TabIndex = 19;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(232, 214, 203);
            ClientSize = new Size(826, 353);
            Controls.Add(label6);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
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
            Text = "Kalulator procentowy";
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
        private Label label6;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
    }
}
