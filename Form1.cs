using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameProject
{
    public partial class Game_form : Form
    {
        public Game_form()
        {
            InitializeComponent();
        }
        Game_logic Obj_Game = new Game_logic();
        Random Rand = new Random();

       

        private void PLAY_BTN_Click(object sender, EventArgs e)
        {
            Application.Restart(); // code for restart button 
        }

        private void Game_form_Load(object sender, EventArgs e)
        {
            LOAD_BTN.Enabled = true; //code for load button
            SPIN_BTN.Enabled = false; //code for spin button
            BTN_SHOOT.Enabled = false; //code for shoot button
            SHOOTAWAY_BTN.Enabled = false; //code for shootaway button
        }

        private void LOAD_BTN_Click(object sender, EventArgs e)
        {
            // code helps to show the image
            Assembly Assem = Assembly.GetExecutingAssembly();
            Stream Str = Assem.GetManifestResourceStream("GameProject.Resources.load.gif");
            Bitmap bmpObj = new Bitmap(Str);
            picbox_main.Image = bmpObj;

            //code helps for sounds//
            System.Media.SoundPlayer sndObj = new System.Media.SoundPlayer(GameProject.Properties.Resources.gun_load);
            sndObj.Play();
            //Enable the spin button and disable other buttons
            SPIN_BTN.Enabled = true;
            LOAD_BTN.Enabled = false;

            //set the bullet at first position
            Obj_Game.Load = 1;
        }

        private void SPIN_BTN_Click(object sender, EventArgs e)
        {
            //coding helps for images//
            Assembly Assem = Assembly.GetExecutingAssembly();
            Stream Str = Assem.GetManifestResourceStream("GameProject.Resources.spin.gif");
            Bitmap bmpObj = new Bitmap(Str);
            picbox_main.Image = bmpObj;




            Obj_Game.spin_Bullet = Rand.Next(1, 7); // assign random position between 1 to 6 
            MessageBox.Show(Obj_Game.spin_Bullet.ToString());
            //enable shoot and shoot away buttons and disable other buttons
            BTN_SHOOT.Enabled = true;
            SHOOTAWAY_BTN.Enabled = true;
            SPIN_BTN.Enabled = false;
        }

        private void BTN_SHOOT_Click(object sender, EventArgs e)
        {
            //below code helps to show the image
            //coding for images//
            Assembly Assem = Assembly.GetExecutingAssembly();
            Stream Str = Assem.GetManifestResourceStream("GameProject.Resources.shoothead.gif");
            Bitmap bmpObj = new Bitmap(Str);
            picbox_main.Image = bmpObj;

            //coding for sounds//
            System.Media.SoundPlayer sndObj = new System.Media.SoundPlayer(GameProject.Properties.Resources.gun_shot);
            sndObj.Play();

            if (Obj_Game.Total_Fire > 0 && Obj_Game.spin_Bullet == Obj_Game.load) // condition to check bullet is under gun hammer
            {
                MessageBox.Show("Sorry! you loose the game");
                SHOOTAWAY_BTN.Enabled = false;
                BTN_SHOOT.Enabled = false;
            }
            else if (Obj_Game.Total_Fire > 0 && Obj_Game.spin_Bullet != Obj_Game.load) // condition to check bullet is not under gun hammer
            {
                MessageBox.Show("Empty Fire");
                Obj_Game.Total_Fire = Obj_Game.Total_Fire - 1;//minus one from total
                Obj_Game.spin_Bullet = Obj_Game.Bulleteloop(Obj_Game.spin_Bullet); // call spin_bullet method from Roullet class to set the bullet position
            }
        }

        private void SHOOTAWAY_BTN_Click(object sender, EventArgs e)
        {
            //coding helps for image//
            Assembly Assem = Assembly.GetExecutingAssembly();
            Stream Str = Assem.GetManifestResourceStream("GameProject.Resources.shootaway.gif");
            Bitmap bmpObj = new Bitmap(Str);
            picbox_main.Image = bmpObj;

            //coding helps for sounds//
            System.Media.SoundPlayer sndObj = new System.Media.SoundPlayer(GameProject.Properties.Resources.gun_shot);
            sndObj.Play();

            if (Obj_Game.Total_Fire > 0 && Obj_Game.spin_Bullet == Obj_Game.load) // condition to check shot is under firearm hammer
            {
                if (Obj_Game.Point_Away == 2) // condition to check slug terminated in first possibility
                {
                    MessageBox.Show("You won and your score is 100");
                    SHOOTAWAY_BTN.Enabled = false;
                    BTN_SHOOT.Enabled = false;
                }
                if (Obj_Game.Point_Away == 1) // condition to check shot discharged in additional opportunity
                {
                    MessageBox.Show("You won and your score is 50");
                    BTN_SHOOT.Enabled = false;
                    SHOOTAWAY_BTN.Enabled = false;
                }
            }

            else if (Obj_Game.Total_Fire > 0 && Obj_Game.spin_Bullet != Obj_Game.load) // condition to check slug isn't under weapon hammer
            {
                MessageBox.Show("Empty Fire");
                Obj_Game.Total_Fire = Obj_Game.Total_Fire - 1; //diminishing the all out fire 
                Obj_Game.Point_Away = Obj_Game.Point_Away - 1; //decreasing the absolute possibilities
                Obj_Game.spin_Bullet = Obj_Game.Bulleteloop(Obj_Game.spin_Bullet); // call spin_bullet technique from Roullet class to set the shot position
                if (Obj_Game.Point_Away == 0) // condition to check any chance left or not
                {
                    MessageBox.Show("Sorry! you loose the game");
                    BTN_SHOOT.Enabled = false;
                    SHOOTAWAY_BTN.Enabled = false;
                }
            }
        }

        private void EXIT_BTN_Click(object sender, EventArgs e)
        {
            Application.Exit(); // close the application
        }

        
    }
}