using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace noyeProj
{
    internal class Crow : Bird
    {
        protected string color;

        public Crow(string name, int age, bool alpha, int calories, int flyHigh, int wingLengh, string color) : base(name, age, alpha, calories, flyHigh, wingLengh)
        {
            this.color = color;
        }

        public string getColor()
        {
            return color;
        }

        public void setColor(string color)
        {
            this.color = color;
        }

        public override string ToString()
        {
            return base.ToString() + $"\nColor:{color}";
        }
    }
}
