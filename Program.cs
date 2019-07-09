using System;

namespace TemaZoo
{
    class Program
    {
        static void Main(string[] args)
        {
            Zoo zoo = new Zoo("NewYork zoo");
            zoo.AddAnimal("wolf", "sheep");
            zoo.AddAnimal("fox", "chicken");
            zoo.AddAnimal("lion", "meat");
            zoo.AddAnimal("monkey", "bananas");
            zoo.AddAnimal("horse1", "carrots");
            zoo.AddAnimal("horse2", "apples");
            zoo.PresentZoo();
            zoo.Transfer("fox");
            zoo.PresentZoo();
        }
    }
}
