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
            Future future = new Future();
            future.LuckyChance(birthday.Month);

            Now now = new Now();//пример полиморфизма
            now.LuckyChance(birthday.Day);

            birthdayDate birthday1 = new birthdayDate(); // Обьявление обьекта класса
            birthday1.GetInfo();
            Console.WriteLine("Number of user - " + birthday1.GetObjectNumbers());
            Future future1= new Future();
            future.LuckyChance(birthday1.Month);

            birthdayDate birthday2 = new birthdayDate(); // Обьявление обьекта класса
            birthday2.GetInfo();
            Console.WriteLine("Number of user - " + birthday2.GetObjectNumbers());
            Future future2= new Future();
            future.LuckyChance(birthday2.Month);

        }
    }
}