using System;
using System.Threading;

class DisplayService
{
    public void ShowAsciiArt()
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine(@"
    ╔══════════════════════════════════════════════════════════╗
    ║                                                          ║
    ║      ██████╗██╗   ██╗██████╗ ███████╗██████╗             ║
    ║     ██╔════╝╚██╗ ██╔╝██╔══██╗██╔════╝██╔══██╗            ║
    ║     ██║      ╚████╔╝ ██████╔╝█████╗  ██████╔╝            ║
    ║     ██║       ╚██╔╝  ██╔══██╗██╔══╝  ██╔══██╗            ║
    ║     ╚██████╗   ██║   ██████╔╝███████╗██║  ██║            ║
    ║      ╚═════╝   ╚═╝   ╚═════╝ ╚══════╝╚═╝  ╚═╝            ║
    ║                                                          ║
    ║           🔐  CYBERSECURITY AWARENESS BOT  🔐            ║
    ║                                                          ║
    ╚══════════════════════════════════════════════════════════╝
        ");
        Console.ResetColor();
    }

    public void ShowWelcomeBorder()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("\n" + new string('═', 54));
        Console.WriteLine("     🌟 WELCOME TO YOUR CYBERSECURITY ASSISTANT 🌟");
        Console.WriteLine(new string('═', 54));
        Console.ResetColor();
    }

    public void PersonalisedWelcome(string userName)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine($"\n✨ Great to have you here, {userName}! ✨");
        Console.WriteLine("💬 I'm here to help you stay safe online.\n");
        Console.ResetColor();

        Thread.Sleep(800);

        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("📋 Type 'help' to see what I can do, or 'quit' to exit.\n");
        Console.ResetColor();
    }

    public void WriteColored(string text, ConsoleColor color)
    {
        Console.ForegroundColor = color;
        Console.Write(text);
        Console.ResetColor();
    }

    public void TypeMessage(string message, ConsoleColor color)
    {
        Console.ForegroundColor = color;
        Console.Write("└─ Bot: ");

        foreach (char c in message)
        {
            Console.Write(c);
            Thread.Sleep(12);
        }
        Console.WriteLine();
        Console.ResetColor();
    }
}