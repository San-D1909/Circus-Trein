using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircusTrein
{
    public class Wagon
    {
        public int Wagon_Number { get; set; }
        public int Free_Space
        {
            get { return free_Space; }
            private set { free_Space = value; }
        }
        private int free_Space = 10;
        public List<Animal> Animals { get; private set; } = new List<Animal>();

        public override string ToString()
        {
            return "Wagon Number: " + Wagon_Number + "    Animals: " + Animals.Count + "  Free Space: " + Free_Space;
        }
        public bool Check_If_Space(Animal animal)
        {
            if (Free_Space >= animal.Weight)
            {
                return true;
            }
            return false;
        }
        public bool Check_If_Safe(Animal animal)
        {
            if (animal.Carnivorous == false && Animals.Count > 0)
            {
                for (int i = 0; i < Animals.Count; i++)
                {
                    if (Animals[i].Carnivorous == true && Animals[i].Weight >= animal.Weight)
                    {
                        return false;
                    }
                }
            }
            if (animal.Carnivorous == true && Animals.Count > 0)
            {
                for (int i = 0; i < Animals.Count; i++)
                {
                    if (Animals[i].Carnivorous == true || Animals[i].Weight <= animal.Weight)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        public bool Add_To_Wagon(Animal animal)
        {
            if (Check_If_Space(animal))
            {
                if (Check_If_Safe(animal))
                {
                    Console.WriteLine(animal.Name + " has been added to wagon: " + Wagon_Number);
                    Animals.Add(animal);
                    Free_Space = Free_Space - animal.Weight;
                    return true;
                }
            }
            return false;
        }
    }
}
