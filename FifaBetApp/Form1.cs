using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;


namespace FifaBetApp
{
    public partial class gambleForm : Form
    {
        private string UserName { get; }
        public static decimal balance;

        public gambleForm(string userName)
        {
            UserName = userName;


            InitializeComponent();
          //  if (balance <= 0)
            //    MessageBox.Show("Je kan geen geld meer inzetten");

         //   else

             //   MessageBox.Show("Je hebt genoeg geld")
             //   ;
               
     
           
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

        public void Form1_Load(object sender, EventArgs e)
        {
            nameLabel.Text = UserName;
            balance = 10000;
            balanceLabel.Text = balance.ToString();

            try
            {
                System.Net.WebClient downloader = new System.Net.WebClient();

                string json;

                json = downloader.DownloadString("http://kasrasenberg.com/index.php?request=teams&key=f6cdadf02b5521c26a7c09e2620d3bf3");

                List<Team> teams = JsonConvert.DeserializeObject<List<Team>>(json);

                foreach (Team team in teams)
                {
                    teamBox.Items.Add(team.name);
                }

                string matchJson;

                matchJson = downloader.DownloadString("http://kasrasenberg.com/index.php?request=matches&key=aa3368d28f9a8dfb952d56c508d7cd3d");
                List<Match> matches = JsonConvert.DeserializeObject<List<Match>>(matchJson);


                for (int i = 0; i < matches.Count; i++)
                {
                    comboBox1.Items.Add(matches[i]);
                }
            }
            catch (System.Net.WebException)
            {
                MessageBox.Show("Kan geen verbinding maken met de server!");
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {

        }

        private void betButton_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "")
            {
                MessageBox.Show("Selecteer een wedstrijd!");

                return;
            }


            if (teamBox.SelectedItem != null)
            {
                try
                {
                    string team = teamBox.SelectedItem.ToString();
                    Match match = (Match)comboBox1.SelectedItem;
                    int betAmount = int.Parse(textBox1.Text);


                    if (betAmount < 1)
                    {
                        MessageBox.Show("Je moet minimaal 1 euro inzetten");

                        return;
                    }

                    if (balance < betAmount)
                    {
                        MessageBox.Show("Je hebt niet genoeg geld!");

                        return;
                    }

                    balance = balance - betAmount;
                    balanceLabel.Text = balance.ToString();

                    Bet newBet = new Bet(match, betAmount, team);

                    MessageBox.Show(newBet.ToString());
                }
                catch (FormatException)
                {
                    MessageBox.Show("Voer een geldig geld bedrag in!");
                }
               
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            teamBox.Items.Clear();
            Match match = (Match)comboBox1.SelectedItem;       
            comboBox1.Items.Add(match.team1);
            comboBox1.Items.Add(match.team2);
        }
    }
}
