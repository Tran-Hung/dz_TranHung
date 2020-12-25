using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using dz1;


namespace dz2
{
    class Program
    {
        static string SerializeAnMixObject()
        {
            var foo = new sensor()
            {
                name = "Hall",
                number = 41,
                address = "Honeywell International",
                number1 = 40,
                type = "Magnetic field",
                pressure = 0,
                viscosity = 0,
                density = 0.12,
                temperatura = 150,
                min_value = 4.5,
                max_value = 24,
                designation = "A/m"
            };
         return JsonConvert.SerializeObject(foo);
     
        }
        static sensor DeserializeAnObject()
        {
            string jsonString = SerializeAnMixObject();

            sensor s1 = JsonConvert.DeserializeObject<sensor>(jsonString);
            return s1;
        }

        static void Main(string[] args)
        { 
            sensor s1 = DeserializeAnObject();
            Console.WriteLine("sensor: [ \n{");
            Console.WriteLine(" name:" + s1.name);
            Console.WriteLine(" number:" + s1.number);
            Console.WriteLine(" address:" + s1.address);
            Console.WriteLine(" number1:" + s1.number1);
            Console.WriteLine(" type:" + s1.type);
            Console.WriteLine(" pressure:" + s1.pressure);
            Console.WriteLine(" viscosity:" + s1.viscosity);
            Console.WriteLine(" density:" + s1.density);
            Console.WriteLine(" temperatura:" + s1.temperatura);
            Console.WriteLine(" min_value:" + s1.min_value);
            Console.WriteLine(" max_value:" + s1.max_value);
            Console.WriteLine(" designation:" + s1.designation);
            Console.WriteLine("} \n]");
        }
    }
}
