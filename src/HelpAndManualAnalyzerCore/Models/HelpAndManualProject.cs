using System.Collections.Generic;

namespace HelpAndManualAnalyzerCore.Models
{
    public class HelpAndManualProject
    {
        public string Name { get; set; } // todo: name of .hmxp file can be unique primary key
        public string Path { get; set; }
        public List<HelpAndManualTopic> Files { get; set; }
    }
}