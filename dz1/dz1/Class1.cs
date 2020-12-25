using System;

namespace dz1
{
    public class Metrological_system
    {
        public string name;
        public int number;
        public string address;

        public Metrological_system()
        {
            Console.WriteLine("- Metrological_systen()");
        }
        public Metrological_system(string name, int number, string address)
        {
            this.name = name;
            this.number = number;
            this.address = address;
        }
    }

    public class measuring_line : Metrological_system
    {
        public int number1;

        public measuring_line()
        {
            Console.WriteLine("- measuring_line()");
        }

        public measuring_line(string name, int number, string address, int number1)
            : base(name, number, address)
        {
            this.number1 = number1;
        }
     
    }

    public class sensor : measuring_line
    {
        public string type;
        public int pressure;
        public int viscosity;
        public double density;
        public double temperatura;
        public double min_value;
        public double max_value;
        public string designation;

        public sensor()
        {
            Console.WriteLine("- sensor()");
        }

        public sensor(string name, int number, string address, int number1, string type, int pressure, int viscosity
            , double density, double temperatura, double min_value, double max_value, string designation)
            :base(name, number, address, number1)
        {
            this.type = type;
            this.pressure = pressure;
            this.viscosity = viscosity;
            this.density = density;
            this.temperatura = temperatura;
            this.min_value = min_value;
            this.max_value = max_value;
            this.designation = designation;
        }
    }
}
