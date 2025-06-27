using System;
using System.Threading;

namespace ChatbotPart1
{
    public static class UIHelper
    {
        public static void DisplayAsciiLogo()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(new string('*', 60));
            Console.WriteLine(@"
____             _                       _   _       _           
  / ___| _ __   ___| |_ _ __ ___  ___ _ __ | |_(_) __ _| | ___  ___ 
 | |    | '_ \ / _ \ __| '__/ _ \/ _ \ '_ \| __| |/ _` | |/ _ \/ __|
 | |___ | | | |  __/ |_| | |  __/  __/ | | | |_| | (_| | |  __/\__ \
  \____||_| |_|\___|\__|_|  \___|\___|_| |_|\__|_|\__, |_|\___||___/
                                                 |___/        
             ");
            Console.WriteLine(new string('*', 60));
            Console.ResetColor();
        }

        public static void TypingEffect(string message, ConsoleColor color)
        {
            Console.ForegroundColor = color;

            foreach (char c in message)
            {
                Console.Write(c);
                Thread.Sleep(80); //delay for typing effect
            }

            Console.WriteLine(); //only write a newline once
            Console.ResetColor();
        }
    }
}
