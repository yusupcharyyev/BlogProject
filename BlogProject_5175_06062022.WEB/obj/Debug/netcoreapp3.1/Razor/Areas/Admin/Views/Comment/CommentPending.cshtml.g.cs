#pragma checksum "C:\Users\yuska\Desktop\BlogProject_5175_06062022\BlogProject_5175_06062022.WEB\Areas\Admin\Views\Comment\CommentPending.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "153b7e5806b266d32ffb4c08d79f95c2967c226e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Comment_CommentPending), @"mvc.1.0.view", @"/Areas/Admin/Views/Comment/CommentPending.cshtml")]
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
#line 1 "C:\Users\yuska\Desktop\BlogProject_5175_06062022\BlogProject_5175_06062022.WEB\Areas\Admin\Views\_ViewImports.cshtml"
using BlogProject_5175_06062022.WEB;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\yuska\Desktop\BlogProject_5175_06062022\BlogProject_5175_06062022.WEB\Areas\Admin\Views\_ViewImports.cshtml"
using BlogProject_5175_06062022.WEB.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\yuska\Desktop\BlogProject_5175_06062022\BlogProject_5175_06062022.WEB\Areas\Admin\Views\_ViewImports.cshtml"
using BlogProject_5175_06062022.Models.Concrete;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\yuska\Desktop\BlogProject_5175_06062022\BlogProject_5175_06062022.WEB\Areas\Admin\Views\_ViewImports.cshtml"
using BlogProject_5175_06062022.WEB.Areas.Admin.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\yuska\Desktop\BlogProject_5175_06062022\BlogProject_5175_06062022.WEB\Areas\Admin\Views\_ViewImports.cshtml"
using BlogProject_5175_06062022.WEB.Areas.Admin.Models.VMs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\yuska\Desktop\BlogProject_5175_06062022\BlogProject_5175_06062022.WEB\Areas\Admin\Views\_ViewImports.cshtml"
using BlogProject_5175_06062022.WEB.Areas.Admin.Models.DTOs;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"153b7e5806b266d32ffb4c08d79f95c2967c226e", @"/Areas/Admin/Views/Comment/CommentPending.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d6af702b171cdbdbdaf7c0907417e322b541f60f", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Comment_CommentPending : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<GetAllCommentParentVM>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CommentActive", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Comment", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("position: relative; float: right; color: white; padding: 8px; margin-left: 5px; border-radius: 0;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("badge badge-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("badge badge-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "EditArticle", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Articles", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n\r\n<div class=\"row\">\r\n\r\n    <div class=\"col-lg-8\">\r\n");
#nullable restore
#line 7 "C:\Users\yuska\Desktop\BlogProject_5175_06062022\BlogProject_5175_06062022.WEB\Areas\Admin\Views\Comment\CommentPending.cshtml"
         foreach (var itemO in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <div class=""card"" style=""margin-bottom:10px;"">
                <div class=""card-header d-flex justify-content-between align-items-center"">
                    <div class=""card-header-title"">
                        <div class=""sl-left"">
                            <img");
            BeginWriteAttribute("src", " src=\"", 424, "\"", 446, 1);
#nullable restore
#line 13 "C:\Users\yuska\Desktop\BlogProject_5175_06062022\BlogProject_5175_06062022.WEB\Areas\Admin\Views\Comment\CommentPending.cshtml"
WriteAttributeValue("", 430, itemO.UserImage, 430, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"user\" class=\"img-circle\" style=\"max-width: 35px;border-radius: 100%;\">\r\n                            <a href=\"#\" class=\"link\" style=\"font-size: 14px; font-weight: 300; color: #455a64; position: relative; top: 3px;\">");
#nullable restore
#line 14 "C:\Users\yuska\Desktop\BlogProject_5175_06062022\BlogProject_5175_06062022.WEB\Areas\Admin\Views\Comment\CommentPending.cshtml"
                                                                                                                                         Write(itemO.UserFullName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                        </div>\r\n                    </div>\r\n                    <nav class=\"card-header-actions\">\r\n                        <a class=\"card-header-action\" data-toggle=\"collapse\"");
            BeginWriteAttribute("href", " href=\"", 883, "\"", 906, 2);
            WriteAttributeValue("", 890, "#", 890, 1, true);
#nullable restore
#line 18 "C:\Users\yuska\Desktop\BlogProject_5175_06062022\BlogProject_5175_06062022.WEB\Areas\Admin\Views\Comment\CommentPending.cshtml"
WriteAttributeValue("", 891, itemO.UserName, 891, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" aria-expanded=\"false\"");
            BeginWriteAttribute("aria-controls", " aria-controls=\"", 929, "\"", 960, 1);
#nullable restore
#line 18 "C:\Users\yuska\Desktop\BlogProject_5175_06062022\BlogProject_5175_06062022.WEB\Areas\Admin\Views\Comment\CommentPending.cshtml"
WriteAttributeValue("", 945, itemO.UserName, 945, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                            <i data-feather=\"minus-circle\"></i>\r\n                        </a>\r\n                    </nav>\r\n                </div>\r\n                <div class=\"card-body collapse show\"");
            BeginWriteAttribute("id", " id=\"", 1163, "\"", 1183, 1);
#nullable restore
#line 23 "C:\Users\yuska\Desktop\BlogProject_5175_06062022\BlogProject_5175_06062022.WEB\Areas\Admin\Views\Comment\CommentPending.cshtml"
WriteAttributeValue("", 1168, itemO.UserName, 1168, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n");
#nullable restore
#line 24 "C:\Users\yuska\Desktop\BlogProject_5175_06062022\BlogProject_5175_06062022.WEB\Areas\Admin\Views\Comment\CommentPending.cshtml"
                     foreach (var items in itemO.getAllCommentChild)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"sl-item\">\r\n                            <div class=\"sl-right\">\r\n                                <span class=\"badge badge-secondary\">");
#nullable restore
#line 28 "C:\Users\yuska\Desktop\BlogProject_5175_06062022\BlogProject_5175_06062022.WEB\Areas\Admin\Views\Comment\CommentPending.cshtml"
                                                               Write(items.CreateDate.ToString("dd.MM.yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 29 "C:\Users\yuska\Desktop\BlogProject_5175_06062022\BlogProject_5175_06062022.WEB\Areas\Admin\Views\Comment\CommentPending.cshtml"
                                 if (items.Statu == BlogProject_5175_06062022.Models.Enums.Statu.Passive)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "153b7e5806b266d32ffb4c08d79f95c2967c226e11494", async() => {
                WriteLiteral("Active Çek");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 31 "C:\Users\yuska\Desktop\BlogProject_5175_06062022\BlogProject_5175_06062022.WEB\Areas\Admin\Views\Comment\CommentPending.cshtml"
                                                                                             WriteLiteral(items.ID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                    <span class=\"badge badge-danger\">Passive</span>\r\n");
#nullable restore
#line 33 "C:\Users\yuska\Desktop\BlogProject_5175_06062022\BlogProject_5175_06062022.WEB\Areas\Admin\Views\Comment\CommentPending.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "153b7e5806b266d32ffb4c08d79f95c2967c226e14517", async() => {
                WriteLiteral("Article Git");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 34 "C:\Users\yuska\Desktop\BlogProject_5175_06062022\BlogProject_5175_06062022.WEB\Areas\Admin\Views\Comment\CommentPending.cshtml"
                                                                                                                    WriteLiteral(items.ArticleID);

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
            WriteLiteral(@"
                                <div class=""row"" style=""margin-left: 5px;"">
                                    <div class=""col-md-9 col-xs-12"" style=""padding-left:0px;"">
                                        <p style=""font-weight: 300;color: #67757c;font-size: 16px;margin-top: 0;margin-bottom: 1rem;"">
                                            ");
#nullable restore
#line 38 "C:\Users\yuska\Desktop\BlogProject_5175_06062022\BlogProject_5175_06062022.WEB\Areas\Admin\Views\Comment\CommentPending.cshtml"
                                       Write(items.Text);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </p>\r\n                                    </div>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n                        <hr />\r\n");
#nullable restore
#line 45 "C:\Users\yuska\Desktop\BlogProject_5175_06062022\BlogProject_5175_06062022.WEB\Areas\Admin\Views\Comment\CommentPending.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n            </div>\r\n");
#nullable restore
#line 48 "C:\Users\yuska\Desktop\BlogProject_5175_06062022\BlogProject_5175_06062022.WEB\Areas\Admin\Views\Comment\CommentPending.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<GetAllCommentParentVM>> Html { get; private set; }
    }
}
#pragma warning restore 1591