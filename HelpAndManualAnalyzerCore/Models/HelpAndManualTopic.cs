using System.Collections.Generic;

namespace HelpAndManualAnalyzerCore.Models
{
    public class HelpAndManualTopic
    {
        public long Uid { get; set; } // UID from table of contents
        public string Title { get; set; }
        public string FilePath { get; set; }
        public List<Paragraph> Paragraphs { get; set; }
    }
}