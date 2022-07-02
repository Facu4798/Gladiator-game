using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learning_c_sharp
{
    class Player
    {
        Method method = new Method();

        public string classtype;
        public int strength;
        public int speed;
        public int health;
        public int level = 1;
        public int xp = 0;
        public int xpRemaining = 100;
        public int upgradePoints = 0;
        public int money = 0;
        public int swordlvl = 0;
        public int shieldlvl = 0;
        public int armorlvl = 0;

        //class initial stats
        public void balanced()
        {
            strength = 100;
            speed = 100;
            health = 100;
            classtype = "Balanced";
        }
        public void tank()
        {
            strength = 150;
            speed = 50;
            health = 100;
            classtype = "Tank";
        }
        public void thief()
        {
            strength = 50;
            speed = 150;
            health = 100;
            classtype = "Thief";
        }
    }
    
}
