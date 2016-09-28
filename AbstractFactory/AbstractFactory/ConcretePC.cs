using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class ConcretePC : AbstractFactory
    {
        public enum CPU { i7, i5}
        public enum GPU { gtx970, integrated}
        public enum Ram { sixteen, four}

        private CPU _CPUPart;
        private GPU _GPUPart;
        private Ram _RamPart;

        public CPU m_CPUPart
        {
            get { return _CPUPart; }
            set
            {
                _CPUPart = value;
            }
        }

        public GPU m_GPUPart
        {
            get { return _GPUPart; }
            set
            {
                _GPUPart = value;
            }
        }

        public Ram m_RamPart
        {
            get { return _RamPart; }
            set
            {
                _RamPart = value;
            }
        }

        public override Desktop createDesktop(ConcretePC.CPU m_CPUPart, ConcretePC.GPU m_GPUPart, ConcretePC.Ram m_RamPart)
        {
            return new Desktop(m_CPUPart,m_GPUPart,m_RamPart);
        }

        public override Laptop createLaptop(ConcretePC.CPU m_CPUPart, ConcretePC.GPU m_GPUPart, ConcretePC.Ram m_RamPart)
        {
            return new Laptop(m_CPUPart, m_GPUPart, m_RamPart);
        }

        public override iMac createiMac(ConcreteMac.CPU m_CPUPart, ConcreteMac.GPU m_GPUPart, ConcreteMac.Ram m_RamPart)
        {
            throw new NotImplementedException();
        }

        public override Macbook createMacbook(ConcreteMac.CPU m_CPUPart, ConcreteMac.GPU m_GPUPart, ConcreteMac.Ram m_RamPart)
        {
            throw new NotImplementedException();
        }
    }
}
