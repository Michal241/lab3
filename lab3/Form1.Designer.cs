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
            SuspendLayout();
            // 
            // clearBtn
            // 
            clearBtn.Location = new Point(322, 275);
            clearBtn.Name = "clearBtn";
            clearBtn.Size = new Size(75, 23);
            clearBtn.TabIndex = 1;
            clearBtn.Text = "Wyczyść";
            clearBtn.UseVisualStyleBackColor = true;
            // 
            // calcBtn
            // 
            calcBtn.Location = new Point(241, 276);
            calcBtn.Name = "calcBtn";
            calcBtn.Size = new Size(75, 23);
            calcBtn.TabIndex = 2;
            calcBtn.Text = "Oblicz";
            calcBtn.UseVisualStyleBackColor = true;
            // 
            // storageTbox
            // 
            storageTbox.Location = new Point(102, 36);
            storageTbox.Name = "storageTbox";
            storageTbox.Size = new Size(100, 23);
            storageTbox.TabIndex = 3;
            // 
            // liquidTbox
            // 
            liquidTbox.Location = new Point(102, 65);
            liquidTbox.Name = "liquidTbox";
            liquidTbox.Size = new Size(100, 23);
            liquidTbox.TabIndex = 4;
            // 
            // countTbox
            // 
            countTbox.Location = new Point(102, 94);
            countTbox.Name = "countTbox";
            countTbox.Size = new Size(100, 23);
            countTbox.TabIndex = 5;
            // 
            // res1Box
            // 
            res1Box.Location = new Point(102, 276);
            res1Box.Name = "res1Box";
            res1Box.Size = new Size(100, 23);
            res1Box.TabIndex = 6;
            // 
            // res2Box
            // 
            res2Box.Location = new Point(102, 305);
            res2Box.Name = "res2Box";
            res2Box.Size = new Size(100, 23);
            res2Box.TabIndex = 7;
            // 
            // storageCbox
            // 
            storageCbox.FormattingEnabled = true;
            storageCbox.Location = new Point(219, 36);
            storageCbox.Name = "storageCbox";
            storageCbox.Size = new Size(121, 23);
            storageCbox.TabIndex = 8;
            // 
            // liquidCbox
            // 
            liquidCbox.FormattingEnabled = true;
            liquidCbox.Location = new Point(219, 65);
            liquidCbox.Name = "liquidCbox";
            liquidCbox.Size = new Size(121, 23);
            liquidCbox.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
    }
}
