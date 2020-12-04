using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace OOPPlanets
{
    class Program
    {
        public class Item
        {
            string name;
            int mass;

            public Item(string _name, int _mass)
            {
                name = _name;
                mass = _mass;
            }

            public string Name { get { return name; } }
            public int Mass { get { return mass; } }
        }
        static void Main(string[] args)
        {
            PlanetFunction();

        }
    
        public static void PlanetFunction()
        {
            string filePath = @"C:\Users\opilane\samples\Planets";
            string fileName = @"planets.txt";

            List<Item> planetItems = new List<Item>();

            List<string> linesFromFile = File.ReadAllLines(Path.Combine(filePath, fileName)).ToList();

            foreach (string line in linesFromFile)
            {
                string[] tempArray = line.Split(new char[] { '$' }, StringSplitOptions.RemoveEmptyEntries);
                Item newItem = new Item(tempArray[0], Int32.Parse(tempArray[1]));
                planetItems.Add(newItem);

               
            }
            int total = 0;
            foreach (Item item in planetItems)
            {
                Console.WriteLine($"Planet: {item.Name} | Mass: {item.Mass}");
                total += item.Mass;
            }

            Console.WriteLine("Total planet mass: " + total);

        }
    }
}       