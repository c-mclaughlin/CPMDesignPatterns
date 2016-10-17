using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern
{
    public class Leaf : Component
    {
        
        private string className;
        private int strength;
        

        public Leaf(string theClass, int theStrength)
        {
            strength = theStrength;
            className = theClass;
            
        }

        public int getStrength()
        {
            
            return strength;
        }


        public override string ToString()
        {
            return className;
        }

      
    }
}
