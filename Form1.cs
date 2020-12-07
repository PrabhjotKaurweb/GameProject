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

      


        private void SHOOTONHEAD_BTN_Click(object sender, EventArgs e)
        {

        }

      

        private void LOAD_BTN_Click(object sender, EventArgs e)
        {
            SPIN_BTN.Enabled = true;
            LOAD_BTN.Enabled = false;
        }

        private void EXIT_BTN_Click(object sender, EventArgs e)
        {

        }

        private void SPIN_BTN_Click(object sender, EventArgs e)
        {
            SHOOTAWAY_BTN.Enabled = true;
            SHOOTONHEAD_BTN.Enabled = true;
            LOAD_BTN.Enabled = false;
        }

    
       
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //code to display image in picture box on button click   

            Assembly myAssembly = Assembly.GetExecutingAssembly();

            Stream myStream = myAssembly.GetManifestResourceStream("ProjectName.Resources.about_us_image.jpg");

            Bitmap bmp_Object = new Bitmap(myStream);

            pictureBox1.Image = bmp_Object;

.
        }
    }
}
