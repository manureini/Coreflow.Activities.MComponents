using Markdig;
using MComponents.MForm;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coreflow.Activities.MComponents.File
{
    public class FileFieldGenerator : MFieldGenerator
    {
        public string FileInputName { get; set; }

        public IDictionary<string, string> AdditionalHeaders { get; set; }

        public override RenderFragment<MFieldGeneratorContext> Template => (context) => (builder) =>
        {
            builder.OpenComponent<FileInputComponent>(0);
            builder.AddAttribute(1, nameof(FileInputComponent.FileInputName), FileInputName);
            builder.AddAttribute(2, nameof(FileInputComponent.AdditionalHeaders), AdditionalHeaders);
            builder.CloseComponent();
        };
    }
}
