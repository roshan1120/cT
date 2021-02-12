using System;

namespace Csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a String : ");
            string s1=Console.ReadLine();
            string s2="";
            for(int i=s1.Length-1;i>=0;i--)
            {
                    s2+=s1[i];
            }
            if(s1==s2)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
            
            Console.ReadLine();

        }
    }
}