using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study
{
    class Future : birthdayDate
    {
        int starNumber; //Зыёздный множитель
        int luckyNumber; // Значение удачи

        public int LuckyNumber
        {
            get { return luckyNumber; }
            set { luckyNumber = value; }
        }

        public int StarNumber
        {
            get { return starNumber; }
            set { starNumber = value; }
        }
        
        public void LuckyChance(int Month)
        {
            Random rnd = new Random(); //Обьект для генерации чисел
            starNumber = rnd.Next(1,10);

            if (Month > 15)
            {
                luckyNumber = Month + starNumber;
                Console.WriteLine("Your lucky chance is: " + luckyNumber);
            }else
            {
                luckyNumber = Month * starNumber;
                Console.WriteLine("Your lucky chance is: " + luckyNumber);
            }
        }
    }
}
