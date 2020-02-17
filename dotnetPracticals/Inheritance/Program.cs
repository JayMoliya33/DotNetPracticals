using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Car
    {
        public void display()
        {
            Console.WriteLine("Car Class");
        }
    }
    class Maruti : Car
    {
        public void display()
        {
            Console.WriteLine("Maruti Class");
        }
    }
    class Mahindra : Car
    {
        public void display()
        {
            Console.WriteLine("Mahindra Class");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Maruti m = new Maruti();
            m.display();
            Mahindra mh = new Mahindra();
            mh.display();

            Console.ReadKey();
;        }
    }
}
