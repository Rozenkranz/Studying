using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study1
{
    static class Developer
    {
        static string name = "Maksim";
        static int birth_year = 2002;

        public static string Name
        {
            get { return name; }
            set { name = value; }
        }

        public static int Birth_year { get { return birth_year; } }

        public static int get_age(int current_year)
        {
            int age = current_year - birth_year;
            return age;
        }

        public static int factorial(int n)
        {
            if (n <= 1)
                return 1;

            return (n * factorial(n - 1));
        }
    }
}
