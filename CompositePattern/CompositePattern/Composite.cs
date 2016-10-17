using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern
{
    public class Composite : Component
    {
        private string className;
        
        public int power;
        public List<Component> classes = new List<Component>();

        public Composite(string theClass, Component R1, Component R2)
        {
            
            className = theClass;
            addClass(R1);
            addClass(R2);

        }
        public Composite(string theClass, Component R1, Component R2, Component R3)
        {

            className = theClass;
            addClass(R1);
            addClass(R2);
            addClass(R3);

        }

        public void addClass(Component c)
        {
            classes.Add(c);
        }

        public void removeClass(Component c)
        {
            classes.Remove(c);
        }

        public Component getClasses(int index)
        {
            return classes[index];
        }

        public int getStrength()
        {
            
            return power;
        }

        public override string ToString()
        {
            return className;
        }

        
    }
}
