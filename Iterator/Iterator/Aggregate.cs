using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    public abstract class Aggregate //this is the Aggregate class from the UML
    {
        public List<string> Elements;

        public abstract Iterator createIterator();

        public abstract Iterator createIteratorShort();
    }
}
