using System;
using System.Collections.Generic;
using System.Linq;

namespace CircusTrein
{
    public class Train
    {
        public string ToString(Wagon wagon)
        {
            return "Wagon Number: " + wagon.Wagon_Number + "    Animals: " + wagon.Animals.Count + "  Free Space: " + wagon.Free_Space;
        }
        public (List<Wagon>, List<Animal>) StartTrain(int count)
        {
            List<Animal> animals = CreateAnimalsList(count);
            List<Wagon> wagons = AddAnimalsToWagons(animals);
            return (wagons, animals);
        }
        public List<Wagon> AddAnimalsToWagons(List<Animal> animals)
        {
            List<Wagon> wagons = new List<Wagon> { new Wagon { Wagon_Number = 0 } };
            foreach (Animal animal in animals)
            {
                for (int i = 0; i <= wagons.Count(); i++)
                {
                    if (wagons[i].AddToWagon(animal))
                    {
                        break;
                    }
                    if (i == wagons.Count - 1)
                    {
                        wagons.Add(new Wagon { Wagon_Number = wagons.Count() });
                        wagons[i + 1].AddToWagon(animal);
                        break;
                    }
                }
            }
            return wagons;
        }
        public List<Animal> CreateAnimalsList(int count)
        {
            List<Animal> animals = new List<Animal> { };
            Random random = new Random { };
            for (int i = 0; i < count; i++) { animals.Add(CreateAnimal(i, random.Next(0, 3), random.Next(0, 2))); }
            return animals;
        }
        public Animal CreateAnimal(int name, int weight, int diet)
        {
            Animal animal = new Animal { Name = Convert.ToString(name) };
            switch (weight)
            {
                case 0:
                    animal.weight = Animal.Weight.Small;
                    break;
                case 1:
                    animal.weight = Animal.Weight.Medium;
                    break;
                case 2:
                    animal.weight = Animal.Weight.Large;
                    break;
            }
            switch (diet)
            {
                case 0:
                    animal.diet = Animal.Diet.Herbivours;
                    return animal;
                default:
                    animal.diet = Animal.Diet.Carnivours;
                    return animal;
            }
        }
    }
}
