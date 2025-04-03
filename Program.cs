using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

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
    }
}
