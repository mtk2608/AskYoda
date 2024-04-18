using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AskYoda.Configuration
{
    public interface ISettings
    {
        public string AzureSearchendPoint { get; }
        public string AzureSearchKey { get; }
        public string AzureOpenAiEndPoint { get; }
        
        public string AzureOpenAiKey { get; }
    }
}
