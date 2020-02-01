using System;
using System.Collections.Generic;
using System.Text;

namespace EasyJekyll
{
    class UIcmd
    {

        public const String domain = "www.fredbarre.com/";
        public const String imageLink = "assets/images/";
        //public const String imageFolder = @"assets\images\";

        void start()
        {
            // Type your username and press enter
            Console.WriteLine("Enter the post title:");

            // Create a string variable and get user input from the keyboard and store it in the variable
            string title = Console.ReadLine();

            Image imagePack;
            imagePack = new Image(title, imageLink);

            string addimg = "yes";

            



            do
            {


                Console.WriteLine("Add an image ?(type yes or no");

                addimg = Console.ReadLine();

                if (addimg.Equals("no"))
                {
                    break;
                }

                Console.WriteLine("write the link of the image (local or online) only use the / separator for folders");

                String img = Console.ReadLine();

                Console.WriteLine("rename the file for an easier use");

                String rename = Console.ReadLine();

                imagePack.download(img, rename);
            } while (addimg.Equals("yes"));

            if (imagePack.getimgList().Count > 0)
            {
                Console.WriteLine("Here are all image(s) available for the shortcut images");
            }
            for(int i = 0; i < imagePack.getimgList().Count; i++)
            {
                Console.WriteLine(imagePack.getimgList()[i]);
            }

            Console.WriteLine("type your image link for the shortcut images");

            String shortimg = Console.ReadLine();

            Console.WriteLine("type your tags for your post ex:\n tag1, tag2, etc");

            String tags = Console.ReadLine();

            if (imagePack.getimgList().Count > 0)
            {
                Console.WriteLine("Here are all image(s) available for your post");
            }
            for (int i = 0; i < imagePack.getimgList().Count; i++)
            {
                Console.WriteLine(imagePack.getimgList()[i]);
            }

            Console.WriteLine("write down your blog post using markdown");

            String post = Console.ReadLine();
        }
    }
}
