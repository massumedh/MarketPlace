#pragma checksum "D:\MarketPlace\MarketPlace\MarketPlace.Web.UI\Views\Shared\_CaptchaScripts.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ecf3bf7ace4b16f07be9f632f1c6010647940ed5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__CaptchaScripts), @"mvc.1.0.view", @"/Views/Shared/_CaptchaScripts.cshtml")]
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
#line 1 "D:\MarketPlace\MarketPlace\MarketPlace.Web.UI\Views\_ViewImports.cshtml"
using MarketPlace.Web.UI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\MarketPlace\MarketPlace\MarketPlace.Web.UI\Views\_ViewImports.cshtml"
using MarketPlace.Web.UI.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\MarketPlace\MarketPlace\MarketPlace.Web.UI\Views\_ViewImports.cshtml"
using MarketPlace.Domain.Services.DTOs.Account;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\MarketPlace\MarketPlace\MarketPlace.Web.UI\Views\_ViewImports.cshtml"
using MarketPlace.Domain.Services.DTOs.Site;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ecf3bf7ace4b16f07be9f632f1c6010647940ed5", @"/Views/Shared/_CaptchaScripts.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4211dd8e309b9d81146bf514fe3cc6495be251d4", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__CaptchaScripts : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<script");
            BeginWriteAttribute("src", " src=\"", 80, "\"", 174, 2);
            WriteAttributeValue("", 86, "https://www.google.com/recaptcha/api.js?render=", 86, 47, true);
#nullable restore
#line 2 "D:\MarketPlace\MarketPlace\MarketPlace.Web.UI\Views\Shared\_CaptchaScripts.cshtml"
WriteAttributeValue("", 133, Configuration["googleReCaptcha:SiteKey"], 133, 41, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></script>\r\n<script>\r\n    grecaptcha.ready(function() {\r\n        window.grecaptcha.execute(\'");
#nullable restore
#line 5 "D:\MarketPlace\MarketPlace\MarketPlace.Web.UI\Views\Shared\_CaptchaScripts.cshtml"
                              Write(Configuration["googleReCaptcha:SiteKey"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\', { action: \'home\' }).then(function (token) {\r\n            $(\"#captchaInput\").val(token);\r\n        });\r\n    });\r\n</script>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public Microsoft.Extensions.Configuration.IConfiguration Configuration { get; private set; }
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
