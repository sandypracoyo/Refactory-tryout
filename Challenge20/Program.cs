using System;

namespace ObjectClass
{
    class Program
    {
        static void Main(string[] args)
        {
            // Make this code works by create new class, method, and property.
            Item item = new Item();
            item.name = "Indomie Goreng";
            item.price = 3500;
            item.onSale = true; // If true the price will drop 20%

            item.print(); // Output: "Indomie Goreng (Rp2800)"
        }
    }
    class Item
    {
        public string name;
        public int price;
        public bool onSale;
        public double diskon;
        public double afterDiskon;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Price
        {
            get { return price; }
            set { price = value; }
        }

        public bool OnSale
        {
            get; set;
        }

        public void print()
        {
            if (onSale == true)
            {
                diskon = Price * 0.2;
                afterDiskon = Price - diskon;
            }
            else
            {
                afterDiskon = Price;
            }
            Console.WriteLine(name + $" (Rp {afterDiskon})");
        }
    }
}
