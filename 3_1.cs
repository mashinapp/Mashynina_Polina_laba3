using System;
using System.Collections.Generic;
using System.Linq;

//Створити об'єкт класу Хижак, використовуючи класи Кігті, Зуби. 
//Методи: гарчати, бігти, спати, добувати їжу.

namespace laba3
{

    public class higak : kigti, zubi
    {
        public string type { get; set; } 
        public bool garchit { get; set; } // через ці властивості отримуємо і встановлємо знвчення
        public higak(string type, bool garchit) // гарчить має два значення true i false
        {
            this.type = type;
            this.garchit = garchit;
        }
        public void richit() //якщо garchit false= хижак не гарчить якщо garchit true= гарчить відповідно
        {
            if (garchit != false)
                Console.WriteLine($"{type} хижак гарчить");
            else Console.WriteLine($"{type} хижак не гарчить");
        }
        public void run()
        {
            Console.WriteLine($"{type} біжить");
        }
        public void sleep()
        {
            Console.WriteLine($"{type} спить");
        }
        public void food()
        {
            Console.WriteLine($"{type} добуває їжу");
        }
        public override bool Equals(object? obj)
        {
            if (obj is higak b) return type == b.type;
            return false;
        }
        public override int GetHashCode()
        {
            int hc;
            if (garchit == true)
                hc = 1;
            else hc = 2;
            return hc;
        }
        public override string ToString()
        {
            return $"вид хижака: {type}, може гарчати: {garchit}"; ;
        }
    }
    public interface kigti //інтерфейс kigti визначає ряд методів food i run які реалізуються в класі
    {
        public void food();
        public void run();
        
    }
    public interface zubi //інтерфейс zubi визначає ряд методів sleep i food які реалізуються в класі
    {
        public void sleep();
        public void food();
    }

}