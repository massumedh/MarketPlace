#pragma checksum "D:\MarketPlace\MarketPlace\MarketPlace.Web.UI\Areas\Admin\Views\Seller\SellerRequests.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c30a78869a6e1ba7e6541f78b9bacefa13a59215"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Seller_SellerRequests), @"mvc.1.0.view", @"/Areas/Admin/Views/Seller/SellerRequests.cshtml")]
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
#line 1 "D:\MarketPlace\MarketPlace\MarketPlace.Web.UI\Areas\Admin\Views\_ViewImports.cshtml"
using MarketPlace.Web.UI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\MarketPlace\MarketPlace\MarketPlace.Web.UI\Areas\Admin\Views\_ViewImports.cshtml"
using MarketPlace.Web.UI.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\MarketPlace\MarketPlace\MarketPlace.Web.UI\Areas\Admin\Views\_ViewImports.cshtml"
using MarketPlace.Domain.Services.DTOs.Account;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\MarketPlace\MarketPlace\MarketPlace.Web.UI\Areas\Admin\Views\_ViewImports.cshtml"
using MarketPlace.Domain.Services.DTOs.Site;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\MarketPlace\MarketPlace\MarketPlace.Web.UI\Areas\Admin\Views\_ViewImports.cshtml"
using MarketPlace.Domain.Services.DTOs.Contacts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\MarketPlace\MarketPlace\MarketPlace.Web.UI\Areas\Admin\Views\_ViewImports.cshtml"
using MarketPlace.Domain.Services.DTOs.Paging;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\MarketPlace\MarketPlace\MarketPlace.Web.UI\Areas\Admin\Views\_ViewImports.cshtml"
using MarketPlace.Domain.Entites.Site;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\MarketPlace\MarketPlace\MarketPlace.Web.UI\Areas\Admin\Views\Seller\SellerRequests.cshtml"
using MarketPlace.Domain.Services.Extensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\MarketPlace\MarketPlace\MarketPlace.Web.UI\Areas\Admin\Views\Seller\SellerRequests.cshtml"
using MarketPlace.Domain.Services.DTOs.Seller;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\MarketPlace\MarketPlace\MarketPlace.Web.UI\Areas\Admin\Views\Seller\SellerRequests.cshtml"
using MarketPlace.Domain.Entites.Store;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c30a78869a6e1ba7e6541f78b9bacefa13a59215", @"/Areas/Admin/Views/Seller/SellerRequests.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7d5e5e178107e7237a16e0730e9e02891d7b7c71", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Seller_SellerRequests : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FilterSellerDTO>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Seller", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "SellerRequests", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("filter-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AcceptSellerRequest", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_AdminPagingPartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 5 "D:\MarketPlace\MarketPlace\MarketPlace.Web.UI\Areas\Admin\Views\Seller\SellerRequests.cshtml"
  
    ViewData["Title"] = "درخواست های فروشندگی";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"col-xs-4\">\r\n    <div class=\"well with-header\">\r\n        <div class=\"header bordered-sky\">\r\n            فیلتر\r\n        </div>\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c30a78869a6e1ba7e6541f78b9bacefa13a592159032", async() => {
                WriteLiteral("\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "c30a78869a6e1ba7e6541f78b9bacefa13a592159302", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 15 "D:\MarketPlace\MarketPlace\MarketPlace.Web.UI\Areas\Admin\Views\Seller\SellerRequests.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.CurrentPage);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n            <div class=\"form-group\">\r\n                <label>نام فروشگاه</label>\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "c30a78869a6e1ba7e6541f78b9bacefa13a5921511125", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
#nullable restore
#line 18 "D:\MarketPlace\MarketPlace\MarketPlace.Web.UI\Areas\Admin\Views\Seller\SellerRequests.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.StoreName);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n            </div>\r\n            <div class=\"form-group\">\r\n                <label>تلفن تماس</label>\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "c30a78869a6e1ba7e6541f78b9bacefa13a5921512839", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
#nullable restore
#line 22 "D:\MarketPlace\MarketPlace\MarketPlace.Web.UI\Areas\Admin\Views\Seller\SellerRequests.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Phone);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n            </div>\r\n           \r\n            <div class=\"form-group\">\r\n                <label>آدرس فروشگاه</label>\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "c30a78869a6e1ba7e6541f78b9bacefa13a5921514567", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
#nullable restore
#line 27 "D:\MarketPlace\MarketPlace\MarketPlace.Web.UI\Areas\Admin\Views\Seller\SellerRequests.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Address);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n            </div>\r\n            <hr />\r\n            <h4>وضعیت</h4>\r\n            <div class=\"control-group\">\r\n");
                WriteLiteral("\r\n");
#nullable restore
#line 45 "D:\MarketPlace\MarketPlace\MarketPlace.Web.UI\Areas\Admin\Views\Seller\SellerRequests.cshtml"
                 foreach (var item in Html.GetEnumSelectList<FilterSellerState>())
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <div class=\"radio\">\r\n                        <label>\r\n                            <input type=\"radio\" class=\"colored-blue\"");
                BeginWriteAttribute("value", " value=\"", 2104, "\"", 2123, 1);
#nullable restore
#line 49 "D:\MarketPlace\MarketPlace\MarketPlace.Web.UI\Areas\Admin\Views\Seller\SellerRequests.cshtml"
WriteAttributeValue("", 2112, item.Value, 2112, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("name", " name=\"", 2124, "\"", 2151, 1);
#nullable restore
#line 49 "D:\MarketPlace\MarketPlace\MarketPlace.Web.UI\Areas\Admin\Views\Seller\SellerRequests.cshtml"
WriteAttributeValue("", 2131, nameof(Model.State), 2131, 20, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" ");
#nullable restore
#line 49 "D:\MarketPlace\MarketPlace\MarketPlace.Web.UI\Areas\Admin\Views\Seller\SellerRequests.cshtml"
                                                                                                                 Write(Convert.ToInt32(item.Value) == Convert.ToInt32(Model.State) ? "checked" : "");

#line default
#line hidden
#nullable disable
                WriteLiteral(">\r\n                            <span class=\"text\">");
#nullable restore
#line 50 "D:\MarketPlace\MarketPlace\MarketPlace.Web.UI\Areas\Admin\Views\Seller\SellerRequests.cshtml"
                                          Write(item.Text);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\r\n                        </label>\r\n                    </div>\r\n");
#nullable restore
#line 53 "D:\MarketPlace\MarketPlace\MarketPlace.Web.UI\Areas\Admin\Views\Seller\SellerRequests.cshtml"
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </div>\r\n            <button type=\"submit\" class=\"btn btn-success btn-block\">فیلتر</button>\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Area = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n</div>\r\n\r\n\r\n<div class=\"col-xs-8\">\r\n    <div class=\"well with-header with-footer\">\r\n        <div class=\"header bordered-sky\">\r\n            ");
#nullable restore
#line 65 "D:\MarketPlace\MarketPlace\MarketPlace.Web.UI\Areas\Admin\Views\Seller\SellerRequests.cshtml"
       Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n");
#nullable restore
#line 67 "D:\MarketPlace\MarketPlace\MarketPlace.Web.UI\Areas\Admin\Views\Seller\SellerRequests.cshtml"
         if (Model.Sellers != null && Model.Sellers.Any())
        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <table class=""table table-bordered table-hover"">
                <thead>
                    <tr>
                        <th>
                            شناسه
                        </th>
                        <th>
                            نام فروشگاه
                        </th>
                        <th>
                            تلفن
                        </th>
                        <th>
                            وضعیت
                        </th>
                        <th>
                            دستورات
                        </th>
                    </tr>
                </thead>
                <tbody>
");
#nullable restore
#line 90 "D:\MarketPlace\MarketPlace\MarketPlace.Web.UI\Areas\Admin\Views\Seller\SellerRequests.cshtml"
                     foreach (var seller in Model.Sellers)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr");
            BeginWriteAttribute("id", " id=\"", 3551, "\"", 3580, 2);
            WriteAttributeValue("", 3556, "ajax-url-item-", 3556, 14, true);
#nullable restore
#line 92 "D:\MarketPlace\MarketPlace\MarketPlace.Web.UI\Areas\Admin\Views\Seller\SellerRequests.cshtml"
WriteAttributeValue("", 3570, seller.ID, 3570, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                            <td>\r\n                                ");
#nullable restore
#line 94 "D:\MarketPlace\MarketPlace\MarketPlace.Web.UI\Areas\Admin\Views\Seller\SellerRequests.cshtml"
                           Write(seller.ID);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 97 "D:\MarketPlace\MarketPlace\MarketPlace.Web.UI\Areas\Admin\Views\Seller\SellerRequests.cshtml"
                           Write(seller.StoreName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 100 "D:\MarketPlace\MarketPlace\MarketPlace.Web.UI\Areas\Admin\Views\Seller\SellerRequests.cshtml"
                           Write(seller.Phone);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 103 "D:\MarketPlace\MarketPlace\MarketPlace.Web.UI\Areas\Admin\Views\Seller\SellerRequests.cshtml"
                           Write(seller.StoreAcceptanceState.GetEnumName());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n");
#nullable restore
#line 106 "D:\MarketPlace\MarketPlace\MarketPlace.Web.UI\Areas\Admin\Views\Seller\SellerRequests.cshtml"
                                 if (seller.StoreAcceptanceState != StoreAcceptanceState.Accepted)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c30a78869a6e1ba7e6541f78b9bacefa13a5921524601", async() => {
                WriteLiteral("تایید اطلاعات");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "ajax-url-button", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 108 "D:\MarketPlace\MarketPlace\MarketPlace.Web.UI\Areas\Admin\Views\Seller\SellerRequests.cshtml"
AddHtmlAttributeValue("", 4327, seller.ID, 4327, 10, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-requestId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 108 "D:\MarketPlace\MarketPlace\MarketPlace.Web.UI\Areas\Admin\Views\Seller\SellerRequests.cshtml"
                                                                                                                                                                               WriteLiteral(seller.ID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["requestId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-requestId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["requestId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 109 "D:\MarketPlace\MarketPlace\MarketPlace.Web.UI\Areas\Admin\Views\Seller\SellerRequests.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </td>\r\n                        </tr>\r\n");
#nullable restore
#line 112 "D:\MarketPlace\MarketPlace\MarketPlace.Web.UI\Areas\Admin\Views\Seller\SellerRequests.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tbody>\r\n            </table>\r\n");
#nullable restore
#line 115 "D:\MarketPlace\MarketPlace\MarketPlace.Web.UI\Areas\Admin\Views\Seller\SellerRequests.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"alert alert-warning\">\r\n                <p>\r\n                    هیچ اطلاعاتی یافت نشد\r\n                </p>\r\n            </div>\r\n");
#nullable restore
#line 123 "D:\MarketPlace\MarketPlace\MarketPlace.Web.UI\Areas\Admin\Views\Seller\SellerRequests.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"footer\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "c30a78869a6e1ba7e6541f78b9bacefa13a5921529172", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_9.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
#nullable restore
#line 125 "D:\MarketPlace\MarketPlace\MarketPlace.Web.UI\Areas\Admin\Views\Seller\SellerRequests.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = Model.GetCurrentPaging();

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
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
