using System;

namespace ORACLE
{
    internal class ORACLEchatbot
    {
        public static void StartChat()
        {

            Console.Write("\nWhat is your name? "); //get users name

            string userName = Console.ReadLine(); //store users name

            if (!string.IsNullOrWhiteSpace(userName))
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                SlowType($"\nHello {userName}! Its nice to meet you Im Oracle\n");
                SlowType("╔═════════════════════════════════");
                SlowType("║          WHAT I COVER!         ║");
                SlowType("╚════════════════════════════════╝\n");
                SlowType("✅ Password security");
                SlowType("✅ Phishing scams");
                SlowType("✅ Safe browsing techniques");
                SlowType("✅ Recognizing suspicious links");
                SlowType("✅ General cybersecurity awareness\n");
                SlowType($"I'm here to assist you with anything cybersecurity related.");
                Console.ResetColor();
                ChatLoop(userName); //start the chatloop
            }
            else
            {
                SlowType("\nI didn't get your name my friend");
                StartChat(); //if the user didnt give name start again
            }
        }

        private static void ChatLoop(string userName)
        {
            string currentTopic = "";

            while (true) //chatbot is looped until user decides to exit
            {
                Console.Write($"\n{userName}: "); //dispalys users name
                string userInput = Console.ReadLine()?.ToLower(); //reads input and converts to lowercase for easy comparison

                if (userInput == "exit" ||
                    userInput == "quit" ||
                    userInput == "goodbye" ||
                    userInput == "bye" ||
                    userInput == "i'm done" ||
                    userInput == "leave" ||
                    userInput == "end chat")
                {                   
                    Console.ForegroundColor = ConsoleColor.Cyan; //sets colour 
                    List<string> farewellMessages = new List<string>
                    {
                     $"Bye Bye {userName}! I'll always be here for you.",
                     $"Goodbye {userName}, stay safe online!",
                     $"See you next time, {userName}! Keep practicing cybersecurity.",
                     $"Farewell, {userName}! I hope you learned something new.",
                     $"Until next time, {userName}! Stay cyber-aware."
                     };

                    Random rand = new Random();
                    int index = rand.Next(farewellMessages.Count);

                    // Display the randomly selected farewell message
                    SlowType(farewellMessages[index]);

                    Console.ResetColor(); // Resets text color to default
                    break;
                }
                else if (userInput.Contains("how are you") ||
                         userInput.Contains("how's it going") ||
                         userInput.Contains("how do you feel") ||
                         userInput.Contains("are you okay") ||
                         userInput.Contains("what's up"))
                {                  
                    Console.ForegroundColor = ConsoleColor.Cyan;

                    // Create a list of multiple possible responses
                    List<string> responses = new List<string>
                     {
                     $"ORACLE: I feel great, {userName}! Thanks for asking.😊",
                     $"ORACLE: I'm running smoothly, {userName}! No cyber threats in sight.🛡️",
                     $"ORACLE: Cybersecurity keeps me energized, {userName}!",
                     $"ORACLE: I'm doing well! Always excited to talk about online safety.💡"
                     };

                    // Select a random response from the list
                    Random rand = new Random();
                    int index = rand.Next(responses.Count);

                    // Display the randomized response
                    SlowType(responses[index]);

                    // Follow up with a consistent message                
                    SlowType("Anything you need help with cybersecurity related?");

                    Console.ResetColor();
                }
                else if (userInput.Contains("purpose") ||
                         userInput.Contains("what do you do") ||
                         userInput.Contains("why are you here") ||
                         userInput.Contains("your goal") ||
                         (userInput.Contains("what can i ask you") ||
                         userInput.Contains("topics") ||
                         userInput.Contains("what do you know")))
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    List<string> purposeResponses = new List<string>
                     {
                     $"ORACLE: I love this question, {userName}!\nI'm here to make sure your digital life stays protected.🛡️",
                     $"ORACLE: Great question, {userName}! My mission is to help you navigate the world of cybersecurity safely.🛡️",
                     $"ORACLE: Cybersecurity is my specialty, {userName}! I’m here to help you avoid scams and stay secure online.🔒",
                     $"ORACLE: I exist to make sure you never fall victim to online threats, {userName}! Let’s keep your data safe.🛡️",
                     $"ORACLE: My goal? To arm you with knowledge about cybersecurity so you're always one step ahead of scammers, {userName}.🔒"
                     };

                    // Select a random response from the list
                    Random rand = new Random();
                    int index = rand.Next(purposeResponses.Count);

                    // Display the randomly selected response
                    SlowType(purposeResponses[index]);

                    // Follow-up with consistent details about topics covered
                    SlowType("\n╔═════════════════════════════════");
                    SlowType("║          WHAT I COVER!         ║");
                    SlowType("╚════════════════════════════════╝\n");
                    SlowType("✅ Password security");
                    SlowType("✅ Phishing scams");
                    SlowType("✅ Safe browsing techniques");
                    SlowType("✅ Recognizing suspicious links");
                    SlowType("✅ General cybersecurity awareness\n");

                    SlowType("Anything specific you'd like help with?");

                    Console.ResetColor();
                }
                else if (userInput.Contains("password") ||
                         userInput.Contains("security") ||
                         userInput.Contains("protect") ||
                         userInput.Contains("secure"))
                {
                    currentTopic = "password";
                    Console.ForegroundColor = ConsoleColor.Cyan;

                    // Detect sentiment and provide an uplifting message if needed
                    if (userInput.Contains("worried") || userInput.Contains("frustrated") || userInput.Contains("confused") ||
                        userInput.Contains("stressed") || userInput.Contains("overwhelmed") || userInput.Contains("anxious") ||
                        userInput.Contains("nervous") || userInput.Contains("upset") || userInput.Contains("uncertain") ||
                        userInput.Contains("lost"))
                    {
                        SlowType("ORACLE: I understand that cybersecurity can feel overwhelming, but you're not alone! I’ll guide you through it step by step. You’ve got this! 😊");
                    }

                    if (userInput.Contains("excited") || userInput.Contains("happy") || userInput.Contains("love") ||
                       userInput.Contains("awesome") || userInput.Contains("cool") || userInput.Contains("great") ||
                       userInput.Contains("fantastic") || userInput.Contains("amazing") || userInput.Contains("enthusiastic"))
                    {
                        SlowType("ORACLE: I love your enthusiasm! Cybersecurity knowledge is empowering—let’s explore something fun today! 🔥");
                    }

                    // Randomly select one password response from the list
                    List<string> passwordResponses = new List<string>
                    {
                    $"ORACLE: I'm so excited to teach you about passwords, {userName}!",
                    $"ORACLE: Passwords are your first line of defense, {userName}! Let’s make them stronger.",
                    $"ORACLE: A strong password keeps your data safe from cyber threats. Here’s how to create one!",
                    $"ORACLE: Protecting your information starts with a strong password. Let’s go over the basics!"
                    };


                    Random rand = new Random();
                    int index = rand.Next(passwordResponses.Count);
                    SlowType(passwordResponses[index]);


                    SlowType("\n🔐 The importance of a password is to protect your personal information in the digital world.");
                    SlowType($"You need a strong password, {userName}, because it helps protect you from scammers and hackers.\n");

                    SlowType("╔═════════════════════════════════");
                    SlowType("║  PASSWORD SECURITY ESSENTIALS  ║");
                    SlowType("╚════════════════════════════════╝");

                    // List of possible tips for password security
                    List<string> passwordTips = new List<string>
                    {
                     "🔑 Make your password at least 12-16 characters long for stronger security.",
                     "🔑 Use a passphrase instead of a random password (e.g., 'ChickenOvaB33f!').",
                     "🔑 Include a mix of uppercase & lowercase letters, numbers, and special characters.",
                     "🔑 Never reuse passwords across different accounts.",
                     "🔑 Consider using a password manager** to securely store your passwords.",
                     "🔑 Enable multi-factor authentication (MFA) for extra security.",
                     "🔑 Beware of password-sharing scams, never share your credentials!"
                    };

                    List<string> selectedTips = passwordTips.OrderBy(x => rand.Next()).Take(3).ToList();
                    foreach (var tip in selectedTips)
                    {
                        SlowType(tip);
                    }

                    SlowType($"\nExample: '1Luv{userName}!###'\n");
                    SlowType("Is there anything else you'd like to explore? 😊");

                    Console.ResetColor(); // Reset text color to default
                }         
                else if (userInput.Contains("phishing") ||
                         userInput.Contains("scam") ||
                         userInput.Contains("fraud"))
                {
                    currentTopic = "phishing";
                    Console.ForegroundColor = ConsoleColor.Cyan;

                    if (userInput.Contains("worried") || userInput.Contains("frustrated") || userInput.Contains("confused") ||
                        userInput.Contains("stressed") || userInput.Contains("overwhelmed") || userInput.Contains("anxious") ||
                        userInput.Contains("nervous") || userInput.Contains("upset") || userInput.Contains("uncertain") ||
                        userInput.Contains("lost"))
                    {
                        SlowType("ORACLE: Phishing scams can be stressful, but don’t worry! I’ll guide you through it so you can stay safe and secure. You’ve got this! 🛡️");
                    }

                    List<string> phishingResponses = new List<string>
                    {
                     $"ORACLE: I can't stand phishing scams, {userName}! They're like digital pickpockets, sneaking into your inbox.",
                     $"ORACLE: Phishing scams are everywhere, {userName}! They disguise themselves as legitimate messages, but they're out to steal your info.",
                     $"ORACLE: Scammers are sneaky, {userName}! They create fake emails and links to trick people into handing over their personal details.",
                     $"ORACLE: Online fraud is a serious threat, {userName}. Let's go over how to spot and avoid phishing scams!"
                    };

                    Random rand = new Random();
                    int index = rand.Next(phishingResponses.Count);
                    SlowType(phishingResponses[index]);

                    SlowType("\n🔎 Scammers impersonate trusted organizations, hoping you'll fall for their tricks.");
                    SlowType($"But don’t worry, {userName}, I’ll help you spot the red flags so they don’t get you!\n");

                    SlowType("╔══════════════════════════════════╗");
                    SlowType("║    SPOTTING A PHISHING SCAM 🚨  ║");
                    SlowType("╚══════════════════════════════════╝\n");

                    List<string> phishingRedFlags = new List<string>
                    {
                     $"⚠️ Emails starting with \"Dear Customer\" instead of \"Dear {userName}\"",
                      "⚠️ Unknown attachments you weren’t expecting",
                      "⚠️ Misspelled domain names that look similar to real ones",
                      "⚠️ Urgent language like \"Claim your prize immediately!\", \"If you don’t update your account, it will be deleted\"",
                      "⚠️ Links that look trustworthy but redirect to fraudulent sites"
                    };

                    List<string> selectedRedFlags = phishingRedFlags.OrderBy(x => rand.Next()).Take(3).ToList();
                    foreach (var redFlag in phishingRedFlags)
                    {
                        SlowType(redFlag);
                    }

                    SlowType("\n╔═══════════════════════════════");
                    SlowType("║    HOW TO STAY PROTECTED🕵️     ║ ");
                    SlowType("╚════════════════════════════════╝");
                    List<string> phishingPreventionTips = new List<string>
                     {
                     "🔒 Add an extra layer of security like Two-Factor Authentication (2FA)",
                     "🚫 Never open strange attachments or links from unknown senders",
                     "🔎 Double-check email sender addresses**—scammers use subtle variations",
                     "🔗 Hover over links before clicking** to verify their real destination",
                     "❌ Never share your password**, no matter who asks for it",
                     "🛡️ Use a password manager** to prevent phishing attempts",
                     "🕵️ Be wary of QR codes**—fraudsters embed malicious links inside them"
                    };

                    List<string> selectedPreventionTips = phishingPreventionTips.OrderBy(x => rand.Next()).Take(3).ToList();
                    foreach (var tip in selectedPreventionTips)
                    {
                        SlowType(tip);
                    }

                    SlowType($"\nAnything else you need, {userName}?");
                    Console.ResetColor();
                }
                else if (userInput.Contains("safe browsing") || userInput.Contains("browsing safely") || userInput.Contains("safe"))
                {
                    currentTopic = "safe browising";
                    Console.ForegroundColor = ConsoleColor.Cyan;

                    if (userInput.Contains("worried") || userInput.Contains("frustrated") || userInput.Contains("confused") ||
                        userInput.Contains("stressed") || userInput.Contains("overwhelmed") || userInput.Contains("anxious") ||
                        userInput.Contains("nervous") || userInput.Contains("upset") || userInput.Contains("uncertain") ||
                        userInput.Contains("lost"))
                    {
                        SlowType("ORACLE: I totally understand how scary this all can be but dont worry I'm here!😊");
                    }

                    List<string> safeBrowsingResponses = new List<string>
                    {
                    $"ORACLE: Safe browsing is all about protecting yourself while exploring the vast web, {userName}!🌐",
                    $"ORACLE: Navigating the internet safely is key, {userName}! Let’s make sure you stay secure online.🛡️",
                    $"ORACLE: Scammers and hackers are lurking everywhere, {userName}! Let me show you how to browse safely.🌐",
                    $"ORACLE: Cyber threats are out there, {userName}, but don’t worry—I’ve got your back!🛡️",
                    $"ORACLE: The internet is a great place, {userName}, but it can also be risky. Here’s how to stay safe!🌐"
                    };


                    Random rand = new Random();
                    int index = rand.Next(safeBrowsingResponses.Count);
                    SlowType(safeBrowsingResponses[index]);

                    SlowType("\n╔═════════════════════════════════");
                    SlowType("║     HOW TO BROWSE SAFELY🔑     ║");
                    SlowType("╚════════════════════════════════╝");


                    List<string> safeBrowsingTips = new List<string>
                     {
                     "\n🔒 Always check for HTTPS or the lock icon** in the address bar—this means the site is secure.",
                     "🔎 Double-check URLs before entering personal info—scammers create fake sites that look identical to real ones.",
                     "📶 Avoid public Wi-Fi for sensitive tasks—hackers can get your data on unsecured networks.",
                     "⚠️ Never download files from unknown sources—they could contain viruses or malware.",
                     "🛠️ Keep your browser updated regularly—updates address security vulnerabilities.",
                     "🚫 Don’t click on suspicious pop-ups or ads—these often lead to scams or malicious sites.",
                     "🔍 Use a secure search engine that prioritizes privacy.",
                     "🛡️ Enable safe browsing settings** in your browser for added protection.",
                     "🔗 Always verify the legitimacy of links before clicking—hover over them to check the true destination."
                     };


                    List<string> selectedTips = safeBrowsingTips.OrderBy(x => rand.Next()).Take(3).ToList();
                    foreach (var tip in selectedTips)
                    {
                        SlowType(tip);
                    }

                    SlowType($"\nAnything else you need, {userName}?");
                    Console.ResetColor();
                }
                else if (userInput.Contains("suspicious links") ||
                         userInput.Contains("unsafe links") || userInput.Contains("links") ||
                         userInput.Contains("weird links"))
                {
                    currentTopic = "suspicious links";
                    Console.ForegroundColor = ConsoleColor.Cyan;

                    if (userInput.Contains("worried") || userInput.Contains("frustrated") || userInput.Contains("confused") || //sentiment response
                        userInput.Contains("stressed") || userInput.Contains("overwhelmed") || userInput.Contains("anxious") ||
                        userInput.Contains("nervous") || userInput.Contains("upset") || userInput.Contains("uncertain") ||
                        userInput.Contains("lost"))
                    {
                        SlowType($"ORACLE: Criminals are a scary threat on the internet but don't worry {userName}, I've got you💪");
                    }

                    List<string> suspiciousLinkResponses = new List<string>
                     {
                     $"ORACLE: GREAT! I love this topic, {userName}. Recognizing shady links is key to avoiding scams online!🔗",
                     $"ORACLE: Hackers love using fake links, {userName}. Let’s break down how to identify them.🔗",
                     $"ORACLE: Scammers are always finding new ways to disguise dangerous links, {userName}. Here's how to stay safe!🔗",
                     $"ORACLE: Suspicious links can lead to phishing attacks, {userName}. Let’s go over how to recognize them!🔗"
                     };


                    Random rand = new Random();
                    int index = rand.Next(suspiciousLinkResponses.Count);
                    SlowType(suspiciousLinkResponses[index]);

                    SlowType("\n╔════════════════════════════════════");
                    SlowType("║    HOW TO SPOT SUSPICIOUS LINKS 🕵️  ║ ");
                    SlowType("╚═════════════════════════════════════╝");


                    List<string> suspiciousLinkRedFlags = new List<string> //list of red flags that get randomly shown to user so its different everytime
                    {
                     "🔎 Check for misspellings – Scammers use fake domains like \"Go0gle.com\" instead of \"Google.com\".",
                     "⚠️ Watch out for shortened URLs – Hackers hide dangerous links behind URL shorteners like bit.ly or tinyurl.",
                     "🔒 Look for HTTPS encryption – A secure website starts with \"https://\"—avoid sites that only have \"http://\".",
                     "👀 Hover over links before clicking – On computers, hovering over a link shows the real destination.",
                     "📩 Be cautious with unexpected emails or messages** – If someone sends you a link out of nowhere, think twice before clicking.",
                     "📧 Always check the sender's email – Scammers use fake sender addresses that appear legitimate.",
                     "🚫 Avoid clicking on links in urgent messages** – If an email says \"Your account will be deactivated unless you click here!\", it’s likely a scam."
                    };

                    // Shuffle and display randomized suspicious link red flags
                    List<string> selectedRedFlags = suspiciousLinkRedFlags.OrderBy(x => rand.Next()).Take(3).ToList();
                    foreach (var redFlag in selectedRedFlags)
                    {
                        SlowType(redFlag);
                    }

                    SlowType($"\nHere’s how to protect yourself, {userName}:");

                    // List of possible suspicious link prevention tips
                    List<string> suspiciousLinkPreventionTips = new List<string>
                    {
                     "🔒 Enable Two-Factor Authentication (2FA) for extra protection.",
                     "🚫 Never open links from unknown sources—especially in unsolicited messages.",
                     "🛠️ Use a link checker tool to verify URLs before clicking.",
                     "🔗 If in doubt, go directly to the official website instead of clicking an email link.",
                     "⚠️ Enable safe browsing settings in your browser to detect malicious sites.",
                     "📷 Be cautious with QR codes—scammers embed phishing links inside them."
                    };

                    // Shuffle and display randomized prevention tips
                    List<string> selectedPreventionTips = suspiciousLinkPreventionTips.OrderBy(x => rand.Next()).Take(3).ToList();
                    foreach (var tip in selectedPreventionTips)
                    {
                        SlowType(tip);
                    }

                    SlowType($"\nAnything else you need help with, {userName}?");
                    Console.ResetColor();
                }
                //follow up responses for all the topics
                else if (userInput.Contains("password"))
                {
                    currentTopic = "password";
                    SlowType("ORACLE: Strong passwords are essential, but there's more to it! Do you want to learn about password managers?");
                }

                else if (currentTopic == "password")
                {
                    if (userInput.Contains("manager") || userInput.Contains("store pass"))
                    {
                        // Password manager response
                        SlowType("ORACLE: A password manager helps you securely store all your passwords in one place. Would you like to know how to choose the best one?");
                    }
                    else if (userInput.Contains("mfa") || userInput.Contains("2fa"))
                    {
                        // MFA explanation
                        SlowType("ORACLE: Multi-factor authentication (MFA) adds an extra layer of protection. It typically involves something you know (like a password) and something you have (like your phone). Would you like a step-by-step guide to set it up?");
                    }
                    else if (userInput.Contains("how often change"))
                    {
                        // Password change frequency
                        SlowType("ORACLE: It's recommended to change your passwords every 3 to 6 months, or sooner if you suspect a breach. Do you want to know how to make password updates easy?");
                    }
                    else
                    {
                        // General password tips follow-up
                        SlowType("ORACLE: Is there a specific aspect of password security you'd like to explore further?");
                    }
                }

                // Example-based follow-up responses
                else if (userInput.Contains("example") || userInput.Contains("show me"))
                {
                    if (currentTopic == "phishing")
                    {
                        // Phishing example
                        SlowType("ORACLE: Here's an example: A phishing email might ask you to click a link to 'update your account'. Always be cautious before clicking!");
                    }
                    else if (currentTopic == "password")
                    {
                        // Password example
                        SlowType("ORACLE: Here's an example of a strong password: 'BlueSky$123!' It includes uppercase, lowercase, numbers, and special characters!");
                    }
                }

                // Context-aware follow-up for password and phishing
                else if (userInput.Contains("what is") || userInput.Contains("explain"))
                {
                    if (currentTopic == "password")
                    {
                        SlowType("ORACLE: A password is a secret code that protects your personal information. It’s the first line of defense against unauthorized access to your accounts.");
                    }
                    else if (currentTopic == "phishing")
                    {
                        SlowType("ORACLE: Phishing is a scam where attackers try to trick you into giving them your personal details, often via fake emails or websites.");
                    }
                    else
                    {
                        // Default explanation if the topic isn't set
                        SlowType("ORACLE: Let me know what you'd like me to explain, and I'll help!");
                    }
                }
                // Handle follow-up questions about specific topics
                else if (userInput.Contains("trustworthy") && userInput.Contains("website"))
                {
                    SlowType("ORACLE: Great question! Look for HTTPS in the address bar, check for spelling errors in the URL, and avoid sites that ask for too much personal info. Do you want tips on checking for fake sites?");
                }

                else if (userInput.Contains("report") && userInput.Contains("phishing"))
                {
                    SlowType("ORACLE: You can report phishing emails to your email provider, your IT department (if at school or work), or directly at reportphishing@apwg.org. Would you like help drafting a report?");
                }

                else if (userInput.Contains("trick") && userInput.Contains("link"))
                {
                    SlowType("ORACLE: Cybercriminals often use urgent language like 'your account will be locked!' or fake rewards to get clicks. Want to see common phrases they use?");
                }

                //when the user asks for a tip for different topics
                else if (userInput.Contains("password tip"))
                {
                    List<string> passwordTips = new List<string>
                    {
                    "✅ Use a **passphrase** instead of a short password—it's easier to remember and harder to crack.",
                    "✅ **Never reuse passwords** across different accounts.",
                    "✅ **Enable multi-factor authentication (MFA)** whenever possible."
                    };
                    Random rand = new Random();
                    int index = rand.Next(passwordTips.Count);
                    SlowType(passwordTips[index]);

                }

                else if (userInput.Contains("phishing tip"))
                {
                    List<string> phishingTips = new List<string>
                    {
                     "🔎 Always verify sender email addresses—scammers often use subtle misspellings.",
                     "🚫 Never click links in unsolicited emails—instead, go directly to the official website.",
                     "⚠️ Beware of urgent messages**—scammers create fake emergencies to trick you into reacting."
                    };

                    Random rand = new Random();
                    int index = rand.Next(phishingTips.Count);
                    SlowType(phishingTips[index]);

                }

                else if (userInput.Contains("safe browsing tip"))
                {
                    List<string> safeBrowsingTips = new List<string>
                    {
                    "🔒 Always check for HTTPS and the lock icon before entering sensitive data.",
                    "🚫 Never enter credentials on sites from unknown emails—they could be phishing scams.",
                    "👀Hover over links before clicking to ensure they lead to legitimate destinations."
                    };

                    Random rand = new Random();
                    int index = rand.Next(safeBrowsingTips.Count);
                    SlowType(safeBrowsingTips[index]);

                }
                else //randomly selects a different response when the user puts something the chatbot doesn't understand
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    List<string> unknownResponses = new List<string>
                    {
                     $"ORACLE: Hmm, {userName}, I’m not sure I understand. Could you rephrase?",
                     $"ORACLE: Umm, I’m a bit lost here, {userName}. Mind explaining in a different way?",
                     $"ORACLE: I don’t quite get what you mean, {userName}. Try asking another way!",
                     $"ORACLE: Oops! That one puzzled me, {userName}. Could you clarify?",
                     $"ORACLE: I'm not sure what you meant by '{userInput}', {userName}. Can you reword it?"
                     };

                    
                    Random rand = new Random();
                    int index = rand.Next(unknownResponses.Count);

                    
                    SlowType(unknownResponses[index]);

                    Console.ResetColor();
                }
            }
        }

        public static void RetroStartUp()
        {
            Console.ForegroundColor = ConsoleColor.Cyan; //setting colour
            Console.Write("[LOADING]\n");
            for (int i = 0; i < 15; i++) //loops 10 times to look like a loading effect and play dots one by one
            {
                Console.Write("█");
                System.Threading.Thread.Sleep(500); //give the retro delayed effect
            }
            Console.ResetColor();
        }

        static void SlowType(string message, int speed = 20) //type writer like effect , message is the string to be typed out, speed is the speed the effect has
        {
            if (message.StartsWith("ORACLE:")) //if message starts with ORACLE this method is to prevent it from printing twice and so its printed separately
            {
                Console.Write("ORACLE: ");
                message = message.Substring(8).TrimStart();
            }


            foreach (char c in message) // loops through each each char so it is printed 1 at a time
            {
                Console.Write(c);
                System.Threading.Thread.Sleep(speed); //typewriter speed
            }
            Console.WriteLine();
        }


    }
}