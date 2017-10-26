using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using ClassLibrary2;


namespace ClassLibrary1
{
   

    public static class IntervalClass
    {
        public static DateTime now = DateTime.Now;
        public static DateTime sevenDays = DateTime.Now.AddDays(7);
        public static DateTime aMonth = DateTime.Now.AddMonths(1);

       
        public static void setNewInterval()
        {
            CompareXml checkXml = new CompareXml();
            checkXml.Comapare("e");

        }


    }
    
}
