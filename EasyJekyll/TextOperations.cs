using System;
using System.Collections.Generic;
using System.Text;

namespace EasyJekyll
{
    class TextOperations
    {
        public static String replaceSpace(String title) //replace Space with -
        {
            
            var builder = new StringBuilder();
            foreach ( var c in title)
            {
                if (c.ToString()[0] == ' ')
                {
                    builder.Append('-');
                }
                else
                {
                    builder.Append(c);
                }           }
            return builder.ToString();
        }
    }
}
