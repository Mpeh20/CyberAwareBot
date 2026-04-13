using System;
using System.ComponentModel.DataAnnotations;

class Bot
{
    private string userName = string.Empty;
    private DisplayService display;
    private ResponseService responder;

    public Bot()
    {
        display = new DisplayService();
        responder = new ResponseService();
    }

    public void Run()
    {
        // Display ASCII art logo
        display.ShowAsciiArt();

        // Show welcome message
        display.ShowWelcomeBorder();

        // Get user name with validation
        GetUserName();

        // Personalised welcome
        display.PersonalisedWelcome(userName);

        // Start chat loop
        ChatLoop();
    }

    private void GetUserName()
    {
        display.WriteColored("What is your name? ", ConsoleColor.Yellow);
        userName = Console.ReadLine() ?? string.Empty;

        while (!Validator.IsValid(userName))
        {
            display.WriteColored("Please enter a valid name: ", ConsoleColor.Red);
            userName = Console.ReadLine() ?? string.Empty;
        }
    }

    private void ChatLoop()
    {
        while (true)
        {
            display.WriteColored("\n┌─ You: ", ConsoleColor.White);
            string input = Console.ReadLine() ?? string.Empty;

            if (!Validator.IsValid(input))
            {
                display.WriteColored("└─ Bot: I didn't quite understand that. Could you rephrase?\n", ConsoleColor.Red);
                continue;
            }

            if (input.ToLower() == "quit" || input.ToLower() == "exit")
                break;

            string response = responder.GetResponse(input, userName);
            display.TypeMessage(response, ConsoleColor.Cyan);
        }

        display.WriteColored("\n═══════════════════════════════════════\n", ConsoleColor.Magenta);
        display.WriteColored("👋 Session ended. Stay safe online!\n", ConsoleColor.Magenta);
        display.WriteColored("═══════════════════════════════════════\n", ConsoleColor.Magenta);
    }
}