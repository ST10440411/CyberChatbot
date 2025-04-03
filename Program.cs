using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using System.Security.Cryptography.X509Certificates;


namespace CyberChatbot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PlayVoiceGreeting();
            DisplayAsciiArt();

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("Enter your name: ");
            string userName = Console.ReadLine();
            Console.ResetColor();

            if (string.IsNullOrWhiteSpace(userName))
            {
                userName = "User"; // Default name if input is empty
            }

            Console.WriteLine($"\nWelcome, {userName}! I'm your Cybersecurity Awareness Bot. Ask me about online safety.");

            // Chat Loop
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("\nYou: ");
                Console.ResetColor();
                string userInput = Console.ReadLine()?.ToLower();

                if (string.IsNullOrWhiteSpace(userInput))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Bot: Please enter a valid question.");
                    Console.ResetColor();
                    continue;
                }

                if (userInput.Contains("exit") || userInput.Contains("quit"))
                {
                    Console.WriteLine("Bot: Stay safe online! Goodbye.");
                    break;
                }
                RespondToUser(userInput);


            }

        }
        static void PlayVoiceGreeting()
        {
            try
            {
                SoundPlayer player = new SoundPlayer("Greetings.wav");
                player.Play();
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Error playing greeting: " + ex.Message);
                Console.ResetColor();
            }
        }

        static void DisplayAsciiArt()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(@"   
  ██████╗ ██╗   ██╗██████╗ ███████╗███████╗
  ██╔══██╗██║   ██║██╔══██╗██╔════╝██╔════╝
  ██████╔╝██║   ██║██║  ██║█████╗  █████╗  
  ██╔═══╝ ██║   ██║██║  ██║██╔══╝  ██╔══╝  
  ██║     ╚██████╔╝██████╔╝███████╗███████╗
  ╚═╝      ╚═════╝ ╚═════╝ ╚══════╝╚══════╝

  Cybersecurity Awareness Bot
        Stay Safe Online!
        ");
            Console.ResetColor();
        }

        static void RespondToUser(string input)
        {
            if (input.Contains("how are you"))
            {
                Console.WriteLine("Bot: I am great thanks for asking!");
            }
            else if (input.Contains("what's your purpose"))
            {
                Console.WriteLine("Bot: I am here to educate you about cybersecurity threats and how to avoid them.");
            }
            else if (input.Contains("what can i ask you about"))
            {
                Console.WriteLine("Bot: You can ask me about phishing, password safety, and safe browsing practices.");
            }
            else if (input.Contains("password safety"))
            {
                Console.WriteLine("Bot: Use strong, unique passwords and enable two-factor authentication.");
            }
            else if (input.Contains("phishing"))
            {
                Console.WriteLine("Bot: Don't click on suspicious links or provide personal information via email.");
            }
            else if (input.Contains("safe browsing"))
            {
                Console.WriteLine("Bot: Always verify website URLs and avoid downloading unknown files.");
            }
            else
            {
                Console.WriteLine("Bot: I didn't quite understand that. Could you rephrase?");
            }







        }
    }
}
