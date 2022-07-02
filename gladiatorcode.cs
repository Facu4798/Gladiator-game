using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learning_c_sharp
{
    public class gladiatorcode
    {
        public static void Main()
        {
            Player player = new Player();
            //some variables
            string ClassSelect;
            string classtype = "3";
            int[] PlayerStats = { 0, 0, 0 };//position 0 = strength 1=speed 2= life
            int[] EnemyStats = { 0, 0, 0 };
            int level = 1;
            int xp = 0;
            int xpRemaining = 100;
            int upgradePoints = 0;
            int money = 0;
            int swordlvl = 0;
            int shieldlvl = 0;
            int armorlvl = 0;
            int gamecount = 0;
            bool win = false;


            //intro Path 1 after class selection
            int choice = Paths(1);
            while (choice == 1 || choice == 2)
            {



                choice = Paths(1);
            }

            //game
            bool i2 = false;
            while (i2 == false)
            {
                //game count

                Console.WriteLine("Game count :   " + gamecount);
                blank();
                blank();

                //enemy stats
                Random randomenemystat = new Random();

                //enemy strength
                switch (level)
                {
                    case 1:
                        EnemyStats[0] = randomenemystat.Next(50, 150);
                        break;
                    case 2:
                        EnemyStats[0] = randomenemystat.Next(50, 150);
                        break;
                    case 3:
                        EnemyStats[0] = randomenemystat.Next(50, 150);
                        break;
                    case 4:
                        EnemyStats[0] = randomenemystat.Next(50, 150);
                        break;
                    case 5:
                        EnemyStats[0] = randomenemystat.Next(50, 150);
                        break;
                }
                //enemy speed
                switch (level)
                {
                    case 1:
                        EnemyStats[1] = randomenemystat.Next(50, 150);
                        break;
                    case 2:
                        EnemyStats[1] = randomenemystat.Next(50, 150);
                        break;
                    case 3:
                        EnemyStats[1] = randomenemystat.Next(50, 150);
                        break;
                    case 4:
                        EnemyStats[1] = randomenemystat.Next(50, 150);
                        break;
                    case 5:
                        EnemyStats[1] = randomenemystat.Next(50, 150);
                        break;
                }
                //enemy life
                switch (level)
                {
                    case 1:
                        EnemyStats[2] = randomenemystat.Next(50, 150);
                        break;
                    case 2:
                        EnemyStats[2] = randomenemystat.Next(50, 150);
                        break;
                    case 3:
                        EnemyStats[2] = randomenemystat.Next(50, 150);
                        break;
                    case 4:
                        EnemyStats[2] = randomenemystat.Next(50, 150);
                        break;
                    case 5:
                        EnemyStats[2] = randomenemystat.Next(50, 150);
                        break;
                }

                //imprint enemy stats
                Console.Write("Enemy strength = "); Console.WriteLine(EnemyStats[0]);
                Console.Write("Enemy speed    = "); Console.WriteLine(EnemyStats[1]);
                Console.Write("Enemy life     = "); Console.WriteLine(EnemyStats[2]);
                blank();

                //algorithm
                double strdif = PlayerStats[0] - EnemyStats[0];
                double spddif = PlayerStats[1] - EnemyStats[1];
                double hpdif = PlayerStats[2] - EnemyStats[2];
                double totalstr = PlayerStats[0] + EnemyStats[0];
                double totalspd = PlayerStats[1] + EnemyStats[1];
                double totalhp = PlayerStats[2] + EnemyStats[2];
                double strvariation = (PlayerStats[0] / totalstr) * 100;
                double spdvariation = (PlayerStats[1] / totalspd) * 100;
                double hpvariation = (PlayerStats[2] / totalhp) * 100;
                double strvariationR = Convert.ToDouble(Math.Round(strvariation));
                double spdvariationR = Convert.ToDouble(Math.Round(spdvariation));
                double hpvariationR = Convert.ToDouble(Math.Round(hpvariation));

                Random rnumenemy = new Random();
                double randomstr = rnumenemy.Next(1, 100);
                double randomspd = rnumenemy.Next(1, 100);
                double randomhp = rnumenemy.Next(1, 100);
                double enemypoints = 0;
                double playerpoints = 0;
                //strength variation check
                if (strvariationR > randomstr)
                {
                    playerpoints += 1;
                    enemypoints += 0;
                }
                else if (strvariationR < randomstr)
                {
                    playerpoints += 0;
                    enemypoints += 1;
                }
                else if (strvariationR == randomstr)
                {
                    playerpoints += 0.5;
                    enemypoints += 0.5;
                }
                //speed variation check
                if (spdvariationR > randomspd)
                {
                    playerpoints += 1;
                    enemypoints += 0;
                }
                else if (spdvariationR < randomspd)
                {
                    playerpoints += 0;
                    enemypoints += 1;
                }
                else if (spdvariationR == randomspd)
                {
                    playerpoints += 0.5;
                    enemypoints += 0.5;
                }
                //hp variation check
                if (hpvariationR > randomhp)
                {
                    playerpoints += 1;
                    enemypoints += 0;
                }
                else if (strvariationR < randomhp)
                {
                    playerpoints += 0;
                    enemypoints += 1;
                }
                else if (hpvariationR == randomhp)
                {
                    playerpoints += 0.5;
                    enemypoints += 0.5;
                }

                double totalplayer = PlayerStats[0] + PlayerStats[1] + PlayerStats[2];
                double totalenemy = EnemyStats[0] + EnemyStats[1] + EnemyStats[2];
                double totalstats = totalenemy + totalplayer;
                double variation = (totalplayer / totalstats) * 100;
                double chance = Convert.ToDouble(Math.Round(variation));

                Console.Write("Chances of winning = " + chance + "%");
                
                //fight
                choice = Paths(2);
                //before fight Paths
                while (choice == 1 || choice == 2)
                {

                    choice = Paths(2);
                }

                //luck
                Random rnum = new Random();
                int random = rnum.Next(1, 100);

                //result
                if (playerpoints > enemypoints)
                {
                    Console.WriteLine("You WIN!!");
                    win = true;
                }
                else if (playerpoints < enemypoints)
                {
                    Console.WriteLine("you lost, better luck next time");
                    win = false;
                }
                else if (playerpoints == enemypoints)
                {
                    Console.WriteLine("it was a tie, so close!");
                    win = false;
                }

                //earnings
                if (win == true && xp < 1000)
                {
                    xp += 10;
                    money += 5;
                    //level up
                    switch (xp)
                    {
                        case 100:
                            level = 2;
                            upgradePoints += 5;
                            xpRemaining = 250;
                            break;

                        case 250:
                            level = 3;
                            upgradePoints += 5;
                            xpRemaining = 560;
                            break;

                        case 560:
                            level = 4;
                            upgradePoints += 5;
                            xpRemaining = 1000;
                            break;
                        case 1000:
                            level = 5;
                            upgradePoints += 5;
                            break;
                    }
                }
                else if (win == true && xp >= 1000)
                {
                    money += 5;
                }
                //print earnings
                blank();
                Console.Write("your Xp = "); Console.Write(xp); Console.Write(" of "); Console.WriteLine(xpRemaining);
                Console.Write("your money = "); Console.WriteLine(money);
                Console.Write("your level ="); Console.WriteLine(level);
                Console.Write("upgrade points ="); Console.WriteLine(upgradePoints);

                //path
                choice = Paths(1);

                //loop
                gamecount++;

            }
        }

        //methods
        //methods
        //methods
        //methods
        public void Continue()
        {
            blank();
            Console.WriteLine("Press enter to continue...");
            Console.ReadLine();
            clear();
        }

        public static void blank()
        {
            Console.WriteLine("");
        }

        public static void clear()
        {
            Console.Clear();
        }

        public static int Paths(int x)
        {
            blank();

            Console.WriteLine("- type exit to exit application");
            Console.WriteLine("- type shop to go to shop");
            Console.WriteLine("- type upgrade to go to upgrade panel");
            if (x == 1)
            {
                Console.WriteLine("- press enter to continue");
            }
            else if (x == 2)
            {
                Console.WriteLine("- press enter to fight");
            }

            blank();
            string input = Console.ReadLine();
            int election = 0;
            if (input == "exit")
            {
                election = 0;
                blank();
                Console.WriteLine("Are you sure you want to exit? All progress will be lost.");
                string response = Console.ReadLine();
                if (response == "yes")
                {
                    Environment.Exit(0);
                }
                else if (response == "no")
                {

                }
            }
            else if (input == "shop")
            {
                election = 1;
            }
            else if (input == "upgrade")
            {
                election = 2;
            }
            clear();
            return election;
        }

        public static int choices()
        {
            int x = 0;
            return x;
        }
    }
}

