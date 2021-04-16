using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircusTrein
{
    public class Animal
    {
        public string Name { get; private set; }
        public int Weight { get; private set; }
        public bool Carnivorous { get; private set; }

        static public List<Animal> Create_Animals_List(int count)
        {
            Random random = new Random { };
            List<Animal> animals = new List<Animal> { };
            for (int i = 1; i <= count; i++)
            {
                int weight = random.Next(0, 3);
                int carnivorous = random.Next(0, 2);

                animals.Add(Create_Animal(i, weight, carnivorous));
            }
            return Order_List(animals);
        }
        static public Animal Create_Animal(int i, int weight, int carnivorous)
        {
            int Weight = 0;
            bool Carnivorous = true;
            if (weight == 0) { Weight = 1; }
            if (weight == 1) { Weight = 3; }
            if (weight == 2) { Weight = 5; }
            if (carnivorous == 0) { Carnivorous = false; }
            Animal animal = new Animal { Weight = Weight, Carnivorous = Carnivorous, Name = "Animal" + Convert.ToString(i) };
            return animal;
        }
        static public List<Animal> Order_List(List<Animal> animals)
        {
            var ordered_animals = animals.OrderByDescending(animal => animal.Carnivorous);
            ordered_animals.OrderByDescending(animal => animal.Weight);
            foreach (Animal animal in ordered_animals)
            {
                Console.Write(animal.Name + " is included   ");
            }
            Console.WriteLine("");
            return ordered_animals.ToList();
        }
    }
}

