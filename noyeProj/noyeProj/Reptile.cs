using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace noyeProj
{
    internal class Reptile : Animal
    {
        protected int tailLenght;

        public Reptile(string name, int age, bool alpha, int calories, int tailLenght) : base(name, age, alpha, calories)
        {
            this.tailLenght = tailLenght;
        }

        public int getTailLenght()
        {
            return tailLenght;
        }

        public void setTailLenght(int teilLenght)
        {
            this.tailLenght=teilLenght;
        }

        public override string ToString()
        {
            return base.ToString() + $"\ntailLenght:{tailLenght}";
        }
    }
}
