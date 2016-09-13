using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    public class UniversalRemote
    {
        private TV m_tv;
        private SurroundSound m_ss;
        private DVD m_dvd;
        private Game m_gs;

        public UniversalRemote(TV tv, SurroundSound ss, DVD dvd, Game gs)
        {
            m_tv = tv;
            m_ss = ss;
            m_dvd = dvd;
            m_gs = gs;
        }

        
    }
}
