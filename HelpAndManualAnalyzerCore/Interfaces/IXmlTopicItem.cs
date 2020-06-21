using System.Collections.Generic;
using HelpAndManualAnalyzerCore.Models;

namespace HelpAndManualAnalyzerCore.Interfaces
{
    public interface IXmlTopicItem
    {
        string RawContent { get; set; }
        List<Issue> Issues { get; set; }
    }
}