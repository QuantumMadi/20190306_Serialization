using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookApp
{
    public sealed class Janre : Attribute
    {  
        public string BookJanre { get; set; }
        
    }

}
