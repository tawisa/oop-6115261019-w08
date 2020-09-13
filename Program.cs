using System;

namespace oop_615261019_w08
{
    class Program
    {
        static void Main(string[] args)
        {
            Actor a1 = new Actor("Mario", "O", "32", "1989 December 4");
            Actor a2 = new Actor("Naphat", "Nine", "24", "1996 May 5");
            Movie m1 = new Movie("Pee Mak Phra Khanong", "Romance-Horror-Comedy", "Banjong Pisanthanakhun", a1);
            Movie m2 = new Movie("Friend Zone","Romance-Comedy", "Chayanop Boonprakob", a2);
            Console.WriteLine(m1);
            Console.WriteLine(m2);
        }
    }
}
