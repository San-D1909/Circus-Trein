﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircusTrein
{
    public class Wagon
    {
        public int Wagon_Number { get; set; }
        public int Free_Space { get; set; }
        private List<Animal> animals { get; set; } = new List<Animal>();
        public List<Animal> Animals { get { return animals; } }
        public override string ToString()
        {
            return "Wagon Number: " + Wagon_Number + "    Animals: " + Animals.Count + "  Free Space: " + Free_Space;
        }
        static public List<Wagon> Create_Wagons(List<Wagon> wagons)
        {
            wagons.Add(new Wagon { Wagon_Number = wagons.Count() }) ;
            return wagons;
        }
        static public bool Check_If_Safe(Animal animal, Wagon wagon)
        {
            if (animal.Carnivorous == false && wagon.animals.Count > 0)
            {
                for (int i = 0; i < wagon.animals.Count; i++)
                {
                    if (wagon.animals[i].Carnivorous == true && wagon.animals[i].Weight >= animal.Weight)
                    {
                        return false;
                    }
                }
            }
            if (animal.Carnivorous == true && wagon.animals.Count > 0)
            {
                for (int i = 0; i < wagon.animals.Count; i++)
                {
                    if (wagon.animals[i].Carnivorous == true || wagon.animals[i].Weight <= animal.Weight)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        static public bool Check_If_Space(Animal animal, Wagon wagon)
        {
            int space = 10;
            foreach (Animal cagedAnimal in wagon.Animals)
            {
                space = space - cagedAnimal.Weight;
            }
            if (space >= animal.Weight)
            {
                wagon.Free_Space = space;
                return true;
            }
            return false;
        }
        static public bool Check_If_Allowed(Animal animal, Wagon wagon)
        {
            if (Check_If_Space(animal, wagon))
            {
                if (Check_If_Safe(animal, wagon))
                {
                    return true;
                }
            }
            return false;
        }
        static public bool Add_To_Wagon(Animal animal, Wagon wagon)
        {
            if (Check_If_Allowed(animal, wagon))
            {
                Console.WriteLine(animal.Name + " has been added to wagon: " + wagon.Wagon_Number);
                wagon.animals.Add(animal);
                return true;
            }
            return false;
        }
    }
}