using System;

namespace ORACLE
{
    internal class ORACLEchatbot
    {
        public static void StartChat()
        {

            Console.Write("\nWhat is your name? ");

            string userName = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(userName))
            {
                SlowType($"\nHello {userName}! I'm here to assist you with anything cybersecurity related");

                ChatLoop(userName);
            }
            else
            {
                SlowType("\nI didn't get your name my friend");
                StartChat();
            }
        }

        private static void ChatLoop(string userName)
        {
            while (true)
            {
                Console.Write($"\n{userName}: ");
                string userInput = Console.ReadLine()?.ToLower();

                if (userInput == "exit" ||
                    userInput == "quit" ||
                    userInput == "goodbye" ||
                    userInput == "bye" ||
                    userInput == "i'm done" ||
                    userInput == "leave" ||
                    userInput == "end chat")
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    SlowType($"Bye Bye {userName}! I'll always be here for you");
                    Console.ResetColor();
                    break;
                }
                else if (userInput.Contains("how are you") ||
                         userInput.Contains("how's it going") ||
                         userInput.Contains("how do you feel") ||
                         userInput.Contains("are you okay") ||
                         userInput.Contains("what's up"))
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    SlowType($"ORACLE: I feel great {userName}! Thanks for asking.");
                    SlowType("I hope you feel great too!!!\n");
                    SlowType("I'm really excited to teach you about Cybersecurity");
                    SlowType("Anything you need help with cybersecurity related?");
                    Console.ResetColor();
                }
                else if (userInput.Contains("purpose") ||
                         userInput.Contains("what do you do") ||
                         userInput.Contains("why are you here") ||
                         userInput.Contains("your goal") ||
                         (userInput.Contains("what can i ask you") ||
                         userInput.Contains("topics") ||
                         userInput.Contains("what do you know")) )
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    SlowType($"ORACLE: I love this question {userName}!\n");
                    SlowType("I'm here to make sure your digital life stays protected.");
                    SlowType("Think of me as your digital mentor—I show you scams and risky situations before they happen,");
                    SlowType("so you're ready to handle them.\n");
                    SlowType("I cover:");
                    SlowType("░  Phishing emails");
                    SlowType("░  Password security");
                    SlowType("░  Safe browsing techniques");
                    SlowType("░  Suspicious links\n");
                    SlowType("Anything specific you'd like help with?");
                    Console.ResetColor();
                }            
                else if (userInput.Contains("password") ||
                         userInput.Contains("security") ||
                         userInput.Contains("protect") ||
                         userInput.Contains("secure"))
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    SlowType($"ORACLE: I'm so excited to teach you about passwords!!!");
                    SlowType("The importance of a password is to protect your personal information in the digital world.");

                    SlowType($"You need a strong password {userName}, because it helps protect you from dangerous characters trying to exploit your information—like scammers and hackers.\n");

                    SlowType("\n=====================================");
                    SlowType("       HOW TO PROTECT YOURSELF     ");
                    SlowType("=====================================\n");
                    SlowType("░  Make your password at least 8 characters or longer");
                    SlowType("░  Include a mix of uppercase & lowercase letters, numbers, and special characters");
                    SlowType("░  Avoid predictable patterns like '6789' or 'password1'");
                    SlowType("░  Consider using a password manager to securely store your passwords\n");

                    SlowType($"Example password: '1Luv{userName}!###'\n");
                    SlowType("Anything else?");
                    Console.ResetColor();
                }
                else if (userInput.Contains("phishing") ||
                         userInput.Contains("scam") ||
                         userInput.Contains("fraud"))
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    SlowType("ORACLE: I can't stand phishing scams! They're like digital pickpockets, sneaking into your space with fake emails, links, and messages that look legit\n");
                    SlowType("but are made to steal your personal information.\n");

                    SlowType($"Scammers impersonate trusted organizations, hoping you'll fall for their schemes.");
                    SlowType($"But don’t worry, {userName}, I’ll help you spot the red flags so they don’t get you!\n");

                    SlowType("\n=====================================");
                    SlowType("      SPOTTING A PHISHING SCAM     ");
                    SlowType("=====================================\n");
                    SlowType($"---> Emails starting with \"Dear Customer\" instead of \"Dear {userName}\"");
                    SlowType("---> Unknown attachments you weren’t expecting");
                    SlowType("---> Misspelled domain names");
                    SlowType("---> Urgent language like \"Claim your prize immediately!\", \"If you don’t update your account, it will be deleted\"\n");

                    SlowType($"I want you to stay safe from phishing scams {userName}, and this is how:");
                    SlowType("---> Add an extra layer of security like Two-Factor Authentication (2FA)");
                    SlowType("---> Don’t open strange attachments or links from unknown senders\n");
                    SlowType("---> Don’t enter your details on websites you don't know or trust\n");
                    SlowType("---> Never share your password\n");

                    SlowType($"Anything else you need {userName}?");
                    Console.ResetColor();
                }
                else if (userInput.Contains("safe browsing") || userInput.Contains("browsing safely") || userInput.Contains("safe"))
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    SlowType($"ORACLE: Safe browsing is all about protecting yourself while exploring the vast web! " +
                                      "Scammers and Hackers love setting traps—fake websites, shady ads, and hidden malware—but don’t worry " +
                                      "I’ve got your back from now on. Let’s make sure you stay safe online!");

                    SlowType("\n=====================================");
                    SlowType("       HOW TO BROWSE SAFETLY      ");
                    SlowType("=====================================\n");
                    SlowType("░ Always check for HTTPS or the lock icon in the address bar—this means the site is secure.");
                    SlowType("░ Double-check URLs before entering personal info—scammers create fake sites that look identical to real ones.");
                    SlowType("░ Avoid public Wi-Fi for sensitive tasks—hackers can get your data on unsecured networks.");
                    SlowType("░ Never download files from unknown sources—they could contain viruses or malware.");
                    SlowType("░ Keep your browser updated regularly—updates address security vulnerabilities.");
                    SlowType("░ Don’t click on suspicious pop-ups or ads—these often lead to scams or malicious sites.");

                    SlowType($"\nAnything else you need {userName}?");
                    Console.ResetColor();
                }
                else if (userInput.Contains("suspicious links") ||
                         userInput.Contains("unsafe links") ||
                         userInput.Contains("weird links"))
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    SlowType($"ORACLE: GREAT! I love this topic {userName}. Recognizing shady links is the key to avoiding scams online, and I want to make sure you stay safe!\n");

                    SlowType("\n=====================================");
                    SlowType("  HOW TO RECOGNIZE SUSPICIOUS LINKS      ");
                    SlowType("=====================================\n");
                    SlowType("---> Check for misspellings – Scammers use fake domains like \"Go0gle.com\" instead of \"Google.com\".");
                    SlowType("---> Watch out for shortened URLs – Hackers hide dangerous links behind URL shorteners like bit.ly or tinyurl.");
                    SlowType("---> Look for HTTPS encryption – A secure website always starts with \"https://\"—avoid sites that only have \"http://\".");
                    SlowType("---> Hover over links before clicking – On computers, hovering over a link shows the real destination.");
                    SlowType("---> Be cautious with unexpected emails or messages – If someone sends you a link out of nowhere, think twice before clicking.\n");
                    SlowType("---> Always check the senders email\n");

                    SlowType($"Anything else you need help with {userName}?");
                    Console.ResetColor();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    SlowType($"ORACLE: umm I don't understand what you meant by '{userInput}',{userName}\n");
                    SlowType($"Please rephrase for me");
                    Console.ResetColor();
                }
            }
        }

        public static void RetroStartUp()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            for (int i = 0; i < 5; i++)
            {
                Console.Write(".");
                System.Threading.Thread.Sleep(500);
            }
            Console.ResetColor();
        }

        static void SlowType(string message, int speed = 50)
        {            
            if (message.StartsWith("ORACLE:"))
            {
                Console.Write("ORACLE: "); 
                message = message.Substring(8);
            }


            foreach (char c in message)
            {
                Console.Write(c);
                System.Threading.Thread.Sleep(speed);
            }
            Console.WriteLine();
        }


    }
}