using System;

namespace Parser.Models.Analytics.ChatBots.YandexGPT
{
    public class YandexGPTMessage
    {
        public string role;
        public string text;

        public YandexGPTMessage(string role, string text)
        {
            this.role = role;
            this.text = text;
        }
    }
}
