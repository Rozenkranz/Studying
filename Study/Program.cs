using System;

namespace Study
{
    class Program
    {
        public static void Main()
        {
            birthdayDate birthday = new birthdayDate(); // Обьявление обьекта класса
            birthday.GetInfo();
            Console.WriteLine("Number of user - " + birthday.GetObjectNumbers());

            birthdayDate birthday1 = new birthdayDate(); // Обьявление обьекта класса
            birthday1.GetInfo();
            Console.WriteLine("Number of user - " + birthday1.GetObjectNumbers());

            birthdayDate birthday2 = new birthdayDate(); // Обьявление обьекта класса
            birthday2.GetInfo();
            Console.WriteLine("Number of user - " + birthday2.GetObjectNumbers());
        }
    }
}