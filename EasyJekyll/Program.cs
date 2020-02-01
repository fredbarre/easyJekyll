using System;
using System.Net;

namespace EasyJekyll
{
    class Program
    {
        static void Main(string[] args)
        {
            Post p=new Post();
            p.exportToFile();

            String a =TextOperations.replaceSpace("abcde zadadad azed");

            Console.WriteLine("Hello World!224455   \n "+a);

            DateTime today = DateTime.Today;
            Console.WriteLine(today.ToString("yyyy-MM-dd"));
            
            using (var client = new WebClient())
            {
                client.DownloadFile(@"C:/Users/11/Desktop/TOTO.bmp", @"img3.bmp");
                //System.IO.Directory.CreateDirectory(@"line/fork/");
            }

        }
    }
}
