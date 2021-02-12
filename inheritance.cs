using System;
namespace Csharp
{
    class Animal
    {
        public void walk(string s)
        {
            Console.WriteLine(s+" can Walk");
        }
    }
    class Bird:Animal
    {
        public void fly(string s)
        {
            base.walk(s);
            Console.WriteLine(s+" can Fly");
        }
    }
    class Program
    {
        static void Main(String[] args)
        {
            Animal cat=new Animal();
            Bird Hawk=new Bird();
            cat.walk("Cat");
            Hawk.fly("Hawk");
            
        }
    }
}