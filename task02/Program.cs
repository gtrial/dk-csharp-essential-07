﻿using System;

namespace task02
{
    struct Train
    {
        private string destination;
        private int number;
        private DateTime departure;

        public Train(string destination, int number, DateTime departure) : this()
        {
            Destination = destination;
            Number = number;
            Departure = departure;
        }

        public string Destination { get => destination; set => destination = value; }
        public int Number { get => number; set => number = value; }
        public DateTime Departure { get => departure; set => departure = value; }
    }
    class Program
    {
        static void Main()
        {
            Train[] trains = new Train[8];
            for (int i = 0; i < 8; i++)
            {

                Train instance = new Train();
                Console.Write("Destination: ");
                instance.Destination = Console.ReadLine();
                Console.Write("Train number: ");
                instance.Number = int.Parse(Console.ReadLine());
                Console.Write("Departure time: ");
                instance.Departure = DateTime.Parse(Console.ReadLine());//4/26/2021 12:00:00 AM
                trains[i] = instance;
            }
            Array.Sort(trains, (x, y) => x.Number.CompareTo(y.Number));

            Console.Write("Input train number for info:");
            int number = int.Parse(Console.ReadLine());
            try
            {
                Train train = trains[number];
                Console.WriteLine($"Destination: {train.Destination}");
                Console.WriteLine($"Departure time: {train.Departure}");
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine($"Train with number {number} was not found");
            }
        }
    }
}
