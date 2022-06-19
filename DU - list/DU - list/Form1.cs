using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DU___list
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<char> list = new List<char>();
        private void button1_Click(object sender, EventArgs e)
        {
            foreach(char c in textBox1.Text)
            {
                list.Add(c);
            }
            Vypis(list, listBox1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string clear = "qwertzuiopasdfghjklyxcvbnm0123456789";
            foreach(char c in clear)
            {
                list.RemoveAll(x => x==c);
            }
            Vypis(list, listBox2);
        }


        void Vypis(List<char> l, ListBox lb)
        {
            lb.Items.Clear();
            foreach(char c in l)
            {
                lb.Items.Add(c);
            }
        }
    }
}
