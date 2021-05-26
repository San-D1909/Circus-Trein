using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircusTrein
{
    public class AnimalData
    {
        public static List<Animal> Animals()
        {
            Animal lion = new Animal { diet = Animal.Diet.Carnivours, Name = "lion", weight = Animal.Weight.Large };
            Animal tiger = new Animal { diet = Animal.Diet.Carnivours, Name = "tiger", weight = Animal.Weight.Large };
            Animal bear = new Animal { diet = Animal.Diet.Carnivours, Name = "bear", weight = Animal.Weight.Large };
            Animal wolf = new Animal { diet = Animal.Diet.Carnivours, Name = "wolf", weight = Animal.Weight.Medium };
            Animal cat = new Animal { diet = Animal.Diet.Carnivours, Name = "cat", weight = Animal.Weight.Small };
            Animal giraffe = new Animal { diet = Animal.Diet.Herbivours, Name = "giraffe", weight = Animal.Weight.Large };
            Animal elephant = new Animal { diet = Animal.Diet.Herbivours, Name = "elephant", weight = Animal.Weight.Large };
            Animal rhino = new Animal { diet = Animal.Diet.Herbivours, Name = "rhino", weight = Animal.Weight.Large };
            Animal monkey = new Animal { diet = Animal.Diet.Herbivours, Name = "monkey", weight = Animal.Weight.Medium };
            Animal mouse = new Animal { diet = Animal.Diet.Herbivours, Name = "mouse", weight = Animal.Weight.Small };
            List<Animal> animals = new List<Animal> { lion, tiger, bear,wolf,cat,giraffe,elephant,rhino,monkey,mouse};
            return animals;
        }
    }
}
