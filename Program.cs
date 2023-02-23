using System;
namespace movies
{
    interface Monster
    {
        public string Name { get; set; }
        public string Size { get; set; }

        string Display();
    }
    class Program
    {
        struct Aboleth : Monster
        {
            public string Name { get; set; }
            public string Size { get; set; }
            public double CR { get; set; }
            public string Type { get; set; }
            public Aboleth(string name, string size, double cr, string type)
            {
                Name = name;
                Size = size;
                CR = cr;
                Type = type;
            }
            public string Display()
            {
                return "Name: " + Name + "\nSize: " + Size +
                    "\nCombat Rating: " + CR + "\nCreature Type: " + Type;
            }
        }
        static void Main(string[] args)
        {
            Aboleth aboleth = new Aboleth("Joe", "Large", 10, "Abberation");
            Console.WriteLine($"{aboleth.Display()}");
        }
    }
}