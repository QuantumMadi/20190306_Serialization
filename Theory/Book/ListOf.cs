using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookApp
{
    public sealed class  Item : Attribute
    {  
        public string ItemName { get; set; }
        
        public Item(string item)
        {
            ItemName = item;
        }
    }

}
