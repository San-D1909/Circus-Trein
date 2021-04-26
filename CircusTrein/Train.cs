using System;
using System.Collections.Generic;
using System.Linq;

namespace CircusTrein
{
    public class Train
    {
        public bool Fill_Train(int count)
        {
            List<Animal> animals = Create_Animals_List(count);
            List<Wagon> wagons = new List<Wagon>();
            Add_List_To_Train(animals, wagons);
            foreach (Wagon wagon in wagons)
            {
                Console.WriteLine(wagon.ToString());
            }
            Console.WriteLine("Total wagons needed: " + wagons.Count + " For a total of: " + animals.Count + " Animals");
            return true;
        }
        public void Add_List_To_Train(List<Animal> animals, List<Wagon> wagons)
        {
            wagons.Add(new Wagon { Wagon_Number = wagons.Count() });
            foreach (Animal animal in animals)
            {
                int count_Till_Full = 0;
                for (int i = 0; i < wagons.Count(); i++)
                {
                    count_Till_Full++;
                    if (wagons[i].Add_To_Wagon(animal))
                    {
                        break;
                    }
                    if (count_Till_Full == wagons.Count)
                    {
                        wagons.Add(new Wagon { Wagon_Number = wagons.Count() });
                        wagons[i + 1].Add_To_Wagon(animal);
                        break;                       
                    }
                }
            }
        }
        public List<Animal> Create_Animals_List(int count)
        {
            List<Animal> animals = new List<Animal> { };
            Random random = new Random { };
            for (int i = 0; i < count; i++)
            {
                animals.Add(Create_Random_Animal(i, random.Next(0, 3), random.Next(0, 2)));
            }
            return animals;
        }
        public Animal Create_Random_Animal(int name, int weight, int carnivorous)
        {
            Animal animal = new Animal { Name = Convert.ToString(name) };
            if (weight == 0) { animal.Weight = 1; }
            else if (weight == 1) { animal.Weight = 3; }
            else if (weight == 2) { animal.Weight = 5; }

            if (carnivorous == 0) { animal.Carnivorous = false; }
            else if (carnivorous == 1) { animal.Carnivorous = true; }
            return animal;
        }
    }
}
