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
            SPIN_BTN.Enabled = false;
            SHOOTONHEAD_BTN.Enabled = false;
            SHOOTAWAY_BTN.Enabled = false;
            
        }

      

        private void LOAD_BTN_Click(object sender, EventArgs e)
        {
            SPIN_BTN.Enabled = true;
            LOAD_BTN.Enabled = false;
        }

        private void EXIT_BTN_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void SPIN_BTN_Click(object sender, EventArgs e)
        {
            SHOOTAWAY_BTN.Enabled = true;
            SHOOTONHEAD_BTN.Enabled = true;
            SPIN_BTN.Enabled = false;

        }

        private void PLAY_BTN_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void SHOOTONHEAD_BTN_CLICK(object sender, EventArgs e)
        {

        }

    }

}
