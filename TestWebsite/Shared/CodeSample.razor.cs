using ColorCode;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;

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

        MarkupString GetHtml()
        {
            string content = GetMarkup();
            var formatter = new HtmlFormatter();
            var html = formatter.GetHtmlString(content, GetLanguage());
            return new MarkupString(html);
        }

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

        string GetMarkup()
        {
            // create a rendertree bulder and write the ChildContent to it
            var b = new RenderTreeBuilder();
            b.AddContent(0, ChildContent);
            var frames = b.GetFrames();
            var lines = new List<string>();
            foreach (var item in frames.Array)
            {
                var m = item.MarkupContent;
                if (!string.IsNullOrEmpty(m))
                    lines.Add(HtmlDecode(m));
            }

            // Remove space before but keep indents
            int spaces = lines.Select(l => SpacesBeforeContent(l)).Min();
            var sb = new System.Text.StringBuilder();
            foreach (var line in lines)
            {
                sb.AppendLine(line.Substring(spaces));
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

        private string HtmlDecode(string m)
        {
            return System.Net.WebUtility.HtmlDecode(m);
        }


    }
}
