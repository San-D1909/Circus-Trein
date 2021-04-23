using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircusTrein
{
    public class WagonMethods
    {
        static public bool Check_If_Safe(Animal animal, Wagon wagon)
        {
            if (animal.Carnivorous == false && wagon.Animals.Count > 0)
            {
                for (int i = 0; i < wagon.Animals.Count; i++)
                {
                    if (wagon.Animals[i].Carnivorous == true && wagon.Animals[i].Weight >= animal.Weight)
                    {
                        return false;
                    }
                }
            }
            if (animal.Carnivorous == true && wagon.Animals.Count > 0)
            {
                for (int i = 0; i < wagon.Animals.Count; i++)
                {
                    if (wagon.Animals[i].Carnivorous == true || wagon.Animals[i].Weight <= animal.Weight)
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
                wagon.Animals.Add(animal);
                return true;
            }
            return false;
        }
    }
}
