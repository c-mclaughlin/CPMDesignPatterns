using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class Laptop : AbstractLaptop
    {
        public Laptop()
        {

        }

        public Laptop(ConcretePC.CPU m_CPUPart, ConcretePC.GPU m_GPUPart, ConcretePC.Ram m_RamPart)
        {
            Form2 f2 = new Form2(m_CPUPart, m_GPUPart, m_RamPart);
            f2.Visible = true;
        }
    }
    public class Macbook : AbstractLaptop
    {
        public Macbook()
        {

        }

        public Macbook(ConcreteMac.CPU m_CPUPart, ConcreteMac.GPU m_GPUPart, ConcreteMac.Ram m_RamPart)
        {
            Form2 f2 = new Form2(m_CPUPart, m_GPUPart, m_RamPart);
            f2.Visible = true;
        }
    }
}
