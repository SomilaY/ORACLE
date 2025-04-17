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
        private static string OracleGreeting = @"assets\ORACLE_GREETING.wav";
        public static void OracleWelcome()
        { 
            Console.Clear(); 
            Console.WriteLine("O R A C L E");
            Console.WriteLine("─────────────");
            Console.WriteLine("   ██████");
            Console.WriteLine(" ██      ██");
            Console.WriteLine(" ██      ██");
            Console.WriteLine(" ██      ██");
            Console.WriteLine(" ██      ██");
            Console.WriteLine("   ██████\n");          

            SoundPlayer player = new SoundPlayer(OracleGreeting);
            try
            {
                player.Load();
                player.Play();
                Console.WriteLine("Welcome to ORACLE an Online Risk Awareness & Cybersecurity Learning Engine");
            }
            catch (Exception error)
            {
                Console.WriteLine($"Error playing greeting: {error.Message}");
            }

        }
    }
}

