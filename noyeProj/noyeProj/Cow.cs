using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace noyeProj
{
    internal class Cow : Mammal
    {
        protected int birthCount;

        public Cow(string name, int age, bool alpha, int calories, int caloriesInMilk, int pregnancy, int birthCount) : base(name, age, alpha, calories, caloriesInMilk, pregnancy)
        {
            this.birthCount = birthCount;
        }

        public int getBirthCount()
        {
            return birthCount;
        }

        public void setBirthCount(int birthCount)
        {
            this.birthCount=birthCount;
        }

        public override string ToString()
        {
            return base.ToString() + $"\nbirthCount{birthCount}";
        }

        public new int eat()
        {
            return base.eat() / 4;
        }
    }
}
