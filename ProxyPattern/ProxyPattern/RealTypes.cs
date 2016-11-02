using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern
{
    public class RealTypes : Types
    {
        public override bool Results(string Player1, string Player2)
        {
            if((Player1 == "Fire" && Player2 == "Grass") ||
               (Player1 == "Water" && Player2 == "Fire") ||
               (Player1 == "Grass" && Player2 == "Water"))
            {
                return true;
            }
            return false;
            
        }
    }
}
