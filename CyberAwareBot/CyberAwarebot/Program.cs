using System;

class Program
{
    static void Main()
    {
        // Play voice greeting immediately when app starts
        AudioService audio = new AudioService();
        audio.PlayVoiceGreeting();

        // Start the chatbot
        Bot chatbot = new Bot();
        chatbot.Run();
    }
}