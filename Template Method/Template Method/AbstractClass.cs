using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template_Method
{
    public abstract class AbstractClass
    {
        

        public abstract string listMarvel();

        public abstract string listDC();

        public void Template_Method()
        {
            listMarvel();
            listDC();
        }
    }
}
