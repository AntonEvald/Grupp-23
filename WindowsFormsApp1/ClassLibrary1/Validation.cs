using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace ClassLibrary1
{
    public class Validation
    {
        public static bool textNotEmpty(string s)
        {
            try
            {
                if (s == "" )
                {
                    return true;
                    throw new System.ArgumentException("Textfield is empty");


                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {
                
                throw;
            }
            
        }
    }

}
