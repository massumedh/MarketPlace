#pragma checksum "D:\MarketPlace\MarketPlace\MarketPlace.Web.UI\Views\Home\AboutUs.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b846cae34dd546a84fc542a4f552cc1bed85c4c2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_AboutUs), @"mvc.1.0.view", @"/Views/Home/AboutUs.cshtml")]
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
#nullable restore
#line 5 "D:\MarketPlace\MarketPlace\MarketPlace.Web.UI\Views\_ViewImports.cshtml"
using MarketPlace.Domain.Services.DTOs.Contacts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\MarketPlace\MarketPlace\MarketPlace.Web.UI\Views\_ViewImports.cshtml"
using MarketPlace.Domain.Entites.Site;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b846cae34dd546a84fc542a4f552cc1bed85c4c2", @"/Views/Home/AboutUs.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"67adecfb022eb9608d3c0ac6a31508fceb3f3123", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_AboutUs : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SiteSetting>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\MarketPlace\MarketPlace\MarketPlace.Web.UI\Views\Home\AboutUs.cshtml"
  
    ViewData["Title"] = "درباره ما";

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
                        <li><a href=""index.html"">خانه</a></li>
                        <li>درباره ما</li>
                    </ul>
                </div>
            </div>
        </div>
    </div>
</div>

<section class=""about_section mt-60"">
    <div class=""container"">
        <div class=""row align-items-center"">
            <div class=""col-12"">
                <figure>
                    <div class=""about_thumb"">
                        <img src=""/img/about/about1.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 761, "\"", 767, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                    </div>\r\n                    <figcaption class=\"about_content\">\r\n                        <h1>همه چیز درباره ما</h1>\r\n                        <p>\r\n                            ");
#nullable restore
#line 33 "D:\MarketPlace\MarketPlace\MarketPlace.Web.UI\Views\Home\AboutUs.cshtml"
                       Write(Model.AboutUs);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                        </p>
                    </figcaption>
                </figure>
            </div>
        </div>
    </div>
</section>

<div class=""about_gallery_section"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-6 col-md-6"">
                <article class=""single_gallery_section"">
                    <figure>
                        <div class=""gallery_thumb"">
                            <img src=""/img/about/about2.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 1473, "\"", 1479, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                        </div>
                        <figcaption class=""about_gallery_content"">
                            <h3>ما چکار می کنیم؟</h3>
                            <p>لورم ایپسوم متن ساختگی با تولید سادگی نامفهوم از صنعت چاپ و با استفاده از طراحان گرافیک است. چاپگرها و متون بلکه روزنامه و مجله در ستون و سطرآنچنان که لازم است و برای شرایط فعلی تکنولوژی مورد نیاز و کاربردهای متنوع با هدف بهبود ابزارهای کاربردی می باشد. کتابهای زیادی در شصت و سه درصد گذشته، حال و آینده شناخت فراوان جامعه و متخصصان را می طلبد تا با نرم افزارها شناخت بیشتری را برای طراحان رایانه ای علی الخصوص طراحان خلاقی و فرهنگ</p>
                        </figcaption>
                    </figure>
                </article>
            </div>
            <div class=""col-lg-6 col-md-6"">
                <article class=""single_gallery_section"">
                    <figure>
                        <div class=""gallery_thumb"">
                            <img src=""/img/about/about3.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 2470, "\"", 2476, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                        </div>
                        <figcaption class=""about_gallery_content"">
                            <h3>تاریخچه ما</h3>
                            <p>لورم ایپسوم متن ساختگی با تولید سادگی نامفهوم از صنعت چاپ و با استفاده از طراحان گرافیک است. چاپگرها و متون بلکه روزنامه و مجله در ستون و سطرآنچنان که لازم است و برای شرایط فعلی تکنولوژی مورد نیاز و کاربردهای متنوع با هدف بهبود ابزارهای کاربردی می باشد. کتابهای زیادی در شصت و سه درصد گذشته، حال و آینده شناخت فراوان جامعه و متخصصان را می طلبد تا با نرم افزارها شناخت بیشتری را برای طراحان رایانه ای علی الخصوص طراحان خلاقی و فرهنگ</p>
                        </figcaption>
                    </figure>
                </article>
            </div>
        </div>
    </div>
</div>

