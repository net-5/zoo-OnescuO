using System;
using System.Collections.Generic;
using System.Text;

namespace TemaZoo
{
    public class Animals
    {

        private List<string> animalList = new List<string>();
        public List<string> AnimalList
        {
            get
            {
                return this.animalList;
            }
        }
        public static string animalName;
        
        public static int count;
        public Animals()
        {

        }
        static void AddAnimal()
        {
            animalName = "";
            count = 0;
        }
        public void AddAnimal(string name)
        {
            animalName = name;
            count++;
            this.animalList.Add(name);
        }
    }
}
