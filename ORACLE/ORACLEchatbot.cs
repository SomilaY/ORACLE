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
                Console.WriteLine($"\nHello,{userName}! I'm here to assist you.");         

                ChatLoop(userName);
            }
            else
            {
                Console.WriteLine("\nI didn't get your name my friend");
                StartChat();
            }
        }

        private static void ChatLoop(string userName)
        {
            while (true)
            {
                Console.Write($"\n{userName}: ");
                string userInput = Console.ReadLine()?.ToLower();

                if (userInput == "exit")
                {
                    Console.WriteLine($"Bye Bye {userName}!");
                    break;
                }
                else if (userInput.Contains("how are you") ||
                         userInput.Contains("how's it going") ||
                         userInput.Contains("how do you feel") ||
                         userInput.Contains("are you okay") ||
                         userInput.Contains("what's up"))
                {
                    Console.WriteLine($"ORACLE: I feel great,{userName}! Thanks for asking. I hope you feel great too!!! anything cybersecurity-related you need help with?");
                }
                else if (!userInput.Contains("?"))
                {
                    Console.WriteLine("ORACLE: Just a friendly reminder to add a '?' if you're asking a question!");
                }
                else if (userInput.Contains("purpose") ||
                         userInput.Contains("what do you do") ||
                         userInput.Contains("why are you here") ||
                         userInput.Contains("your goal"))
                {
                    Console.WriteLine($"\nORACLE: Nice question,{userName}! I'm here to make sure your digital life stays protected. " +
                                      "Think of me as your digital mentor—I show you scams and risky situations before they happen, " +
                                      "so you're ready to handle them. " +
                                      "I cover phishing emails, password security, and recognizing suspicious links. " +
                                      "Anything specific you'd like help with?");
                }
                else if (userInput.Contains("what can i ask you") ||
                         userInput.Contains("help topics") ||
                         userInput.Contains("what do you know"))
                {
                    Console.WriteLine($"\nORACLE: I'm glad you asked, {userName}! As your digital mentor " +
                                      "I can help you with: \n" +
                                      "- The dangers of a weak password and how to create strong passwords and protect your accounts \n" +
                                      "- How to spot phishing emails and avoid scams \n" +
                                      "- Recognizing suspicious links and staying safe online \n" +
                                      "- General cybersecurity tips to keep your personal information secure \n" +
                                      "I'm here to help you with any of these");
                }
                else if (userInput.Contains("password"))
                {
                    Console.WriteLine($"\nORACLE: I'm so excited to teach about passwords!!! The importance of a password is to protect your personal information in the digital world.");
                    Console.WriteLine($"\nYou need a strong password, {userName}, because it helps protect you from dangerous characters trying to exploit your information—like scammers and hackers.");
                    Console.WriteLine("\nHere's how you ensure your information stays safe:");
                    Console.WriteLine("- Make your password at least **8 characters long**");
                    Console.WriteLine("- Include a mix of **uppercase & lowercase letters, numbers, and special characters**");
                    Console.WriteLine("- Avoid **predictable patterns** like '123456' or 'password'");
                    Console.WriteLine("- Consider using a **password manager** to securely store your passwords");
                    Console.WriteLine($"\nExample password: '1Luv{userName}!###' (but always use something unique!)");
                    Console.WriteLine($"Anything else?");
                }
                else if (userInput.Contains("phishing"))
                {
                    Console.WriteLine($"\nORACLE: I can’t stand phishing scams! They’re like digital pickpockets, sneaking into your inbox with fake emails, links, and messages that look legit—but they’re scams made to steal your personal information.");
                    Console.WriteLine($"These scammers impersonate trusted organizations, hoping you'll fall for their schemes. But don’t worry, {userName}, I’ll help you spot the red flags so they don't get you!");

                    Console.WriteLine("\nSpotting a phishing scam:");
                    Console.WriteLine($"- Emails starting with \"Dear Customer\" instead of \"Dear {userName}\"");
                    Console.WriteLine("- Unknown attachments you weren’t expecting");
                    Console.WriteLine("- Misspelled domains");
                    Console.WriteLine("- Urgent language like \"Claim your prize immediately!\", \"If you don’t update your account, it will be deleted\"");

                    Console.WriteLine($"\nI want you to stay safe {userName}, and this is how:");
                    Console.WriteLine("- Add an extra layer of security like Two-Factor Authentication (2FA)");
                    Console.WriteLine("- Don’t open strange attachments or links from unknown senders");
                    Console.WriteLine($"\nAnything else you need {userName}?");
                }
                else
                {
                    Console.WriteLine($"ORACLE: umm I don't understand what you meant by'{userInput}',{userName}");
                }
            }
        }
    }
}