﻿using Markdig;
using MComponents.MForm;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coreflow.Activities.MComponents
{
    public class MarkdownMFieldGenerator : MFieldGenerator
    {
        private string mText;

        protected static MarkdownPipeline Pipeline => new MarkdownPipelineBuilder()
            .UseEmojiAndSmiley()
            .UseAdvancedExtensions()
            .Build();

        public string Text
        {
            get => mText;
            set
            {
                mText = value;
                Html = new MarkupString(Markdig.Markdown.ToHtml(mText, Pipeline));
            }
        }

        public MarkupString Html { get; protected set; }

        public override RenderFragment<MFieldGeneratorContext> Template => (context) => (builder) =>
        {
            builder.AddContent(0, Html);
        };
    }
}
