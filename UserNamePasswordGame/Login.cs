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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        Game1 myGame1 = new Game1();//The Game 1 Form

        private bool GetLogin()
        {//getting the user input for login
            string Username = "EAC";
            string Password = "Student";
            bool blIsGood = false;
            if (txtUsername.Text == Username)
            {
                if (txtPass.Text == Password)
                {
                    blIsGood = true;
                }
                else
                {
                    MessageBox.Show("SORRY BUT THE PASSWORD IS NOT CORRECT TRY AGAIN");
                }
            }
            else
            {
                MessageBox.Show("SORRY BUT I BELIVE THE USER YOU HAVE INPUTED DON'T HAVE THE CORRECT AUTH FOR THIS PROGRAM TRY AGAIN");
            }
            return blIsGood;
        }
        
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (GetLogin())
            {//if all is right this will start the next step on the program
                MessageBox.Show("You are now Logining in as." + txtUsername.Text + " Please wait a few moments for the page to load your game." +
                    " If Your Game is taking to long restart the application." +
                    " At the end of game you will be presented with another Username And Password combo to use!(AS of right the one usersname and paasword is the only combo till further notice)");
                System.Threading.Thread.Sleep(2000);
                myGame1.ShowDialog();

            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            MessageBox.Show("The UserName:EAC \r\nThe Password:Student" +
                "\r\n\fFind the Hidden Easter Eggs");
        }

        private void label1_Click(object sender, EventArgs e)/*Now if you Noticed this is the first easter egg 
                                                              * 
                                                              */
        {
            MessageBox.Show("First Easter Egg");
            System.Threading.Thread.Sleep(1000);
            txtPass.Text = "Student";
            System.Threading.Thread.Sleep(2000);
            txtUsername.Text = "EAC";
            System.Threading.Thread.Sleep(1000);
            if (GetLogin())
            {//if all is right this will start the next step on the program
                MessageBox.Show("You are now Logining in as." + txtUsername.Text + " Please wait a few moments for the page to load your game." +
                    " If Your Game is taking to long restart the application." +
                    " At the end of game you will be presented with another Username And Password combo to use!(AS of right the one usersname and paasword is the only combo till further notice)");
                System.Threading.Thread.Sleep(2000);
                myGame1.ShowDialog();

            }
        }
    }
}
