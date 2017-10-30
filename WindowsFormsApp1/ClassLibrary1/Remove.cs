using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary2;
using System.IO;

namespace ClassLibrary1
{
    public class Remove
    {

        public void RemoveMp3(string e)
        {


            System.IO.Directory.Delete(@"..\Mp3\" + e, true);

        }
      
    }
}
