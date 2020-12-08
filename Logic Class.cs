using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    public class Logic_Class
    {
        public int Hammer_Positon;
        public int Bullet_Positon;
        public int Fire_on_head;

        public int shoot()
        {
            if (Hammer_Position == Bullet_Positon)

            {
                return 1;
            }
            else if (Bullet_Position == 6)
            {
                Bullet_Positon = 1;
                return = 0;
            }
            else
            {
                Bullet_Positon++;
                return 0;
            }
        }
    }
}

