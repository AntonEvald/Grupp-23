using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ClassLibrary1
{
    public class ModifyCategories
    {
        public static List <string> Categories = new List<string>();

        public static void RemoveCategory(String c)
        {
            if(c != "")
            {
                Categories.Remove(c);
            }
            else
            {

            }
        }

        public static void AddCategory(String c)
        {
            try
            {
                if (validateNewCat(c))
                {
                    Categories.Add(c);
                }
            }
            catch (Exception)
            {

                throw;
            }

        }

        public static bool validateNewCat(string c)
        {
            foreach (string category in Categories)
            {
                if (c.Equals(category, StringComparison.InvariantCultureIgnoreCase))
                {
                    return false;
                }
            }
            if (Validation.textEmpty(c) || c.Equals("All", StringComparison.InvariantCultureIgnoreCase))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public static void SaveCategories()
        {
            string path = System.Reflection.Assembly.GetExecutingAssembly().Location;
            string directory = Path.GetDirectoryName(path);
            string dirPath = directory + "//categories.txt";
            StreamWriter textWriter = new StreamWriter(dirPath, false);
            try
            {
                foreach(string category in Categories)
                {
                    textWriter.WriteLine(category);
                }
                textWriter.Close();
            }
            catch (IOException)
            {

                throw;
            }

        }

        public static void GetCategories()
        {
            string path = System.Reflection.Assembly.GetExecutingAssembly().Location;
            string directory = Path.GetDirectoryName(path);
            string dirPath = directory + "//categories.txt";
            if(!File.Exists(dirPath))
            {
                StreamWriter sw = new StreamWriter(dirPath, false);
                sw.Close();
            }
            else
            {
                Categories.Clear();
                StreamReader sr = new StreamReader(dirPath, false);
                while (sr.Peek() != -1)
                {
                    string category = sr.ReadLine();
                    Categories.Add(category);
                }
                sr.Close();
            }      
        }
    }
}
