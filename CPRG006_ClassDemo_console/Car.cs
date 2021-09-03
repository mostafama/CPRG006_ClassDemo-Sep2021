using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPRG006_ClassDemo_console
{
    /// <summary>
    /// This class represent a car
    /// </summary>
    class Car
    {
        /// <summary>
        /// Color field
        /// </summary>
        private short _color; // field 0-255
        /// <summary>
        /// The car color which should be from 0 to 255
        /// </summary>
        public short Color    // Property
        {
            get { return _color; }
            set
            {
                _color = value > -1 ? value : 0;
                if (value > -1) _color = value;
                else _color = 0;
            }
        }

        /// <summary>
        /// If the car is broken
        /// </summary>
        public bool Broken { get; set; } = false;

        /// <summary>
        /// The car make
        /// </summary>
        public string Make { get; set; }    // Auto property
                                            //private string _make;
                                            //public string Make
                                            //{
                                            //    get { return _make; }
                                            //    set { _make = value; }
                                            //}
        /// <summary>
        /// Car year
        /// </summary>
        public ushort Year { get; set; }

        /// <summary>
        /// If the car is over 10 year old
        /// </summary>
        /// <returns></returns>
        public bool isOld() // A method 
        {
            return Year <= DateTime.Now.Year-10 ? true : false;
        }

        /// <summary>
        /// Car default constructor
        /// </summary>
        public Car()    //  Constructor 
        {
            Console.WriteLine("Constructed");
            Year = (ushort)DateTime.Now.Year;
            Color = 200;
        }

        /// <summary>
        /// Car parametrized constructor
        /// </summary>
        /// <param name="Yr">Car year</param>
        /// <param name="Make">Car make</param>
        /// <param name="Color">Car color (0-255)</param>
        public Car(ushort Yr, string Make, short Color = 0)    //  Constructor overload
        {
            Console.WriteLine("Parametrized Constructed");
            Year = Yr;
            this.Make = Make;
            this.Color = Color;
        }

        ~Car()
        {
            Console.WriteLine($"{Make} was destructed");
        }

        public override string ToString()
        {
            return $" * The car color is {Color}, the make is {Make}, " +
                $"the year is {Year}, is Old: {isOld()}, {Workshop.NeedFix(this)}";
        }

        /// <summary>
        /// The car model
        /// </summary>
        public string Model
        {
            get ;
            set;
        }
    }
}
