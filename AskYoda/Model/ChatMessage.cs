using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AskYoda.Enums;

namespace AskYoda.Model
{
    public class ChatMessage
    {
        public ChatMessageTypeEnum MessageType { get; set; }
        public string? MessageBody { get; set; }
    }
}
