using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learning_c_sharp
{

    class Upgrade
    {
        Method method = new Method();
        Player player = new Player();

        public void Upgrades()
        {
            //info
            Console.WriteLine("Current stats: ");
            method.blank();
            Console.WriteLine("Strength: " + player.strength);
            Console.WriteLine("Speed: " + player.speed);
            Console.WriteLine("Life: " + player.health);
            Console.WriteLine("Upgrade points:" + player.upgradePoints);
            method.blank();
            //upgrade choice
            Console.WriteLine("Which one do you wish to upgrade?(don't type if you don't wish to upgrade)");
            string upchoice = Console.ReadLine();
            if (upchoice == "strength")
            {
                method.blank();
                Console.WriteLine("using how many upgrade points?");
                int strup = Convert.ToInt32(Console.ReadLine());
                if (strup <= player.upgradePoints)
                {
                    player.strength += strup;
                    player.upgradePoints -= strup;
                    strup = 0;
                    method.blank();
                    Console.WriteLine("successfully upgraded strength to : " + player.strength);
                    method.Continue();
                }
                else if (strup > player.upgradePoints)
                {
                    Console.WriteLine("insufficient upgrade points");
                    method.Continue();
                }
            }
            else if (upchoice == "speed")
            {
                method.blank();
                Console.WriteLine("using how many upgrade points?");
                int spdup = Convert.ToInt32(Console.ReadLine());
                if (spdup <= player.upgradePoints)
                {
                    player.speed += spdup;
                    player.upgradePoints -= spdup;
                    spdup = 0;
                    method.blank();
                    Console.WriteLine("successfully upgraded speed to : " + player.speed);
                    method.Continue();
                }
                else if (spdup > player.upgradePoints)
                {
                    Console.WriteLine("insufficient upgrade points");
                    method.Continue();
                }
            }
            else if (upchoice == "life")
            {
                method.blank();
                Console.WriteLine("using how many upgrade points?");
                int hpup = Convert.ToInt32(Console.ReadLine());
                if (hpup <= player.upgradePoints)
                {
                    player.health += hpup;
                    player.upgradePoints -= hpup;
                    hpup = 0;
                    method.blank();
                    Console.WriteLine("successfully upgraded strength to : " + player.health);
                    method.Continue();
                }
                else if (hpup > player.upgradePoints)
                {
                    Console.WriteLine("insufficient upgrade points");
                    method.Continue();
                }
            }
        }
    }
}
