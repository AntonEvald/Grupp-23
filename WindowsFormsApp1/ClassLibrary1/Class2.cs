using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class ModifyCategories
    {
        public static List <string> Categories = new List<string>();

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
            try
            {
                if (c == null || Categories.Contains(c))
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            catch (Exception)
            {
                throw;
            }

        }
    }
}
