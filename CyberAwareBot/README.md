# 🔐 Cybersecurity Awareness Bot

A conversational console-based chatbot designed to educate users about cybersecurity best practices, including password safety, phishing awareness, and safe browsing habits.

## 📋 Table of Contents
- [Features](#features)
- [Technologies Used](#technologies-used)
- [Project Structure](#project-structure)
- [Installation](#installation)
- [Usage](#usage)
- [Chat Commands](#chat-commands)
- [Sample Conversation](#sample-conversation)
- [GitHub Commits](#github-commits)
- [Troubleshooting](#troubleshooting)
- [Future Enhancements](#future-enhancements)
- [Author](#author)
- [License](#license)

## ✨ Features

### Core Features
- 🎤 **Voice Greeting** - Audio welcome message when the application launches
- 🎨 **ASCII Art Logo** - Visually appealing cybersecurity-themed banner
- 💬 **Personalised Interaction** - Asks for user's name and uses it throughout conversations
- 🔒 **Cybersecurity Education** - Provides information about:
  - Password safety
  - Phishing attacks
  - Safe browsing practices
- ✅ **Input Validation** - Handles empty inputs and unrecognized queries gracefully
- 🎨 **Coloured Console UI** - Enhanced visual experience with color-coded messages
- ⌨️ **Typing Effect** - Simulates natural conversation with delayed text output
- 📦 **Modular Code Structure** - Organized into separate classes for maintainability

### Response Categories
| Category | Keywords | Response Type |
|----------|----------|----------------|
| Greetings | hello, hi, hey | Personalised welcome |
| How are you? | how are you, how are u | Status update |
| Purpose | purpose, what do you do | Mission statement |
| Help | help | Command list |
| Password | password | Security tips |
| Phishing | phish, phishing | Warning & advice |
| Safe browsing | browsing, browse | Safety tips |

## 🛠️ Technologies Used

- **Language**: C# (.NET Core/.NET 5+)
- **Framework**: .NET Console Application
- **Audio**: System.Media.SoundPlayer (optional) / Console.Beep()
- **Version Control**: Git & GitHub
- **CI/CD**: GitHub Actions (optional)

## 📁 Project Structure
