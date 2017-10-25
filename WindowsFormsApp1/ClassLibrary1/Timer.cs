using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace ClassLibrary1
{
    class Timer
    {
        public Timer newTimer = new Timer();
        String timerIN;

        public Timer()
        {
            SetTimer(timerIN);
        }
         
        public void SetTimer(string a)
        {
            newTimer.SetTimer(a);          

        }
    }
}
