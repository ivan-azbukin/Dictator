using System;

namespace Dictator
{
    class Program
    {
        static void Main(string[] args)
        {
            var rocket = new Rocket();
            int ammoNumber = 13;
            var level = rocket.GetAmmoLevel(ammoNumber);
            Console.WriteLine($"Боеприпас с номер {ammoNumber} находится в отсеке {level}");
        }
    }
}
