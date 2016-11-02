using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProxyPattern
{
    public partial class Form1 : Form
    {

        Proxy proxy = new Proxy();
       
        public Form1()
        {
            InitializeComponent();
            cbPlayer1.Items.Insert(0, "Fire");
            cbPlayer1.Items.Insert(1, "Water");
            cbPlayer1.Items.Insert(2, "Grass");
            cbPlayer2.Items.Insert(0, "Fire");
            cbPlayer2.Items.Insert(1, "Water");
            cbPlayer2.Items.Insert(2, "Grass");
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            if (cbPlayer1.Text == "Pick A Type")
            {
                MessageBox.Show("PICK A TYPE YOU UNDERSIZED BANANA HAMMOCK");

            }
            else if (cbPlayer2.Text == "Pick A Type")
            {
                MessageBox.Show("PICK A TYPE YOU UNDERSIZED BANANA HAMMOCK");
            }
            else if (cbPlayer1.SelectedIndex.Equals(cbPlayer2.SelectedIndex))
            {
                txtResults.Text = "Well this is awkward";
            }
            else
            {
                if(proxy.Results(cbPlayer1.Text,cbPlayer2.Text))
                {
                    txtResults.Text = "Player One would win.";
                }
                else
                {
                    txtResults.Text = "Player Two would win.";
                }
            }
            
        }
    }
}
