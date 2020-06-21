using HelpAndManualAnalyzerCore.Interfaces;

namespace HelpAndManualAnalyzerCore.Models
{
    public class Issue
    {
        public string Uid { get; }
        public Inspection Inspection { get; }
        public Paragraph Paragraph { get; }

        public Issue(Inspection inspection, Paragraph paragraph)
        {
            Inspection = inspection;
            Paragraph = paragraph;
            Uid = $"{paragraph.RawContent}-{inspection.Uid}"; // todo: raw content to hash + optimize for indexing
        }

        public void Fix()
        {
            if (!Inspection.HasFix)
                return;

            Inspection.Fix(Paragraph);
        }
        
    }
}