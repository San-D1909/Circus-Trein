using System;
using System.Collections.Generic;

namespace CircusTrein
{
    public class MainProgram
    {
        static void Main(string[] args)
        {
            Train train = new Train { };
            train.StartTrain(10);
            Console.ReadLine();
        }
    }
}
