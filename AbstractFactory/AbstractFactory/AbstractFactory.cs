using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
   public abstract class AbstractFactory
    {
       public abstract Desktop createDesktop(ConcretePC.CPU m_CPUPart, ConcretePC.GPU m_GPUPart, ConcretePC.Ram m_RamPart);
       public abstract Laptop createLaptop(ConcretePC.CPU m_CPUPart, ConcretePC.GPU m_GPUPart, ConcretePC.Ram m_RamPart);
       public abstract Macbook createMacbook(ConcreteMac.CPU m_CPUPart, ConcreteMac.GPU m_GPUPart, ConcreteMac.Ram m_RamPart);
       public abstract iMac createiMac(ConcreteMac.CPU m_CPUPart, ConcreteMac.GPU m_GPUPart, ConcreteMac.Ram m_RamPart);
    }
}
