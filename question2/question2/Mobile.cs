using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace question2
{
    internal class Mobile
    {
        public string Name { get; set; }

        public string Model { get; set; }

        public int Price { get; set; }

        public string Company { get; set; }

        public void GetData(string Name1, string Model1, int Price1, string Company1)
        {
            Name = Name1;
            Model = Model1;
            Price = Price1;
            Company = Company1;
        }
        public void GetData(string Name1, string Model1, int Price1)
        {
            Name = Name1;
            Model = Model1;
            Price = Price1;
            Company = "Samsung";
        }
    }
}
