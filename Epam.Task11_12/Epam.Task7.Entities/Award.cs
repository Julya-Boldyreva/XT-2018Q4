using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Drawing;

namespace Epam.Task7.Entities
{
    public class Award
    {
        private string id;
        private string title;
       // private string img;

        public Award(string title)
        {
            this.id = $"A{DateTime.Now:ddMMyyyyHHmmssffff}";
            this.title = title;
           // this.img = ImgToStr("C:\\Users\\Юля\\Documents\\GitHub\\XT-2018Q4\\Epam.Task11_12\\Epam.Task11_12.WebPL\\App_Data\\Images\\default_ava.png");
        }

        public Award(string id, string title)
        {
            this.id = id;
            this.title = title;
        }

        public Award(int id, string title)
        {
            this.id = id.ToString();
            this.title = title;
        }

       /* public Award(string title, string path)
        {
            this.id = $"A{DateTime.Now:ddMMyyyyHHmmssffff}";
            this.title = title;
            this.img = ImgToStr(path);
        }*/

        public string Title
        {
            get
            {
                return this.title;
            }

            set
            {
                this.title = value;
            }
        }

        public string Id
        {
            get
            {
                return this.id;
            }
        }

       /* public Image Img
        {
            get
            {
                return StrToImg(this.img);
            }
        }

        public string StrImg
        {
            get
            {
                return this.img;
            }
        }
        */

        public override string ToString()
        {
            return $"{Title} ";
        }

        public static string ImgToStr(string filename)
        {
            MemoryStream Memostr = new MemoryStream();
            Image img = Image.FromFile(filename);
            img.Save(Memostr, img.RawFormat);
            byte[] arrayimg = Memostr.ToArray();
            return Convert.ToBase64String(arrayimg);
        }

        public static Image StrToImg(string StrImg)
        {
            byte[] arrayimg = Convert.FromBase64String(StrImg);
            Image imageStr = Image.FromStream(new MemoryStream(arrayimg));
            return imageStr;
        }
    }
}
