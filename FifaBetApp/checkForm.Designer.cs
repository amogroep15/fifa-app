namespace FifaBetApp
{
    partial class checkForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.yesButton = new System.Windows.Forms.RadioButton();
            this.noButton = new System.Windows.Forms.RadioButton();
            this.toAppButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(104, 102);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Voer hier je naam in:";
            // 
            // nameBox
            // 
            this.nameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameBox.Location = new System.Drawing.Point(304, 104);
            this.nameBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(136, 23);
            this.nameBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(104, 155);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "18 jaar en ouder?";
            // 
            // yesButton
            // 
            this.yesButton.AutoSize = true;
            this.yesButton.Location = new System.Drawing.Point(299, 161);
            this.yesButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.yesButton.Name = "yesButton";
            this.yesButton.Size = new System.Drawing.Size(36, 17);
            this.yesButton.TabIndex = 3;
            this.yesButton.TabStop = true;
            this.yesButton.Text = "Ja";
            this.yesButton.UseVisualStyleBackColor = true;
            // 
            // noButton
            // 
            this.noButton.AutoSize = true;
            this.noButton.Location = new System.Drawing.Point(374, 161);
            this.noButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.noButton.Name = "noButton";
            this.noButton.Size = new System.Drawing.Size(45, 17);
            this.noButton.TabIndex = 4;
            this.noButton.TabStop = true;
            this.noButton.Text = "Nee";
            this.noButton.UseVisualStyleBackColor = true;
            // 
            // toAppButton
            // 
            this.toAppButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toAppButton.Location = new System.Drawing.Point(9, 267);
            this.toAppButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.toAppButton.Name = "toAppButton";
            this.toAppButton.Size = new System.Drawing.Size(582, 89);
            this.toAppButton.TabIndex = 5;
            this.toAppButton.Text = "Naar de app!";
            this.toAppButton.UseVisualStyleBackColor = true;
            this.toAppButton.Click += new System.EventHandler(this.toAppButton_Click);
            // 
            // checkForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.toAppButton);
            this.Controls.Add(this.noButton);
            this.Controls.Add(this.yesButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "checkForm";
            this.Text = "checkForm";
            this.Load += new System.EventHandler(this.checkForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton yesButton;
        private System.Windows.Forms.RadioButton noButton;
        private System.Windows.Forms.Button toAppButton;
    }
}