using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab24_waterpool
{
    class Acts : Picasso
    {
       public Acts() : base("Acts") { }
        public override int Ear()
        {
            return 5;
        }
    }
    
}
