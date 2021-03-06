using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Game_Russian_Roulette
{
   public class Game
   {  
        public int Bullet;
        public int Points = 0;
        public int chances = 4;
        public int chancesAway = 2;

        public void LoadingFunc() //loading the gun
        {
            Bullet = 6;
        }

        public int SpinFunc() //spin the chamber
        {
            Random rand = new Random();
            Bullet = rand.Next(1, 7); //setting a range
            return Bullet;
            //chamber to go to a new place from 1 to 6 (which should be 7)

        }
        public int ShootingAwayFunc()
        {
            if (Bullet == 1 && chancesAway == 2)
            {
                //tell the user you win!
                Points = 100;
                MessageBox.Show("You win and you got " + Points + " points");
            }
            else if (Bullet == 1 && chancesAway == 1)
            {
                //tell the user you win but with lesser points
                Points = 50;
                MessageBox.Show("You win and you got " + Points + " points");
            }
            else
            {
                chancesAway--;
                Bullet--;
                //if chances are zero tell him you are dead else tell him keep playing
                if (chancesAway == 0)
                {
                    MessageBox.Show("You have lost all chances of survival, do you want to play again?", "Game Over");
                    Application.Restart();
                }
                else
                {
                    MessageBox.Show("All the best!! Last chance to try your luck");
                }
            }

            return chancesAway;
        }


        public int ShootingAtHead()
        {            //if user will get 1 chance come message user is dead!
            if (Bullet == 1)
            {
                
                MessageBox.Show("You are dead and you have " + Points + " points, do you want to try Again");
                Application.Restart();
            }

            else

            {
                chances--;
                Bullet--;
                //if chances of shooting at your head is zero,
                if (chances == 0 && chancesAway ==2)
                {
                    Points = 50;
                    MessageBox.Show("You win!!! Congrats!" + Points+ " Do you want to try again?");
                    Application.Restart();
                }
                else if (chances == 0 && chancesAway == 1)
                {
                    Points = 20;
                    MessageBox.Show("You win!!! Congrats!" + Points+ " Do you want to try again ? ");
                    Application.Restart();
                }

                else
                {
                    MessageBox.Show("Try your luck.. ");
                }
            }
            return chances;
        }




        
    }
}

    



   

