using System;
using laba3;



higak volf = new higak("вовк", true);
Console.WriteLine(volf);

higak snake = new higak("змія", false);
Console.WriteLine(snake );  //записали два вида один приймає значення тру і гарчить інший ні
Console.WriteLine(volf.GetHashCode());//що може виконувати 1 
volf.richit();
volf.run();
volf.sleep();
volf.food(); 
Console.WriteLine(snake.GetHashCode());//що може виконувати 2

snake.richit();
snake.sleep();
snake.food();

