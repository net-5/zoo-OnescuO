using System;

namespace TemaZoo
{
    class Program
    {
        static void Main(string[] args)
        {
            Zoo myZoo = new Zoo("NewYork Zoo");
            myZoo.AddAnimal("horse");
            myZoo.AddAnimal("wolf");
            myZoo.AddAnimal("fox");
            myZoo.AddAnimal("lion");
            myZoo.PresentZoo();
            myZoo.Transfer("lion");
            myZoo.Eat();
        }
    }
}
