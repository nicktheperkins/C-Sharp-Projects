using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> intList = new List<int>();
        intList.Add(4);
        intList.Add(10);
        intList.Remove(10);

        Console.WriteLine(intList[0]);
        Console.ReadLine();

        List<string> stringList = new List<string>();
        stringList.Add("Hello");
        stringList.Add("World");
        stringList.Remove("World");

        Console.WriteLine(stringList[0]);
        Console.ReadLine();

        //// Array are typically only used when working with a fix quantity of items that don't change.
        //// Creates a new instance of an array that is initialized and instantiated.
        //// Array creation must have array size or array initializer. [5]
        //int[] numArray = new int[5];
        //numArray[0] = 5;
        //numArray[1] = 2;
        //numArray[2] = 10;
        //numArray[3] = 200;
        //numArray[4] = 5000;

        //// Below is an easier example of how to initialize an array
        //// In order to initialize an array, you must create a new instance of that array.
        //int[] numArray1 = new int[] { 5, 2, 10, 200, 5000, 600, 2300 };

        //// Here is an even easier way to initialize an array
        //int[] numArray2 = { 5, 2, 10, 200, 5000, 600, 2300 };

        //// This is how to change an array value.
        //numArray2[5] = 650;

        //Console.WriteLine(numArray2[5]);
        //Console.WriteLine(numArray2[3]);
        //Console.WriteLine(numArray1[3]);
        //Console.WriteLine(numArray[3]);
        //Console.ReadLine();
    }
}
