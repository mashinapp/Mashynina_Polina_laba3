using System;
using System.Collections.Generic;
using System.Linq;

namespace Motorcycle
{
    public class Amunition
    {
        private List<Amunicia> amunition;  //створюємо list(список) амуніцій

        public long Totalweight
        {
            get
            {
                long totalweight = 0;                //метод для отримання загальної ваги 

                foreach (var item in amunition)
                    totalweight += item.weight;

                return totalweight;
            }
        }

        public long Totalprice
        {
            get
            {
                long totalprice = 0;

                foreach (var item in amunition)
                    totalprice += item.price;      //метод для отримання ціни всієї амуніції

                return totalprice;
            }/Users/polinamashinina/Desktop/2.cs
        }

        public Amunition()
        {
            amunition = new();
        }

        public void AddAmunition(Amunicia amun)
        {
            amunition.Add(amun);
        }

        public void GetAllIamunition()
        {
            foreach (var amun in amunition)
                Console.WriteLine(amun.GetInformation());      //вивід отриманих амуніцій
        }


        //сортування амуніції за вагою
        public void Sortamunition()
        {
            amunition = amunition.OrderByDescending(t => t.weight).ToList();
            GetAllIamunition();
        }

        public Amunicia GetAmunitionByRange(int bottom, int up)
        {
            foreach (var amunition in amunition)
                if (amunition.price >= bottom && amunition.price  <= up)
                    return amunition;

            return null;
        }
    }
}