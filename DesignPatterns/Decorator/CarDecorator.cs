using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Decorator
{
    class CarDecorator : ICar
    {
        ICar car;
        public CarDecorator(ICar car)
        {
            this.car = car;
        }

        public void Drive()
        {
            Console.WriteLine("Start");
            car.Drive();
            Console.WriteLine("Stop");
        }
    }
}
