using System;
using System.Text;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Threading.Tasks;

namespace Parser.Models.Analytics.ChatBots.GigaChat
{
    public class GigaChat
    {
        const string Authorization = "OTE4NWUwNzAtYzJiYS00Y2I1LTgzYjctOGI0M2QxNjUyNDZiOjM1MjQyMDlhLWJiZjAtNGRlOS1iM2E0LTg3MGI5ZjQ4NzlhNA==";
        const string RqUID = "3524209a-bbf0-4de9-b3a4-870b9f4879a4";

        private string accessToken;
        private List<Message> conversation;
        private string curAnswer;

        public GigaChat()
        {
            conversation = new List<Message>();

            GetToken();
        }

        private async void GetToken()
        {
            string url = @"https://ngw.devices.sberbank.ru:9443/api/v2/oauth";
            var http = new HttpClient();

            http.DefaultRequestHeaders.Add("Authorization", $"Bearer {Authorization}");
            http.DefaultRequestHeaders.Add("RqUID", RqUID);

            var data = new Dictionary<string, string>()
            {
                { "scope", "GIGACHAT_API_PERS" }
            };

            var content = new FormUrlEncodedContent(data);

            var response = await http.PostAsync(url, content);
            var responseString = await response.Content.ReadAsStringAsync();
            dynamic responseJson = JsonConvert.DeserializeObject(responseString);

            accessToken = responseJson.access_token;
        }

        public async Task<string> AskQuestion(string question, double temperature = 0.7)
        {
            string url = @"https://gigachat.devices.sberbank.ru/api/v1/chat/completions";

            conversation.Add(new Message(role: "user", content: question));

            var data = new Dictionary<string, object>()
            {
                { "model", "GigaChat:latest" },
                { "messages", conversation },
                { "temperature", temperature }
            };

            var http = new HttpClient();
            http.DefaultRequestHeaders.Add("Authorization", $"Bearer {accessToken}");

            var response = await http.PostAsync(
                url, 
                new StringContent(JsonConvert.SerializeObject(data), Encoding.UTF8, "application/json")
            );
            
            if (response.StatusCode == HttpStatusCode.Unauthorized)
            {
                GetToken();
                conversation.RemoveAt(conversation.Count - 1);
                var answer = await AskQuestion(question, temperature);
                return answer;
            }
            else
            {
                var contentString = await response.Content.ReadAsStringAsync();
                var contentJson = JObject.Parse(contentString);
                var answer = contentJson["choices"][0]["message"]["content"].ToString();

                conversation.Add(new Message(role: "assistant", content: answer));

                curAnswer = answer;
                return curAnswer;
            }
        }
    }
}
