using System;

namespace CPRG006_ClassDemo_console
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Car c1;  // created the Object c1 = null
            c1 = new Car();  // c1 doesn't =null
            Console.WriteLine($"** Initial: color is {c1.Color}, and the make is {c1.Make}, " +
                $"and the year is {c1.Year}, is Old: {c1.isOld()}");
            c1.Color = 10;
            c1.Make = "Mazda";
            c1.Year = 2021;
            Console.WriteLine(c1);

            Car c2 = new Car(){ Color = 255, Year = 2009, Make="Audi", Broken = true };
            //Console.WriteLine($"The color is {c.Color}, and the make is {c.Make}, " +
            //    $"and the year is {c.Year}, is Old: {c.isOld()}");
            //Console.WriteLine($"The color 2 is {c2.Color}, and the make is {c2.Make}, " +
            //    $"and the year is {c2.Year}, is Old: {c2.isOld()}");
            Console.WriteLine(c2);

            Car c3 = new Car(2005, "Volvo");
            Console.WriteLine(c3.ToString());

            Workshop.Fix(c2);
            Console.WriteLine(c2.ToString());

        }
    }

   
}
