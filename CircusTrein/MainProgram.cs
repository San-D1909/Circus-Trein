using System;
using System.Collections.Generic;

namespace CircusTrein
{
    public class MainProgram
    {
        static void Main()
        {
            Train train = new Train { };
            (List<Wagon> wagons,List<Animal> animals) = train.StartTrain(10);
            PrintMethod(wagons,animals,train);
            Console.ReadLine();
        }
        public static void PrintMethod(List<Wagon> wagons,List<Animal>animals, Train train)
        {
            foreach (Wagon wagon in wagons)
            {
                foreach (Animal animal in wagon.Animals)
                {
                    foreach(Animal animalx in animals)
                    {
                        if(animal.Name == animalx.Name)
                        {
                            Console.WriteLine("Animal "+ animalx.Name + " has been added to wagon: " + wagon.Wagon_Number);
                        }
                    }
                }
                Console.WriteLine(train.ToString(wagon)+"\n");
            }
            Console.WriteLine("Total wagons needed: " + wagons.Count + " For a total of: " + animals.Count + " Animals");
        }
    }
}
