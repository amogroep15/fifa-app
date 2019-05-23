namespace FifaBetApp
{
    partial class gambleForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.teamBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.plus1Button = new System.Windows.Forms.Button();
            this.plus5Button = new System.Windows.Forms.Button();
            this.plus10Button = new System.Windows.Forms.Button();
            this.betButton = new System.Windows.Forms.Button();
            this.balanceLabel = new System.Windows.Forms.Label();
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // teamBox
            // 
            this.teamBox.FormattingEnabled = true;
            this.teamBox.Location = new System.Drawing.Point(10, 11);
            this.teamBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.teamBox.Name = "teamBox";
            this.teamBox.Size = new System.Drawing.Size(176, 342);
            this.teamBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(189, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Wed";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(242, 15);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(30, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(275, 11);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "euro";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(193, 89);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Op Team";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(290, 91);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(61, 21);
            this.comboBox1.TabIndex = 5;
            // 
            // plus1Button
            // 
            this.plus1Button.Location = new System.Drawing.Point(193, 37);
            this.plus1Button.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.plus1Button.Name = "plus1Button";
            this.plus1Button.Size = new System.Drawing.Size(39, 40);
            this.plus1Button.TabIndex = 6;
            this.plus1Button.Text = "+1";
            this.plus1Button.UseVisualStyleBackColor = true;
            this.plus1Button.Click += new System.EventHandler(this.plus1Button_Click);
            // 
            // plus5Button
            // 
            this.plus5Button.Location = new System.Drawing.Point(251, 39);
            this.plus5Button.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.plus5Button.Name = "plus5Button";
            this.plus5Button.Size = new System.Drawing.Size(40, 38);
            this.plus5Button.TabIndex = 7;
            this.plus5Button.Text = "+5";
            this.plus5Button.UseVisualStyleBackColor = true;
            this.plus5Button.Click += new System.EventHandler(this.plus5Button_Click);
            // 
            // plus10Button
            // 
            this.plus10Button.Location = new System.Drawing.Point(308, 39);
            this.plus10Button.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.plus10Button.Name = "plus10Button";
            this.plus10Button.Size = new System.Drawing.Size(42, 38);
            this.plus10Button.TabIndex = 8;
            this.plus10Button.Text = "+10";
            this.plus10Button.UseVisualStyleBackColor = true;
            this.plus10Button.Click += new System.EventHandler(this.plus10Button_Click);
            // 
            // betButton
            // 
            this.betButton.Location = new System.Drawing.Point(222, 128);
            this.betButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.betButton.Name = "betButton";
            this.betButton.Size = new System.Drawing.Size(116, 67);
            this.betButton.TabIndex = 9;
            this.betButton.Text = "Plaats weddenschap!";
            this.betButton.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(418, 171);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 24);
            this.label4.TabIndex = 10;
            this.label4.Text = "Je saldo is:";
            // 
            // balanceLabel
            // 
            this.balanceLabel.AutoSize = true;
            this.balanceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.balanceLabel.Location = new System.Drawing.Point(446, 206);
            this.balanceLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.balanceLabel.Name = "balanceLabel";
            this.balanceLabel.Size = new System.Drawing.Size(0, 26);
            this.balanceLabel.TabIndex = 11;
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeLabel.Location = new System.Drawing.Point(416, 11);
            this.welcomeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(117, 31);
            this.welcomeLabel.TabIndex = 12;
            this.welcomeLabel.Text = "Welkom";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.ForeColor = System.Drawing.Color.Blue;
            this.nameLabel.Location = new System.Drawing.Point(424, 54);
            this.nameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(0, 38);
            this.nameLabel.Size = new System.Drawing.Size(72, 31);
            this.nameLabel.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(556, 54);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 31);
            this.label6.TabIndex = 14;
            this.label6.Text = "!";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(504, 330);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 15;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(557, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 29);
            this.label4.TabIndex = 10;
            this.label4.Text = "Je saldo is:";
            // 
            // gambleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.welcomeLabel);
            this.Controls.Add(this.balanceLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.betButton);
            this.Controls.Add(this.plus10Button);
            this.Controls.Add(this.plus5Button);
            this.Controls.Add(this.plus1Button);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.teamBox);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "gambleForm";
            this.Text = "FIFA Bet App";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox teamBox;
        private System.Windows.Forms.Label label1; 
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button plus1Button;
        private System.Windows.Forms.Button plus5Button;
        private System.Windows.Forms.Button plus10Button;
        private System.Windows.Forms.Button betButton;
        private System.Windows.Forms.Label balanceLabel;
        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label label4;
    }
}

