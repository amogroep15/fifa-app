using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FifaBetApp
{
    public partial class Form1 : Form
    {

        decimal balance;
        List<string> teamNumbers = new List<string>();
        List<string> teamMembers = new List<string>();

        public Form1()
        {
            InitializeComponent();
            teamNumbers.Add("Team 1");
            teamNumbers.Add("Team 2");
            teamNumbers.Add("Team 3");
            teamNumbers.Add("Team 4");

            teamMembers.Add("-TEAM 1");
            teamMembers.Add("Rick van Zelst");
            teamMembers.Add("Kas Rasenberg");
            teamMembers.Add("Daniel Vahabi");
            teamMembers.Add("Hassan Hassan");
            teamMembers.Add("Rick van Zelst");
            teamMembers.Add("Kas Rasenberg");
            teamMembers.Add("Daniel Vahabi");
            teamMembers.Add("Hassan Hassan");
            teamMembers.Add("Rick van Zelst");
            teamMembers.Add("Kas Rasenberg");
            teamMembers.Add("Daniel Vahabi");
            teamMembers.Add("Hassan Hassan");

            teamMembers.Add("-TEAM 2");
            teamMembers.Add("Rick van Zelst");
            teamMembers.Add("Kas Rasenberg");
            teamMembers.Add("Daniel Vahabi");
            teamMembers.Add("Hassan Hassan");
            teamMembers.Add("Rick van Zelst");
            teamMembers.Add("Kas Rasenberg");
            teamMembers.Add("Daniel Vahabi");
            teamMembers.Add("Hassan Hassan");
            teamMembers.Add("Rick van Zelst");
            teamMembers.Add("Kas Rasenberg");
            teamMembers.Add("Daniel Vahabi");
            teamMembers.Add("Hassan Hassan");

            teamMembers.Add("-TEAM 3");
            teamMembers.Add("Rick van Zelst");
            teamMembers.Add("Kas Rasenberg");
            teamMembers.Add("Daniel Vahabi");
            teamMembers.Add("Hassan Hassan");
            teamMembers.Add("Rick van Zelst");
            teamMembers.Add("Kas Rasenberg");
            teamMembers.Add("Daniel Vahabi");
            teamMembers.Add("Hassan Hassan");
            teamMembers.Add("Rick van Zelst");
            teamMembers.Add("Kas Rasenberg");
            teamMembers.Add("Daniel Vahabi");
            teamMembers.Add("Hassan Hassan");

            teamMembers.Add("-TEAM 4");
            teamMembers.Add("Rick van Zelst");
            teamMembers.Add("Kas Rasenberg");
            teamMembers.Add("Daniel Vahabi");
            teamMembers.Add("Hassan Hassan");
            teamMembers.Add("Rick van Zelst");
            teamMembers.Add("Kas Rasenberg");
            teamMembers.Add("Daniel Vahabi");
            teamMembers.Add("Hassan Hassan");
            teamMembers.Add("Rick van Zelst");
            teamMembers.Add("Kas Rasenberg");
            teamMembers.Add("Daniel Vahabi");
            teamMembers.Add("Hassan Hassan");

            comboBox1.DataSource = teamNumbers;
            teamBox.DataSource = teamMembers;
        }

        private void plus1Button_Click(object sender, EventArgs e)
        {
         int result = int.Parse(textBox1.Text);
            result = result + 1;
            textBox1.Text = result.ToString();

        }

        private void plus5Button_Click(object sender, EventArgs e)
        {
            int result = int.Parse(textBox1.Text);
            result = result + 5;
            textBox1.Text = result.ToString();
        }

        private void plus10Button_Click(object sender, EventArgs e)
        {
            int result = int.Parse(textBox1.Text);
            result = result + 10;
            textBox1.Text = result.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            balance = 100000;
            balanceLabel.Text = balance.ToString();
        }
    }
}