<div class=""choseus_area"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-4 col-md-4"">
                <div class=""single_chose"">
                    <div class=""chose_icone"">
                        <img");
            WriteLiteral(" src=\"/img/about/About_icon1.png\"");
            BeginWriteAttribute("alt", " alt=\"", 3534, "\"", 3540, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                    </div>
                    <div class=""chose_content"">
                        <h3>تضمین بازگشت وجه</h3>
                        <p>لورم ایپسوم متن ساختگی با تولید سادگی نامفهوم از صنعت چاپ و با استفاده از طراحان گرافیک است. چاپگرها</p>

                    </div>
                </div>
            </div>
            <div class=""col-lg-4 col-md-4"">
                <div class=""single_chose"">
                    <div class=""chose_icone"">
                        <img src=""/img/about/About_icon2.png""");
            BeginWriteAttribute("alt", " alt=\"", 4076, "\"", 4082, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                    </div>
                    <div class=""chose_content"">
                        <h3>طراحی خلاقانه</h3>
                        <p>لورم ایپسوم متن ساختگی با تولید سادگی نامفهوم از صنعت چاپ و با استفاده از طراحان گرافیک است. چاپگرها</p>

                    </div>
                </div>
            </div>
            <div class=""col-lg-4 col-md-4"">
                <div class=""single_chose"">
                    <div class=""chose_icone"">
                        <img src=""/img/about/About_icon3.png""");
            BeginWriteAttribute("alt", " alt=\"", 4615, "\"", 4621, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                    </div>
                    <div class=""chose_content"">
                        <h3>کیفیت بالا</h3>
                        <p>لورم ایپسوم متن ساختگی با تولید سادگی نامفهوم از صنعت چاپ و با استفاده از طراحان گرافیک است. چاپگرها</p>

                    </div>
                </div>
            </div>
        </div>
    </div>
</div>

<div class=""team_area"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-3 col-md-6"">
                <article class=""team_member"">
                    <figure>
                        <div class=""team_thumb"">
                            <img src=""/img/about/about-us-person1.png""");
            BeginWriteAttribute("alt", " alt=\"", 5315, "\"", 5321, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                        </div>
                        <figcaption class=""team_content"">
                            <h3>جان</h3>
                            <h5>کارگردان</h5>
                            <p>
                                تلفن: <span class=""ltr-text"">+(98) 123 456 789</span>
                                <br> ایمیل: john@example.com
                            </p>
                        </figcaption>
                    </figure>
                </article>
            </div>
            <div class=""col-lg-3 col-md-6"">
                <article class=""team_member"">
                    <figure>
                        <div class=""team_thumb"">
                            <img src=""/img/about/about-us-person2.png""");
            BeginWriteAttribute("alt", " alt=\"", 6081, "\"", 6087, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                        </div>
                        <figcaption class=""team_content"">
                            <h3>مریم</h3>
                            <h5>طراح</h5>
                            <p>
                                تلفن: <span class=""ltr-text"">+(98) 123 456 789</span>
                                <br> ایمیل: john@example.com
                            </p>
                        </figcaption>
                    </figure>
                </article>
            </div>
            <div class=""col-lg-3 col-md-6"">
                <article class=""team_member"">
                    <figure>
                        <div class=""team_thumb"">
                            <img src=""/img/about/about-us-person3.png""");
            BeginWriteAttribute("alt", " alt=\"", 6844, "\"", 6850, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                        </div>
                        <figcaption class=""team_content"">
                            <h3>محسن</h3>
                            <h5>توسعه دهنده</h5>
                            <p>
                                تلفن: <span class=""ltr-text"">+(98) 123 456 789</span>
                                <br> ایمیل: john@example.com
                            </p>
                        </figcaption>
                    </figure>
                </article>
            </div>
            <div class=""col-lg-3 col-md-6"">
                <article class=""team_member"">
                    <figure>
                        <div class=""team_thumb"">
                            <img src=""/img/about/about-us-person4.png""");
            BeginWriteAttribute("alt", " alt=\"", 7614, "\"", 7620, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                        </div>
                        <figcaption class=""team_content"">
                            <h3>جیمز</h3>
                            <h5>کدنویس</h5>
                            <p>
                                تلفن: <span class=""ltr-text"">+(98) 123 456 789</span>
                                <br> ایمیل: john@example.com
                            </p>
                        </figcaption>
                    </figure>
                </article>
            </div>
        </div>
    </div>
</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SiteSetting> Html { get; private set; }
    }
}
#pragma warning restore 1591