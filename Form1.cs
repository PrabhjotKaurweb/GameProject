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
        Game_Logic Obj_Logic = new Game_Logic();
        public Game_form()
        {
            InitializeComponent();
            SPIN_BTN.Enabled = false; // disables the spin button
            SHOOTONHEAD_BTN.Enabled = false; // disables shootonhead button
            SHOOTAWAY_BTN.Enabled = false; // disables shootaway buttton 
            
        }

      

        private void LOAD_BTN_Click(object sender, EventArgs e)
        {
            SPIN_BTN.Enabled = true; // enables the spin button 
            LOAD_BTN.Enabled = false; // disables the load button 

            //load logic
            Obj_Logic.load_positon = 1;
        }

        private void EXIT_BTN_Click(object sender, EventArgs e)
        {
            Application.Restart(); // enables exit restart button 
        }

        private void SPIN_BTN_Click(object sender, EventArgs e)
        {
            SHOOTAWAY_BTN.Enabled = true; // enables shootaway button 
            SHOOTONHEAD_BTN.Enabled = true; // enables shootonhead button
            SPIN_BTN.Enabled = false; // disable spin button

            // spin the bullet 
            Random Obj_random = new Random();
            Obj_Logic.spin_bullet = Object random.Next(1, 7);
            MessageBox.Show("Bullet postion" + Obj_Logic.Bullet_Postion);


        }

        private void PLAY_BTN_Click(object sender, EventArgs e)
        {
            Application.Restart(); // enables restart button 
        }

        private void SHOOTONHEAD_BTN_CLICK(object sender, EventArgs e)
        {
            Obj_Logic.Fire = Obj_Logic.shoot();
            if (Logic.Fire == 1)
            {
                MessageBox.Show("Sorry, you are dead now");
            }
            else
            {
                MessageBox.Show("Empty Show");
            }
        }
        private void SHOOTAWAY_BTN_CLICK(object sender, EventArgs e)
        {
            if(Obj_Logic.chances <=2 )
            {
                Obj_Logic.Fire = Obj_Logic.shoot();
                if (Obj_Logic.Fire == 1)
                {
                    MessageBox.Show("Wow, you are safe");
                    SHOOTAWAY_BTN.Enabled = false;
                    SHOOTONHEAD_BTN.Enabled = false; 
                }
                else
                {
                    MessageBox.Show("Empty shot");
                }
                Obj_Logic.chances++
            }
        }
    }

}
