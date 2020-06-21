using HelpAndManualAnalyzerCore.Models;
using LanguageExt;

namespace HelpAndManualAnalyzerCore.Interfaces
{
    public abstract class Inspection
    {
        public abstract long Uid { get; }
        public abstract Option<Issue> DetectIssue(IXmlTopicItem topicItem);
        public abstract bool HasFix { get; }
        public abstract IXmlTopicItem Fix(IXmlTopicItem topicItem);
    }
}