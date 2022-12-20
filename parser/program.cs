using System;

namespace parser
{
    internal class program
    {
        static void Main(string[] args)
        { 
            logo main = new logo();
            generator gn = new generator();

            main.Main();
            Console.Write(" Enter: ");
            string what = Console.ReadLine();

            if (what == "1") {
                main.Format();
                Console.Write(" Enter: ");
                string what1 = Console.ReadLine();
                if (what1 == "1")
                {
                    main.Logo();
                    while (true) {
                        gn.GenerateLink(".png");
                    }

                }
                else if (what1 == "2")
                {
                    main.Logo();
                    while (true)
                    {
                        gn.GenerateLink(".jpg");
                    }
                }
                else if (what1 == "3")
                {
                    main.Logo();
                    while (true)
                    {
                        gn.GenerateLink(".gif");
                    }
                }
                else if (what1 == "4")
                {
                    main.Logo();
                    while (true) {
                        gn.GenerateLink(".png");
                        gn.GenerateLink(".jpg");
                        gn.GenerateLink(".gif");
                    }
                }
                else if (what1 == "5")
                {
                    main.Logo();
                    Console.WriteLine(" Example: .jpeg");
                    Console.Write(" Enter Format: ");
                    string whatFormat = Console.ReadLine();
                    Console.Clear();
                    main.Logo();
                    while (true)
                    {
                        gn.GenerateLink(whatFormat);
                    }
                }
            }
            else if (what == "2")
            {
                main.Format();
                Console.Write(" Enter: ");
                string what1 = Console.ReadLine();
                if (what1 == "1")
                {
                    main.Logo();
                    while (true)
                    {
                        gn.GenerateLinkSpeed(".png");
                    }

                }
                else if (what1 == "2")
                {
                    main.Logo();
                    while (true)
                    {
                        gn.GenerateLinkSpeed(".jpg");
                    }
                }
                else if (what1 == "3")
                {
                    main.Logo();
                    while (true)
                    {
                        gn.GenerateLinkSpeed(".gif");
                    }
                }
                else if (what1 == "4")
                {
                    main.Logo();
                    while (true)
                    {
                        gn.GenerateLinkSpeed(".png");
                        gn.GenerateLinkSpeed(".jpg");
                        gn.GenerateLinkSpeed(".gif");
                    }
                }
                else if (what1 == "5")
                {
                    main.Logo();
                    Console.WriteLine(" Example: .jpeg");
                    Console.Write(" Enter Format: ");
                    string whatFormat = Console.ReadLine();
                    Console.Clear();
                    main.Logo();
                    while (true)
                    {
                        gn.GenerateLinkSpeed(whatFormat);
                    }
                }
            }
            else if (what == "3") {
                main.menuHelp();
            }
            else if (what == "4")
            {
                Environment.Exit(0);
            }
        } 
    }
}
