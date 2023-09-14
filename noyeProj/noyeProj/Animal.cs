using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace noyeProj
{
    internal class Animal
    {
        protected string name;
        protected int age;
        protected bool alpha;
        protected int calories;

        public Animal(string name, int age, bool alpha, int calories)
        {
            this.name = name;
            this.age = age;
            this.alpha = alpha;
            this.calories = calories;
        }

        public string getName()
        {
            return name;
        }

        public int getAge()
        {
            return age;
        }

        public bool getAlpha()
        {
            return alpha;
        }

        public int getCalories()
        {
            return calories;
        }

        public void setName(string name)
        {
            this.name = name;
        }

        public void setAge(int age)
        {
            this.age = age;
        }

        public void setAlpha(bool alpha)
        {
            this.alpha = alpha;
        }

        public void setCalories(int calories)
        {
            this.calories = calories;
        }

        public override string ToString()
        {
            return $"Name:{name}\nage:{age}\nisAlpha:{alpha}\ncalories:{calories}";
        }

        public int eat()
        {
            return this.calories * 3;
        }


    }
}
