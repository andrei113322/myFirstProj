using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace noyeProj
{
    internal class Python : Snake
    {
        protected int size;

        public Python(string name, int age, bool alpha, int calories, int tailLenght, bool venimous, int size) : base(name, age, alpha, calories, tailLenght, venimous)
        {
            this.size = size;
        }

        public int getSize()
        {
            return size;
        }

        public void setSize(int size)
        {
            this.size = size;
        }

        public override string ToString()
        {
            return base.ToString() + $"\nsize:{size}";
        }
    }
}
