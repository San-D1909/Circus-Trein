using System;
using System.Collections.Generic;

namespace CircusTrein
{
    public class MainProgram
    {
        static void Main(string[] args)
        {
            int animalcount = 0;
            Train train = new Train { };
            List<Wagon> wagons = train.StartTrain(10);
            foreach(Wagon wagon in wagons)
            {
                Console.WriteLine(train.ToString(wagon));
                foreach(Animal animal in wagon.Animals)
                {
                    animalcount++;
                }
            }
            Console.WriteLine("Total wagons needed: " + wagons.Count + " For a total of: " + animalcount + " Animals");
            Console.ReadLine();
        }
    }
}
