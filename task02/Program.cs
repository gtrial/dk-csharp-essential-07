using System;

namespace task02
{
    internal struct Train
    {
        public Train(string destination, int number, DateTime departure) : this()
        {
            Destination = destination;
            Number = number;
            Departure = departure;
        }

        public string Destination { get; set; }

        public int Number { get; set; }

        public DateTime Departure { get; set; }
    }

    internal static class Program
    {
        private static void Main()
        {
            Train[] trains = new Train[8];
            for (int i = 0; i < 8; i++)
            {

                Train instance = new Train();
                Console.Write("Destination: ");
                instance.Destination = Console.ReadLine();
                Console.Write("Train number: ");
                instance.Number = int.Parse(Console.ReadLine() ?? string.Empty);
                Console.Write("Departure time: ");
                instance.Departure = DateTime.Parse(Console.ReadLine() ?? string.Empty);//4/26/2021 12:00:00 AM
                trains[i] = instance;
            }
            Array.Sort(trains, (x, y) => x.Number.CompareTo(y.Number));

            Console.Write("Input train number for info:");
            int number = int.Parse(Console.ReadLine() ?? string.Empty);
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
