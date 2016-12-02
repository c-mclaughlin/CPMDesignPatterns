using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template_Method
{
    public class ConcreteClass : AbstractClass
    {
        public override string listDC()
        {
            
            return "Batman, Superman, Green Lantern, Wonder Woman, and Nightwing.";
        } 

        public override string listMarvel()
        {
            return "Spider-Man, Captain America, Iron Man, Hulk, and Deadpool";
        }
    }
}
