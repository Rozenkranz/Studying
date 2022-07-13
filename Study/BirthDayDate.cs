using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study
{
    class birthdayDate
    {
        int year;
        int month;
        int day;

        enum Months { January , February, March, April, May, June, July, August, September, October, November, December}
        public int Year
        {
            get { return year; }
            set { year = value; }
        }

        public int Month
        {
            get { return month; }
            set { month = value; }
        }

        public int Day
        {
            get { return day; }
            set { day = value; }
        }
        public void GetInfo() //метод определения знака зодиака
        {
            string[] Zodiacs = { "Aries","Taurus","Gemini","Cancer","Leo","Virgo","Libro"
                    ,"Scorpio","Sagittarius","Capricorn","Acquarius","Pisces"};


            int monthZod = --Month;
            
            

            Console.WriteLine("Congratulations you are: " + Zodiacs[monthZod] );
        }

        public birthdayDate(int year, int month, int day)
        {
            this.year = year;
            this.month = month;
            this.day = day;
            
        }

        public birthdayDate() //конструктор для сбора данных пользователя
        {
            Console.WriteLine("Enter the year: ");
            int temp;
            bool result;
            do
            {
                result = int.TryParse(Console.ReadLine(), out temp); //проверка на правильность ввода данных

                if (result)
                    Year = temp;
                else
                    Console.WriteLine("You are bullshit\n Try again. Enter the year: ");               
            } while (!result);

            Console.WriteLine("Enter the month: ");
            
            do
            {
                result = int.TryParse(Console.ReadLine(), out temp); //проверка на правильность ввода данных

                if (result)
                    Month = temp;
                else
                    Console.WriteLine("You are bullshit\n Try again. Enter the month: ");
            } while (!result);

            Console.WriteLine("Enter the day: ");
            
            do
            {
                result = int.TryParse(Console.ReadLine(), out temp); //проверка на правильность ввода данных

                if (result)
                    Day = temp;
                else
                    Console.WriteLine("You are bullshit\n Try again. Enter the day: ");               
            } while (!result);

        }
    }
}
