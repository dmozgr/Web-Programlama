#pragma checksum "C:\Users\dmozgr\Documents\GitHub\WebProgrammingMovie\Areas\Admin\Views\Movie\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ac7c961d925cf3dd551f1395446043bb8c6221dc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Movie_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Movie/Index.cshtml")]
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
#line 1 "C:\Users\dmozgr\Documents\GitHub\WebProgrammingMovie\Areas\Admin\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\dmozgr\Documents\GitHub\WebProgrammingMovie\Areas\Admin\_ViewImports.cshtml"
using WebProgrammingMovie.Areas.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\dmozgr\Documents\GitHub\WebProgrammingMovie\Areas\Admin\_ViewImports.cshtml"
using WebProgrammingMovie.Areas.Identity.Pages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\dmozgr\Documents\GitHub\WebProgrammingMovie\Areas\Admin\_ViewImports.cshtml"
using WebProgrammingMovie.Enum;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\dmozgr\Documents\GitHub\WebProgrammingMovie\Areas\Admin\_ViewImports.cshtml"
using WebProgrammingMovie;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\dmozgr\Documents\GitHub\WebProgrammingMovie\Areas\Admin\_ViewImports.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ac7c961d925cf3dd551f1395446043bb8c6221dc", @"/Areas/Admin/Views/Movie/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7edd947e55424f0cc276837c6f7e4955fc58ab02", @"/Areas/Admin/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Movie_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<WebProgrammingMovie.Models.Movie>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("color:cornflowerblue"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("color: cornflowerblue"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\Users\dmozgr\Documents\GitHub\WebProgrammingMovie\Areas\Admin\Views\Movie\Index.cshtml"
   ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";
    

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n<h3 style=\"color:white\">");
#nullable restore
#line 8 "C:\Users\dmozgr\Documents\GitHub\WebProgrammingMovie\Areas\Admin\Views\Movie\Index.cshtml"
                   Write(Localizer["Movie"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\n\n<p>\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ac7c961d925cf3dd551f1395446043bb8c6221dc6535", async() => {
#nullable restore
#line 11 "C:\Users\dmozgr\Documents\GitHub\WebProgrammingMovie\Areas\Admin\Views\Movie\Index.cshtml"
                                                   Write(SharedLocalizer["Create"]);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n</p>\n<table class=\"table\">\n    <thead>\n        <tr>\n            <th style=\"color:white\">\n                ");
#nullable restore
#line 17 "C:\Users\dmozgr\Documents\GitHub\WebProgrammingMovie\Areas\Admin\Views\Movie\Index.cshtml"
           Write(Localizer["Name"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th style=\"color:white\">\n                ");
#nullable restore
#line 20 "C:\Users\dmozgr\Documents\GitHub\WebProgrammingMovie\Areas\Admin\Views\Movie\Index.cshtml"
           Write(Localizer["Review"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th style=\"color:white\">\n                ");
#nullable restore
#line 23 "C:\Users\dmozgr\Documents\GitHub\WebProgrammingMovie\Areas\Admin\Views\Movie\Index.cshtml"
           Write(Localizer["View"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th style=\"color:white\">\n                ");
#nullable restore
#line 26 "C:\Users\dmozgr\Documents\GitHub\WebProgrammingMovie\Areas\Admin\Views\Movie\Index.cshtml"
           Write(Localizer["Category"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th style=\"color:white\">\n                ");
#nullable restore
#line 29 "C:\Users\dmozgr\Documents\GitHub\WebProgrammingMovie\Areas\Admin\Views\Movie\Index.cshtml"
           Write(Localizer["Director"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th style=\"color:white\">\n                ");
#nullable restore
#line 32 "C:\Users\dmozgr\Documents\GitHub\WebProgrammingMovie\Areas\Admin\Views\Movie\Index.cshtml"
           Write(Localizer["SliderPhoto"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th style=\"color:white\">\n                ");
#nullable restore
#line 35 "C:\Users\dmozgr\Documents\GitHub\WebProgrammingMovie\Areas\Admin\Views\Movie\Index.cshtml"
           Write(Localizer["DetailPhoto"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th style=\"color:white\">\n                ");
#nullable restore
#line 38 "C:\Users\dmozgr\Documents\GitHub\WebProgrammingMovie\Areas\Admin\Views\Movie\Index.cshtml"
           Write(Localizer["ReleaseDate"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th style=\"color:white\">\n                ");
#nullable restore
#line 41 "C:\Users\dmozgr\Documents\GitHub\WebProgrammingMovie\Areas\Admin\Views\Movie\Index.cshtml"
           Write(Localizer["Duration"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th style=\"color:white\">\n                ");
#nullable restore
#line 44 "C:\Users\dmozgr\Documents\GitHub\WebProgrammingMovie\Areas\Admin\Views\Movie\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.IMDB));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th style=\"color:white\">\n                ");
#nullable restore
#line 47 "C:\Users\dmozgr\Documents\GitHub\WebProgrammingMovie\Areas\Admin\Views\Movie\Index.cshtml"
           Write(Localizer["Country"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th></th>\n        </tr>\n    </thead>\n    <tbody>\n");
#nullable restore
#line 53 "C:\Users\dmozgr\Documents\GitHub\WebProgrammingMovie\Areas\Admin\Views\Movie\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("<tr>\n    <td style=\"color:white\">\n        ");
#nullable restore
#line 57 "C:\Users\dmozgr\Documents\GitHub\WebProgrammingMovie\Areas\Admin\Views\Movie\Index.cshtml"
   Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </td>\n    <td style=\"color:white\">\n        ");
#nullable restore
#line 60 "C:\Users\dmozgr\Documents\GitHub\WebProgrammingMovie\Areas\Admin\Views\Movie\Index.cshtml"
   Write(Html.DisplayFor(modelItem => item.Review));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </td>\n    <td style=\"color:white\">\n        ");
#nullable restore
#line 63 "C:\Users\dmozgr\Documents\GitHub\WebProgrammingMovie\Areas\Admin\Views\Movie\Index.cshtml"
   Write(Html.DisplayFor(modelItem => item.View));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </td>\n    <td style=\"color:white\">\n        ");
#nullable restore
#line 66 "C:\Users\dmozgr\Documents\GitHub\WebProgrammingMovie\Areas\Admin\Views\Movie\Index.cshtml"
   Write(Html.DisplayFor(modelItem => item.Category.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </td>\n    <td style=\"color:white\">\n        ");
#nullable restore
#line 69 "C:\Users\dmozgr\Documents\GitHub\WebProgrammingMovie\Areas\Admin\Views\Movie\Index.cshtml"
   Write(Html.DisplayFor(modelItem => item.Director.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </td>\n    <td style=\"color:white\">\n        ");
#nullable restore
#line 72 "C:\Users\dmozgr\Documents\GitHub\WebProgrammingMovie\Areas\Admin\Views\Movie\Index.cshtml"
   Write(Html.DisplayFor(modelItem => item.SliderPhotoURL));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </td>\n    <td style=\"color:white\">\n        ");
#nullable restore
#line 75 "C:\Users\dmozgr\Documents\GitHub\WebProgrammingMovie\Areas\Admin\Views\Movie\Index.cshtml"
   Write(Html.DisplayFor(modelItem => item.DetailPhotoURL));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </td>\n    <td style=\"color:white\">\n        ");
#nullable restore
#line 78 "C:\Users\dmozgr\Documents\GitHub\WebProgrammingMovie\Areas\Admin\Views\Movie\Index.cshtml"
   Write(Html.DisplayFor(modelItem => item.ReleaseDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </td>\n    <td style=\"color:white\">\n        ");
#nullable restore
#line 81 "C:\Users\dmozgr\Documents\GitHub\WebProgrammingMovie\Areas\Admin\Views\Movie\Index.cshtml"
   Write(Html.DisplayFor(modelItem => item.Duration));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </td>\n    <td style=\"color:white\">\n        ");
#nullable restore
#line 84 "C:\Users\dmozgr\Documents\GitHub\WebProgrammingMovie\Areas\Admin\Views\Movie\Index.cshtml"
   Write(Html.DisplayFor(modelItem => item.IMDB));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </td>\n    <td style=\"color:white\">\n        ");
#nullable restore
#line 87 "C:\Users\dmozgr\Documents\GitHub\WebProgrammingMovie\Areas\Admin\Views\Movie\Index.cshtml"
   Write(Html.DisplayFor(modelItem => item.Country));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </td>\n    <td>\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ac7c961d925cf3dd551f1395446043bb8c6221dc15360", async() => {
#nullable restore
#line 90 "C:\Users\dmozgr\Documents\GitHub\WebProgrammingMovie\Areas\Admin\Views\Movie\Index.cshtml"
                                                                              Write(SharedLocalizer["Edit"]);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 90 "C:\Users\dmozgr\Documents\GitHub\WebProgrammingMovie\Areas\Admin\Views\Movie\Index.cshtml"
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
            WriteLiteral(" |\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ac7c961d925cf3dd551f1395446043bb8c6221dc17874", async() => {
#nullable restore
#line 91 "C:\Users\dmozgr\Documents\GitHub\WebProgrammingMovie\Areas\Admin\Views\Movie\Index.cshtml"
                                                                                 Write(SharedLocalizer["Detail"]);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 91 "C:\Users\dmozgr\Documents\GitHub\WebProgrammingMovie\Areas\Admin\Views\Movie\Index.cshtml"
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
            WriteLiteral(" |\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ac7c961d925cf3dd551f1395446043bb8c6221dc20396", async() => {
#nullable restore
#line 92 "C:\Users\dmozgr\Documents\GitHub\WebProgrammingMovie\Areas\Admin\Views\Movie\Index.cshtml"
                                                                                Write(SharedLocalizer["Delete"]);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 92 "C:\Users\dmozgr\Documents\GitHub\WebProgrammingMovie\Areas\Admin\Views\Movie\Index.cshtml"
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
            WriteLiteral("\n    </td>\n</tr>");
#nullable restore
#line 94 "C:\Users\dmozgr\Documents\GitHub\WebProgrammingMovie\Areas\Admin\Views\Movie\Index.cshtml"
     }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\n</table>\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IHtmlLocalizer<CommonResources> SharedLocalizer { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IViewLocalizer Localizer { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<WebProgrammingMovie.Models.Movie>> Html { get; private set; }
    }
}
#pragma warning restore 1591
