using System;
using System.Buffers;
using System.Windows;

namespace PROG_POE_PART_2
{
    public partial class ChatbotGUI : Window
    {
        private ChatbotCore bot = new ChatbotCore();
        private MemoryManager memory = new MemoryManager();
        private SentimentAnalyzer sentiment = new SentimentAnalyzer();

        public ChatbotGUI()
        {
            InitializeComponent();
            ChatOutput.Text = "Welcome to the Cybersecurity Awareness Chatbot!\n";
        }

        private void SendMessage(object sender, RoutedEventArgs e)
        {
            string input = UserInput.Text;
            ChatOutput.AppendText("You: " + input + "\n");

            string sentimentResponse = sentiment.Analyze(input);
            string response = sentimentResponse ?? bot.GetResponse(input);

            ChatOutput.AppendText("Bot: " + response + "\n\n");
            UserInput.Clear();
        }
    }
}