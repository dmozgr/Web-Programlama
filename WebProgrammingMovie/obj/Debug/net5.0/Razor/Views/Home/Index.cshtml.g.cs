#pragma checksum "C:\Users\dmozgr\Documents\GitHub\WebProgrammingMovie\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dfbb34b2d271ac4563cff347a3879882fcd70fbf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\dmozgr\Documents\GitHub\WebProgrammingMovie\Views\_ViewImports.cshtml"
using WebProgrammingMovie;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\dmozgr\Documents\GitHub\WebProgrammingMovie\Views\_ViewImports.cshtml"
using WebProgrammingMovie.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\dmozgr\Documents\GitHub\WebProgrammingMovie\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\dmozgr\Documents\GitHub\WebProgrammingMovie\Views\Home\Index.cshtml"
using Microsoft.Extensions.Localization;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dfbb34b2d271ac4563cff347a3879882fcd70fbf", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7422cfb295da108120d5c08b49ae4abde604ee2a", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebProgrammingMovie.Models.HomeViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Movie", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "C:\Users\dmozgr\Documents\GitHub\WebProgrammingMovie\Views\Home\Index.cshtml"
   ViewData["Title"] = "Home Page"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n\n<section class=\"hero\">\n    <div class=\"container\">\n        <div class=\"hero__slider owl-carousel\">\n");
#nullable restore
#line 11 "C:\Users\dmozgr\Documents\GitHub\WebProgrammingMovie\Views\Home\Index.cshtml"
               foreach (var item in Model._SliderMovie)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"hero__items set-bg\" data-setbg=\"");
#nullable restore
#line 13 "C:\Users\dmozgr\Documents\GitHub\WebProgrammingMovie\Views\Home\Index.cshtml"
                                           Write(item.SliderPhotoURL);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\n        <div class=\"row\">\n            <div class=\"col-lg-6\">\n                <div class=\"hero__text\">\n                    <div class=\"label\">");
#nullable restore
#line 17 "C:\Users\dmozgr\Documents\GitHub\WebProgrammingMovie\Views\Home\Index.cshtml"
                                  Write(item.Category.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n                    <h2></h2>\n                    <h2>");
#nullable restore
#line 19 "C:\Users\dmozgr\Documents\GitHub\WebProgrammingMovie\Views\Home\Index.cshtml"
                   Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dfbb34b2d271ac4563cff347a3879882fcd70fbf5710", async() => {
                WriteLiteral("<span>Şimdi İncele</span> <i class=\"fa fa-angle-right\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 20 "C:\Users\dmozgr\Documents\GitHub\WebProgrammingMovie\Views\Home\Index.cshtml"
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
            WriteLiteral("\n                </div>\n            </div>\n        </div>\n    </div> ");
#nullable restore
#line 24 "C:\Users\dmozgr\Documents\GitHub\WebProgrammingMovie\Views\Home\Index.cshtml"
           } 

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        </div>
    </div>
</section>

<!-- Hero Section End -->
<!-- Product Section Begin -->

<section class=""product spad"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-8"">
                <div class=""trending__product"">
                    <div class=""row"">
                        <div class=""col-lg-8 col-md-8 col-sm-8"">
                            <div class=""section-title"">
                                <h4>");
#nullable restore
#line 40 "C:\Users\dmozgr\Documents\GitHub\WebProgrammingMovie\Views\Home\Index.cshtml"
                               Write(lang["newMovie"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\n                            </div>\n                        </div>\n\n                    </div>\n                    <div class=\"row\">\n");
#nullable restore
#line 46 "C:\Users\dmozgr\Documents\GitHub\WebProgrammingMovie\Views\Home\Index.cshtml"
                           foreach (var item in Model._TotalMovie)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col-lg-4 col-md-6 col-sm-6\">\n                    <div class=\"product__item\">\n                        <div class=\"product__item__pic set-bg\" data-setbg=\"");
#nullable restore
#line 50 "C:\Users\dmozgr\Documents\GitHub\WebProgrammingMovie\Views\Home\Index.cshtml"
                                                                      Write(item.DetailPhotoURL);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\n                            <div class=\"ep\">");
#nullable restore
#line 51 "C:\Users\dmozgr\Documents\GitHub\WebProgrammingMovie\Views\Home\Index.cshtml"
                                       Write(item.ReleaseDate.Year);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n                            <div class=\"comment\"><i class=\"fa fa-comments\"></i> ");
