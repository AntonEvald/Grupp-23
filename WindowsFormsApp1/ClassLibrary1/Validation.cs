﻿using System;
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
