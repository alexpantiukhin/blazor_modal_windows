using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace BlazorModalWindowComponent
{
    public static class TagHelper
    {
        public static HtmlString AddModalWindowStyle(this IHtmlHelper html, params string[] items)
        {
            string result = "<link href='_content/BlazorModalWindowComponent/index.css' rel='stylesheet' />";
            result += items == null ? null : string.Join("", items);
            return new HtmlString(result);
        }
    }
}
