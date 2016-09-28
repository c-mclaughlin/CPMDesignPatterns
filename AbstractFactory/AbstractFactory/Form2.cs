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
    public partial class Form2 : Form
    {
        public Form2()
        {

        }

        public Form2(ConcretePC.CPU m_CPUPart,ConcretePC.GPU m_GPUPart,ConcretePC.Ram m_RamPart)
        {
            InitializeComponent();
            txtCPU.Text = m_CPUPart.ToString();
            txtGPU.Text = m_GPUPart.ToString();
            txtRam.Text = m_RamPart.ToString();
        }

        public Form2(ConcreteMac.CPU m_CPUPart,ConcreteMac.GPU m_GPUPart, ConcreteMac.Ram m_RamPart)
        {
            InitializeComponent();
            txtCPU.Text = m_CPUPart.ToString();
            txtGPU.Text = m_GPUPart.ToString();
            txtRam.Text = m_RamPart.ToString();
        }
    }
}
