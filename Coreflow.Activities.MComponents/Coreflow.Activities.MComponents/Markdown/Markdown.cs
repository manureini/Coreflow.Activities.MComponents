using Coreflow.Activities.MComponents;
using Markdig;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;
using System;

namespace Coreflow.Activities.MComponents.Markdown
{
    public class Markdown : ComponentBase
    {
        [Parameter]
        public string Text { get; set; }

        protected MarkupString mHtml;

        protected static MarkdownPipeline Pipeline = MarkdownMFieldGenerator.Pipeline;

        protected override void BuildRenderTree(RenderTreeBuilder builder)
        {
            builder.AddContent(0, mHtml);
        }

        protected override void OnParametersSet()
        {
            if (Text == null)
                return;

            mHtml = new MarkupString(Markdig.Markdown.ToHtml(Text, Pipeline));
        }
    }
}
