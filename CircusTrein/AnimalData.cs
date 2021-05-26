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
            Animal lion = new Animal { diet = Animal.Diet.Carnivours, Name = "Lion", weight = Animal.Weight.Large };
            Animal tiger = new Animal { diet = Animal.Diet.Carnivours, Name = "Tiger", weight = Animal.Weight.Large };
            Animal bear = new Animal { diet = Animal.Diet.Carnivours, Name = "Bear", weight = Animal.Weight.Large };
            Animal wolf = new Animal { diet = Animal.Diet.Carnivours, Name = "Wolf", weight = Animal.Weight.Medium };
            Animal cat = new Animal { diet = Animal.Diet.Carnivours, Name = "Cat", weight = Animal.Weight.Small };
            Animal giraffe = new Animal { diet = Animal.Diet.Herbivours, Name = "Giraffe", weight = Animal.Weight.Large };
            Animal elephant = new Animal { diet = Animal.Diet.Herbivours, Name = "Elephant", weight = Animal.Weight.Large };
            Animal rhino = new Animal { diet = Animal.Diet.Herbivours, Name = "Rhino", weight = Animal.Weight.Large };
            Animal monkey = new Animal { diet = Animal.Diet.Herbivours, Name = "Monkey", weight = Animal.Weight.Medium };
            Animal mouse = new Animal { diet = Animal.Diet.Herbivours, Name = "Mouse", weight = Animal.Weight.Small };
            List<Animal> animals = new List<Animal> { lion, tiger, bear,wolf,cat,giraffe,elephant,rhino,monkey,mouse};
            return animals;
        }
    }
}
