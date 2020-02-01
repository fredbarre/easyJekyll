using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.IO;

namespace EasyJekyll
{
    class Image
    {
        List<string> imgList = new List<string>();
        
        String title;
        String imgPath;

        public Image(String title,String imgPath)
        {
            this.title = title;
            this.imgPath = imgPath;
        }
        public void download(String url,String rename)
        {
            using (var client = new WebClient())
            {
                System.IO.Directory.CreateDirectory(imgPath + TextOperations.replaceSpace(title));
                client.DownloadFile(url, imgPath + TextOperations.replaceSpace(title) + @"/" + rename);
                imgList.Add(imgPath + TextOperations.replaceSpace(title) + @"/" + rename);
                
            }
        }

        public List<string> getimgList()
        {
            return imgList;
        }

        public void copy(String image)
        {

        }
    }
}
