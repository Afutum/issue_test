using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace issue_test
{
    internal class Item
    {
        public int id { get; set; }
        public string name { get; set; }
        public int price { get; set; }

        public void CreateItem(int id,string name, int price)
        {
            this.id = id;
            this.name = name;
            this.price = price;
        }
    }
}
