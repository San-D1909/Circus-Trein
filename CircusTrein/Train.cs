using System;
using System.Collections.Generic;
using System.Linq;

namespace CircusTrein
{
    class Train
    {
        internal static void StartTrain()
        {
            List<Animal> animals = AnimalMethods.Create_Animals_List(50);
            Console.WriteLine("");
            List<Wagon> wagons = new List<Wagon>();
            Add_To_Train(animals, wagons);
            foreach (Wagon wagon in wagons)
            {
                Console.WriteLine(wagon.ToString());
            }
            Console.WriteLine("Total wagons needed: " + wagons.Count + " For a total of: " + animals.Count + " Animals");
        }
        static public void Add_To_Train(List<Animal> animals, List<Wagon> wagons)
        {
            int count_Till_Full = 0;
            wagons.Add(new Wagon { Wagon_Number = wagons.Count() });
            foreach (Animal animal in animals)
            {
                for (int i = 0; i < wagons.Count(); i++)
                {
                    count_Till_Full++;
                    if (WagonMethods.Add_To_Wagon(animal, wagons[i]))
                    {
                        count_Till_Full = 0;
                        break;
                    }
                    if (count_Till_Full == wagons.Count)
                    {
                        Wagon wagon = new Wagon { Wagon_Number = wagons.Count() };
                        wagons.Add(wagon);
                        count_Till_Full = 0;
                    }
                }
            }
        }



    }
}
