using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace p278___TallGuy
{
    class TallGuy : IClown
    {
        public string Name;
        public int Height;
        public int iPhone = 0;

        public void TalkAboutYourself()
        {
                MessageBox.Show("Меня зовут " + Name + " и мой рост равен "
                   + Height + " см.");
        }

        public void Phone()
        {
           if (iPhone != 0)
                MessageBox.Show("У меня есть iPhone"); 
        }

        public string FunnyThingIHave
        {
            get { return "большие ботинки"; }
        }

        public void Honk()
        {
            MessageBox.Show("Би-би!");
        }
    }
}