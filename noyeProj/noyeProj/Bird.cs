using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace noyeProj
{
    internal class Bird : Animal
    {
        protected int flyHigh;
        protected int wingLengh;

        public Bird(string name, int age, bool alpha, int calories, int flyHigh, int wingLengh) : base(name, age, alpha, calories)
        {
            this.flyHigh = flyHigh;
            this.wingLengh = wingLengh;
        }

        public int getFlyHigh()
        {
            return flyHigh;
        }

        public int getWingLengh()
        {
            return wingLengh;
        }

        public void setFlyHigh(int flyHigh)
        {
            this.flyHigh = flyHigh;
        }

        public void setWingLengh(int wingLengh)
        {
            this.wingLengh = wingLengh;
        }

        public override string ToString()
        {
            return base.ToString() + $"\nFlyHigh:{flyHigh}\nWingLengh:{wingLengh}";
        }

        public string Sing()
        {
            return "Suka sing sing sing lal la la l";
        }
        public string Dance()
        {
            return "Dance";
        }
    }
}
