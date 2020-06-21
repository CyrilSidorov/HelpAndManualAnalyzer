using System.Collections.Generic;
using HelpAndManualAnalyzerCore.Interfaces;

namespace HelpAndManualAnalyzerCore.Models
{
    // todo: may be it is implementation of abstract help and manual item
    // for example: list item, table cell but not 'text' without paragraph

    public class Paragraph : IXmlTopicItem
    {
        public string RawContent { get; set; }
        public List<Issue> Issues { get; set; }
    }
}