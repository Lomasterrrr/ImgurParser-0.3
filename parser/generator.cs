using System;
using System.Diagnostics;
using System.Net;
using System.Text; 

namespace parser
{
    internal class generator
    {
        public int length = 5;
        public int i = 0;
        
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
        
        public static string GenerateStrSpeed(int length)
        {
            const string chars = "0123456789";

            StringBuilder sb = new StringBuilder();
            Random rnd = new Random();

            for (int i = 0; i < length; i++)
            {
                int index = rnd.Next(chars.Length);
                sb.Append(chars[index]);
            }
            return sb.ToString();
        }

        public string GenerateLink(string format) 
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            string g = GenerateStr(length);
            string result = "https://i.imgur.com/" + g + format;
            WebClient webcl = new WebClient();
            webcl.DownloadFile(result, g + format);
            i++;
            stopwatch.Stop();
            Console.WriteLine(" " + result + " | Downloaded for: " + stopwatch.ElapsedMilliseconds + "ms" + "\t-| Count: " + i + "");
            return result;
            
        }
        
        public string GenerateLinkSpeed(string format)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            string g = GenerateStrSpeed(length);
            string result = "https://i.imgur.com/" + g + format;
            WebClient webcl = new WebClient();
            webcl.DownloadFile(result, g + format);
            i++;
            stopwatch.Stop();
            Console.WriteLine(" " + result);
            return result;

        }


    }
}
