using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO; // This namespace contains the file class.
using Casino;
using Casino.TwentyOne;
using System.Data.SqlClient;
using System.Data;

namespace TwentyOne
{
    class Program
    {
        static void Main(string[] args)
        {
            //string text = "Here is some text.";
            //File.WriteAllText(@"C:\Users\Nick\Downloads\log.txt", text); // Writes the text into a txt file and saves it in the downloads folder.
            //string readText = File.ReadAllText("C:\\Users\\Nick\\Downloads\\log.txt"); // Reads the text from the txt file saved in the downloads folder.


            //DateTime yearOfBirth = new DateTime(1995, 6, 7, 7, 0, 0); // DateTime is a struct value type and is not nullable.
            //DateTime yearOfGraduation = new DateTime(2013, 6, 1, 9, 0, 0);
            //TimeSpan ageAtGraduation = yearOfGraduation - yearOfBirth; // This will give the difference between the dates in days.

            //// The general rule for var is if the data type is in question you use var. But it is better to declare known data types for code readability. var implicitly defines a variable
            //var newDictionary = new Dictionary<string, string>(); // var can save typing by not adding Dictionary<string, string> before newDictionary.
            //var newPlayer = new Player("Nick"); // This assigns the name and gives a default balance of 100. This is called constructor chaining.
            //const string casinoName = "Grand Hotel and Casino"; // This is a constant. Once the program is compiled the constant can not change. This gives me more control over the program.
            //Console.WriteLine("Welcome to the {0}. Let's start by telling me your name.", casinoName); // This is an example of the constant being used.

            //Guid indentifier = Guid.NewGuid(); // Global Unique Identifier: guids are maining used to give an id to a user of the program. It it very dificult to create duplicate guids.

            Console.WriteLine("Welcome to the Grand Hotel and Casino. Let's start by telling me your name.");
            string playerName = Console.ReadLine();
            if (playerName.ToLower() == "admin")
            {
                List<ExceptionEntity> Exceptions = ReadExceptions();
                foreach (var exception in Exceptions)
                {
                    Console.Write(exception.Id + " | ");
                    Console.Write(exception.ExceptionType + " | ");
                    Console.Write(exception.ExceptionMessage + " | ");
                    Console.Write(exception.TimeStamp + " | ");
                    Console.WriteLine();
                }
                Console.Read();
                return;
            }
            bool validAnswer = false;
            int bank = 0;
            while (!validAnswer)
            {
                Console.WriteLine("And how much money did you bring today?");
                validAnswer = int.TryParse(Console.ReadLine(), out bank); // Trys to cast a string to an integer if it suceeded it has an out parameter to bank.
                if (!validAnswer) Console.WriteLine("Please enter digits only, no decimals.");
            }

            Console.WriteLine("Hello, {0}. Would you like to join a game of 21 right now?", playerName);
            string answer = Console.ReadLine().ToLower();
            if (answer == "yes" || answer == "yeah" || answer == "ya" || answer == "y")
            {
                Player player = new Player(playerName, bank);
                player.Id = Guid.NewGuid();
                using (StreamWriter file = new StreamWriter(@"C:\Users\Nick\Documents\GitHub\C-Sharp-Projects\Basic_C#_Programs\logs\log.txt", true)) // This logs the players Id to the txt file before they begin to play.
                {
                    file.WriteLine(player.Id);
                }
                Game game = new TwentyOneGame();
                game += player;
                player.isActivelyPlaying = true;
                while (player.isActivelyPlaying && player.Balance > 0)
                {
                    try
                    {
                        game.Play();
                    }
                    catch (FraudException ex)
                    {
                        Console.WriteLine(ex.Message);
                        UpdateDbWithException(ex); // This calls our exception method and passes the exception into it.
                        Console.ReadLine();
                        return;
                    }
                    catch (Exception ex)
                    {

                        Console.WriteLine("An error occurred. Please contact your System Administrator");
                        UpdateDbWithException(ex); 
                        Console.ReadLine();
                        return; // A return in a void method returns nothing. Just a little trick.
                    }
                }
                game -= player;
                Console.WriteLine("Thank you for playing!");
            }
            Console.WriteLine("Feel free to look around the casino. Bye for now.");
            Console.Read();
        }

        private static void UpdateDbWithException(Exception ex) // ADO.Net is a portion of the base class library that assists with comminicating with a SQL database.
        {
            string connectionString = @"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = TwentyOneGame; Integrated Security = True; Connect Timeout = 30; Encrypt = False; 
                                      TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False";

            string queryString = @"INSERT INTO Exceptions (ExceptionType, ExceptionMessage, TimeStamp) VALUES (@ExceptionType, @ExceptionMessage, @TimeStamp)"; // Parameterized queries are used to prevent SQL injection.

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection); // This sets up the connection to the database and the query structure.
                command.Parameters.Add("@ExceptionType", SqlDbType.VarChar); // This names the parameter and sets its datatype.
                command.Parameters.Add("@ExceptionMessage", SqlDbType.VarChar);
                command.Parameters.Add("@TimeStamp", SqlDbType.DateTime);

                command.Parameters["@ExceptionType"].Value = ex.GetType().ToString(); // This sets the value of the parameter and uses the GetType method to get the datatype of the exception.
                command.Parameters["@ExceptionMessage"].Value = ex.Message;
                command.Parameters["@TimeStamp"].Value = DateTime.Now;

                connection.Open(); // This opens the connection.
                command.ExecuteNonQuery(); // This executes the command. Since this is an INSERT statement it is a NonQuery.
                connection.Close(); // This closes the connection.
            }
        }
        private static List<ExceptionEntity> ReadExceptions()
        {
            string connectionString = @"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = TwentyOneGame; Integrated Security = True; Connect Timeout = 30; Encrypt = False; 
                                      TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False";

            string queryString = @"Select Id, ExceptionType, ExceptionMessage, TimeStamp From Exceptions"; // This is the query structure.

            List<ExceptionEntity> Exceptions = new List<ExceptionEntity>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection); // This setsup the command to execute.

                connection.Open(); // This opens the connection to the database.

                SqlDataReader reader = command.ExecuteReader(); // This is a ExecuteReader command because we are using a Select statement.

                while (reader.Read()) // This says while the reader is reading do some stuff. This loops through each record we are getting back.
                {
                    ExceptionEntity exception = new ExceptionEntity(); // This creates a new ExceptionEntity object.
                    exception.Id = Convert.ToInt32(reader["Id"]); // This records the Id column of the exception to the ExceptionEntity property but it needs to be converted into an integer because it is being pulled from a SQL database.
                    exception.ExceptionType = reader["ExceptionType"].ToString(); // The rest of these lines do the same as the last. We are converting SQL to C#.
                    exception.ExceptionMessage = reader["ExceptionMessage"].ToString(); // C# and SQL don't share data types so conversion is necessary when accessing the database.
                    exception.TimeStamp = Convert.ToDateTime(reader["TimeStamp"]);
                    Exceptions.Add(exception); // This takes all the records from the ExceptionEntity and adds them to the list of Exceptions outside of the using statement.
                }
                connection.Close(); // After everything is looped through we close the connection.
            }
            return Exceptions; // This returns the list of exceptions to the method ReadExceptions().

        }
    }
}
