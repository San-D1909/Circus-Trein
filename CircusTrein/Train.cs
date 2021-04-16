using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircusTrein
{
    public class Train
    {
        static public void Add_To_Train(List<Animal> animals, List<Wagon> wagons)
        {
            int count_Till_Full = 0;
            foreach (Animal animal in animals)
            {
                for (int i = 0; i < wagons.Count(); i++)
                {
                    count_Till_Full++;
                    if (Wagon.Add_To_Wagon(animal, wagons[i]))
                    {
                        count_Till_Full = 0;
                        break;
                    }                  
                    if (count_Till_Full == wagons.Count)
                    {
                        wagons = Wagon.Create_Wagons(wagons);
                        count_Till_Full = 0;
                    }
                }
            }
            return;
        }

        internal static void StartTrain()
        {
            List<Animal> animals = Animal.Create_Animals_List(50);
            List<Wagon> wagons = new List<Wagon> { };
            Wagon.Create_Wagons(wagons);
            Add_To_Train(animals, wagons);
            foreach (Wagon wagon in wagons)
            {
                Console.WriteLine(wagon.ToString());
            }
            Console.WriteLine("Total wagons needed: " + wagons.Count+" For a total of: "+ animals.Count+" Animals");
            return;
        }
    }
}
