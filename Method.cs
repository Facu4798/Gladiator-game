using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learning_c_sharp
{
    class Method
    {
        public void Continue()
        {
            blank();
            Console.WriteLine("Press enter to continue...");
            Console.ReadLine();
            clear();
        }

        public void blank()
        {
            Console.WriteLine("");
        }

        public void clear()
        {
            Console.Clear();
        }

        public int Paths(int x)
        {
            Method method = new Method();
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
    }
}
