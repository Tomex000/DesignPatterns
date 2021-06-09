using DesignPatterns.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {

            CarBuilder carBuilder = new CarBuilder();

            var car1 = carBuilder.Build(); //members have correct values at the begining 
            var car2 = carBuilder.SetColor(Color.Black).SetRoof(false).SetSedan().Build();

            Console.WriteLine(Singleton.Singleton.Instance.ToString());
        }
    }
}
