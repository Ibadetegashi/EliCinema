#pragma checksum "C:\Users\ibade\source\repos\eli18\CinemaApplication\CinemaApplication\Views\Users\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7837b532fa11ec277b5225669bd44d3f5b9742ed"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Users_Index), @"mvc.1.0.view", @"/Views/Users/Index.cshtml")]
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
#nullable restore
#line 1 "C:\Users\ibade\source\repos\eli18\CinemaApplication\CinemaApplication\Views\Users\Index.cshtml"
using CinemaApplication.Models.Users;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7837b532fa11ec277b5225669bd44d3f5b9742ed", @"/Views/Users/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c4f8ef31d7cf7224822fd5a3dcbd074cdda1e9c3", @"/Views/_ViewImports.cshtml")]
    public class Views_Users_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\ibade\source\repos\eli18\CinemaApplication\CinemaApplication\Views\Users\Index.cshtml"
  
    ViewData["Title"] = "Index";

    var users = (List<User>)ViewData["Users"];

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>Perdoruesit</h2>\r\n\r\n<ul>\r\n");
#nullable restore
#line 12 "C:\Users\ibade\source\repos\eli18\CinemaApplication\CinemaApplication\Views\Users\Index.cshtml"
     foreach (var user in users)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <li>\r\n            ");
#nullable restore
#line 15 "C:\Users\ibade\source\repos\eli18\CinemaApplication\CinemaApplication\Views\Users\Index.cshtml"
       Write(user.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 15 "C:\Users\ibade\source\repos\eli18\CinemaApplication\CinemaApplication\Views\Users\Index.cshtml"
                       Write(user.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" (");
#nullable restore
#line 15 "C:\Users\ibade\source\repos\eli18\CinemaApplication\CinemaApplication\Views\Users\Index.cshtml"
                                        Write(user.IsAdmin ? "Admin" : "Not admin");

#line default
#line hidden
#nullable disable
            WriteLiteral(") (<a");
            BeginWriteAttribute("href", " href=\"", 309, "\"", 360, 1);
#nullable restore
#line 15 "C:\Users\ibade\source\repos\eli18\CinemaApplication\CinemaApplication\Views\Users\Index.cshtml"
WriteAttributeValue("", 316, Url.Action("Details", new { id = user.Id }), 316, 44, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Shiko detajet</a>)\r\n        </li>\r\n");
#nullable restore
#line 17 "C:\Users\ibade\source\repos\eli18\CinemaApplication\CinemaApplication\Views\Users\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</ul>\r\n\r\n<a");
            BeginWriteAttribute("href", " href=\"", 415, "\"", 440, 1);
#nullable restore
#line 20 "C:\Users\ibade\source\repos\eli18\CinemaApplication\CinemaApplication\Views\Users\Index.cshtml"
WriteAttributeValue("", 422, Url.Action("Add"), 422, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-success\">Shto p??rdorues</a>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
