#pragma checksum "C:\Users\ibade\source\repos\eli18\CinemaApplication\CinemaApplication\Views\Movies\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "798f817d0d53a86d36fa6bc61611dc0ae69404f6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Movies_Index), @"mvc.1.0.view", @"/Views/Movies/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\ibade\source\repos\eli18\CinemaApplication\CinemaApplication\Views\_ViewImports.cshtml"
using CinemaApplication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ibade\source\repos\eli18\CinemaApplication\CinemaApplication\Views\_ViewImports.cshtml"
using CinemaApplication.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"798f817d0d53a86d36fa6bc61611dc0ae69404f6", @"/Views/Movies/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c4f8ef31d7cf7224822fd5a3dcbd074cdda1e9c3", @"/Views/_ViewImports.cshtml")]
    public class Views_Movies_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Movie>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("color:darkred"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline aa float-right"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("background-color:darkred;color:white; box-shadow: black 0px 2px 15px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Orders", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddItemToShoppingCart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\ibade\source\repos\eli18\CinemaApplication\CinemaApplication\Views\Movies\Index.cshtml"
   ViewData["Title"] = "List of Movies"; 

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<style>
.aa{
    border-radius:20px;
    box-shadow: black 0px 2px 15px; 
}


    .card:hover > .card-body {
        background-color: gray;
        color: white;
        text-shadow: black 0px 2px 10px;
    }
    btn:hover{
        color:white;
        background-color:darkred;
    }
   

       
    
</style>
    <div  style="" display: flex; flex-wrap: wrap;justify-content:inherit;"">
");
#nullable restore
#line 98 "C:\Users\ibade\source\repos\eli18\CinemaApplication\CinemaApplication\Views\Movies\Index.cshtml"
         foreach (var item in Model)
        {


#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"card-group\" style=\"margin:10px;\">\r\n                \r\n                 <div class=\"card aa \" style=\"max-width: 16rem;max-height:900px;\">\r\n                    <img");
            BeginWriteAttribute("src", " src=\"", 3839, "\"", 3859, 1);
#nullable restore
#line 104 "C:\Users\ibade\source\repos\eli18\CinemaApplication\CinemaApplication\Views\Movies\Index.cshtml"
WriteAttributeValue("", 3845, item.ImageURL, 3845, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"card-img-top\"");
            BeginWriteAttribute("alt", " alt=\"", 3881, "\"", 3897, 1);
#nullable restore
#line 104 "C:\Users\ibade\source\repos\eli18\CinemaApplication\CinemaApplication\Views\Movies\Index.cshtml"
WriteAttributeValue("", 3887, item.Name, 3887, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"max-height:450px;min-height:450px;\">\r\n               \r\n                    <div class=\"card-body\">\r\n                        <em> <h3 class=\"card-title\" style=\" text-shadow: darkred 0px 2px 10px; \">");
#nullable restore
#line 107 "C:\Users\ibade\source\repos\eli18\CinemaApplication\CinemaApplication\Views\Movies\Index.cshtml"
                                                                                            Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3></em>\r\n                        <div>\r\n");
            WriteLiteral("                            <p style=\"color:darkred\" class=\"card-text\"><b> ");
#nullable restore
#line 111 "C:\Users\ibade\source\repos\eli18\CinemaApplication\CinemaApplication\Views\Movies\Index.cshtml"
                                                                      Write(item.MovieCategory.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </b></p>\r\n\r\n                            <p class=\"card-text \">\r\n");
#nullable restore
#line 115 "C:\Users\ibade\source\repos\eli18\CinemaApplication\CinemaApplication\Views\Movies\Index.cshtml"
                                 if (DateTime.Now >= item.StartDate && DateTime.Now <= item.EndDate)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <span class=\"badge bg-success text-white\">AVAILABLE</span> ");
#nullable restore
#line 117 "C:\Users\ibade\source\repos\eli18\CinemaApplication\CinemaApplication\Views\Movies\Index.cshtml"
                                                                                               }
                                else if (DateTime.Now > item.EndDate)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <span class=\"badge bg-danger text-white\">EXPIRED</span> ");
#nullable restore
#line 120 "C:\Users\ibade\source\repos\eli18\CinemaApplication\CinemaApplication\Views\Movies\Index.cshtml"
                                                                                            }
                                else
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <span class=\"badge bg-primary text-white\">UPCOMING</span>");
#nullable restore
#line 123 "C:\Users\ibade\source\repos\eli18\CinemaApplication\CinemaApplication\Views\Movies\Index.cshtml"
                                                                                             }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            </p>

                        </div>

                    </div>
                       
                    <div class=""card-footer"" >

                        <p class=""card-text"" style=""display:flex;justify-content:space-between;column-gap:5px;"">
                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "798f817d0d53a86d36fa6bc61611dc0ae69404f610230", async() => {
                WriteLiteral("\r\n                                <i class=\"bi bi-eye\" style=\"padding-bottom:100px;color:darkred\"></i> Show Details\r\n                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 133 "C:\Users\ibade\source\repos\eli18\CinemaApplication\CinemaApplication\Views\Movies\Index.cshtml"
                                                                                                                   WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "798f817d0d53a86d36fa6bc61611dc0ae69404f612814", async() => {
                WriteLiteral("\r\n                                <i style=\"color:white\" class=\"bi bi-cart-plus\"></i>   ");
#nullable restore
#line 137 "C:\Users\ibade\source\repos\eli18\CinemaApplication\CinemaApplication\Views\Movies\Index.cshtml"
                                                                                 Write(item.Price.ToString("c"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "class", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 5836, "btn", 5836, 3, true);
#nullable restore
#line 136 "C:\Users\ibade\source\repos\eli18\CinemaApplication\CinemaApplication\Views\Movies\Index.cshtml"
AddHtmlAttributeValue("   ", 5839, (DateTime.Now > item.EndDate || !User.Identity.IsAuthenticated) ? "disabled" : "", 5842, 84, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 136 "C:\Users\ibade\source\repos\eli18\CinemaApplication\CinemaApplication\Views\Movies\Index.cshtml"
                                                                                                                                                                                                                                                                             WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n\r\n");
            WriteLiteral("                        </p>\r\n                    </div>\r\n                </div>\r\n\r\n\r\n            </div>\r\n");
#nullable restore
#line 153 "C:\Users\ibade\source\repos\eli18\CinemaApplication\CinemaApplication\Views\Movies\Index.cshtml"

        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n    \r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Movie>> Html { get; private set; }
    }
}
#pragma warning restore 1591
