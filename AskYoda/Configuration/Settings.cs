using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AskYoda.Configuration
{
    internal class ConstantSettings : ISettings
    {
        public string AzureOpenAiEndPoint { get => "https://yodachatbot.openai.azure.com/"; }
        public string AzureOpenAiKey { get => "dd2f614ba2f7407097b67e3ed962908f"; }
    }
}
