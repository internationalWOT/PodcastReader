using Data;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Logik
{
    public class LogikLager


    {
        XmlHanterare xmlHanterare = new XmlHanterare();

        public void remove(string category)
        {
            string path = Directory.GetCurrentDirectory() + @"\" + category;

            Directory.Delete(path, true);
        }

        public void remove(string category, string namn)

        {
            var fhe = Path.Combine(Directory.GetCurrentDirectory().ToString(), category, namn +@".xml");
            string path = Directory.GetCurrentDirectory() + @"\" + category + @"\" + namn + @".xml";

            File.Delete(path);
        }

        public void changePodName(string category, string oldName, string newName, ListBox lista)

        {
            
               
            string path1 = Directory.GetCurrentDirectory() + @"\" + category + @"\" + oldName + @".xml";
            string path2 = Directory.GetCurrentDirectory() + @"\" + category + @"\" + newName + @".xml";

            File.Move(path1, path2);
        }

        public void changePodcastLocation(string oldCategory, string newCategory, string namn, ComboBox combo)
        {
            string path1 = Directory.GetCurrentDirectory() + @"\" + oldCategory + @"\" + namn + @".xml";
            string path2 = Directory.GetCurrentDirectory() + @"\" + newCategory + @"\" + namn + @".xml";

            File.Move(path1, path2);
        }

        public void changeCategory(string oldCategory, string newName, ListBox lista, ComboBox combo)
        {
            string path1 = Directory.GetCurrentDirectory() + @"\" + oldCategory;
            string path2 = Directory.GetCurrentDirectory() + @"\" + newName;

            Directory.Move(path1, path2);
        }

    }

    

}
