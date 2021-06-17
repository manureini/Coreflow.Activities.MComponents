using Markdig;
using MComponents.MForm;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coreflow.Activities.MComponents
{
    public class MFieldSpaceGenerator : MFieldGenerator
    {
        public int Height { get; set; }

        public override RenderFragment<MFieldGeneratorContext> Template => (context) => (builder) =>
        {
            builder.AddMarkupContent(0, $"<div class=\"m-field-space\" style=\"height: {Height}px\"></div>");
        };
    }
}
