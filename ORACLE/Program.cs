using System;

namespace ORACLE
{
    internal class Program
    {
        static void Main()
        {
            // Display the welcome screen
            WelcomePage.OracleWelcome();
            ORACLEchatbot.StartChat();
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey(); // This keeps the console open until a key is pressed


        }
    }
}