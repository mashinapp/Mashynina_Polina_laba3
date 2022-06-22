using System;


namespace Motorcycle
{
    // Мотоцикліст.Визначити ієрархію амуніції.Екіпірувати мотоцикліста.
    // Підрахувати вартість.Провести сортування амуніції на основі ваги.
    // Знайти елементи амуніції, відповідні заданому діапазону параметрів ціни.
    class Program
    {
        static void Main(string[] args)
        {
            Amunition Amunition = new();
            Amunition.AddAmunition(new("шолом"));
            Amunition.AddAmunition(new("рукавиці"));
            Amunition.AddAmunition(new("наколінники"));
            Amunition.AddAmunition(new("взуття"));
            Amunition.AddAmunition(new("желет"));

            Amunition.GetAllIamunition();

            Console.WriteLine();

           

            //Рахуємо загальну ціну
            Console.WriteLine("Загальна ціна: " + Amunition.Totalprice);

            //Сортування амуніції за вагою
            Console.WriteLine();
            Amunition.Sortamunition();

            //Пошук амуніції за діапазоном ціни
            Console.WriteLine();
            Console.WriteLine("Введіть через пробіл тільки дві межі, щоб знайти амуніцію в діапазоні вашої ціни");
            string[] str = Console.ReadLine().Split(' ');

            if (str.Length != 2)
                Exeption();

            Amunicia amun = Amunition.GetAmunitionByRange(int.Parse(str[0]), int.Parse(str[1]));
            if (amun == null)
                Console.WriteLine("У заданих межах не існує такої амуніції");
            else
                Console.WriteLine(amun.GetInformation());
        }

        static void Exeption()
        {
            throw new Exception(" введено некоректно");
        }
    }
}