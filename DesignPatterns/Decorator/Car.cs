using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Decorator
{
    class Car : ICar
    {
        public void Drive()
        {
            Console.WriteLine("driving");
        }
    }
}
