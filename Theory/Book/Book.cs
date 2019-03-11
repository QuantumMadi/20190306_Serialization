using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookApp
{
    [Serializable]
    public class Book
    {
        public string Name{ get;set;}
        public int Price { get; set; }
        public string Author { get; set; }
        public DateTime PublishYear { get; set; }
        
    }
}
