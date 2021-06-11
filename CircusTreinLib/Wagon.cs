using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircusTrein
{
    public class Wagon
    {
        public int Wagon_Number { get; set; }
        public int FreeSpace
        {
            get
            {
                int space = freeSpace;
                foreach (Animal animal in Animals)
                {
                    space = space - animal.getWeight;
                }
                return space;
            }
        }
        private readonly int freeSpace = 10;
        public List<Animal> Animals { get; private set; } = new List<Animal>();

        public bool AddToWagon(Animal animal)
        {
            if (FreeSpace >= animal.getWeight)
            {
                if (animal.IsSafe(Animals))
                {
                    Animals.Add(animal);
                    return true;
                }
            }
            return false;
        }
    }
}
