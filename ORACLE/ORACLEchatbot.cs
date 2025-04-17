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
                Console.WriteLine($"\nHello, {userName}! I'm here to assist you.");         

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
                    Console.WriteLine($"ORACLE: I feel great,{userName}! Thanks for asking. I hope you feel great too!!! anything you need help with?");
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
                    Console.WriteLine($"ORACLE: Nice question,{userName}! I'm here to make sure your digital life stays protected. " +
                                      "Think of me as your digital mentor—I show you scams and risky situations before they happen, " +
                                      "so you're ready to handle them. " +
                                      "I cover phishing emails, password security, and recognizing suspicious links. " +
                                      "Anything specific you'd like help with?");
                }
                else if (userInput.Contains("what can i ask you") ||
                         userInput.Contains("help topics") ||
                         userInput.Contains("what do you know"))
                {
                    Console.WriteLine($"ORACLE: I'm glad you asked, {userName}! As your digital mentor " +
                                      "I can help you with: \n" +
                                      "- The dangers of a weak password and how to create strong passwords and protect your accounts \n" +
                                      "- How to spot phishing emails and avoid scams \n" +
                                      "- Recognizing suspicious links and staying safe online \n" +
                                      "- General cybersecurity tips to keep your personal information secure \n" +
                                      "I'm here to help you with any of these");
                }
                else if (userInput.Contains("password"))
                {
                    Console.WriteLine($"ORACLE: I'm so excited to teach about passwords!!! The importance of a password is to protect your personal information in the digital world.");
                    Console.WriteLine($"\nYou need a strong password, {userName}, because it helps protect you from dangerous characters trying to exploit your information—like scammers and hackers.");
                    Console.WriteLine("\nHere's how you ensure your information stays safe:");
                    Console.WriteLine("- Make your password at least **8 characters long**");
                    Console.WriteLine("- Include a mix of **uppercase & lowercase letters, numbers, and special characters**");
                    Console.WriteLine("- Avoid **predictable patterns** like '123456' or 'password'");
                    Console.WriteLine("- Consider using a **password manager** to securely store your passwords");
                    Console.WriteLine($"\nExample password: **1Luv{userName}!###** (but always use something unique!)");
                }
                else
                {
                    Console.WriteLine($"ORACLE: I don't understand what you meant by'{userInput}'");
                }
            }
        }
    }
}