#pragma checksum "C:\Users\ibade\source\repos\CinemaProject\CinemaApplication\CinemaApplication\Views\Users\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f4370d9a70432f2672596e4ed4758296eb497cad"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Users_Details), @"mvc.1.0.view", @"/Views/Users/Details.cshtml")]
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
#line 1 "C:\Users\ibade\source\repos\CinemaProject\CinemaApplication\CinemaApplication\Views\_ViewImports.cshtml"
using CinemaApplication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ibade\source\repos\CinemaProject\CinemaApplication\CinemaApplication\Views\_ViewImports.cshtml"
using CinemaApplication.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\ibade\source\repos\CinemaProject\CinemaApplication\CinemaApplication\Views\Users\Details.cshtml"
using CinemaApplication.Models.Users;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f4370d9a70432f2672596e4ed4758296eb497cad", @"/Views/Users/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c4f8ef31d7cf7224822fd5a3dcbd074cdda1e9c3", @"/Views/_ViewImports.cshtml")]
    public class Views_Users_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\ibade\source\repos\CinemaProject\CinemaApplication\CinemaApplication\Views\Users\Details.cshtml"
  
    ViewData["Title"] = "Index";

    var user = (User)ViewData["User"];

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>Perdoruesi: ");
#nullable restore
#line 9 "C:\Users\ibade\source\repos\CinemaProject\CinemaApplication\CinemaApplication\Views\Users\Details.cshtml"
           Write(user.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 9 "C:\Users\ibade\source\repos\CinemaProject\CinemaApplication\CinemaApplication\Views\Users\Details.cshtml"
                           Write(user.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n\r\n<table>\r\n    <tr>\r\n        <td>\r\n            Id\r\n        </td>\r\n        <td>\r\n            ");
#nullable restore
#line 17 "C:\Users\ibade\source\repos\CinemaProject\CinemaApplication\CinemaApplication\Views\Users\Details.cshtml"
       Write(user.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </td>\r\n    </tr>\r\n    <tr>\r\n        <td>\r\n            Emri\r\n        </td>\r\n        <td>\r\n            ");
#nullable restore
#line 25 "C:\Users\ibade\source\repos\CinemaProject\CinemaApplication\CinemaApplication\Views\Users\Details.cshtml"
       Write(user.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </td>\r\n    </tr>\r\n    <tr>\r\n        <td>\r\n            Mbiemri\r\n        </td>\r\n        <td>\r\n            ");
#nullable restore
#line 33 "C:\Users\ibade\source\repos\CinemaProject\CinemaApplication\CinemaApplication\Views\Users\Details.cshtml"
       Write(user.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </td>\r\n    </tr>\r\n    <tr>\r\n        <td>\r\n            Eshte administrator?\r\n        </td>\r\n        <td>\r\n");
#nullable restore
#line 41 "C:\Users\ibade\source\repos\CinemaProject\CinemaApplication\CinemaApplication\Views\Users\Details.cshtml"
             if (user.IsAdmin)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                ");
            WriteLiteral("Po\r\n");
#nullable restore
#line 44 "C:\Users\ibade\source\repos\CinemaProject\CinemaApplication\CinemaApplication\Views\Users\Details.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                ");
            WriteLiteral("Jo\r\n");
#nullable restore
#line 48 "C:\Users\ibade\source\repos\CinemaProject\CinemaApplication\CinemaApplication\Views\Users\Details.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </td>\r\n    </tr>\r\n</table>\r\n\r\n<br />\r\n<a");
            BeginWriteAttribute("href", " href=\"", 851, "\"", 878, 1);
#nullable restore
#line 54 "C:\Users\ibade\source\repos\CinemaProject\CinemaApplication\CinemaApplication\Views\Users\Details.cshtml"
WriteAttributeValue("", 858, Url.Action("Index"), 858, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Kthehu te perdoruesit</a>\r\n");
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