using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            ////syntax for dictionary

            //Dictionary<string, string> snackMachine = new Dictionary<string, string>()
            //{
            //    {"A1","Twix" },
            //    {"A2","Twizzlers" },
            //    {"A3", "Reeses" },
            //    {"A4", "Sourpatch Kids" }

            //};

            //foreach (KeyValuePair<string,string>item in snackMachine)
            //{
            //    Console.WriteLine(item);
            //}

            //Dictionary<int, string> drinkMachine = new Dictionary<int, string>();
            ////using add method to add drinks
            //drinkMachine.Add(10, "Ginger Ale");
            //drinkMachine.Add(11, "Bottled Water");
            //drinkMachine.Add(12, "Orange");
            //drinkMachine.Add(13, "Cherry Coke");
            //drinkMachine.Add(14, "Mountain Dew Code Red");

            //Console.WriteLine(drinkMachine.Count);

            //foreach (KeyValuePair<int,string> drink in drinkMachine)
            //{               // drink .Value would return the values

            //    Console.WriteLine(drink.Key);
            //    Console.WriteLine(drink.Value);
            //}

            //creat a dictionary for a thearter coat check with 10 elements
            //the key will be a number and the value will be the coat style
            //print all the elements to the console

            Dictionary<int, string> coatCheck = new Dictionary<int, string>()
            {
                {1,"Puffer Coat" },
                {2,"Leather Jacket" },
                {3,"Blue Coat" },
                {4, "Trench Coat" },
                {5,"Car Coat" },
                {6,"That Coat" },
                {7,"Black Coat" },
                {8,"Green Coat" },
                {9,"Pea Coat" },
                {10,"Last Coat" }
            };

            foreach (KeyValuePair<int,string> coat in coatCheck)
            {
                Console.WriteLine(coat);
            }

            //Car valet with 10 cars the key will be customers lastname and the value will be the car make
            //print all the elements to the console

            Dictionary<string, string> valet = new Dictionary<string, string>()
            {
                {"Thomas","Focus" },
                {"Quesenberry", "Cobalt" },
                {"Wilson","Mustang" },
                {"Bundy", "Viper" },
                {"Stockman","Jaguar" },
                {"Walker","Speeder" },
                {"Wayne","Batmobile" },
                {"Krang","Technodrome" },
                {"House","Harley" },
                {"Homes","Carriage" },
                {"Goodman", "Beetle" }
            };

            foreach (KeyValuePair<string,string> car in valet)
            {
                Console.WriteLine(car);
            }
            //create a dictionary of 10 zoo animals the key will be the animal and the 
            //the value will be the number of animals
            //print the animal with the highest quantity first
            //remove the zoo animal with the lowest quantity
            //user should be able to enter animal if it does not exist

            Dictionary<string, int> zooKeeper = new Dictionary<string, int>()
            {
                {"Monkeys",3 },
                {"Tigers", 2 },
                {"Lions", 8 },
                {"Bears",4 },
                {"Cougars", 12},
                {"Rhinos",6 },
                {"Alligators",3 },
                {"Fox", 1 },
                {"Jackels",8 },
                {"Goldfishes",3 }
            };


            foreach (KeyValuePair<string,int> animal in zooKeeper.Where(KeyValuePair => KeyValuePair.Value == zooKeeper.Values.Min()).ToList())
            {
                zooKeeper.Remove(animal.Key);
            }
            var animalCountOrder = from pair in zooKeeper
                        orderby pair.Value descending
                        select pair;
            
            foreach (KeyValuePair<string,int> pair in animalCountOrder)
            {
                Console.WriteLine("{0} {1}", pair.Key, pair.Value);
            }

            




            //foreach (KeyValuePair<string,int> animal in zooKeeper.OrderBy(key => key.Value))
            //{
            //    Console.WriteLine(animal);
            //}
            //List<string> list = new List<string>(zooKeeper.Keys);

            //foreach (string temp in list)
            //{
            //    Console.WriteLine("{0}, {1}",temp,zooKeeper[temp]);
            //}
        }
    }
}
