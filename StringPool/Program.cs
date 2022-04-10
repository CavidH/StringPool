using System;

namespace StringPool
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "Helllo";
            string s1 = "Helllo";
            string s4 = new string("Helllo");


            string s2 = "hhhh";
            Console.WriteLine(s.GetHashCode());
            Console.WriteLine(s1.GetHashCode());
            Console.WriteLine(s4.GetHashCode());
            Console.WriteLine(s2.GetHashCode());
            Console.WriteLine(s2.GetHashCode());
            
            
            
            
        }
    }
}