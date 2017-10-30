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
        }

        public static void AddCategory(String c)
        {
            if (Validation.IsNewCat(c))
            {
                Categories.Add(c);
            }
        }

        public static void SaveCategories()
        {
            try
            {
                string path = System.Reflection.Assembly.GetExecutingAssembly().Location;
                string directory = Path.GetDirectoryName(path);
                string dirPath = directory + "//categories.txt";
                StreamWriter textWriter = new StreamWriter(dirPath, false);
                foreach (string category in Categories)
                {
                    textWriter.WriteLine(category);
                }
                textWriter.Close();
            }
            catch (IOException e)
            {
                throw new IOException ("Error", e);
            }
        }           

        

        public static void GetCategories()
        {
            try
            {
                string path = System.Reflection.Assembly.GetExecutingAssembly().Location;
                string directory = Path.GetDirectoryName(path);
                string dirPath = directory + "//categories.txt";
                if (!File.Exists(dirPath))
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
            catch (IOException)
            {
                throw;
            }
           
        }
    }
}
