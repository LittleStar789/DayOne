using System;

namespace DayOne
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string hello = "Hello";
            string world = "world";
            Console.WriteLine(hello + " " + world);
            Console.WriteLine();

           int number1 = 56;
            int number2 =  8;

            int sum = number1 + number2;
            int subtraction = number1 - number2;
            int mult = number1 * number2;
            int division = number1 / number2;

            Console.WriteLine("Сложение = " + sum);
            Console.WriteLine("Вычитание = " + subtraction);
            Console.WriteLine("Умножение = " + mult);
            Console.WriteLine("Деление = " + division);
            Console.WriteLine();


            Console.WriteLine("Введите имя: ");
            string name = Console.ReadLine();
            Console.WriteLine("Введите фамилию: ");
            string surname = Console.ReadLine();
            Console.WriteLine("Введите отчество: ");
            string patronymic = Console.ReadLine();
            Console.WriteLine(name + " " + surname + " " + patronymic);
            Console.WriteLine();

            // P - игрок,  M - монстр.
            Random rand = new Random();
            int health_P = 200; // здоровье игрока

            int armor_P = 20; // защита игрока

            int health_M = 180; // здоровье монстра

            int armor_M = 15; // защита монстра

            do
            {
                int damage_P = rand.Next(35, 80); // урон игрока
                int damage_done_1;
                    damage_done_1 = damage_P / armor_M;
                    health_M = health_M - damage_done_1;
                    Console.WriteLine("Здоровье монстра : " + health_M);
                    Console.WriteLine("Урон нанесенный игроком : " + damage_done_1);
                Console.WriteLine();

                int damage_M = rand.Next(30, 70); // урон монстра
                int damage_done_2;
                    damage_done_2 = damage_M / armor_P;
                    health_P = health_P - damage_done_2;
                    Console.WriteLine("Здоровье игрока : " + health_P);
                    Console.WriteLine("Урон нанесенный монстром : " + damage_done_2);
                Console.WriteLine();
            }
            while (health_P > 0 || health_M > 0);
        }
    }
}
