using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    public class ConcreteIteratorShort : Iterator
    {
        Aggregate aggregate;
        int CurrIndex;

        public ConcreteIteratorShort(Aggregate agg)
        {
            aggregate = agg;
        }

        public override object first()
        {
            CurrIndex = aggregate.Elements.Count - 1;
            return current();
        }

        public override object next()
        {
            if (!isDone())
                CurrIndex--;
            return current();
        }

        public override bool isDone()
        {
            return (CurrIndex < 0);
        }

        public override object current()
        {
            if (isDone())
                return null;
            return aggregate.Elements[CurrIndex];
        }
    }
}
