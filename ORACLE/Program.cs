using System;

namespace ORACLE
{
    internal class Program
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            ORACLEchatbot.RetroStartUp();
            WelcomePage.OracleWelcome();
            ORACLEchatbot.StartChat();
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();


        }
    }
}