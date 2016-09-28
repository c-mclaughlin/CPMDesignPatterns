using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class Desktop : AbstractDesktop
    {
        public Desktop()
        {

        }

        public Desktop(ConcretePC.CPU m_CPUPart, ConcretePC.GPU m_GPUPart, ConcretePC.Ram m_RamPart)
        {
            Form2 f2 = new Form2(m_CPUPart,m_GPUPart,m_RamPart);
            f2.Visible = true;
        }
    }
    public class iMac : AbstractDesktop
    {
        public iMac()
        {

        }

        public iMac(ConcreteMac.CPU m_CPUPart, ConcreteMac.GPU m_GPUPart, ConcreteMac.Ram m_RamPart)
        {
            Form2 f2 = new Form2(m_CPUPart, m_GPUPart, m_RamPart);
            f2.Visible = true;
        }
    }
}
