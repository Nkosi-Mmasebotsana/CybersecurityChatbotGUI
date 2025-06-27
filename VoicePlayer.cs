using System;
using System.Media;

namespace ChatbotPart1
{
    public class VoicePlayer
    {
        private readonly string greetingPath = "greeting.wav";

        public void PlayGreeting()
        {
            try
            {
                if (File.Exists(greetingPath))
                {
                    using (SoundPlayer player = new SoundPlayer(greetingPath))
                    {
                        player.PlaySync(); //PlaySync waits for the sound to finish
                    }
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Audio file not found: " + greetingPath);
                    Console.ResetColor();
                }
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Error playing audio: " + ex.Message);
                Console.ResetColor();
            }
        }
    }
}
