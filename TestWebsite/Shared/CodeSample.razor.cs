using ColorCode;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Web;

namespace TestWebsite.Shared
{
    [SuppressMessage("Usage", "BL0006:Do not use RenderTree types", Justification = "<Pending>")]
    public partial class CodeSample
    {
        // component to contain a code fragment

        [Parameter] public RenderFragment ChildContent { get; set; }

        [Parameter] public bool Visible { get; set; }

        /// <summary>
        /// Language for syntax - HTML or C#
        /// </summary>
        [Parameter] public string Language { get; set; }

        string Css => Visible ? "" : "d-none";

        string ActionText { get => !Visible ? "Show Code ▼" : "Hide Code ▲"; }

        void Toggle() => Visible = !Visible;

        /// <summary>
        /// Convert the child content to highlighted HTML
        /// </summary>
        /// <returns></returns>
        MarkupString GetHtml()
        {
            string content = GetMarkup();
            // HTML DECODE before encoding
            var decoded = HttpUtility.HtmlDecode(content);
            var formatter = new HtmlFormatter();
            var html = formatter.GetHtmlString(decoded, GetLanguage());
            var clean = RemoveSpacing(html);
            return new MarkupString(clean);
        }

        private string RemoveSpacing(string html)
        {
            var lines = html.Split(Environment.NewLine);

            var codeLines = from l in lines where IsCodeLine(l)
                            select l;

            var minSpaces = (from l in codeLines select SpacesBeforeContent(l)).Min();

            if (minSpaces > 0)
            {
                var sb = new StringBuilder();
                // remove spacing from code lines
                foreach (var line in lines)
                {
                    if (IsCodeLine(line))
                        sb.AppendLine(line.Substring(minSpaces));
                    else
                        sb.AppendLine(line);
                }
                return sb.ToString();
            }

            return html;
        }

        private bool IsCodeLine(string line)
        {
            return !(line.StartsWith("</pre") || line.EndsWith("<pre>") || string.IsNullOrWhiteSpace(line));
        }


        /// <summary>
        /// Determine language to use
        /// </summary>
        /// <returns></returns>
        private ILanguage GetLanguage()
        {
            switch (Language?.ToLower())
            {
                // support both c# and cs
                case "cs":
                case "c#":
                    return Languages.FindById("c#");

                case "html":
                case "":
                case null:
                    return Languages.FindById("html");

                default:
                    return Languages.FindById(Language);
            }
        }

        /// <summary>
        /// Render ChildContent as a string
        /// </summary>
        /// <returns></returns>
        string GetMarkup()
        {
            // create a rendertree bulder and write the ChildContent using it
            var b = new RenderTreeBuilder();
            b.AddContent(0, ChildContent);
            var frames = b.GetFrames();
            var lines = new List<string>();
            foreach (var item in frames.Array)
            {
                var m = item.MarkupContent;
                if (!string.IsNullOrEmpty(m))
                    lines.AddRange(SplitLines(m));
            }
            Console.WriteLine($"There are {lines.Count} lines");
            // Remove space before but keep indents
            int minSpaces = lines.Select(l => SpacesBeforeContent(l)).Min();
            Console.Write($"Smallest space prefix is {minSpaces}");
            var sb = new System.Text.StringBuilder();
            foreach (var line in lines)
            {
                sb.AppendLine(line.Substring(minSpaces));
            }
            return sb.ToString();
        }

        private int SpacesBeforeContent(string l)
        {
            if (string.IsNullOrEmpty(l))
                return 0;
            int result = 0;
            while (result < l.Length && l[result] == ' ')
                result++;
            return result;
        }

        private List<string> SplitLines(string text)
        {
            var l = Regex.Split(text, "\r\n|\r|\n");
            return l.ToList();
        }


    }
}
