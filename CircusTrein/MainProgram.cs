using System;
using System.Collections.Generic;

namespace CircusTrein
{
    public class MainProgram
    {
        static void Main()
        {           
            Train train = new Train { };
            PrintClass.PrintMethod(train.StartTrain(AnimalData.Animals()), AnimalData.Animals());
            Console.ReadLine();
        }
    }
}
