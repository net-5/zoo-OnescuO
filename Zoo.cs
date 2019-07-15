using System;
using System.Collections.Generic;
using System.Text;

namespace TemaZoo
{
    public enum FavoriteFood { Apple, Carrots, Meat, Chicken }
    public class Zoo : Animals, IAnimalsEat
    {
        public string ZooName { get; }
        private FavoriteFood favoriteFood;

        public static string animalFood;
        public Zoo(string zooName): base()
        {
            ZooName = zooName;
        }
        public void Transfer(string animal)
        {
            if (this.AnimalList.Contains(animal))
            {
                Console.Write(this.AnimalList.Remove(animal));
                count--;
            }
            else
            {
                Console.WriteLine("We don't have this animal in our garden.");
            }

        }

        public void PresentZoo()
        {
            int num = 1;
            Console.WriteLine("In gradina noastra " + ZooName + " avem " + count + " animale, dupa cum urmeaza: ");
            foreach (var animal in this.AnimalList)
            {
                Console.WriteLine(num + ". " + animal);
                num++;
            }
        }
        public FavoriteFood FavoriteMeal
        {
            get { return favoriteFood; }
            set { this.favoriteFood = value; } 
        }

        public void Eat()
        {
            Console.WriteLine($"I am {this.AnimalList.Contains("fox")} and i like to eat {this.favoriteFood}");
        }
    }
}
