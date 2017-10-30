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
        public static DateTime aDay = DateTime.Now.AddDays(1);
        public static DateTime sevenDays = DateTime.Now.AddDays(7);
        public static DateTime aMonth = DateTime.Now.AddMonths(1);


        public static void setNewInterval()
        {
            CompareXml checkXml = new CompareXml();
            checkXml.Compare("e");

        }
        public static void updateTitles(List<string> titles)
        {
            foreach (string title in titles)
            {
                CompareXml CX = new CompareXml();
                CX.Compare(title);
                XmlHandler.setNextupdate(title);
            }
        }
        public static List<string> toBeUpdatedList()
        {
            List<string> listan = new List<string>();
            listan = XmlHandler.getNextUpdate();
            return listan;
        }


        /*public static bool compareDates(string date)
        {
            DateTime dt = Convert.ToDateTime(date);
            int result = DateTime.Compare(now, dt);
            if (result >= 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }*/

    }
    
}
