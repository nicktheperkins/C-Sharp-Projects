using System;
using System.Collections.Generic;


class Program
{
    static void Main()
    {
        // Creates a one-dimensional array of strings. Asks the user to select an index of the array and then displays the string at that index on the screen.
        // If the user selects an index that doesn't exist the program ends.
        string[] stringArray = { "Happy", "Sad", "Angry", "Excited", "Tired", "Joyful", "Stressed", "Beautiful", "Strong", "Confident" };

        Console.WriteLine("Input a number from 0 to 9 and the program will tell you what emotion you are feeling right now.");
        int mood = Convert.ToInt32(Console.ReadLine());
        if (mood < 0 || mood > 9)
        {
            Console.WriteLine("That is not a number between 0 and 9.");
            Console.ReadLine();
            return;
        }
        else
        {
            Console.WriteLine("Your mood is: " + stringArray[mood]);
            Console.ReadLine();
        }

        // Creates a one-dimensional array of integers. Asks the user to select an index of the Array and then displays the integer at that index on the screen.
        // If the user selects an index that doesn't exist the program ends.
        int[] numArray = { 54, 12, 24, 33, 17, 3, 75, 101, 45, 99 };

        Console.WriteLine("Input a number from 0 to 9 and the program will tell you what your lucky number is for today.");
        int number = Convert.ToInt32(Console.ReadLine());
        if (number < 0 || number > 9)
        {
            Console.WriteLine("That is not a number between 0 and 9.");
            Console.ReadLine();
            return;
        }
        else
        {
            Console.WriteLine("Your lucky number for today is: " + numArray[number]);
            Console.ReadLine();
        }

        // Creates a list of strings. Asks the user to select an index of the list and then displays the content at that index on the screen.
        List<string> stringList = new List<string>();
        stringList.Add("It is certain");
        stringList.Add("As I see it, yes.");
        stringList.Add("Reply hazy, try again");
        stringList.Add("Don't count on it.");
        stringList.Add("It is decidedly so.");
        stringList.Add("Most likely.");
        stringList.Add("Ask again later.");
        stringList.Add("My reply is no.");
        stringList.Add("Without a doubt");
        stringList.Add("Outlook good.");
        stringList.Add("Better not tell you now.");
        stringList.Add("My sources say no.");
        stringList.Add("Yes definitely.");
        stringList.Add("Yes.");
        stringList.Add("Cannot predict now.");
        stringList.Add("Outlook not so good.");
        stringList.Add("You may rely on it.");
        stringList.Add("Signs point to yes.");
        stringList.Add("Concentrate and ask again.");
        stringList.Add("Very doubtful.");

        Console.WriteLine("Ask yourself a question and input a number from 0 to 19 and the program will tell you the answer to your question.");
        int answer = Convert.ToInt32(Console.ReadLine());
        if (number < 0 || number > 19)
        {
            Console.WriteLine("That is not a number between 0 and 19.");
            Console.ReadLine();
            return;
        }
        else
        {
            Console.WriteLine(stringList[answer]);
            Console.ReadLine();
        }

    }
}
