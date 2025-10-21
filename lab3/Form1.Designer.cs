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
            SuspendLayout();
            // 
            // calcBtn
            // 
            calcBtn.Location = new Point(472, 137);
            calcBtn.Name = "calcBtn";
            calcBtn.Size = new Size(75, 23);
            calcBtn.TabIndex = 0;
            calcBtn.Text = "Oblicz";
            calcBtn.UseVisualStyleBackColor = true;
            // 
            // clearBtn
            // 
            clearBtn.Location = new Point(570, 137);
            clearBtn.Name = "clearBtn";
            clearBtn.Size = new Size(75, 23);
            clearBtn.TabIndex = 1;
            clearBtn.Text = "Wyczyść";
            clearBtn.UseVisualStyleBackColor = true;
            // 
            // storageTbox
            // 
            storageTbox.Location = new Point(43, 31);
            storageTbox.Name = "storageTbox";
            storageTbox.Size = new Size(100, 23);
            storageTbox.TabIndex = 2;
            // 
            // liquidTbox
            // 
            liquidTbox.Location = new Point(43, 74);
            liquidTbox.Name = "liquidTbox";
            liquidTbox.Size = new Size(100, 23);
            liquidTbox.TabIndex = 3;
            // 
            // countTbox
            // 
            countTbox.Location = new Point(43, 103);
            countTbox.Name = "countTbox";
            countTbox.Size = new Size(100, 23);
            countTbox.TabIndex = 4;
            // 
            // resTbox
            // 
            resTbox.Location = new Point(43, 240);
            resTbox.Name = "resTbox";
            resTbox.Size = new Size(100, 23);
            resTbox.TabIndex = 5;
            // 
            // res2Tbox
            // 
            res2Tbox.Location = new Point(43, 290);
            res2Tbox.Name = "res2Tbox";
            res2Tbox.Size = new Size(100, 23);
            res2Tbox.TabIndex = 6;
            // 
            // storageCbox
            // 
            storageCbox.FormattingEnabled = true;
            storageCbox.Items.AddRange(new object[] { "Kieliszek (50ml)", "Szklanka (250ml)", "Butelka (500 ml)", "Dzbanek (800ml)" });
            storageCbox.Location = new Point(43, 153);
            storageCbox.Name = "storageCbox";
            storageCbox.Size = new Size(121, 23);
            storageCbox.TabIndex = 7;
            // 
            // liquidCbox
            // 
            liquidCbox.FormattingEnabled = true;
            liquidCbox.Items.AddRange(new object[] { "Wódka (40%)", "Spirytus (96%)", "Płyn Lugola (5%)", "Ocet (10%)" });
            liquidCbox.Location = new Point(43, 182);
            liquidCbox.Name = "liquidCbox";
            liquidCbox.Size = new Size(121, 23);
            liquidCbox.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
    }
}
