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
                SlowType($"\nHello {userName}! I'm here to assist you.");

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
                    SlowType($"Bye Bye {userName}!");
                    break;
                }
                else if (userInput.Contains("how are you") ||
                         userInput.Contains("how's it going") ||
                         userInput.Contains("how do you feel") ||
                         userInput.Contains("are you okay") ||
                         userInput.Contains("what's up"))
                {
                    SlowType($"ORACLE: I feel great {userName}! Thanks for asking. I hope you feel great too!!! anything cybersecurity-related you need help with?");
                }
                else if (userInput.Contains("purpose") ||
                         userInput.Contains("what do you do") ||
                         userInput.Contains("why are you here") ||
                         userInput.Contains("your goal"))
                {
                    SlowType($"\nORACLE: Nice question {userName}! I'm here to make sure your digital life stays protected. " +
                                      "Think of me as your digital mentor—I show you scams and risky situations before they happen, " +
                                      "so you're ready to handle them. " +
                                      "I cover phishing emails, password security, safe browsing techniques and teaching you the tricks of scammers etc. " +
                                      "Anything specific you'd like help with?");
                }
                else if (userInput.Contains("what can i ask you") ||
                         userInput.Contains("topics") ||
                         userInput.Contains("what do you know"))
                {
                    SlowType($"\nORACLE: I'm glad you asked {userName}! As your digital mentor " +
                                      "I can help you with: \n" +
                                      "- The dangers of a weak password and how to create strong passwords and protect your accounts \n" +
                                      "- How to spot phishing emails and avoid scams \n" +
                                      "- Recognizing suspicious links and staying safe online \n" +
                                      "- General cybersecurity tips to keep your personal information secure \n" +
                                      "I'm here to help you with any of these");
                }
                else if (userInput.Contains("password") ||
                         userInput.Contains("security") ||
                         userInput.Contains("protect") ||
                         userInput.Contains("secure"))
                {
                    SlowType($"\nORACLE: I'm so excited to teach about passwords!!! The importance of a password is to protect your personal information in the digital world.");
                    SlowType($"\nYou need a strong password, {userName}, because it helps protect you from dangerous characters trying to exploit your information—like scammers and hackers.");
                    SlowType("\nHere's how you ensure your information stays safe:");
                    SlowType("- Make your password at least 8 characters long");
                    SlowType("- Include a mix of uppercase & lowercase letters, numbers, and special characters");
                    SlowType("- Avoid predictable patterns like '123456' or 'password'");
                    SlowType("- Consider using a password manager to securely store your passwords");
                    SlowType($"\nExample password: '1Luv{userName}!###' (but always use something unique!)");
                    SlowType($"Anything else?");
                }
                else if (userInput.Contains("phishing") ||
                         userInput.Contains("scam") ||
                         userInput.Contains("fraud"))
                {
                    SlowType($"\nORACLE: I can’t stand phishing scams! They’re like digital pickpockets, sneaking into your inbox with fake emails, links, and messages that look legit—but they’re scams made to steal your personal information.");
                    SlowType($"These scammers impersonate trusted organizations, hoping you'll fall for their schemes. But don’t worry, {userName}, I’ll help you spot the red flags so they don't get you!");

                    SlowType("\nSpotting a phishing scam:");
                    SlowType($"- Emails starting with \"Dear Customer\" instead of \"Dear {userName}\"");
                    SlowType("- Unknown attachments you weren’t expecting");
                    SlowType("- Misspelled domains");
                    SlowType("- Urgent language like \"Claim your prize immediately!\", \"If you don’t update your account, it will be deleted\"");

                    SlowType($"\nI want you to stay safe {userName}, and this is how:");
                    SlowType("- Add an extra layer of security like Two-Factor Authentication (2FA)");
                    SlowType("- Don’t open strange attachments or links from unknown senders");
                    SlowType($"\nAnything else you need {userName}?");
                }
                else if (userInput.Contains("safe browsing") || userInput.Contains("browsing safely") || userInput.Contains("safe"))
                {
                    SlowType($"\nORACLE: Safe browsing is all about protecting yourself while exploring the vast web! " +
                                      "Cybercriminals love setting traps—fake websites, shady ads, and hidden malware—but don’t worry {userName} " +
                                      "I’ve got your back from now on. Let’s make sure you stay safe online!");

                    SlowType("\nHere’s how to browse safely:");
                    SlowType("-Always check for HTTPS or the lock icon in the address bar—this means the site is secure.");
                    SlowType("-Double-check URLs before entering personal info—scammers create fake sites that look identical to real ones.");
                    SlowType("-Avoid public Wi-Fi for sensitive tasks—hackers can intercept your data on unsecured networks.");
                    SlowType("-Never download files from unknown sources—they could contain viruses or malware.");
                    SlowType("-Keep your browser updated regularly—updates patch security vulnerabilities.");
                    SlowType("-Don’t click on suspicious pop-ups or ads—these often lead to scams or malicious sites.");

                    SlowType($"\nAnything else you need,{userName}?");
                }
                else if (userInput.Contains("suspicious links") || userInput.Contains("unsafe links") || userInput.Contains("weird links"))
                {
                    SlowType($"\nORACLE: GREAT! I love this topic {userName}. Recognizing shady links is the key to avoiding scams online, and I want to make sure you stay safe!");

                    SlowType("\nHere’s how to spot suspicious links:");
                    SlowType("-Check for misspellings – Scammers use fake domains like \"Go0gle.com\" instead of \"Google.com\".");
                    SlowType("-Watch out for shortened URLs – Hackers hide dangerous links behind URL shorteners like bit.ly or tinyurl.");
                    SlowType("-Look for HTTPS encryption – A secure website always starts with \"https://\"—avoid sites that only have \"http://\".");
                    SlowType("-Hover over links before clicking – On computers, hovering over a link shows the real destination.");
                    SlowType("-Be cautious with unexpected emails or messages– If someone sends you a link out of nowhere,think twice before clicking.");

                    SlowType($"\nAnything else you need help with {userName}?");
                }
                else
                {
                    SlowType($"ORACLE: umm I don't understand what you meant by '{userInput}',{userName}");
                }
            }
        }

        public static void RetroStartUp()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
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