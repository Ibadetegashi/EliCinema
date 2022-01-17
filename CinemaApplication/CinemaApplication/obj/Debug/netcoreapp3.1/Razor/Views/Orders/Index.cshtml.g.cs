#pragma checksum "C:\Users\ibade\Source\Repos\EliCinema\CinemaApplication\CinemaApplication\Views\Orders\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7ece04bcd0cde3708c413b3eedc7c289ac6a0c5c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Orders_Index), @"mvc.1.0.view", @"/Views/Orders/Index.cshtml")]
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
#line 1 "C:\Users\ibade\Source\Repos\EliCinema\CinemaApplication\CinemaApplication\Views\_ViewImports.cshtml"
using CinemaApplication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ibade\Source\Repos\EliCinema\CinemaApplication\CinemaApplication\Views\_ViewImports.cshtml"
using CinemaApplication.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7ece04bcd0cde3708c413b3eedc7c289ac6a0c5c", @"/Views/Orders/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c4f8ef31d7cf7224822fd5a3dcbd074cdda1e9c3", @"/Views/_ViewImports.cshtml")]
    public class Views_Orders_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Order>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\ibade\Source\Repos\EliCinema\CinemaApplication\CinemaApplication\Views\Orders\Index.cshtml"
  
    ViewData["Title"] = "All orders";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

        <p>
            <h4>List of all your orders</h4>
        </p>

        <table id=""myTable"" class=""table table-striped table-hover table-sm"">
            <thead>
                <tr>
                    <th>Order ID</th>
                    <th>Movies</th>
                    <th>Total</th>
                  


                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 24 "C:\Users\ibade\Source\Repos\EliCinema\CinemaApplication\CinemaApplication\Views\Orders\Index.cshtml"
                 foreach (var order in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td class=\"align-middle\">");
#nullable restore
#line 27 "C:\Users\ibade\Source\Repos\EliCinema\CinemaApplication\CinemaApplication\Views\Orders\Index.cshtml"
                                        Write(order.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td class=\"align-middle\">\r\n                        <ul style=\"list-style-type:none\">\r\n");
#nullable restore
#line 30 "C:\Users\ibade\Source\Repos\EliCinema\CinemaApplication\CinemaApplication\Views\Orders\Index.cshtml"
                             foreach (var item in order.OrderItems)
                            {


#line default
#line hidden
#nullable disable
            WriteLiteral("                                <img");
            BeginWriteAttribute("src", " src=\"", 864, "\"", 890, 1);
#nullable restore
#line 33 "C:\Users\ibade\Source\Repos\EliCinema\CinemaApplication\CinemaApplication\Views\Orders\Index.cshtml"
WriteAttributeValue("", 870, item.Movie.ImageURL, 870, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"100\"");
            BeginWriteAttribute("alt", " alt=\"", 903, "\"", 909, 0);
            EndWriteAttribute();
            WriteLiteral(" />\r\n                                <br />\r\n                                <li>\r\n                                    <div");
            BeginWriteAttribute("class", " class=\"", 1033, "\"", 1041, 0);
            EndWriteAttribute();
            WriteLiteral(" role=\"alert\">\r\n                                        <span class=\"badge badge-pill badge-light\">");
#nullable restore
#line 37 "C:\Users\ibade\Source\Repos\EliCinema\CinemaApplication\CinemaApplication\Views\Orders\Index.cshtml"
                                                                              Write(item.Amount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span> [");
#nullable restore
#line 37 "C:\Users\ibade\Source\Repos\EliCinema\CinemaApplication\CinemaApplication\Views\Orders\Index.cshtml"
                                                                                                   Write(item.Price.ToString("c"));

#line default
#line hidden
#nullable disable
            WriteLiteral("] - ");
#nullable restore
#line 37 "C:\Users\ibade\Source\Repos\EliCinema\CinemaApplication\CinemaApplication\Views\Orders\Index.cshtml"
                                                                                                                                Write(item.Movie.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </div>\r\n                                </li>\r\n");
#nullable restore
#line 40 "C:\Users\ibade\Source\Repos\EliCinema\CinemaApplication\CinemaApplication\Views\Orders\Index.cshtml"

                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </ul>\r\n                    </td>\r\n                    <td class=\"align-middle\">\r\n                        ");
#nullable restore
#line 45 "C:\Users\ibade\Source\Repos\EliCinema\CinemaApplication\CinemaApplication\Views\Orders\Index.cshtml"
                   Write(order.OrderItems.Select(m => m.Movie.Price * m.Amount).Sum().ToString("c"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                  \r\n                </tr>\r\n");
#nullable restore
#line 49 "C:\Users\ibade\Source\Repos\EliCinema\CinemaApplication\CinemaApplication\Views\Orders\Index.cshtml"

                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Order>> Html { get; private set; }
    }
}
#pragma warning restore 1591
