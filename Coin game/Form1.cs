using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coin_game
{
    public partial class Form1 : Form
    {
        Coin[] coins = new Coin[5];
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Coin[] coins = new Coin[5];
            label1.Text = "";
            for(int i = 0; i < coins.Length; i++)
            {
                coins[i] = new Coin(true);
                label1.Text += coins[i].ishead + " ,";
            }
        }

        private void button1_Click(object sender, EventArgs e)

        {
            Random r = new Random();
            label1.Text = "";
            for (int i = 0; i < coins.Length; i++)
            {
                
                coins[i] = new Coin(true);
                coins[i].flip(r);
                label1.Text += coins[i].ishead + " ,";
            }
            pictureBox1.Image =  coins[0].ishead ?  Properties.Resources.head :  Properties.Resources.tail;
            pictureBox3.Image =  coins[1].ishead ?  Properties.Resources.head :  Properties.Resources.tail;
            pictureBox4.Image =  coins[2].ishead ?  Properties.Resources.head :  Properties.Resources.tail;
            pictureBox5.Image =  coins[3].ishead ?  Properties.Resources.head :  Properties.Resources.tail;
            pictureBox2.Image =  coins[4].ishead ?  Properties.Resources.head :  Properties.Resources.tail;
        }
    }
}
