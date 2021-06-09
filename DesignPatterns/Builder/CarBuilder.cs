using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Builder
{
    class CarBuilder
    {
        private Color color = Color.Red;
        private int doorsNumber = 2;
        private bool hasRoof = true;

        public Car Build()
        {
            return new Car(color, doorsNumber, hasRoof);
        }
        public CarBuilder SetColor(Color color)
        {
            this.color = color;
            return this;
        }
        public CarBuilder SetRoof(bool hasRoof)
        {
            this.hasRoof = hasRoof;
            return this;
        }
        public CarBuilder SetHatchBack()
        {
            this.doorsNumber = 2;
            return this;
        }
        public CarBuilder SetSedan()
        {
            this.doorsNumber = 4;
            return this;
        }
    }
}
