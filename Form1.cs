using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace For_döngüsü
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("1");
            listBox1.Items.Add("2");
            listBox1.Items.Add("3");
            listBox1.Items.Add("4");
            listBox1.Items.Add("5");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int i;
            for (i=0;i<8;i++)
            {
                listBox2.Items.Add(i);
            }
        }
    }
}
