using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Iterator
{
    public partial class Form1 : Form
    {
        Aggregate agg = new ConcreteAggregate();
        Iterator iterator;

        public Form1()
        {
            InitializeComponent();
            PrepareAggWithIter();
        }

        private void PrepareAggWithIter()
        {
            agg.Elements.Add("Casey");
            agg.Elements.Add("Andrea");
            agg.Elements.Add("John");
            agg.Elements.Add("Sean");
            agg.Elements.Add("Jonathan");
            agg.Elements.Add("Nick");
            agg.Elements.Add("Erin");
            agg.Elements.Add("Jeremy");
            agg.Elements.Add("Ben");
            agg.Elements.Add("Dave Retterer (a soul so bright I need sunglasses)");
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IteratedListCollection.Items.Clear();
            iterator.first();
            while(!iterator.isDone())
            {
                IteratedListCollection.Items.Add(iterator.current());
                iterator.next();
            }
        }

        private void Longest_CheckedChanged(object sender, EventArgs e)
        {
            iterator = agg.createIterator();
        }

        private void Shortest_CheckedChanged(object sender, EventArgs e)
        {
            iterator = agg.createIteratorShort();
        }
    }
}
    


    

