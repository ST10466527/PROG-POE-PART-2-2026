namespace PROG_POE_PART_2
{
    public class SentimentAnalyzer
    {
        public string Analyze(string input)
        {
            input = input.ToLower();
            if (input.Contains("worried"))
                return "It's understandable to feel worried. Let me share some tips to help you stay safe.";
            if (input.Contains("frustrated"))
                return "I hear your frustration. Cybersecurity can be tricky, but I’ll guide you through.";
            if (input.Contains("curious"))
                return "Curiosity is great! Let’s explore this topic together.";
            return null;
        }
    }
}