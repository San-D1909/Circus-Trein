using System;
using System.Collections.Generic;

namespace CircusTrein
{
    public class MainProgram
    {
        static void Main()
        {
            Train train = new Train { };
            (List<Wagon> wagons, List<Animal> animals) = train.StartTrain(10);
            PrintMethod(wagons, animals, train);
            Console.ReadLine();
        }

        public static void PrintMethod(List<Wagon> wagons, List<Animal> animals, Train train)
        {
            foreach (Wagon Trainpart in wagons)
            {
                Console.WriteLine("            ||             0            ||        ");
                Console.WriteLine("            ||-------------0------------||        ");
                Console.WriteLine("            ||             0            ||        ");
                Console.WriteLine("  ====================== ooooo =======================");
                foreach (Animal animal in Trainpart.Animals)
                {
                    if (animal.weight == Animal.Weight.Medium)
                    {
                        Console.WriteLine($"  == Animal: {animal.Name}   Weight: {animal.weight}   Diet: {animal.diet}  ==");
                    }
                    else
                    {
                        Console.WriteLine($"  == Animal: {animal.Name}   Weight: {animal.weight}    Diet: {animal.diet}  ==");
                    }
                }
                Console.WriteLine($"  ==             (Total FreeSpace: {Trainpart.Free_Space })               ==");
                Console.WriteLine("  ====================== ooooo =======================");
            }
            foreach (Wagon wagon in wagons)
            {
                Console.WriteLine(train.ToString(wagon));
            }
            Console.WriteLine("Total wagons needed: " + wagons.Count + " For a total of: " + animals.Count + " Animals");
        }
    }
}
