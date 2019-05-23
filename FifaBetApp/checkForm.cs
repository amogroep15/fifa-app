using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace FifaBetApp
{
    public partial class checkForm : Form
    {
        public checkForm()
        {
            InitializeComponent();
        }



    private void toAppButton_Click(object sender, EventArgs e)
        {
            if (yesButton.Checked)
            {
                gambleForm Check = new gambleForm();
                Check.Show();
                Hide();
            }
            else
            {

                MessageBox.Show("Je moet goed op je geld letten en sparen");
                this.Close();
            }
           
    
        }
    }
}
