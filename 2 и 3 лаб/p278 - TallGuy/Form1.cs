using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace p278___TallGuy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TallGuy tallGuy = new TallGuy() { Height = 192, Name = "Alex", iPhone = 1};
            tallGuy.TalkAboutYourself();
            tallGuy.Honk();
            tallGuy.Phone();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TallGuy tallGuy = new TallGuy() { Height = Convert.ToInt32(textBox1), Name = Convert.ToString(textBox2), iPhone = Convert.ToInt32(textBox3)};
            tallGuy.Phone();
       
        }

    }
}