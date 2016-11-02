using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern
{
    public class Proxy : Types
    {
        RealTypes _realTypes = new RealTypes();
        public override bool Results(string Player1, string Player2)
        {
            return _realTypes.Results(Player1, Player2);
        }
    }
}
