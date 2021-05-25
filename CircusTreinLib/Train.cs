using System;
using System.Collections.Generic;
using System.Linq;

namespace CircusTrein
{
    public class Train
    {
        public string ToStringAnimalCreated(Wagon wagon)
        {
            string text = "";
            foreach (Animal animal in wagon.Animals)
            {
                text = text + animal.Name + " has been added to wagon: " + wagon.Wagon_Number + "\n";
            }
            return text;
        }
        public string ToStringWagon(Wagon wagon)
        {
            return "Wagon Number: " + wagon.Wagon_Number + "    Animals: " + wagon.Animals.Count + "  Free Space: " + wagon.Free_Space + "\n";
        }
        public List<Wagon> StartTrain(int count)
        {
            List<Animal> animals = CreateAnimalsList(count);
            List<Wagon> wagons = new List<Wagon>();
            wagons = AddAnimalsToWagons(animals, wagons);

            return wagons;
        }
        public List<Wagon> AddAnimalsToWagons(List<Animal> animals, List<Wagon> wagons)
        {
            wagons.Add(new Wagon { Wagon_Number = wagons.Count() });
            foreach (Animal animal in animals)
            {
                for (int i = 0; i < wagons.Count(); i++)
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
            for (int i = 0; i < count; i++)
            {
                animals.Add(CreateRandomAnimal(i, random.Next(0, 3), random.Next(0, 2)));
            }
            return animals;
        }
        public Animal CreateRandomAnimal(int name, int weight, int carnivorous)
        {
            Animal animal = new Animal { Name = Convert.ToString(name) };
            if (weight == 0) { animal.weight = Animal.Weight.Small; }
            else if (weight == 1) { animal.weight = Animal.Weight.Medium; }
            else if (weight == 2) { animal.weight = Animal.Weight.Large; }

            if (carnivorous == 0) { animal.diet = Animal.Diet.Herbivours; }
            else if (carnivorous == 1) { animal.diet = Animal.Diet.Carnivours; }
            return animal;
        }
    }
}
