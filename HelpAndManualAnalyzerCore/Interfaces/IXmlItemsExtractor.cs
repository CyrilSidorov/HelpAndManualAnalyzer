using System.Collections.Generic;
using HelpAndManualAnalyzerCore.Models;

namespace HelpAndManualAnalyzerCore.Interfaces
{
    public interface IXmlItemsExtractor
    {
        List<IXmlTopicItem> Extract(HelpAndManualTopic topic);
    }
}