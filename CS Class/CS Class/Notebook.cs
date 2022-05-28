using System;
using System.Collections.Generic;
using System.Text;

namespace CS_Class
{
    internal class Notebook
    {
        public Notebook(string name, string brandName, int price)
        {
            Name = name;
            BrandName = brandName;
            Price = price;
        }

        public string Name;
        public string BrandName;
        public int Price;

    }
}
