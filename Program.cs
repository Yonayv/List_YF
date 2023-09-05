using System;
using System.Collections.Generic;
namespace Lists_YF
{
    internal class Program
    {
        /// <summary>
        /// In Main method string games is initialized with game titles
        /// An array of strings otherGames is initialized with a couple of more game titles
        /// a foreach loop is used to print each game in games list
        /// The number of items in the list is printed to the console
        /// A range is added to the array
        /// the items in the list are printed to the console
        /// if the list contains "Halo", then its printed, "MASTER CHEIF is in the house!" 
        /// Else, add "Halo" to the games list
        /// An int is assigned to the value of 6
        /// if the int is less than the number of games in the games list, then the games at index 6 is removed from the list. 
        /// Else "Game not found!" is printed
        /// "All games in the list:"  is printed to console
        /// Games list is looped & each game is printed to console again
        /// Games list is sorted 
        /// Each game is printed to console again
        /// A string array newList is initialized to the same size as the games list
        /// The games list is copied to the string array newList
        /// The games list is cleared 
        /// Each of the strings in the new list is printed
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            
            List<string> games = new List<string>
            {

                "CS:GO",
                "Halo 3",
                "Borderlands 3",
                "Fifa 22",
                "Minecraft",


            };

            string[] otherGames = new string[]
            {
                "Tiny Tina's Wonderlands",
                "Farcry 3",
            };

            foreach(string game in games)
            {
                Console.WriteLine(game);

            }

            Console.WriteLine($"Games in List: {games.Count}");

            games.AddRange(otherGames);

            Console.WriteLine($"Games in List: {games.Count}");

            if (games.Contains("Halo"))
            {
                Console.WriteLine("MASTER CHEIF IS IN THE HOUSE!!");

            }
            else
            {
                games.Add("Halo");
            }

            int myInt = 6;

            if(myInt < games.Count)
            {
                games.RemoveAt(myInt);
            }
            else
            {
                Console.WriteLine("Game not found!");
            }
             Console.WriteLine("zSorted games list:");
            foreach (string game in games)
            {
                Console.WriteLine(game);

            }

            string[] newList = new string[games.Count];

            games.CopyTo(newList);

            games.Clear();

            Console.WriteLine("\nNew List:");
            foreach(string game in newList)
            {
                Console.WriteLine(game);
            }
        }
    }
}