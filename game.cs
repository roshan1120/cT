using System;

namespace Csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r=new Random();
            int warriors=r.Next();
            int arrows=r.Next();
            
            Console.WriteLine("Number of warriors: "+warriors);
            Console.WriteLine("Number of Arrows: "+arrows);

            if((warriors*3)<=arrows)
            {
            Console.WriteLine("Its a Win !!");
            }
            else
            {
            Console.WriteLine("Its a Lose !!");       
            }
            Console.ReadLine();

        }
    }
}