using System;

class ResponseService
{
    public string GetResponse(string input, string userName)
    {
        string lower = input.ToLower();

        // How are you?
        if (lower.Contains("how are you") || lower.Contains("how are u"))
            return $"I'm functioning perfectly, {userName}! Ready to help you stay secure online. 🔐";

        // What's your purpose?
        if (lower.Contains("purpose") || lower.Contains("what do you do") || lower.Contains("why do you exist"))
            return $"My purpose is to educate people about cybersecurity! I can help you with passwords, phishing, and safe browsing. 💡";

        // What can I ask about?
        if (lower.Contains("what can i ask") || lower.Contains("ask you about"))
            return $"You can ask me about:\n  • Password safety 🔒\n  • Phishing attacks 🎣\n  • Safe browsing 🌐\n  • How I'm doing 😊\n  • My purpose 🎯";

        // Password safety
        if (lower.Contains("password"))
            return "🔐 TIP: Use strong passwords with 12+ characters, mix of letters, numbers, and symbols! Never reuse passwords across sites.";

        // Phishing
        if (lower.Contains("phish"))
            return "🎣 WARNING: Never click suspicious links! Always verify sender email addresses before clicking. Legitimate companies won't ask for passwords via email.";

        // Safe browsing
        if (lower.Contains("browsing") || lower.Contains("browse"))
            return "🌐 SAFE BROWSING TIPS: Look for 'https://' and padlock icons. Avoid public Wi-Fi for banking. Keep your browser updated!";

        // Hello/Hi
        if (lower.Contains("hello") || lower.Contains("hi") || lower.Contains("hey"))
            return $"Hello {userName}! 👋 Ask me about passwords, phishing, or safe browsing!";

        // Help
        if (lower.Contains("help"))
            return "💡 HELP: Try asking:\n  • 'How are you?'\n  • 'What's your purpose?'\n  • 'What can I ask you about?'\n  • 'Password safety'\n  • 'Phishing'\n  • 'Safe browsing'\n  • Type 'quit' to exit";

        // Default response for invalid/unrecognized input
        return $"I didn't quite understand that. Could you rephrase? Try asking for 'help' to see what I can do! 🤔";
    }
}