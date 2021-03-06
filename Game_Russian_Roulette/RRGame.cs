using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Game_Russian_Roulette
{
    public partial class Form1 : Form
    {
        Game Gameobj = new Game();
        public Form1()
        {
            InitializeComponent();
        }

        private void LoadBtn_Click(object sender, EventArgs e)
        {   
            //This method  is using for loading the bullets
            Game_ImageBox.Image = Game_Russian_Roulette.Resource1.load;
            SoundPlayer sc = new SoundPlayer(Game_Russian_Roulette.Resource1.loadG);
            sc.Play();
            //run the function from the object of the class Shooting to run the logic of shooting
            Gameobj.LoadingFunc();
            Btn_Load.Enabled = false;
            Btn_Spin.Enabled = true;
        }
        

        private void Spin_Click(object sender, EventArgs e)
        {  // Spin the revolver
            Game_ImageBox.Image = Game_Russian_Roulette.Resource1.spin;
            SoundPlayer sc = new SoundPlayer(Game_Russian_Roulette.Resource1.Trriger);
            sc.Play();
            Gameobj.SpinFunc();//Calling the spin function to act
            Btn_Spin.Enabled = false;
            Btn_ShootAt.Enabled = true;
            Btn_ShootHd.Enabled = true;
        }

        private void ShootAt_Click(object sender, EventArgs e)
        {
            Game_ImageBox.Image = Game_Russian_Roulette.Resource1.try_again;
            SoundPlayer sc = new SoundPlayer(Game_Russian_Roulette.Resource1.Reload);
            sc.Play();
            int chances = Gameobj.ShootingAtHead();//calling the shootingAwayFunc
        }

        private void ShootHd_Click(object sender, EventArgs e)
        {
            Btn_Spin.Enabled = false;
            Btn_Load.Enabled = false;
            Game_ImageBox.Image = Game_Russian_Roulette.Resource1.shot;
            SoundPlayer sc = new SoundPlayer(Game_Russian_Roulette.Resource1.ShotGu);
            sc.Play();
            int chancesAway = Gameobj.ShootingAwayFunc();//calling the ShootingAwayFunc2 
        }

        private void PLyAgn_Click(object sender, EventArgs e)
        {
            Application.Restart();
            Btn_Load.Enabled = true;
        }

        private void Exit_Btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
