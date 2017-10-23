using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace ClassLibrary1
{
    public class Validation
    {
        public static bool textEmpty(string s)
        {
            
            if (s == "" || s== null)
            {
                return true;   
            }
            else
            {
                return false;
            }
        }
        public static bool isNull(string s)
        {
            if(s == null)
            {
                return true;

            }
            else
            {
                return false;
            }
        }

        public static bool IsNewCat(string c)
        {
            foreach (string category in ModifyCategories.Categories)
            {
                if (c.Equals(category, StringComparison.InvariantCultureIgnoreCase))
                {
                    return false;
                }
            }
            if (c.Equals("All", StringComparison.InvariantCultureIgnoreCase))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public static bool IsXML(string s)
        {
            if (s.Contains("/rss"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        

    }

   

}
