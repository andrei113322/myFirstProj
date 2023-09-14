using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace noyeProj
{
    internal class Hipo : Mammal
    {
        protected int fatProcentale;

        public Hipo(string name, int age, bool alpha, int calories, int caloriesInMilk, int pregnancy, int fatProcentale) : base(name, age, alpha, calories, caloriesInMilk, pregnancy)
        {
            this.fatProcentale = fatProcentale;
        }

        public int getFatProcentale()
        {
            return fatProcentale;
        }

        public void setFatProcentale(int fatProcentale)
        {
            this.fatProcentale = fatProcentale;
        }

        public override string ToString()
        {
            return base.ToString() + $"\nfatProcentile:{fatProcentale}";
        }
    }
}
