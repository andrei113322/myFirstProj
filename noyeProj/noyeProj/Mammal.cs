using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace noyeProj
{
    internal class Mammal : Animal
    {
        protected int caloriesInMilk;
        protected int pregnancy;

        public Mammal(string name, int age, bool alpha, int calories, int caloriesInMilk, int pregnancy) : base(name, age, alpha, calories)
        {
            this.caloriesInMilk = caloriesInMilk;
            this.pregnancy = pregnancy;
        }

        public int getCaloriesInMilk()
        {
            return this.caloriesInMilk;
        }

        public int getPregnancy()
        {
            return this.pregnancy;
        }

        public void setCaloriesInMilk(int caloriesInMilk)
        {
            this.caloriesInMilk = caloriesInMilk;
        }

        public void setPregnancy(int pregnancy)
        {
            this.pregnancy = pregnancy;
        }

        public override string ToString()
        {
            return base.ToString() + $"\ncaloriesInMilk:{caloriesInMilk}\npregnancy:{pregnancy}";
        }

        public new int eat()
        {
            return base.eat() + this.caloriesInMilk * 3;
        }
    }
}
