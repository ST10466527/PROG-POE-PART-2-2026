using System;
using System.Collections.Generic;

namespace PROG_POE_PART_2
{
    public class ChatbotCore
    {
        private Dictionary<string, string[]> responses = new Dictionary<string, string[]>()
        {
            { "password", new string[] {
                "Use a mix of letters, numbers, and symbols in your password.",
                "Never reuse the same password across multiple accounts.",
                "Consider using a password manager to keep track of strong passwords."
            }},
            { "phishing", new string[] {
                "Be cautious of emails asking for personal information.",
                "Check the sender’s email address carefully before clicking links.",
                "Avoid downloading attachments from unknown sources."
            }},
            { "privacy", new string[] {
                "Review your social media privacy settings regularly.",
                "Limit the amount of personal information you share online.",
                "Use two-factor authentication whenever possible."
            }},
            { "scam", new string[] {
                "If it sounds too good to be true, it probably is.",
                "Don’t trust unsolicited offers or requests for money.",
                "Verify suspicious messages with the official company directly."
            }}
        };

        public string GetResponse(string userInput)
        {
            string lower = userInput.ToLower();

            // Exit logic
            if (lower.Contains("exit") || lower.Contains("quit") || lower.Contains("bye"))
            {
                return "Goodbye! Stay safe online.";
            }

            // Keyword detection
            foreach (var keyword in responses.Keys)
            {
                if (lower.Contains(keyword))
                {
                    var rand = new Random();
                    var options = responses[keyword];
                    return options[rand.Next(options.Length)];
                }
            }

            // Default response
            return "I’m not sure I understand. Can you try rephrasing?";
        }
    }
}