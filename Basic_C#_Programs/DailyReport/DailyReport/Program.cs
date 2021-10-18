using System;

namespace DailyReport
{
    class Program
    {
        static void Main()
        {
            // Entry messages
            Console.WriteLine("The Teach Academy");
            Console.WriteLine("Student Daily Report");

            // Asks for name and writes hello response back
            Console.WriteLine("What is your Name?");
            string yourName = Console.ReadLine();
            Console.WriteLine("Hello, " + yourName + "!");

            // Asks for course and reads response into a string
            Console.WriteLine("What course are you on?");
            string yourCourse = Console.ReadLine();

            // Asks for page number and reads and converts response to an integer
            Console.WriteLine("What page number?");
            string yourPageNumber = Console.ReadLine();
            int yourPageNum = Convert.ToInt32(yourPageNumber);

            // Asks if student needs help and reads and converts reponse to a boolean
            Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false\".");
            string needHelp = Console.ReadLine();
            bool needsHelp = Convert.ToBoolean(needHelp);

            // Asks for any positive experiences and reads response into a string
            Console.WriteLine("Were there any positive experiences you'd like to share? Please give specifics.");
            string positiveExperience = Console.ReadLine();

            // Asks for any other feedback and reads response into a string
            Console.WriteLine("Is there any other feedback you'd like to provide? Please be specific.");
            string otherFeedback = Console.ReadLine();

            // Asks for how many hours studied and reads and converts response into an integer
            Console.WriteLine("How many hours did you study today?");
            string studyTime = Console.ReadLine();
            int studyHours = Convert.ToInt32(studyTime);

            // Closing message and summary of responses
            Console.WriteLine("Thank you for your answers. An instructor will respond to this shortly. Have a great day!");
            Console.WriteLine("Student Name: " + yourName);
            Console.WriteLine("Course: " + yourCourse);
            Console.WriteLine("Page Number: " + yourPageNum);
            Console.WriteLine("Needs Help: " + needsHelp);
            Console.WriteLine("Positive Experience(s): " + positiveExperience);
            Console.WriteLine("Other Feedback: " + otherFeedback);
            Console.WriteLine("Hours Studied: " + studyHours);
            Console.Read();


        }
    }
}
