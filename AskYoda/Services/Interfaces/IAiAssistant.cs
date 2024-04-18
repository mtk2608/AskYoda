using AskYoda.Model;
using Azure.AI.OpenAI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AskYoda.Services.Interfaces
{
    public interface IAiAssistant
    {
        ChatResponseMessage GetCompletion(IList<ChatMessage> chatInbound, ChatMessage usermessage);
    }
}
