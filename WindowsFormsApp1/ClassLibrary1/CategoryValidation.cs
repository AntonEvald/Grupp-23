using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public abstract class CategoryValidation
    {
        public virtual bool IsNewCat(String c)
        {
            c += c;
            return true;
        }

    }
}
