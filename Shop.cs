using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learning_c_sharp
{
    class Shop
    {
        Player player = new Player();
        Method method = new Method();
        
        public void shop()
        {


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
    }
}
