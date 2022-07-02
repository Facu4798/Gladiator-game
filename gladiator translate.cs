using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learning_c_sharp
{
    class gladiator_translate
    {

        public static void Main(string[] args)
        {
            //objects summoning
            Player player = new Player();
            Method method = new Method();
            //intro
            method.blank();
            Console.WriteLine("HELLO USER");
            method.blank();
            Console.WriteLine("Please enter your name...");
            method.blank();
            string name = Console.ReadLine();
            method.clear();

            //class selection
            int i = 0;
            while (i == 0)
            {
                Console.WriteLine("Welcome to the arena, " + name);
                method.blank();
                Console.WriteLine("Please select your class");
                method.blank();
                Console.WriteLine("A. balanced");
                Console.WriteLine("B. Tank");
                Console.WriteLine("C. Thief");
                method.blank();
                Console.WriteLine("Type the upper case letter");
                method.blank();
                string ClassSelect = Console.ReadLine();

                switch (ClassSelect)
                {
                    case "a":
                        player.balanced();
                        i = 1;
                        break;
                    case "b":
                        player.tank();
                        i = 1;
                        break;
                    case "c":
                        player.thief();
                        i = 1;
                        break;
                    case "exit":
                        Environment.Exit(0);
                        break;
                }
                method.clear();
            }

            // initial stats
            Console.WriteLine("Excellent Choice");
            Console.Write("your stats :"); Console.WriteLine(player.classtype);
            method.blank();
            Console.Write("Strength = "); Console.WriteLine(player.strength);
            Console.Write("Speed    = "); Console.WriteLine(player.speed);
            Console.Write("Life     = "); Console.WriteLine(player.health);
            method.blank();
            Paths(1);




            void upgrade()
            {
                method.clear();
                //info
                Console.WriteLine("SHOP");
                method.blank();
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

            void shop()
            {
                method.clear();
                //info
                Console.WriteLine("Your money : $" + player.money);
                //sword level check price assignment
                int swordprice = 0;
                Console.Write("Level " + (player.swordlvl + 1) + " Sword : ");
                switch (player.swordlvl)
                {
                    case 0:
                        Console.WriteLine("$10");
                        swordprice = 10;
                        break;

                    case 1:
                        Console.WriteLine("$20");
                        swordprice = 20;
                        break;

                    case 2:
                        Console.WriteLine("$30");
                        swordprice = 30;
                        break;

                    case 3:
                        Console.WriteLine("$40");
                        swordprice = 40;
                        break;

                    case 4:
                        Console.WriteLine("$50");
                        swordprice = 50;
                        break;

                    case 5:
                        Console.WriteLine("Fully upgraded!");
                        break;
                }
                //shield level check price assignment
                int shieldprice = 0;
                Console.Write("Level " + (player.shieldlvl + 1) + " Shield : ");
                switch (player.shieldlvl)
                {
                    case 0:
                        Console.WriteLine("$10");
                        shieldprice = 10;
                        break;

                    case 1:
                        Console.WriteLine("$20");
                        shieldprice = 20;
                        break;

                    case 2:
                        Console.WriteLine("$30");
                        shieldprice = 30;
                        break;

                    case 3:
                        Console.WriteLine("$40");
                        shieldprice = 40;
                        break;

                    case 4:
                        Console.WriteLine("$50");
                        shieldprice = 50;
                        break;

                    case 5:
                        Console.WriteLine("Fully upgraded!");
                        break;
                }
                //armor level check price assignment
                int armorprice = 0;
                Console.Write("Level " + (player.armorlvl + 1) + " Armor : ");
                switch (player.armorlvl)
                {
                    case 0:
                        Console.WriteLine("$15");
                        armorprice = 15;
                        break;

                    case 1:
                        Console.WriteLine("$30");
                        armorprice = 30;
                        break;

                    case 2:
                        Console.WriteLine("$50");
                        armorprice = 50;
                        break;

                    case 3:
                        Console.WriteLine("$75");
                        armorprice = 75;
                        break;

                    case 4:
                        Console.WriteLine("$100");
                        armorprice = 100;
                        break;

                    case 5:
                        Console.WriteLine("Fully upgraded!");
                        break;
                }
                //purchase choice
                method.blank();

                Console.WriteLine("Which item do you choose to upgrade?");
                string shopchoice = Console.ReadLine();
                if (shopchoice == "sword")
                {
                    if (swordprice <= player.money && player.swordlvl < 5)
                    {
                        player.money -= swordprice;
                        player.swordlvl += 1;
                        //stat augmentation
                        switch (player.swordlvl)
                        {
                            case 1:
                                player.strength += 10;
                                break;
                            case 2:
                                player.strength += 15;
                                break;
                            case 3:
                                player.strength += 25;
                                break;
                            case 4:
                                player.strength += 45;
                                break;
                            case 5:
                                player.strength += 70;
                                break;
                        }
                        Console.WriteLine("Successfully upgraded: sword. Strength incremented to " + player.strength);
                    }
                    else if (swordprice > player.money && player.swordlvl < 5)
                    {
                        Console.WriteLine("insufficient funds");
                        method.Continue();
                    }
                    else
                    {
                        Console.WriteLine("Fully upgraded");
                    }
                }
                else if (shopchoice == "shield")
                {
                    if (shieldprice <= player.money && player.shieldlvl < 5)
                    {
                        player.money -= shieldprice;
                        player.shieldlvl += 1;
                        switch (player.shieldlvl)
                        {
                            case 1:
                                player.health += 10;
                                break;
                            case 2:
                                player.health += 15;
                                break;
                            case 3:
                                player.health += 25;
                                break;
                            case 4:
                                player.health += 45;
                                break;
                            case 5:
                                player.health += 70;
                                break;
                        }
                        Console.WriteLine("Successfully upgraded: shield. Health incremented to " + player.health);
                    }
                    else if (shieldprice > player.money && player.shieldlvl < 5)
                    {
                        Console.WriteLine("insufficient funds");
                        method.Continue();
                    }
                    else
                    {
                        Console.WriteLine("Fully upgraded");
                    }
                }
                else if (shopchoice == "armor")
                {
                    if (armorprice <= player.money && player.armorlvl < 5)
                    {
                        player.money -= armorprice;
                        player.armorlvl += 1;
                        switch (player.armorlvl)
                        {
                            case 1:
                                player.speed += 10;
                                break;
                            case 2:
                                player.speed += 15;
                                break;
                            case 3:
                                player.speed += 25;
                                break;
                            case 4:
                                player.speed += 45;
                                break;
                            case 5:
                                player.speed += 70;
                                break;
                        }
                        Console.WriteLine("Successfully upgraded: armor");
                    }
                    else if (armorprice > player.money && player.armorlvl < 5)
                    {
                        Console.WriteLine("insufficient funds");
                        method.Continue();
                    }
                    else
                    {
                        Console.WriteLine("Fully upgraded");
                    }
                }
            }

            void Paths(int x)
            {
                int ploop = 0;
                while (ploop == 0)
                {
                    method.blank();
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

                    method.blank();
                    string input = Console.ReadLine();
                    if (input == "exit")
                    {
                        method.blank();
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
                        shop();
                    }
                    else if (input == "upgrade")
                    {
                        upgrade();
                    }
                    method.clear();
                }
            }
        }
    }
}
