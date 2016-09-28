using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AbstractFactory
{
    public partial class Form1 : Form
    {
        ConcretePC concretePC;
        ConcreteMac concreteMac;
        Desktop desktop;
        Laptop laptop;
        iMac iMac;
        Macbook macbook;

        public Form1()
        {
            InitializeComponent();
            concretePC = new ConcretePC();
            concreteMac = new ConcreteMac();
            desktop = new Desktop();
            laptop = new Laptop();
            iMac = new iMac();
            macbook = new Macbook();
        }

        private void btnPC_Click(object sender, EventArgs e)
        {
            concretePC.m_CPUPart = ConcretePC.CPU.i7;
            concretePC.m_GPUPart = ConcretePC.GPU.gtx970;
            concretePC.m_RamPart = ConcretePC.Ram.sixteen;
            concretePC.createDesktop(concretePC.m_CPUPart, concretePC.m_GPUPart, concretePC.m_RamPart);
        }

        private void btnPCTop_Click(object sender, EventArgs e)
        {
            concretePC.m_CPUPart = ConcretePC.CPU.i5;
            concretePC.m_GPUPart = ConcretePC.GPU.integrated;
            concretePC.m_RamPart = ConcretePC.Ram.four;
            concretePC.createLaptop(concretePC.m_CPUPart, concretePC.m_GPUPart, concretePC.m_RamPart);
        }

        private void btnMac_Click(object sender, EventArgs e)
        {
            concreteMac.m_CPUPart = ConcreteMac.CPU.i5;
            concreteMac.m_GPUPart = ConcreteMac.GPU.amd6970;
            concreteMac.m_RamPart = ConcreteMac.Ram.eight;
            concreteMac.createiMac(concreteMac.m_CPUPart, concreteMac.m_GPUPart, concreteMac.m_RamPart);
        }

        private void btnMacTop_Click(object sender, EventArgs e)
        {
            concreteMac.m_CPUPart = ConcreteMac.CPU.i3;
            concreteMac.m_GPUPart = ConcreteMac.GPU.integrated;
            concreteMac.m_RamPart = ConcreteMac.Ram.four;
            concreteMac.createMacbook(concreteMac.m_CPUPart, concreteMac.m_GPUPart, concreteMac.m_RamPart);
        }
    }
}
