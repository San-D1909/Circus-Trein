using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircusTrein
{
    public class PrintClass
    {

        public static void PrintMethod(List<Wagon> wagons, List<Animal> animals)
        {
            foreach (Wagon Trainpart in wagons)
            {
                Console.WriteLine("            ||             0            ||        ");
                Console.WriteLine("            ||-------------0------------||        ");
                Console.WriteLine("            ||             0            ||        ");
                Console.WriteLine("  ====================== ooooo =======================");
                Console.WriteLine($"  ==               (Wagon Number: {Trainpart.Wagon_Number })                ==");
                foreach (Animal animal in Trainpart.Animals)
                {
                    Console.WriteLine($"   Animal: {animal.Name}   Weight: {animal.weight}    Diet: {animal.diet}  ");
                }
                Console.WriteLine($"  ==             (Total FreeSpace: {Trainpart.FreeSpace })               ==");
                Console.WriteLine("  ====================== ooooo =======================");
            }
            Console.WriteLine("            ||             0            ||        ");
            Console.WriteLine("            ||-------------0------------||        ");
            Console.WriteLine("            ||             0            ||        ");
            Console.WriteLine("Total wagons needed: " + wagons.Count + " For a total of: " + animals.Count + " Animals");
        }
    }
}
