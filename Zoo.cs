using System;
using System.Collections.Generic;
using System.Text;

namespace TemaZoo
{
    public class Zoo
    {


        public string Name { get; }
        private Dictionary<string, string> animalsList = new Dictionary<string, string>();
        public static string animalName;
        public string animalFood;
        public static int contor;
        
        public Zoo(string name)
        {
            Name = name;
     
        }
        public Dictionary<string, string> AnimalList
        {
            get
            {
                return this.animalsList;
            }
        }
       
        public static void AddAnimal()
        {
            animalName = "";
            contor = 0;
        }
        public void AddAnimal(string name, string food)
        {
            animalName = name;
            this.animalFood = food;
            contor++;
            this.animalsList.Add(name, food);
        }
        public static int GetContor()
        {
            return contor;
        }
        public void Transfer(string animal)
        {
            if (this.AnimalList.ContainsKey(animal))
            {
                Console.WriteLine(this.AnimalList.Remove(animal));
                contor--;
            }
            else
            {
                Console.WriteLine("We don`t have this animal in our garden.");
            }

        }
        public void PresentZoo()
        {
            int num = 1;
            Console.WriteLine("In our garden " + Name + " we have " + contor + " animals:");
            foreach (var animal in this.AnimalList)
            {
                Console.WriteLine(num + " . " + animal.Key + " who loves to eat " + animal.Value);
                num++;
            }

        }

    }
}
