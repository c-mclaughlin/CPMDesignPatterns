using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CompositePattern
{
    public partial class Form1 : Form
    {
        const string Indent = "    ";
         void PrintType(Composite c)
        {
            txtResponse.Text +=   c.ToString() + Environment.NewLine;
            foreach (Component co in c.classes)
            {
                txtResponse.Text += Indent;
                PrintClass((Leaf) co);

            }
           
        }
        void PrintClass(Leaf l)
        {
            txtResponse.Text += l.ToString() +" " + l.getStrength()+ Environment.NewLine;
        }

        static List<Component> ClassList = new List<Component>()
        {
            new Leaf("Fighter" , 20),
            new Leaf("Mage" , 6),
            new Leaf("Rogue" , 14),
            new Leaf("Cleric" , 16),
            new Leaf("Paladin" , 18),
            new Leaf("Ranger" , 16),
        };

        static List<Component> ClassType = new List<Component>()
        {
            new Composite ("Tank" , ClassList[0], ClassList[4]),
            new Composite ("Magic" , ClassList[1], ClassList[3], ClassList[4]),
            new Composite ("Damage" , ClassList[0], ClassList[2], ClassList[5]),
            new Composite ("Healer" , ClassList[4], ClassList[3]),

        };

        public Form1()
        {
            InitializeComponent();
        }

        private void btnTank_Click(object sender, EventArgs e)
        {
            PrintType((Composite)ClassType[0]);
           
        }

        private void btnDamage_Click(object sender, EventArgs e)
        {
            PrintType((Composite)ClassType[2]);
        }

        private void btnMagic_Click(object sender, EventArgs e)
        {
            PrintType((Composite)ClassType[1]);
        }

        private void btnHealer_Click(object sender, EventArgs e)
        {
            PrintType((Composite)ClassType[3]);
        }

        private void btnFighter_Click(object sender, EventArgs e)
        {
            PrintClass((Leaf)ClassList[0]);
        }

        private void btnMage_Click(object sender, EventArgs e)
        {
            PrintClass((Leaf)ClassList[1]);
        }

        private void btnRogue_Click(object sender, EventArgs e)
        {
            PrintClass((Leaf)ClassList[2]);
        }

        private void btnCleric_Click(object sender, EventArgs e)
        {
            PrintClass((Leaf)ClassList[3]);
        }

        private void btnPaladin_Click(object sender, EventArgs e)
        {
            PrintClass((Leaf)ClassList[4]);
        }

        private void btnRanger_Click(object sender, EventArgs e)
        {
            PrintClass((Leaf)ClassList[5]);
        }
    }
}
