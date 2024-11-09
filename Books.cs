using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation_2
{
    public class Books:Product
    {
        public string Genre { get; set; }

        public Books(int id, string name, double price, string genre):base(id,name,price)
        {
            this.Genre = genre;
        }
    }
}
