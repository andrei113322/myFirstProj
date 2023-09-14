using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace noyeProj
{
    internal class Crocodile : Reptile
    {
        protected bool hadTeethCare;

        public Crocodile(string name, int age, bool alpha, int calories, int tailLenght, bool hadTeethCare) : base(name, age, alpha, calories, tailLenght)
        {
            this.hadTeethCare = hadTeethCare;
        }

        public bool getHadTeethCare()
        {
            return hadTeethCare;
        }

        public void setHadTeethCare(bool hadTeethCare)
        {
            this.hadTeethCare = hadTeethCare;
        }

        public override string ToString()
        {
            return base.ToString() + $"\nhadTeethCare:{hadTeethCare}";
        }
    }
}
