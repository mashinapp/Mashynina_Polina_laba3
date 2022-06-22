using System;
namespace Motorcycle
{
    public class Amunicia : Amunition 
    {
        private readonly string Name;

        private int _weight;
        private int _price;
        

        public int weight 
        {
            get => _weight;
            set => _weight = value;
        }

        public int price
        {
            get => _price;
            set => _price = value;
        }

        

        public Amunicia(string name, int weight, int price)
        {
            Name = name;
            _weight = weight;
            _price = price;
           
        }

        public Amunicia(string name)           //метод щоб надати рандомні характеристики амуніції
        {
            Random rand = new();
            Name = name;
            _weight = rand.Next(100, 1000);
            _price = rand.Next(1000, 10000);
            
        }

        public string GetInformation() //виводе стовбцями назву вагу і ціну
        {
            return $"Назва: {Name} | Вага: {weight} | Ціна: {price} |";
        }
    }
}