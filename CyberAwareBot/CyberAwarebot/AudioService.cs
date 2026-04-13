using System;
using System.IO;
using System.Runtime.Versioning;

class AudioService
{
    public void PlayVoiceGreeting()
    {
        try
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;

#if WINDOWS
            // Play musical beeps as audio greeting
            // These beeps simulate a voice greeting
            Console.Beep(440, 300);  // "Hel-"
            Console.Beep(523, 200);  // "-lo"
            System.Threading.Thread.Sleep(100);
            Console.Beep(587, 400);  // "Wel-"
            Console.Beep(523, 300);  // "-come"
            System.Threading.Thread.Sleep(100);
            Console.Beep(659, 350);  // "Friend!"
#else
            Console.WriteLine("\n[Audio greeting not supported on this platform.]");
#endif

            // Display voice greeting text
            Console.WriteLine("\n╔════════════════════════════════════════════════════════╗");
            Console.WriteLine("║                    🎤 VOICE GREETING 🎤                 ║");
            Console.WriteLine("╚════════════════════════════════════════════════════════╝");
            Console.WriteLine("\n🔊 \"Hello! Welcome to the Cybersecurity Awareness Bot.\"");
            Console.WriteLine("🔊 \"I'm here to help you stay safe online.\"\n");
            Console.ResetColor();

            System.Threading.Thread.Sleep(1500);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"⚠ Audio error: {ex.Message}");
        }
    }
}