using System;

namespace Parser.Models.Analytics.ChatBots.GigaChat
{
    public class GigaChatMessage
    {
        public string role;
        public string content;

        public GigaChatMessage(string role, string content)
        {
            this.role = role;
            this.content = content;
        }
    }
}
