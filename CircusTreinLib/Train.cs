using System;
using System.Collections.Generic;
using System.Linq;

namespace CircusTrein
{
    public class Train
    {
        public List<Wagon> StartTrain(List<Animal> animals)
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
    }
}
