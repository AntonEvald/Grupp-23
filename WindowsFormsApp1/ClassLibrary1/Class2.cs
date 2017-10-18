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

        public void AddCategory(String c)
        {
            if(c == null || Categories.Contains(c))
            {

            }
            else
            {
                Categories.Add(c);
            }
        }
    }
}
