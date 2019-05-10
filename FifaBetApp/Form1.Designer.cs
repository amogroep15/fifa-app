namespace FifaBetApp
{
    partial class Form1
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
            this.label4 = new System.Windows.Forms.Label();
            this.balanceLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // teamBox
            // 
            this.teamBox.FormattingEnabled = true;
            this.teamBox.ItemHeight = 16;
            this.teamBox.Location = new System.Drawing.Point(13, 13);
            this.teamBox.Name = "teamBox";
            this.teamBox.Size = new System.Drawing.Size(233, 420);
            this.teamBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(252, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Wed";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(322, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(39, 22);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(367, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "euro";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(257, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 29);
            this.label3.TabIndex = 4;
            this.label3.Text = "Op Team";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(386, 112);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(80, 24);
            this.comboBox1.TabIndex = 5;
            // 
            // plus1Button
            // 
            this.plus1Button.Location = new System.Drawing.Point(257, 46);
            this.plus1Button.Name = "plus1Button";
            this.plus1Button.Size = new System.Drawing.Size(52, 49);
            this.plus1Button.TabIndex = 6;
            this.plus1Button.Text = "+1";
            this.plus1Button.UseVisualStyleBackColor = true;
            this.plus1Button.Click += new System.EventHandler(this.plus1Button_Click);
            // 
            // plus5Button
            // 
            this.plus5Button.Location = new System.Drawing.Point(335, 48);
            this.plus5Button.Name = "plus5Button";
            this.plus5Button.Size = new System.Drawing.Size(54, 47);
            this.plus5Button.TabIndex = 7;
            this.plus5Button.Text = "+5";
            this.plus5Button.UseVisualStyleBackColor = true;
            this.plus5Button.Click += new System.EventHandler(this.plus5Button_Click);
            // 
            // plus10Button
            // 
            this.plus10Button.Location = new System.Drawing.Point(410, 48);
            this.plus10Button.Name = "plus10Button";
            this.plus10Button.Size = new System.Drawing.Size(56, 47);
            this.plus10Button.TabIndex = 8;
            this.plus10Button.Text = "+10";
            this.plus10Button.UseVisualStyleBackColor = true;
            this.plus10Button.Click += new System.EventHandler(this.plus10Button_Click);
            // 
            // betButton
            // 
            this.betButton.Location = new System.Drawing.Point(296, 158);
            this.betButton.Name = "betButton";
            this.betButton.Size = new System.Drawing.Size(155, 82);
            this.betButton.TabIndex = 9;
            this.betButton.Text = "Plaats weddenschap!";
            this.betButton.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(549, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 29);
            this.label4.TabIndex = 10;
            this.label4.Text = "Saldo:";
            // 
            // balanceLabel
            // 
            this.balanceLabel.AutoSize = true;
            this.balanceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.balanceLabel.Location = new System.Drawing.Point(644, 13);
            this.balanceLabel.Name = "balanceLabel";
            this.balanceLabel.Size = new System.Drawing.Size(0, 32);
            this.balanceLabel.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
            this.Name = "Form1";
            this.Text = "Form1";
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label balanceLabel;
    }
}

