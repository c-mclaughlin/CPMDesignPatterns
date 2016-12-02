using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Template_Method
{
    public partial class Form1 : Form
    {
        AbstractClass ac;
        public Form1()
        {
            InitializeComponent();
            
        }

        private void btnMarvel_Click(object sender, EventArgs e)
        {
            ac = new ConcreteClass();
            txtList.Text = ac.listMarvel();
            
        }

        private void btnDC_Click(object sender, EventArgs e)
        {
            ac = new ConcreteClass();
            txtList.Text = ac.listDC();
        }
    }
}
