﻿using System;
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
        List<string> teamNumbers = new List<string>();
        List<string> teamMembers = new List<string>();

        public gambleForm(string userName)
        {
            UserName = userName;

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
        }

        private void saveButton_Click(object sender, EventArgs e)
        {

            // Branches = JsonConvert.DeserializeObject<List<Branch>>(File.ReadAllText(@".\InformationTree.dat")); load
            // File.WriteAllText(@".\InformationTree.dat", JsonConvert.SerializeObject(Branches)); save
            // in form_load moet dit Program.InformationTree.LoadTree();
            // opslaan Program.InformationTree.SaveTree();
            // showInfoTree(Program.InformationTree, "");

            string username = nameLabel.Text;

       //     User = JsonConvert.DeserializeObject<User<UserName>>(File.ReadAllText(@".\InformationTree.dat"));

        //    File.WriteAllText(@".\InformationTree.dat", JsonConvert.SerializeObject(Branches));

          //  System.IO.StreamWriter file = new System.IO.StreamWriter(".//test.txt");

            //file.WriteLine(username);

            //file.Close();
        }
    }
}
