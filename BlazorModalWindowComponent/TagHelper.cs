using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace BlazorModalWindowComponent
{
    public static class TagHelper
    {
        public static HtmlString AddModalWindowStyle(this IHtmlHelper html, string[] items)
        {
            string result = "<link href='_content/BlazorModalWindowComponent/index.css' rel='stylesheet' />";
            return new HtmlString(result);
        }
    }
}
