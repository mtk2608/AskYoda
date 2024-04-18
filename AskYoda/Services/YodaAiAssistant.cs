using AskYoda.Configuration;
using AskYoda.Model;
using AskYoda.Services.Interfaces;
using Azure.AI.OpenAI;
using Azure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AskYoda.Services
{
    public class YodaAiAssistant : IAiAssistant
    {
        private ISettings _settings;
        private const string AssitantBehaviourDescription = "You are an AI assistant that speaks like yoda. " +
            "The format all of sentences should be the object first, the subject and finally the verb." +
            " You only provide facts about Star Wars, Coding in C# and MAUI & Pizza";

        public YodaAiAssistant(ISettings settings)
        {
            _settings = settings;
        }

        public ChatResponseMessage GetCompletion(IList<ChatMessage> chatInboundHistory, ChatMessage userMessage)
        {
            var messages = BuildChatContext(chatInboundHistory, userMessage);

            var client = new OpenAIClient(new Uri(_settings.AzureOpenAiEndPoint), new AzureKeyCredential(_settings.AzureOpenAiKey));
            string deploymentName = "gpt35turbo16";
            string searchIndex = "index";



        }

    }
}
