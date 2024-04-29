using System;
using System.Text;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Threading.Tasks;

namespace Parser.Models.Analytics.ChatBots.YandexGPT
{
    public class YandexGPT
    {
        const string ApiKey = @"AQVN1kPWUPG6Z8i8wQ3rq7cc9Y7o967_zYKtBGcc";
        const string CatalogId = @"b1gufhrieol29pl9lhjq";

        private List<YandexGPTMessage> conversation;

        public YandexGPT()
        {
            conversation = new List<YandexGPTMessage>();
            //conversation.Add(new YandexGPTMessage(role: "system", text: "Ты специалист патентного ведомства. " +
            //    "Твоя задача ответь на мои вопросы, связанные с данной тематикой."));
        }

        public async Task<string> AskQuestion(string question, double temperature = 0.6)
        {
            string url = @"https://llm.api.cloud.yandex.net/foundationModels/v1/completion";

            conversation.Add(new YandexGPTMessage(role: "user", text: question));

            var data = new
            {
                modelUri = $"gpt://{CatalogId}/yandexgpt-lite",
                completionOptions = new
                {
                    stream = false,
                    temperature = temperature,
                    maxTokens = "2000"
                },
                messages = conversation,
            };

            var http = new HttpClient();
            http.DefaultRequestHeaders.Add("Authorization", $"Api-Key {ApiKey}");
            http.DefaultRequestHeaders.Add("x-folder-id", CatalogId);

            var response = await http.PostAsync(
                url,
                new StringContent(JsonConvert.SerializeObject(data), Encoding.UTF8, "application/json")
            );

            if (response.StatusCode != HttpStatusCode.OK)
                return "-- Что-то пошло не так --";

            var contentString = await response.Content.ReadAsStringAsync();
            var contentJson = JObject.Parse(contentString);
            var answer = contentJson["result"]["alternatives"][0]["message"]["text"].ToString();
            
            conversation.Add(new YandexGPTMessage(role: "assistant", text: answer));

            return answer;
        }
    }
}
