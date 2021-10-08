using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team3
{
    public class Menu
    {
        public int menuID { get; set; }

        public int categoryID { get; set; }

        public string name { get; set; }

        public string description { get; set; }

        public decimal price { get; set; }

        public byte[] Image { get; set; }

        public Menu()
        {

        }
    }
}
