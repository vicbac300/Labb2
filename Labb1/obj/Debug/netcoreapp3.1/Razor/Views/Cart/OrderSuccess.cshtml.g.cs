#pragma checksum "F:\online\Dropbox\ITHS\3. Avancerad C#-programmering\Labb2\Labb1\Views\Cart\OrderSuccess.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a84db70c77a57a86277550525bd9743ab538241a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cart_OrderSuccess), @"mvc.1.0.view", @"/Views/Cart/OrderSuccess.cshtml")]
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
#line 1 "F:\online\Dropbox\ITHS\3. Avancerad C#-programmering\Labb2\Labb1\Views\_ViewImports.cshtml"
using Labb1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\online\Dropbox\ITHS\3. Avancerad C#-programmering\Labb2\Labb1\Views\_ViewImports.cshtml"
using Labb1.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a84db70c77a57a86277550525bd9743ab538241a", @"/Views/Cart/OrderSuccess.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4108acb36cd04c2183ac91f884148f3206400ec5", @"/Views/_ViewImports.cshtml")]
    public class Views_Cart_OrderSuccess : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Labb1.ViewModels.OrderViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "F:\online\Dropbox\ITHS\3. Avancerad C#-programmering\Labb2\Labb1\Views\Cart\OrderSuccess.cshtml"
  
    ViewData["Title"] = "OrderSuccess";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>OrderSuccess</h1>\r\n\r\n<div class=\"row\">\r\n    <div class=\"card bg-light col-sm-12 col-md-4\">\r\n        <div class=\"card-body\">\r\n            <h3 class=\"card-title\">\r\n                Order ID:\r\n                ");
#nullable restore
#line 14 "F:\online\Dropbox\ITHS\3. Avancerad C#-programmering\Labb2\Labb1\Views\Cart\OrderSuccess.cshtml"
           Write(Html.DisplayFor(modelItem => modelItem.Order.ID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </h3>\r\n            <div class=\"card-text\">\r\n                <div>\r\n                    Order date:\r\n                    ");
#nullable restore
#line 19 "F:\online\Dropbox\ITHS\3. Avancerad C#-programmering\Labb2\Labb1\Views\Cart\OrderSuccess.cshtml"
               Write(Html.DisplayFor(modelItem => modelItem.Order.Date));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n                <div>\r\n                    ");
#nullable restore
#line 22 "F:\online\Dropbox\ITHS\3. Avancerad C#-programmering\Labb2\Labb1\Views\Cart\OrderSuccess.cshtml"
               Write(Html.DisplayFor(modelItem => modelItem.User.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 23 "F:\online\Dropbox\ITHS\3. Avancerad C#-programmering\Labb2\Labb1\Views\Cart\OrderSuccess.cshtml"
               Write(Html.DisplayFor(modelItem => modelItem.User.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n                <div>\r\n                    <div>");
#nullable restore
#line 26 "F:\online\Dropbox\ITHS\3. Avancerad C#-programmering\Labb2\Labb1\Views\Cart\OrderSuccess.cshtml"
                    Write(Html.DisplayFor(modelItem => modelItem.User.StreetAdress));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                    <div>");
#nullable restore
#line 27 "F:\online\Dropbox\ITHS\3. Avancerad C#-programmering\Labb2\Labb1\Views\Cart\OrderSuccess.cshtml"
                    Write(Html.DisplayFor(modelItem => modelItem.User.PostalCode));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                    <div>");
#nullable restore
#line 28 "F:\online\Dropbox\ITHS\3. Avancerad C#-programmering\Labb2\Labb1\Views\Cart\OrderSuccess.cshtml"
                    Write(Html.DisplayFor(modelItem => modelItem.User.City));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                </div>\r\n                <div>\r\n                    Phone number:\r\n                    ");
#nullable restore
#line 32 "F:\online\Dropbox\ITHS\3. Avancerad C#-programmering\Labb2\Labb1\Views\Cart\OrderSuccess.cshtml"
               Write(Html.DisplayFor(modelItem => modelItem.User.PhoneNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                </div>
            </div>
        </div>
    </div>

    <div class=""col-sm-12 col-md-8"">
        <table class=""table table-responsive-sm"">
            <thead>
                <tr>
                    <th>
                        NAME
                    </th>
                    <th>
                        PRICE
                    </th>
                    <th>
                        AMOUNT
                    </th>
                    <th></th>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 55 "F:\online\Dropbox\ITHS\3. Avancerad C#-programmering\Labb2\Labb1\Views\Cart\OrderSuccess.cshtml"
                 foreach (var item in Model.Order.OrderRows)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>\r\n                            ");
#nullable restore
#line 59 "F:\online\Dropbox\ITHS\3. Avancerad C#-programmering\Labb2\Labb1\Views\Cart\OrderSuccess.cshtml"
                       Write(Html.DisplayFor(modelItem => Model.GetProduct(item).Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 62 "F:\online\Dropbox\ITHS\3. Avancerad C#-programmering\Labb2\Labb1\Views\Cart\OrderSuccess.cshtml"
                       Write(Html.DisplayFor(modelItem => Model.GetProduct(item).Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 65 "F:\online\Dropbox\ITHS\3. Avancerad C#-programmering\Labb2\Labb1\Views\Cart\OrderSuccess.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Amount));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 68 "F:\online\Dropbox\ITHS\3. Avancerad C#-programmering\Labb2\Labb1\Views\Cart\OrderSuccess.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n            <tfoot>\r\n                <tr>\r\n                    <td colspan=\"3\">\r\n\r\n                        ");
#nullable restore
#line 74 "F:\online\Dropbox\ITHS\3. Avancerad C#-programmering\Labb2\Labb1\Views\Cart\OrderSuccess.cshtml"
                   Write(Html.LabelFor(modelItem => modelItem.Order.TotalPrice));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        ");
#nullable restore
#line 75 "F:\online\Dropbox\ITHS\3. Avancerad C#-programmering\Labb2\Labb1\Views\Cart\OrderSuccess.cshtml"
                   Write(Html.DisplayFor(modelItem => modelItem.Order.TotalPrice));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                    </td>\r\n                </tr>\r\n            </tfoot>\r\n        </table>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Labb1.ViewModels.OrderViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
