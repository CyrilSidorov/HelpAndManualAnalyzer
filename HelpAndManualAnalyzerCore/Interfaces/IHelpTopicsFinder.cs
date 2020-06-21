using System.Collections.Generic;
using HelpAndManualAnalyzerCore.Models;

namespace HelpAndManualAnalyzerCore.Interfaces
{
    public interface IHelpTopicsFinder
    {
        List<HelpAndManualTopic> Find(HelpAndManualProject project);
    }
}