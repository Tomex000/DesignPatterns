using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Builder
{
    enum Color
    {
        Red,
        Black,
    }
    class Car
    {
        private Color color;
        private int doorsNumber;
        private bool hasRoof;

        public Car(Color color, int doorsNumber, bool hasRoof)
        {
            this.color = color;
            this.doorsNumber = doorsNumber;
            this.hasRoof = hasRoof;
        }
    }
}
