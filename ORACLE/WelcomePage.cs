using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

namespace ORACLE
{
    internal class WelcomePage
    {
        private static string OracleGreeting = @"assets\ORACLE_GREETING.wav"; //The path to the ORACLE greeting
        public static void OracleWelcome()
        { 
            Console.Clear();  //Clears anything on the console for a clean start
            Console.WriteLine("O R A C L E");
            Console.WriteLine("─────────────");
            Console.WriteLine("   ██████");
            Console.WriteLine(" ██      ██");
            Console.WriteLine(" ██      ██");
            Console.WriteLine(" ██      ██"); //ASCII Art
            Console.WriteLine(" ██      ██");
            Console.WriteLine("   ██████\n");          

            SoundPlayer player = new SoundPlayer(OracleGreeting);
            try
            {
                player.Load();             
                Console.WriteLine("Welcome to ORACLE an Online Risk Awareness & Cybersecurity Learning Engine"); //plays the ORACLE greeting
                player.PlaySync();   //waits for the greeting to finish playing before continuing
            }
            catch (Exception error)
            {
                Console.WriteLine($"Error playing greeting: {error.Message}");
            }

        }
    }
}

