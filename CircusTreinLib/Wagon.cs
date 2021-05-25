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
        public int Free_Space
        {
            get { return free_Space; }
            private set { free_Space = value; }
        }
        private int free_Space = 10;
        public List<Animal> Animals { get; private set; } = new List<Animal>();

        public bool CheckIfSpace(Animal animal)
        {
            if (Free_Space >= (int)animal.weight)
            {
                return true;
            }
            return false;
        }
        public bool CheckIfSafe(Animal animal)
        {
            if (animal.diet == Animal.Diet.Herbivours && Animals.Count > 0)
            {
                for (int i = 0; i < Animals.Count; i++)
                {
                    if (Animals[i].diet == Animal.Diet.Carnivours && Animals[i].weight >= animal.weight)
                    {
                        return false;
                    }
                }
            }
            if (animal.diet == Animal.Diet.Carnivours && Animals.Count > 0)
            {
                for (int i = 0; i < Animals.Count; i++)
                {
                    if (Animals[i].diet == Animal.Diet.Carnivours || Animals[i].weight <= animal.weight)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        public bool AddToWagon(Animal animal)
        {
            if (CheckIfSpace(animal))
            {
                if (CheckIfSafe(animal))
                {
                    Animals.Add(animal);
                    Free_Space = Free_Space - (int)animal.weight;
                    return true;
                }
            }
            return false;
        }
    }
}
