# CyberSecurity Awareness Bot – PROG POE Part 2 (2026)

## Project Overview

The **CyberSecurity Awareness Bot – Part 2** is an enhanced console-based chatbot application developed in **C# using .NET 8.0**. This version focuses on improving chatbot interaction, implementing smarter response handling, and creating a more engaging educational experience for users learning about cybersecurity awareness.

The application builds upon basic chatbot concepts by introducing improved conversational flow, modular programming, keyword recognition, and better user interaction techniques.


## Objectives of Part 2

The main objectives of this project were to:

* Improve chatbot functionality and interaction
* Implement modular and structured programming
* Enhance user experience within the console application
* Introduce keyword recognition and smarter responses
* Expand cybersecurity educational content
* Demonstrate object-oriented programming concepts

---

## Features Implemented in Part 2

### Advanced Chatbot Interaction

The chatbot responds dynamically to user input and maintains a more natural conversation flow.

### Keyword Recognition

The application detects cybersecurity-related keywords and provides relevant educational responses.

### Expanded Cybersecurity Topics

The chatbot now covers additional topics including:

* Malware
* Social engineering
* Data privacy
* Online scams
* Password security
* Phishing awareness
* Safe browsing habits

### Improved User Experience

Enhancements include:

* Color-coded console interface
* Typing animation effects
* Better menu navigation
* Clearer response formatting

### Modular Programming

The application code is separated into multiple classes and methods for improved organization and maintainability.

### Input Validation and Error Handling

The chatbot validates user input and handles invalid responses gracefully without crashing.

### Audio Greeting

A welcome sound effect is played when the program launches.

---

## Technologies Used

| Technology                | Purpose                                |
| ------------------------- | -------------------------------------- |
| C#                        | Main programming language              |
| .NET 8.0                  | Application framework                  |
| Visual Studio 2022        | Development environment                |
| GitHub                    | Version control and repository hosting |
| GitHub Actions            | Continuous Integration (CI)            |
| System.Windows.Extensions | Audio playback support                 |

---

## Project Structure

```text
PROG-POE-PART-2-2026/
│
├── .github/
│   └── workflows/
│       └── dotnet.yml
│
├── PROG-POE-PART-2/
│   ├── Program.cs
│   ├── Chatbot.cs
│   ├── Responses.cs
│   ├── greeting.wav
│   ├── PROG-POE-PART-2.csproj
│
└── README.md
```

---

## System Requirements

Before running the application, ensure the following are installed:

* .NET 8.0 SDK
* Visual Studio 2022 or later
* Windows Operating System

> Note: Audio playback functionality requires Windows.

---

## Installation and Setup

### 1. Clone the Repository

```bash
git clone https://github.com/ST10466527/PROG-POE-PART-2-2026.git
```

### 2. Open the Project

Open the project in:

* Visual Studio 2022
  OR
* Visual Studio Code with C# extensions

### 3. Navigate to the Project Folder

```bash
cd PROG-POE-PART-2-2026/PROG-POE-PART-2
```

### 4. Restore Dependencies

```bash
dotnet restore
```

### 5. Run the Application

```bash
dotnet run
```

---

## Example User Interaction

```text
====================================
 CYBERSECURITY AWARENESS CHATBOT
====================================

Enter your name:
> Kuhle

Welcome Kuhle!

How can I assist you today?

1. Password Safety
2. Phishing
3. Malware
4. Safe Browsing
5. Exit
```

---

## GitHub Actions Workflow

This project includes a GitHub Actions workflow that automatically:

* Restores dependencies
* Builds the application
* Verifies successful compilation

The workflow runs automatically whenever changes are pushed to the repository.

---

## Challenges Experienced

### Implementing Keyword Recognition

Creating accurate chatbot responses based on user keywords required proper response mapping and input handling.

### Improving Code Structure

Separating functionality into multiple classes improved maintainability and readability.

### Enhancing User Experience

Typing animations, colors, and improved menus were implemented to create a more interactive experience.

### Audio File Management

Managing audio playback and file paths required additional configuration and troubleshooting.

---

## Skills Developed

This project helped improve skills in:

* Object-oriented programming
* Console application development
* Input validation
* Exception handling
* Debugging and troubleshooting
* GitHub version control
* CI/CD workflows with GitHub Actions
* Modular programming techniques

---

## Future Improvements

Potential future enhancements include:

* AI-powered chatbot responses
* Voice recognition support
* Graphical User Interface (GUI)
* Database integration
* User login system
* Quiz and scoring functionality
* Saving conversation history
* Advanced cybersecurity simulations

---

## Screenshots
<img width="1090" height="609" alt="image" src="https://github.com/user-attachments/assets/013a9574-4d97-4d91-a93e-eeddfd40d50a" />



## Presentation Video
https://youtu.be/6oUS4KevS1M

---

## Author

### Silindokuhle Makunga

Second-Year Diploma in Software Development
Cape Town, South Africa

---

## Repository Link

https://github.com/ST10466527/PROG-POE-PART-2-2026

---

## License

This project is intended for educational purposes only.

---

## Final Notes

The CyberSecurity Awareness Bot – Part 2 demonstrates improved chatbot functionality, enhanced user interaction, and stronger programming practices through modular development and cybersecurity-focused educational features.

The project showcases practical software development skills while promoting cybersecurity awareness in an interactive and engaging way.
