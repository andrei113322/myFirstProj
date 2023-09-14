using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace noyeProj
{
    internal class Park
    {
        protected Animal[] animals;
        protected int numOfAnimals;

        public Park()
        {
            animals = new Animal[1000];
            numOfAnimals = 0;
        }

        public bool anterAnimal(Animal ani)
        {
            if (numOfAnimals < 1000)
            {
                animals.Append(ani);
                numOfAnimals++;
            }
            return true;
        }

        public List<Animal> myAniList()
        {
            List<Animal> list = new List<Animal>();
            foreach (Animal item in this.animals)
            {
                if (item.getAge() > 10 && item.getAlpha())
                {
                    list.Add(item);
                }
            }
            return list;
        }

        public int getAllReptilesAndAlpha()
        {
            int sum = 0;
            foreach (var item in animals)
            {
                if (item is Reptile && item.getAlpha())
                {
                    sum++;
                }
                else if(item is Bird && item.getAlpha())
                {
                    sum++;
                }
            }
            return sum;
        }
    }
}
