using System;

namespace ConsoleApp17
{
    class Program
    {
        static void Main(string[] args)
        {
            var ship = new TransportShip("Planet Express", 10);

            // keep loading it until we don't have enough space left
            while (true)
            {
                // create some new cargo that takes up 3 units of space 
                var cargo = new Cargo("Bottles of Slurm", 3);

                if (!ship.AddCargo(cargo))
                    break;
            }

            Console.WriteLine($"{ship.name}, space available: {ship.available}");
            ship.ListCargo();

            // unload the last inserted cargo item, available space +3
            ship.RemoveCargo();

            Console.WriteLine($"{ship.name}, space available: {ship.available}");
            ship.ListCargo();

            Console.ReadKey();
        }
    }
}
