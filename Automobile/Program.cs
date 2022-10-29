using System;

namespace Automobile
{
    public enum autoType
    {
        Sedan, Truck, Van, SUV
    }

    class Automobile
    {
        private string make;
        private string model;
        private int year;
        private string vin;
        private string color;
        private autoType type;

        public Automobile(string make, string model, int year, string vin, string color, autoType type)
        {
            this.make = make;
            this.model = model;
            this.year = year;
            this.vin = vin;
            this.color = color;
            this.type = type;
        }
        //FUNCTIONS
        public string returnMake()
        {
            return make;
        }
        public string returnModel()
        {
            return model;
        }
        public string getVin()
        {
            return vin;
        }
        public string getColor()
        {
            return color;
        }
        public void setColor(string Color)
        {
            color = Color;
        }
        public int getYear()
        {
            return year;
        }
        public autoType getType()
        {
            return type;
        }
        public int getAutoAge()
        {
            string currentYear = DateTime.Now.Year.ToString();
            int result = Int32.Parse(currentYear);
            int autoAge = result - this.year;

            return autoAge;
        }
        static void Main()
        {
            Console.WriteLine("\nCreating the first Automobile\n---------------");
            Automobile auto1 = new Automobile("Tesla", "Model X", 2020, "12345", "blue", autoType.Sedan);
            Console.WriteLine($"Make: {auto1.returnMake()} \nModel: {auto1.returnModel()}\nYear: {auto1.getYear()}\nType: {auto1.getType()} \nVIN: {auto1.getVin()}");
            Console.WriteLine($"Color: {auto1.getColor()}");
            Console.WriteLine("\nChanging the Color\n---------------");
            auto1.setColor("Magenta");
            Console.WriteLine($"Color: {auto1.getColor()}");

            Console.WriteLine("\nCreating the second Automobile\n---------------");
            Automobile auto2 = new Automobile("Mercedes", "G-Wagon", 2017, "24578", "silver", autoType.SUV);
            Console.WriteLine($"Make: {auto2.returnMake()}\nModel: {auto2.returnModel()}\nYear: {auto2.getYear()}\nType: {auto2.getType()}\nVIN: {auto2.getVin()}");

            Console.WriteLine("\nPrinting Automobile Ages\n---------------");
            Console.WriteLine($"{auto1.make} {auto1.model} Age: {auto1.getAutoAge()} years");
            Console.WriteLine($"{auto2.make} {auto2.model} Age: {auto2.getAutoAge()} years");
        }
    }
}
