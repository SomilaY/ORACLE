using System;

namespace ORACLE
{
    internal class Program
    {
        static void Main()
        {
            ORACLEchatbot.RetroStartUp();
            WelcomePage.OracleWelcome();
            ORACLEchatbot.StartChat();
            ORACLEchatbot.RetroStartUp();
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();


        }
    }
}