using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircusTrein
{
    public class Animal
    {
        public string Name { get; set; }
        public Weight weight { get; set; }
        public int getWeight 
        {
            get { return (int)weight; }
        }
        public enum Weight
        {
            Large = 5,
            Medium = 3,
            Small = 1
        }
        public Diet diet { get; set; }
        public enum Diet
        {
            Herbivours,
            Carnivours
        }
        public bool IsSafe(List<Animal> animals)
        {
            foreach (Animal animal in animals)
            {
                if ((diet == Animal.Diet.Carnivours && weight >= animal.weight)||(animal.diet == Animal.Diet.Carnivours&&animal.weight>=weight))
                {
                    return false;
                }
            }
            return true;
        }
    }
}

