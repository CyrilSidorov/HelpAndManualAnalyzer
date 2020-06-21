using System;
using System.Collections.Generic;
using System.Text;
using HelpAndManualAnalyzerCore.Models;
using ReactiveUI;

namespace HelpAndManualAnalyzerUI.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        private HelpAndManualTopic? _selectedFile;
        public HelpAndManualTopic? SelectedFile
        {
            get => _selectedFile;
            set => this.RaiseAndSetIfChanged(ref _selectedFile, value);
        }


        private readonly ObservableAsPropertyHelper<List<Paragraph>?> _issues;
        public List<Paragraph>? Issues => _issues.Value;

        
        public List<HelpAndManualTopic> Files { get; set; }

        public MainWindowViewModel()
        {
            _issues = this
                .WhenAnyValue(x => x.SelectedFile, selectedFile => selectedFile?.Paragraphs)
                .ToProperty(this, x => x.Issues);


            Files = new List<HelpAndManualTopic>()
            {
                new HelpAndManualTopic()
                {
                    Paragraphs = new List<Paragraph>()
                    {
                        new Paragraph()
                        {
                            Issues = new List<Issue>()
                            {

                            },
                            RawContent = "<para styleclass=\"Normal\"><text styleclass=\"Normal\" translate=\"true\">In some cases requests take significant time to process and/or there are multiple requests processed at the same time. </text><var styleclass=\"Normal\">&lt;%VAC%&gt;</var><text styleclass=\"Normal\" translate=\"true\">&#32;</text><var styleclass=\"Normal\">&lt;%REST%&gt;</var><text styleclass=\"Normal\" translate=\"true\"> v3 allows such operations to be handled asynchronously. It decreases the load on web-browsers and notifies clients when their requests are accepted but not yet processed by the server.</text></para>"
                        },
                        new Paragraph()
                        {
                            RawContent = "<para styleclass=\"Normal\"><text styleclass=\"Normal\" translate=\"true\">Some operations can take longer time to finish but do not behave as async actions. These operations are marked with the </text><text styleclass=\"Normal\" style=\"font-style:italic;\" translate=\"true\">x-veeam-vac-fire-and-forget: true</text><text styleclass=\"Normal\" translate=\"true\"> extension.</text></para>"
                        }
                    },
                    Title = "Asynchronous Processing"
                },
                new HelpAndManualTopic()
                {
                    Paragraphs = new List<Paragraph>()
                    {
                        new Paragraph()
                        {
                            Issues = new List<Issue>()
                            {

                            },
                            RawContent = "<para styleclass=\"Normal\"><text styleclass=\"Normal\" translate=\"true\">If your infrastructure can handle a greater number of requests than it is allowed by default throttling policy, you can increase maximum values of limitations. To do that, on the </text><var styleclass=\"Normal\">&lt;%VAC%&gt;</var><text styleclass=\"Normal\" translate=\"true\"> server, open the </text><text styleclass=\"T_Filenames\" translate=\"true\">appsettings.json</text><text styleclass=\"Normal\" translate=\"true\"> file located in the </text><text styleclass=\"T_Filenames\" translate=\"true\">RestAPI</text><text styleclass=\"Normal\" translate=\"true\"> folder of the </text><var styleclass=\"Normal\">&lt;%VAC%&gt;</var><text styleclass=\"Normal\" translate=\"true\"> installation directory. The </text><text styleclass=\"T_Filenames\" translate=\"true\">Throttling</text><text styleclass=\"Normal\" translate=\"true\"> section of the file contains the following parameters:</text></para>"
                        }
                    },
                    Title = "Throttling"
                }
            };

        }
    }
}
