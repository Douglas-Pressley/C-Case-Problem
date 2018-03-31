using System;

namespace GreenvilleRevenue
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many contestants are there this year: ");
            int x = Con();
            Console.WriteLine("How many contestants were there last year: ");
            int y = Con();
            Console.WriteLine(More(x, y));
            Re(x);


        }
        public static int Con()
        {
            Console.Write("Enter the number of contestants: ");
            int z;
            bool t = int.TryParse(Console.ReadLine(), out z);
            if (z >= 0 && z <= 30 && t == true)
            {
                return z;
            }
            else
            {
                Console.WriteLine("That was either not a number, or was not a valid number of contestants. (The limit is 30)");
                return Con();
            }
           
        }
        public static string More(int x, int y)
        {
            if (x > y * 2)
            {
                return "The competition is more than twice as big this year!";
            }
            else if (x >= y)
            {
                return "The competition is bigger than ever!";
            }
            else
            {
                return "A tighter race this year! Come out and cast your vote!";
            }
        }
        public static string[] Array(int x)
        {
            string[] name = new string[x * 2];
            int b = 1;
            for (int o = 0; o < name.Length; o += 2)
            {    
                Console.Write("Enter contestant " + b + "'s name: ");
                name[o] = Console.ReadLine();
                Console.Write("Enter " + name[o] + "'s talent: ");
                string g = Console.ReadLine().ToUpper();
                if (g == "S" || g == "D" || g == "M" || g == "O")
                {
                    name[o + 1] = g;
                }
                else
                {
                    Console.WriteLine("You entered an invalid talent code reenter " + name[o] + "'s information.");
                    o-= 2;
                    b--;
                }
                b += 1;
            }
            return name;
        }
        public static void Re(int x)
        {
            string[] o = Array(x);
            string h = "";

            while (h != "EXIT")
            {
                Console.Write("Enter a talent code to view the contestants with that talent, enter EXIT to stop. ");
                h = Console.ReadLine().ToUpper();
                if (h == "O" || h == "D" || h == "S" || h == "M")
                {
                    for (int u = 0; u < o.Length; u++)
                    {
                        if (o[u] == h)
                        {
                            Console.WriteLine(o[u - 1] + ": " + o[u]);
                        }
                    }
                }
                else if (h != "EXIT")
                {
                    Console.WriteLine("That is not a proper talent code. S, D, M, or O");
                }
            }
        }
    }
}