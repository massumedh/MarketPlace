#pragma checksum "D:\MarketPlace\MarketPlace\MarketPlace.Web.UI\Areas\User\Views\Seller\SellerRequests.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4db00f0050cb97c8369bb74a376d3654e1041282"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_User_Views_Seller_SellerRequests), @"mvc.1.0.view", @"/Areas/User/Views/Seller/SellerRequests.cshtml")]
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
#line 1 "D:\MarketPlace\MarketPlace\MarketPlace.Web.UI\Areas\User\Views\_ViewImports.cshtml"
using MarketPlace.Web.UI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\MarketPlace\MarketPlace\MarketPlace.Web.UI\Areas\User\Views\_ViewImports.cshtml"
using MarketPlace.Web.UI.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\MarketPlace\MarketPlace\MarketPlace.Web.UI\Areas\User\Views\_ViewImports.cshtml"
using MarketPlace.Domain.Services.DTOs.Account;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\MarketPlace\MarketPlace\MarketPlace.Web.UI\Areas\User\Views\_ViewImports.cshtml"
using MarketPlace.Domain.Services.DTOs.Site;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\MarketPlace\MarketPlace\MarketPlace.Web.UI\Areas\User\Views\_ViewImports.cshtml"
using MarketPlace.Domain.Services.DTOs.Contacts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\MarketPlace\MarketPlace\MarketPlace.Web.UI\Areas\User\Views\_ViewImports.cshtml"
using MarketPlace.Domain.Services.DTOs.Seller;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\MarketPlace\MarketPlace\MarketPlace.Web.UI\Areas\User\Views\_ViewImports.cshtml"
using MarketPlace.Domain.Entites.Site;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\MarketPlace\MarketPlace\MarketPlace.Web.UI\Areas\User\Views\Seller\SellerRequests.cshtml"
using MarketPlace.Domain.Services.Extensions;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4db00f0050cb97c8369bb74a376d3654e1041282", @"/Areas/User/Views/Seller/SellerRequests.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f837a6baf299b0d5f3ae17af5f3160d5a786cd89", @"/Areas/User/Views/_ViewImports.cshtml")]
    public class Areas_User_Views_Seller_SellerRequests : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FilterSellerDTO>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("view"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "User", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Seller", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "EditRequestSeller", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 3 "D:\MarketPlace\MarketPlace\MarketPlace.Web.UI\Areas\User\Views\Seller\SellerRequests.cshtml"
  
    ViewData["Title"] = "???????? ?????????????? ????";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<div class=""breadcrumbs_area"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-12"">
                <div class=""breadcrumb_content"">
                    <ul>
                        <li><a href=""/"">????????</a></li>
                        <li>");
#nullable restore
#line 15 "D:\MarketPlace\MarketPlace\MarketPlace.Web.UI\Areas\User\Views\Seller\SellerRequests.cshtml"
                       Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</li>
                    </ul>
                </div>
            </div>
        </div>
    </div>
</div>

<section class=""main_content_area"">
    <div class=""container"">
        <div class=""account_dashboard"">
            <div class=""row"">
                <div class=""col-sm-12 col-md-3 col-lg-3"">
                    ");
#nullable restore
#line 28 "D:\MarketPlace\MarketPlace\MarketPlace.Web.UI\Areas\User\Views\Seller\SellerRequests.cshtml"
               Write(await Component.InvokeAsync("UserSidebar"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                </div>
                <div class=""col-sm-12 col-md-9 col-lg-9"">
                    <!-- Tab panes -->
                    <div class=""tab-content dashboard_content"">
                        <h3>?????????????? ????</h3>
                        <div class=""table-responsive"">
");
#nullable restore
#line 35 "D:\MarketPlace\MarketPlace\MarketPlace.Web.UI\Areas\User\Views\Seller\SellerRequests.cshtml"
                             if (Model.Sellers != null && Model.Sellers.Any())
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                <table class=""table"">
                                    <thead>
                                        <tr>
                                            <th>??????????</th>
                                            <th>?????? ??????????????</th>
                                            <th>???????? ????????</th>
                                            <th>?????????? ????????</th>
                                            <th>??????????????</th>
                                        </tr>
                                    </thead>
                                    <tbody>
");
#nullable restore
#line 48 "D:\MarketPlace\MarketPlace\MarketPlace.Web.UI\Areas\User\Views\Seller\SellerRequests.cshtml"
                                         foreach (var seller in Model.Sellers)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <tr>\r\n                                                <td>");
#nullable restore
#line 51 "D:\MarketPlace\MarketPlace\MarketPlace.Web.UI\Areas\User\Views\Seller\SellerRequests.cshtml"
                                               Write(seller.ID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                <td>");
#nullable restore
#line 52 "D:\MarketPlace\MarketPlace\MarketPlace.Web.UI\Areas\User\Views\Seller\SellerRequests.cshtml"
                                               Write(seller.StoreName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                <td>");
#nullable restore
#line 53 "D:\MarketPlace\MarketPlace\MarketPlace.Web.UI\Areas\User\Views\Seller\SellerRequests.cshtml"
                                               Write(seller.Phone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                <td>");
#nullable restore
#line 54 "D:\MarketPlace\MarketPlace\MarketPlace.Web.UI\Areas\User\Views\Seller\SellerRequests.cshtml"
                                               Write(seller.StoreAcceptanceState.GetEnumName());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                <td>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4db00f0050cb97c8369bb74a376d3654e104128210126", async() => {
                WriteLiteral("????????????");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 55 "D:\MarketPlace\MarketPlace\MarketPlace.Web.UI\Areas\User\Views\Seller\SellerRequests.cshtml"
                                                                                                                                             WriteLiteral(seller.ID);

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
            WriteLiteral("</td>\r\n                                            </tr>\r\n");
#nullable restore
#line 57 "D:\MarketPlace\MarketPlace\MarketPlace.Web.UI\Areas\User\Views\Seller\SellerRequests.cshtml"
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    </tbody>\r\n                                </table>\r\n");
#nullable restore
#line 60 "D:\MarketPlace\MarketPlace\MarketPlace.Web.UI\Areas\User\Views\Seller\SellerRequests.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FilterSellerDTO> Html { get; private set; }
    }
}
#pragma warning restore 1591
