using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // PART 1
        // A one-dimensional array of strings.
        string[] names = { "Nick", "Katie", "Penelope", "Gerty", "Wini", "Angus" };

        // Asks the user to input some text.
        Console.WriteLine("Please type in the following word as written \"Perkins\".");
        string input = Console.ReadLine();

        // A loop that iterates through each string in the array and adds the user's text input to the end of each string.
        for (int i = 0; i < names.Length; i++)
        {
            names[i] = names[i] + " " + input;
        }

        // A loop that prints off each string in the array on a seperate line.
        for (int i = 0; i < names.Length; i++)
        {
            Console.WriteLine(names[i]);
        }
        Console.ReadLine();


        // PART 2
        // Infinite loop that has been fixed.
        int j = 0;
        //while (true)
        while (j < 6)
        {
            Console.WriteLine(j);
            j++;
        }
        Console.ReadLine();

        //PART 3
        // A loop where the comparison that's used to determine whether to continue iterating the loop is a "<"
        int k = 0;
        while (k < 11)
        {
            Console.WriteLine(k);
            k++;
        }
        Console.ReadLine();

        // A loop where the comparison that's used to determine whether to continue iterating the loop is a "<="
        int l = 0;
        while (l <= 10)
        {
            Console.WriteLine(l);
            l++;
        }
        Console.ReadLine();

        // PART 4
        // A list of strings where each item in the list is unique.
        List<string> cities = new List<string>() { "Portland", "Salt Lake City", "New York City", "San Diego", "Chicago" };

        // Asks the user to input text to search for in the list.
        Console.WriteLine("Input a city name to search a list of cities. (Example: Portland)");
        string search = Console.ReadLine();

        // A loop that iterates through the list and then displays the index of the list that contains matching text on the screen.
        // Checks if the user put in text that isn't on the list and, if they did, tells the user their input is not on the list.
        // Stops the loop from executing once a match has been found.
        foreach (string city in cities)
        {
            if (cities.Contains(search))
            {
                Console.WriteLine("The index of the city you searched is: "+ cities.IndexOf(search));
                Console.ReadLine();
                break;
            }
            else
            {
                Console.WriteLine("Your input is not on the list of cities.");
                Console.ReadLine();
                break;

            }
        }


        //PART 5
        // A list of stings that has at least two identical strings in the list.
        // Asks the user to select text to search for in the list.
        List<string> colors = new List<string>() { "red", "green", "red", "green", "blue" };
        Console.WriteLine("Input a color from the following options to display the indices of the items matching the color you selected; red, green, blue.");
        string guess = Console.ReadLine();

        // A loop that iterates through the list and then displays the indicies of the items matching the user selected text.
        for (int i = 0; i < colors.Count; i++)
        {
            string color = colors[i];
            if (color.Contains(guess))
            {
                Console.WriteLine("Index {0}: Is a match!", i);
            }
            else
            {
                Console.WriteLine("Index {0}: Is NOT a match.", i);
            }
        }
        Console.ReadLine();

        // PART 6
        // A list of strings that has at least two identical strings in the list.
        List<string> actions = new List<string>() { "Go", "Stop", "Go", "Stop", "Wait" };
        List<string> passingActions = new List<string>();
        // A foreach loop that evaluates each item in the list, and displays a message showing the string and whether or not it has already appeared in the list.
        foreach (string action in actions)
        {
            if (passingActions.Contains(action))
            {
                Console.WriteLine($"Item {action} has already appeared on the list.");
            }
            else
            {
                Console.WriteLine($"Item {action} is the first instance of its kind on the list.");
                passingActions.Add(action);
            }
            Console.ReadLine();
        }
    }
}