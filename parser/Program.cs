using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace parser
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int length = 5;
            int i = 0;
            Console.WriteLine();
            Thread.Sleep(300);
            Console.WriteLine("    ██▓     ▒█████   ███▄ ▄███▓ ▄▄▄        ██████ ▄▄▄█████▓▓█████  ██▀███  ");
            Thread.Sleep(300);
            Console.WriteLine("   ▓██▒    ▒██▒  ██▒▓██▒▀█▀ ██▒▒████▄    ▒██    ▒ ▓  ██▒ ▓▒▓█   ▀ ▓██ ▒ ██▒");
            Thread.Sleep(300);
            Console.WriteLine("   ▒██░    ▒██░  ██▒▓██    ▓██░▒██  ▀█▄  ░ ▓██▄   ▒ ▓██░ ▒░▒███   ▓██ ░▄█ ▒");
            Thread.Sleep(300);
            Console.WriteLine("   ▒██░    ▒██   ██░▒██    ▒██ ░██▄▄▄▄██   ▒   ██▒░ ▓██▓ ░ ▒▓█  ▄ ▒██▀▀█▄  ");
            Thread.Sleep(300);
            Console.WriteLine("   ░██████▒░ ████▓▒░▒██▒   ░██▒ ▓█   ▓██▒▒██████▒▒  ▒██▒ ░ ░▒████▒░██▓ ▒██▒");
            Thread.Sleep(300);
            Console.WriteLine("   ░ ▒░▓  ░░ ▒░▒░▒░ ░ ▒░   ░  ░ ▒▒   ▓▒█░▒ ▒▓▒ ▒ ░  ▒ ░░   ░░ ▒░ ░░ ▒▓ ░▒▓░");
            Thread.Sleep(300);
            Console.WriteLine("   ░ ░ ▒  ░  ░ ▒ ▒░ ░  ░      ░  ▒   ▒▒ ░░ ░▒  ░ ░    ░     ░ ░  ░  ░▒ ░ ▒░");
            Thread.Sleep(300);
            Console.WriteLine("     ░ ░   ░ ░ ░ ▒  ░      ░     ░   ▒   ░  ░  ░    ░         ░     ░░   ░ ");
            Thread.Sleep(300);
            Console.WriteLine(" Beta 0.2  ░  ░    ░ ░         ░         ░  ░      ░              ░  ░   ░   ");
            Thread.Sleep(300);
            Console.WriteLine(" ---------------------------------------------------------------------------");
            Console.WriteLine(" [1] - i.imgur.com");
            Console.WriteLine(" [2] - Help  ");
            Console.WriteLine(" [3] - Exit");
            Console.WriteLine(" ---------------------------------------------------------------------------");


            Console.Write(" Enter: ");
            string what = Console.ReadLine();

            if (what == "1") {
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine("    ██▓     ▒█████   ███▄ ▄███▓ ▄▄▄        ██████ ▄▄▄█████▓▓█████  ██▀███  ");
                Console.WriteLine("   ▓██▒    ▒██▒  ██▒▓██▒▀█▀ ██▒▒████▄    ▒██    ▒ ▓  ██▒ ▓▒▓█   ▀ ▓██ ▒ ██▒");
                Console.WriteLine("   ▒██░    ▒██░  ██▒▓██    ▓██░▒██  ▀█▄  ░ ▓██▄   ▒ ▓██░ ▒░▒███   ▓██ ░▄█ ▒");
                Console.WriteLine("   ▒██░    ▒██   ██░▒██    ▒██ ░██▄▄▄▄██   ▒   ██▒░ ▓██▓ ░ ▒▓█  ▄ ▒██▀▀█▄  ");
                Console.WriteLine("   ░██████▒░ ████▓▒░▒██▒   ░██▒ ▓█   ▓██▒▒██████▒▒  ▒██▒ ░ ░▒████▒░██▓ ▒██▒");
                Console.WriteLine("   ░ ▒░▓  ░░ ▒░▒░▒░ ░ ▒░   ░  ░ ▒▒   ▓▒█░▒ ▒▓▒ ▒ ░  ▒ ░░   ░░ ▒░ ░░ ▒▓ ░▒▓░");
                Console.WriteLine("   ░ ░ ▒  ░  ░ ▒ ▒░ ░  ░      ░  ▒   ▒▒ ░░ ░▒  ░ ░    ░     ░ ░  ░  ░▒ ░ ▒░");
                Console.WriteLine("     ░ ░   ░ ░ ░ ▒  ░      ░     ░   ▒   ░  ░  ░    ░         ░     ░░   ░ ");
                Console.WriteLine(" Beta 0.2  ░  ░    ░ ░         ░         ░  ░      ░              ░  ░   ░   ");
                Console.WriteLine(" ---------------------------------------------------------------------------");
                Console.WriteLine(" [1] - .png");
                Console.WriteLine(" [2] - .jpg  ");
                Console.WriteLine(" [3] - .gif");
                Console.WriteLine(" [4] - .all ");
                Console.WriteLine(" ---------------------------------------------------------------------------");

                Console.Write(" Enter: ");
                string what1 = Console.ReadLine();
                if (what1 == "1") 
                {
                    Console.Clear();
                    Console.WriteLine();
                    Console.WriteLine("    ██▓     ▒█████   ███▄ ▄███▓ ▄▄▄        ██████ ▄▄▄█████▓▓█████  ██▀███  ");
                    Console.WriteLine("   ▓██▒    ▒██▒  ██▒▓██▒▀█▀ ██▒▒████▄    ▒██    ▒ ▓  ██▒ ▓▒▓█   ▀ ▓██ ▒ ██▒");
                    Console.WriteLine("   ▒██░    ▒██░  ██▒▓██    ▓██░▒██  ▀█▄  ░ ▓██▄   ▒ ▓██░ ▒░▒███   ▓██ ░▄█ ▒");
                    Console.WriteLine("   ▒██░    ▒██   ██░▒██    ▒██ ░██▄▄▄▄██   ▒   ██▒░ ▓██▓ ░ ▒▓█  ▄ ▒██▀▀█▄  ");
                    Console.WriteLine("   ░██████▒░ ████▓▒░▒██▒   ░██▒ ▓█   ▓██▒▒██████▒▒  ▒██▒ ░ ░▒████▒░██▓ ▒██▒");
                    Console.WriteLine("   ░ ▒░▓  ░░ ▒░▒░▒░ ░ ▒░   ░  ░ ▒▒   ▓▒█░▒ ▒▓▒ ▒ ░  ▒ ░░   ░░ ▒░ ░░ ▒▓ ░▒▓░");
                    Console.WriteLine("   ░ ░ ▒  ░  ░ ▒ ▒░ ░  ░      ░  ▒   ▒▒ ░░ ░▒  ░ ░    ░     ░ ░  ░  ░▒ ░ ▒░");
                    Console.WriteLine("     ░ ░   ░ ░ ░ ▒  ░      ░     ░   ▒   ░  ░  ░    ░         ░     ░░   ░ ");
                    Console.WriteLine(" Beta 0.2  ░  ░    ░ ░         ░         ░  ░      ░              ░  ░   ░   ");
                    Console.WriteLine(" ---------------------------------------------------------------------------");

                    while (true) {
                        string g = GenerateStr(length);
                        string result = "https://i.imgur.com/" + g + ".png";
                        WebClient webcl = new WebClient();
                        webcl.DownloadFile(result, g + ".png");
                        i++;
                        Console.WriteLine(" " + i + ". " + result + " | Successful download!");
                    }
                    
                }
                else if (what1 == "2")  
                {
                    Console.Clear();
                    Console.WriteLine();
                    Console.WriteLine("    ██▓     ▒█████   ███▄ ▄███▓ ▄▄▄        ██████ ▄▄▄█████▓▓█████  ██▀███  ");
                    Console.WriteLine("   ▓██▒    ▒██▒  ██▒▓██▒▀█▀ ██▒▒████▄    ▒██    ▒ ▓  ██▒ ▓▒▓█   ▀ ▓██ ▒ ██▒");
                    Console.WriteLine("   ▒██░    ▒██░  ██▒▓██    ▓██░▒██  ▀█▄  ░ ▓██▄   ▒ ▓██░ ▒░▒███   ▓██ ░▄█ ▒");
                    Console.WriteLine("   ▒██░    ▒██   ██░▒██    ▒██ ░██▄▄▄▄██   ▒   ██▒░ ▓██▓ ░ ▒▓█  ▄ ▒██▀▀█▄  ");
                    Console.WriteLine("   ░██████▒░ ████▓▒░▒██▒   ░██▒ ▓█   ▓██▒▒██████▒▒  ▒██▒ ░ ░▒████▒░██▓ ▒██▒");
                    Console.WriteLine("   ░ ▒░▓  ░░ ▒░▒░▒░ ░ ▒░   ░  ░ ▒▒   ▓▒█░▒ ▒▓▒ ▒ ░  ▒ ░░   ░░ ▒░ ░░ ▒▓ ░▒▓░");
                    Console.WriteLine("   ░ ░ ▒  ░  ░ ▒ ▒░ ░  ░      ░  ▒   ▒▒ ░░ ░▒  ░ ░    ░     ░ ░  ░  ░▒ ░ ▒░");
                    Console.WriteLine("     ░ ░   ░ ░ ░ ▒  ░      ░     ░   ▒   ░  ░  ░    ░         ░     ░░   ░ ");
                    Console.WriteLine(" Beta 0.2  ░  ░    ░ ░         ░         ░  ░      ░              ░  ░   ░   ");
                    Console.WriteLine(" ---------------------------------------------------------------------------");
                    while (true) {
                        string g = GenerateStr(length);
                        string result = "https://i.imgur.com/" + g + ".jpg";
                        WebClient webcl = new WebClient();
                        webcl.DownloadFile(result, g + ".jpg");
                        i++;
                        Console.WriteLine(" " + i + ". " + result + " | Successful download!");

                    }
                }
                else if (what1 == "3")
                {
                    Console.Clear();
                    Console.WriteLine();
                    Console.WriteLine("    ██▓     ▒█████   ███▄ ▄███▓ ▄▄▄        ██████ ▄▄▄█████▓▓█████  ██▀███  ");
                    Console.WriteLine("   ▓██▒    ▒██▒  ██▒▓██▒▀█▀ ██▒▒████▄    ▒██    ▒ ▓  ██▒ ▓▒▓█   ▀ ▓██ ▒ ██▒");
                    Console.WriteLine("   ▒██░    ▒██░  ██▒▓██    ▓██░▒██  ▀█▄  ░ ▓██▄   ▒ ▓██░ ▒░▒███   ▓██ ░▄█ ▒");
                    Console.WriteLine("   ▒██░    ▒██   ██░▒██    ▒██ ░██▄▄▄▄██   ▒   ██▒░ ▓██▓ ░ ▒▓█  ▄ ▒██▀▀█▄  ");
                    Console.WriteLine("   ░██████▒░ ████▓▒░▒██▒   ░██▒ ▓█   ▓██▒▒██████▒▒  ▒██▒ ░ ░▒████▒░██▓ ▒██▒");
                    Console.WriteLine("   ░ ▒░▓  ░░ ▒░▒░▒░ ░ ▒░   ░  ░ ▒▒   ▓▒█░▒ ▒▓▒ ▒ ░  ▒ ░░   ░░ ▒░ ░░ ▒▓ ░▒▓░");
                    Console.WriteLine("   ░ ░ ▒  ░  ░ ▒ ▒░ ░  ░      ░  ▒   ▒▒ ░░ ░▒  ░ ░    ░     ░ ░  ░  ░▒ ░ ▒░");
                    Console.WriteLine("     ░ ░   ░ ░ ░ ▒  ░      ░     ░   ▒   ░  ░  ░    ░         ░     ░░   ░ ");
                    Console.WriteLine(" Beta 0.2  ░  ░    ░ ░         ░         ░  ░      ░              ░  ░   ░   ");
                    Console.WriteLine(" ---------------------------------------------------------------------------");
                    while (true) {
                        string g = GenerateStr(length);
                        string result = "https://i.imgur.com/" + g + ".gif";
                        WebClient webcl = new WebClient();
                        webcl.DownloadFile(result, g + ".gif");
                        i++;
                        Console.WriteLine(" " + i + ". " + result + " | Successful download!");
                    }

                }
                else if (what1 == "4")
                {
                    Console.Clear();
                    Console.WriteLine();
                    Console.WriteLine("    ██▓     ▒█████   ███▄ ▄███▓ ▄▄▄        ██████ ▄▄▄█████▓▓█████  ██▀███  ");
                    Console.WriteLine("   ▓██▒    ▒██▒  ██▒▓██▒▀█▀ ██▒▒████▄    ▒██    ▒ ▓  ██▒ ▓▒▓█   ▀ ▓██ ▒ ██▒");
                    Console.WriteLine("   ▒██░    ▒██░  ██▒▓██    ▓██░▒██  ▀█▄  ░ ▓██▄   ▒ ▓██░ ▒░▒███   ▓██ ░▄█ ▒");
                    Console.WriteLine("   ▒██░    ▒██   ██░▒██    ▒██ ░██▄▄▄▄██   ▒   ██▒░ ▓██▓ ░ ▒▓█  ▄ ▒██▀▀█▄  ");
                    Console.WriteLine("   ░██████▒░ ████▓▒░▒██▒   ░██▒ ▓█   ▓██▒▒██████▒▒  ▒██▒ ░ ░▒████▒░██▓ ▒██▒");
                    Console.WriteLine("   ░ ▒░▓  ░░ ▒░▒░▒░ ░ ▒░   ░  ░ ▒▒   ▓▒█░▒ ▒▓▒ ▒ ░  ▒ ░░   ░░ ▒░ ░░ ▒▓ ░▒▓░");
                    Console.WriteLine("   ░ ░ ▒  ░  ░ ▒ ▒░ ░  ░      ░  ▒   ▒▒ ░░ ░▒  ░ ░    ░     ░ ░  ░  ░▒ ░ ▒░");
                    Console.WriteLine("     ░ ░   ░ ░ ░ ▒  ░      ░     ░   ▒   ░  ░  ░    ░         ░     ░░   ░ ");
                    Console.WriteLine(" Beta 0.2  ░  ░    ░ ░         ░         ░  ░      ░              ░  ░   ░   ");
                    Console.WriteLine(" ---------------------------------------------------------------------------");
                    while (true) {
                        string g = GenerateStr(length);
                        string result = "https://i.imgur.com/" + g + ".png";
                        WebClient webcl = new WebClient();
                        webcl.DownloadFile(result, g + ".png");
                        i++;
                        
                        Console.WriteLine(" " + i + ". " + result + " | Successful download!");
                       

                        string g1 = GenerateStr(length);
                        string result1 = "https://i.imgur.com/" + g + ".jpg";
                        WebClient webcl1 = new WebClient();
                        webcl.DownloadFile(result1, g + ".jpg");
                        i++;
                        
                        Console.WriteLine(" " + i + ". " + result1 + " | Successful download!");
                        

                        string g2 = GenerateStr(length);
                        string result2 = "https://i.imgur.com/" + g + ".gif";
                        WebClient webcl2 = new WebClient();
                        webcl.DownloadFile(result2, g + ".gif");
                        i++;   
                        Console.WriteLine(" " + i + ". " + result2 + " | Successful download!");
                   

                    }
                    


                }



            } 


            } 
        public static string GenerateStr(int length)
        {
            const string chars = "0123456789abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";

            StringBuilder sb = new StringBuilder();
            Random rnd = new Random();

            for (int i = 0; i < length; i++)
            {
                int index = rnd.Next(chars.Length);
                sb.Append(chars[index]);
            }
            return sb.ToString();
        }

    }
}
