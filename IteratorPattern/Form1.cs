using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IteratorPattern
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
            agg.Roster.Add("Lorie");
            agg.Roster.Add("Iris");
            agg.Roster.Add("Hermione");
            agg.Roster.Add("Irene");
            agg.Roster.Add("Conor");
            agg.Roster.Add("Michael");
            agg.Roster.Add("Alec");
            agg.Roster.Add("Theresa");
            agg.Roster.Add("Miranda");
            agg.Roster.Add("Elizabeth");
            agg.Roster.Add("James");
            agg.Roster.Add("Anne");
            agg.Roster.Add("Eric");
            agg.Roster.Add("Zachary");
            agg.Roster.Add("Megan");
            agg.Roster.Add("Cynthia");
            agg.Roster.Add("Nicholas");
            agg.Roster.Add("William");
            agg.Roster.Add("Linda");
            agg.Roster.Add("David");
            agg.Roster.Add("Paul");
            agg.Roster.Add("Collin");
            agg.Roster.Add("Griffin");
            agg.Roster.Add("Harry");
            agg.Roster.Add("Kevin");
            iterator = agg.createIterator();
        }

        private void iterateButton_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            iterator.first();
            while (!iterator.isDone())
            {
                listBox1.Items.Add(iterator.currentItem());
                iterator.next();
            }
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            iterator.first();
            while (!iterator.isDone())
            {
                if(iterator.currentItem().ToString().ToUpper().Contains(textBox1.Text.ToUpper()))
                {                    
                    listBox1.Items.Add(iterator.currentItem());
                }
                iterator.next();
            }
        }
    }
}
