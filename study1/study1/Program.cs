using MyDeveloper;
using MyUser;

namespace Study1
{
    class Program
    {
        static void summ(ref int x, ref int y)
        {
            x += y;
        }

        static int param(ref int sum, params int[] values)
        {
            foreach (int i in values)
                sum += i;
            return sum;
        }

        public static void Main()
        {
            //                                              MAIN ARGS
            string[] args = Environment.GetCommandLineArgs();
            Console.WriteLine($"Executable file is:  {args[0]}");
            //                                              CLASS USER TEST
            /*
            user User1 = new user("Grisha1", "mjk71@mail.ru", "yasosubibu");
            user User2 = new user("Grisha2", "mjk71@mail.ru", "yasosubibu");
            user User3 = new user("Grisha3", "mjk71@mail.ru", "yasosubibu");
            user User4 = new user("Grisha4", "mjk71@mail.ru", "yasosubibu");
            user User5 = new user("Grisha5", "mjk71@mail.ru", "yasosubibu");

            Console.WriteLine("Was created users: " + user.Id);

            Console.WriteLine("Original pass:" + User1.Password);
            User1.ChangePassword();
            Console.WriteLine("New Random pass: " + User1.Password);
            User1.ChangePassword("yanacist");
            Console.WriteLine("New original pass: " + User1.Password);

            User1.Show();

            //                                              REF, OUT, PARAMS TEST

            int a = 3;
            int b = 2;

            Console.WriteLine("'a' before = " + a);
            summ(ref a, ref b);
            Console.WriteLine("'a' after = " + a);

            int sum = 0;
            Console.WriteLine("'sum' before = " + sum);
            int[] values = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            param(ref sum, values);
            Console.WriteLine("'sum' after = " + sum);
            */

            //                                              STATIC CLASS TEST

            Console.WriteLine("static Developer class TEST\nEnter the current year: ");

            int input;
            bool result = int.TryParse(Console.ReadLine(), out input);
            if (result)
            {
                Console.WriteLine("Success! current year = " + input);
                Console.WriteLine(Developer.get_age(input));
            }
            else
            {
                Console.WriteLine("Invalid year! Shuting down.");
            }

            //                                              RECURSION TEST
            Console.WriteLine($"Factorial 10 is :{Developer.factorial(10)}");

            

        }
    }
}