#nullable restore
#line 52 "C:\Users\dmozgr\Documents\GitHub\WebProgrammingMovie\Views\Home\Index.cshtml"
                                                                           Write(item.Rating.Count());

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n                            <div class=\"view\"><i class=\"fa fa-eye\"></i> ");
#nullable restore
#line 53 "C:\Users\dmozgr\Documents\GitHub\WebProgrammingMovie\Views\Home\Index.cshtml"
                                                                   Write(item.View);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n                        </div>\n                        <div class=\"product__item__text\">\n                            <ul>\n                                <li>");
#nullable restore
#line 57 "C:\Users\dmozgr\Documents\GitHub\WebProgrammingMovie\Views\Home\Index.cshtml"
                               Write(item.Category.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\n                            </ul>\n                            <h5>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dfbb34b2d271ac4563cff347a3879882fcd70fbf11596", async() => {
#nullable restore
#line 59 "C:\Users\dmozgr\Documents\GitHub\WebProgrammingMovie\Views\Home\Index.cshtml"
                                                                                                Write(item.Name);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 59 "C:\Users\dmozgr\Documents\GitHub\WebProgrammingMovie\Views\Home\Index.cshtml"
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
            WriteLiteral("</h5>\n                        </div>\n                    </div>\n                </div> ");
#nullable restore
#line 62 "C:\Users\dmozgr\Documents\GitHub\WebProgrammingMovie\Views\Home\Index.cshtml"
                       } 

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    </div>
                </div>
            </div>

            <div class=""col-lg-1"">

            </div>

            <div class=""col-lg-3"">
                <div class=""trending__product"">
                    <div class=""row"">
                        <div class=""col-lg-12"">
                            <div class=""section-title"">
                                <h4>");
#nullable restore
#line 76 "C:\Users\dmozgr\Documents\GitHub\WebProgrammingMovie\Views\Home\Index.cshtml"
                               Write(lang["trendMovie"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\n                            </div>\n                        </div>\n\n                    </div>\n                    <div class=\"row\">\n");
#nullable restore
#line 82 "C:\Users\dmozgr\Documents\GitHub\WebProgrammingMovie\Views\Home\Index.cshtml"
                           foreach (var item in Model._TrendMovie)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col-lg-12\">\n                    <div class=\"product__item\">\n                        <div class=\"product__item__pic set-bg\" data-setbg=\"");
#nullable restore
#line 86 "C:\Users\dmozgr\Documents\GitHub\WebProgrammingMovie\Views\Home\Index.cshtml"
                                                                      Write(item.DetailPhotoURL);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\n                            <div class=\"ep\">");
#nullable restore
#line 87 "C:\Users\dmozgr\Documents\GitHub\WebProgrammingMovie\Views\Home\Index.cshtml"
                                       Write(item.ReleaseDate.Year);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n                            <div class=\"comment\"><i class=\"fa fa-comments\"></i> ");
#nullable restore
#line 88 "C:\Users\dmozgr\Documents\GitHub\WebProgrammingMovie\Views\Home\Index.cshtml"
                                                                           Write(item.Rating.Count());

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n                            <div class=\"view\"><i class=\"fa fa-eye\"></i> ");
#nullable restore
#line 89 "C:\Users\dmozgr\Documents\GitHub\WebProgrammingMovie\Views\Home\Index.cshtml"
                                                                   Write(item.View);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n                        </div>\n                        <div class=\"product__item__text\">\n                            <ul>\n                                <li>");
#nullable restore
#line 93 "C:\Users\dmozgr\Documents\GitHub\WebProgrammingMovie\Views\Home\Index.cshtml"
                               Write(item.Category.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\n                            </ul>\n                            <h5>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dfbb34b2d271ac4563cff347a3879882fcd70fbf17610", async() => {
#nullable restore
#line 95 "C:\Users\dmozgr\Documents\GitHub\WebProgrammingMovie\Views\Home\Index.cshtml"
                                                                                                Write(item.Name);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 95 "C:\Users\dmozgr\Documents\GitHub\WebProgrammingMovie\Views\Home\Index.cshtml"
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
            WriteLiteral("</h5>\n                        </div>\n                    </div>\n                </div> ");
#nullable restore
#line 98 "C:\Users\dmozgr\Documents\GitHub\WebProgrammingMovie\Views\Home\Index.cshtml"
                       } 

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </div>\n                </div>\n            </div>\n        </div>\n    </div>\n</section>\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IStringLocalizer<lang> lang { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebProgrammingMovie.Models.HomeViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
