using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookApp
{
    public sealed class Janre : System.Attribute
    {
        public string BookJanre { get; set; }

        public Janre(string Janre)
        {
            BookJanre = Janre;
        }
    }

}
