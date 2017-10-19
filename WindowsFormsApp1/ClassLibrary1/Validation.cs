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
            
            if (s == "" )
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
