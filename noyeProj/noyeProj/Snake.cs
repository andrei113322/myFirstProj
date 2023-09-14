using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace noyeProj
{
    internal class Snake : Reptile
    {
        protected bool venimous;

        public Snake(string name, int age, bool alpha, int calories, int tailLenght, bool venimous) : base(name, age, alpha, calories, tailLenght)
        {
            this.venimous = venimous;
        }

        public bool getVenimous()
        {
            return venimous;
        }

        public void setVenimous(bool venimous)
        {
            this.venimous=venimous;
        }

        public override string ToString()
        {
            return base.ToString() + $"\nisVenimous:{venimous}";
        }

        public string Dance()
        {
            return "Dance";
        }
    }
}
