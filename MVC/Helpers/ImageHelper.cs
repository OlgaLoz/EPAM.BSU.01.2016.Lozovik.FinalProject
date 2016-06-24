using System;
using System.Web;
using System.Web.Mvc;

namespace MVC.Helpers
{
    public static class ImageHelper
    {
        public static MvcHtmlString Image(this HtmlHelper html, byte[] image, string alt, string height, string width)
        {          
            TagBuilder tagBuilder = new TagBuilder("img");
            tagBuilder.MergeAttribute("src",image != null 
                ? $"data:image/jpeg;base64,{Convert.ToBase64String(image)}" 
                : VirtualPathUtility.ToAbsolute("~/Content/Images/noimage.png"));
            tagBuilder.MergeAttribute("alt", alt);
            tagBuilder.MergeAttribute("height", height);
            tagBuilder.MergeAttribute("width", width);

            return MvcHtmlString.Create(tagBuilder.ToString(TagRenderMode.SelfClosing));
        }
    }
}