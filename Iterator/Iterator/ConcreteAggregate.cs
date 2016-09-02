using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    public class ConcreteAggregate : Aggregate // this is the ConcreteAggregate class from the UML
    {
        public ConcreteAggregate()
        {
            Elements = new List<string>();
        }
        public override Iterator createIterator()
        {
            return new ConcreteIterator(this);
        }
        public override Iterator createIteratorShort()
        {
            return new ConcreteIteratorShort(this);
        }
    } 
}
