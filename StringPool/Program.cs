using System;

namespace StringPool
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "Helllo";
            string s1 = "Helllo";
            string s2 = "Helllo";
            string s3 = "Helllo";
            string s4 = new string(new []{'d','d'});
            Console.WriteLine(s.GetHashCode());
            Console.WriteLine(s1.GetHashCode());
            Console.WriteLine(s3.GetHashCode());
            Console.WriteLine(s3.GetHashCode());
            Console.WriteLine(s4.GetHashCode());
        }
    }
}