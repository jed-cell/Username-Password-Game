using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserNamePasswordGame
{
    public partial class Game1 : Form
    {
        public Game1()
        {
            InitializeComponent();
        }
        Random rand = new Random();
        int intRandom1,
            intRandom2;
        int Counter = 0;
        int intAnswer;
        Credits myCredits = new Credits();//for the credits page
        private void GameCounter()//this displays the correct number of rounds and a new number
        {
            intRandom1 = rand.Next(100)+1;
            intRandom2 = rand.Next(100)+1;
            txtAnswer.Clear();
            lblNumberofroundsCorrect.Text = Counter.ToString();
            lblNumber1.Text = intRandom1.ToString();
            lblNumber2.Text = intRandom2.ToString();
            if (Counter == 20)
            {
                MessageBox.Show("Congrats you have won");
                System.Threading.Thread.Sleep(1000);
                this.Hide();
                myCredits.Show();
            }

        }
        private void Gamereset()/*This is for the reset of the game Note it is as a call method as it may be used later
                                 * 
                                 */
        {
            MessageBox.Show("Sorry Incorrect Try Again\r\nNote: Game Counter is reset");
            Counter = 0; 
            txtAnswer.Clear();
            lblNumberofroundsCorrect.Text = Counter.ToString();
            lblNumber1.Text = intRandom1.ToString();
            lblNumber2.Text = intRandom2.ToString();
        }
        private void btnCheck_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtAnswer.Text, out intAnswer))
            {
                if (intAnswer == intRandom1 * intRandom2)
                {
                    Counter++;
                    if (Counter != 20)
                    {
                        MessageBox.Show("Congrats you are moving on to the next round");
                        System.Threading.Thread.Sleep(2000);
                    }
                    
                    GameCounter();
                }
                else
                {
                   Gamereset();
                }
            }
            else
            {
                MessageBox.Show("sorry invaild input");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("thanks for playing good bye");
            Application.Exit();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You are loging out thanks for Playing!");
            System.Threading.Thread.Sleep(2000);
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Congratulation You found an Easter Egg Use this Wisely");
            MessageBox.Show("Your Game Counter is Now Set to 19\r\n\b Use This Wisely");
            Counter = 19;
            GameCounter();
        }

        private void Game1_Load(object sender, EventArgs e)
        {
            Counter = 0;
           GameCounter();   
        }
    }
}
