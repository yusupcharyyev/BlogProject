#pragma checksum "C:\Users\yuska\Desktop\BlogProject_5175_06062022\BlogProject_5175_06062022.WEB\Areas\Admin\Views\Admin\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c70240d7aa148a436c56561caf22870633eaf20b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Admin_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Admin/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c70240d7aa148a436c56561caf22870633eaf20b", @"/Areas/Admin/Views/Admin/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d6af702b171cdbdbdaf7c0907417e322b541f60f", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Admin_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<AdminLastArticlesVM>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "EditArticle", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Articles", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-warning"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("float:right;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral(@"
<nav aria-label=""breadcrumb"" role=""navigation"">
    <ol class=""breadcrumb adminx-page-breadcrumb"">
        <li class=""breadcrumb-item""><a href=""#"">Admin</a></li>
        <li class=""breadcrumb-item active"" aria-current=""page"">Admin</li>
    </ol>
</nav>
");
#nullable restore
#line 9 "C:\Users\yuska\Desktop\BlogProject_5175_06062022\BlogProject_5175_06062022.WEB\Areas\Admin\Views\Admin\Index.cshtml"
  
    int TotalCategory = 0;
    int TotalComment = 0;
    int TotalArticle = 0;
    int TotalUser = 0;
    foreach (var item in Model)
    {
         TotalCategory = item.TotalCategory;
         TotalComment = item.TotalComment;
         TotalArticle = item.TotalArticle;
         TotalUser = item.TotalUser;
    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""row"">
    <div class=""col-md-6 col-lg-3 d-flex"">
        <div class=""card border-0 bg-secondary text-white text-center mb-grid w-100"">
            <div class=""d-flex flex-row align-items-center h-100"">
                <div class=""card-icon d-flex align-items-center h-100 justify-content-center"">
                    <i data-feather=""align-justify""></i>
                </div>
                <div class=""card-body"">
                    <div class=""card-info-title"">Toplam Kategori</div>
                    <h3 class=""card-title mb-0"">
                        ");
#nullable restore
#line 33 "C:\Users\yuska\Desktop\BlogProject_5175_06062022\BlogProject_5175_06062022.WEB\Areas\Admin\Views\Admin\Index.cshtml"
                   Write(TotalCategory);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    </h3>
                </div>
            </div>
        </div>
    </div>

    <div class=""col-md-6 col-lg-3 d-flex"">
        <div class=""card border-0 bg-warning text-white text-center mb-grid w-100"">
            <div class=""d-flex flex-row align-items-center h-100"">
                <div class=""card-icon d-flex align-items-center h-100 justify-content-center"">
                    <i class=""fas fa-comments""></i>
                </div>
                <div class=""card-body"">
                    <div class=""card-info-title"">Toplam Yorum</div>
                    <h3 class=""card-title mb-0"">
                        ");
#nullable restore
#line 49 "C:\Users\yuska\Desktop\BlogProject_5175_06062022\BlogProject_5175_06062022.WEB\Areas\Admin\Views\Admin\Index.cshtml"
                   Write(TotalComment);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    </h3>
                </div>
            </div>
        </div>
    </div>

    <div class=""col-md-6 col-lg-3 d-flex"">
        <div class=""card border-0 bg-primary text-white text-center mb-grid w-100"">
            <div class=""d-flex flex-row align-items-center h-100"">
                <div class=""card-icon d-flex align-items-center h-100 justify-content-center"">
                    <i class=""fas fa-newspaper""></i>
                </div>
                <div class=""card-body"">
                    <div class=""card-info-title"">Yayımlanan Makale</div>
                    <h3 class=""card-title mb-0"">
                        ");
#nullable restore
#line 65 "C:\Users\yuska\Desktop\BlogProject_5175_06062022\BlogProject_5175_06062022.WEB\Areas\Admin\Views\Admin\Index.cshtml"
                   Write(TotalArticle);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    </h3>
                </div>
            </div>
        </div>
    </div>

    <div class=""col-md-6 col-lg-3 d-flex"">
        <div class=""card border-0 bg-success text-white text-center mb-grid w-100"">
            <div class=""d-flex flex-row align-items-center h-100"">
                <div class=""card-icon d-flex align-items-center h-100 justify-content-center"">
                    <i data-feather=""users""></i>
                </div>
                <div class=""card-body"">
                    <div class=""card-info-title"">Toplam Üye</div>
                    <h3 class=""card-title mb-0"">
                        ");
#nullable restore
#line 81 "C:\Users\yuska\Desktop\BlogProject_5175_06062022\BlogProject_5175_06062022.WEB\Areas\Admin\Views\Admin\Index.cshtml"
                   Write(TotalUser);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    </h3>
                </div>
            </div>
        </div>
    </div>
</div>
<div class=""row"">
    <div class=""col-lg-8"">
        <div class=""card"">
            <div class=""card-header d-flex justify-content-between align-items-center"">
                <div class=""card-header-title"">Son Eklenen Makaleler</div>

                <nav class=""card-header-actions"">
                    <a class=""card-header-action"" data-toggle=""collapse"" href=""#card1"" aria-expanded=""false"" aria-controls=""card1"">
                        <i data-feather=""minus-circle""></i>
                    </a>
                </nav>
            </div>
            <div class=""card-body collapse show"" id=""card1"">
");
#nullable restore
#line 101 "C:\Users\yuska\Desktop\BlogProject_5175_06062022\BlogProject_5175_06062022.WEB\Areas\Admin\Views\Admin\Index.cshtml"
                 foreach (var items in Model)
                {


#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"sl-item\" style=\"margin-top: 8px;display: -webkit-box;display: -ms-flexbox;display: flex;\">\r\n                        <div class=\"sl-left\" style=\"z-index: 1;margin-right: 15px;\">\r\n                            <img");
            BeginWriteAttribute("src", " src=\"", 4272, "\"", 4294, 1);
#nullable restore
#line 106 "C:\Users\yuska\Desktop\BlogProject_5175_06062022\BlogProject_5175_06062022.WEB\Areas\Admin\Views\Admin\Index.cshtml"
WriteAttributeValue("", 4278, items.UserImage, 4278, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" alt=""user"" class=""img-circle"" style=""max-width: 40px;border-radius: 100%;"">
                        </div>
                        <div class=""sl-right"">
                            <a href=""#"" class=""link"" style=""font-size: 16px;font-weight: 300;color: #455a64;"">");
#nullable restore
#line 109 "C:\Users\yuska\Desktop\BlogProject_5175_06062022\BlogProject_5175_06062022.WEB\Areas\Admin\Views\Admin\Index.cshtml"
                                                                                                         Write(items.UserFullName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                            <span class=\"sl-date\" style=\"font-size: 12px;color: #99abb4;\">");
#nullable restore
#line 110 "C:\Users\yuska\Desktop\BlogProject_5175_06062022\BlogProject_5175_06062022.WEB\Areas\Admin\Views\Admin\Index.cshtml"
                                                                                     Write(items.CreateDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 111 "C:\Users\yuska\Desktop\BlogProject_5175_06062022\BlogProject_5175_06062022.WEB\Areas\Admin\Views\Admin\Index.cshtml"
                             if (items.Statu == BlogProject_5175_06062022.Models.Enums.Statu.Active || items.Statu == BlogProject_5175_06062022.Models.Enums.Statu.Modified)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <span style=\"position:relative;float:right;\" class=\"badge badge-success\">Active</span>\r\n");
#nullable restore
#line 114 "C:\Users\yuska\Desktop\BlogProject_5175_06062022\BlogProject_5175_06062022.WEB\Areas\Admin\Views\Admin\Index.cshtml"
                            }
                            else if (items.Statu == BlogProject_5175_06062022.Models.Enums.Statu.Passive)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <span style=\"position:relative;float:right;\" class=\"badge badge-danger\">Passive</span>\r\n");
#nullable restore
#line 118 "C:\Users\yuska\Desktop\BlogProject_5175_06062022\BlogProject_5175_06062022.WEB\Areas\Admin\Views\Admin\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"mt-3 row\" style=\"margin-top: 1rem!important;\">\r\n                                <div class=\"col-md-3 col-xs-12\">\r\n                                    <img");
            BeginWriteAttribute("src", " src=\"", 5543, "\"", 5561, 1);
#nullable restore
#line 121 "C:\Users\yuska\Desktop\BlogProject_5175_06062022\BlogProject_5175_06062022.WEB\Areas\Admin\Views\Admin\Index.cshtml"
WriteAttributeValue("", 5549, items.Image, 5549, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" alt=""user"" class=""img-responsive w-100 radius"" style=""border-radius: 2px; height: 118px; box-shadow: 0px 0px 4px"">
                                </div>
                                <div class=""col-md-9 col-xs-12"" style=""padding-left:0px;"">
                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c70240d7aa148a436c56561caf22870633eaf20b15207", async() => {
                WriteLiteral("\r\n                                        <span style=\"font-weight: 500;color: #67757c;font-size: 16px;margin-top: 0;margin-bottom: 1rem;\">\r\n                                            ");
#nullable restore
#line 126 "C:\Users\yuska\Desktop\BlogProject_5175_06062022\BlogProject_5175_06062022.WEB\Areas\Admin\Views\Admin\Index.cshtml"
                                       Write(items.Title);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                        </span>\r\n                                    ");
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
#line 124 "C:\Users\yuska\Desktop\BlogProject_5175_06062022\BlogProject_5175_06062022.WEB\Areas\Admin\Views\Admin\Index.cshtml"
                                                                                            WriteLiteral(items.ID);

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
            WriteLiteral("\r\n                                    <p style=\"font-weight: 300;color: #67757c;font-size: 16px;margin-top: 0;margin-bottom: 1rem;\">\r\n                                        ");
#nullable restore
#line 130 "C:\Users\yuska\Desktop\BlogProject_5175_06062022\BlogProject_5175_06062022.WEB\Areas\Admin\Views\Admin\Index.cshtml"
                                   Write(items.Content.Substring(0, 146));

#line default
#line hidden
#nullable disable
            WriteLiteral(" ...\r\n                                    </p>\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c70240d7aa148a436c56561caf22870633eaf20b18792", async() => {
                WriteLiteral("\r\n                                        Düzenle/Değiştir\r\n                                    ");
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
#line 132 "C:\Users\yuska\Desktop\BlogProject_5175_06062022\BlogProject_5175_06062022.WEB\Areas\Admin\Views\Admin\Index.cshtml"
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
            WriteLiteral(@"
                                </div>
                            </div>
                            <div class=""like-comm mt-2"" style=""float:right;"">
                                <span class=""link me-2"" style=""font-size: 16px;font-weight: 300;color: #455a64; margin-right:5px;""><i class=""fa fa-comments""></i> ");
#nullable restore
#line 138 "C:\Users\yuska\Desktop\BlogProject_5175_06062022\BlogProject_5175_06062022.WEB\Areas\Admin\Views\Admin\Index.cshtml"
                                                                                                                                                             Write(items.CommentCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                <span class=\"link me-2\" style=\"font-size: 16px;font-weight: 300;color: #455a64;\"><i class=\"fas fa-thumbs-up\"></i> ");
#nullable restore
#line 139 "C:\Users\yuska\Desktop\BlogProject_5175_06062022\BlogProject_5175_06062022.WEB\Areas\Admin\Views\Admin\Index.cshtml"
                                                                                                                                             Write(items.LikeCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                    <hr />\r\n");
#nullable restore
#line 144 "C:\Users\yuska\Desktop\BlogProject_5175_06062022\BlogProject_5175_06062022.WEB\Areas\Admin\Views\Admin\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            </div>
        </div>
    </div>
    <div class=""col-lg-4"">
        <div class=""card"">
            <div class=""card-header"">
                Kategori/Takip
                <span style=""font-weight: 500; padding: 0; margin: 0; float: right; font-size: 15px; color: #7c8695;"">");
#nullable restore
#line 152 "C:\Users\yuska\Desktop\BlogProject_5175_06062022\BlogProject_5175_06062022.WEB\Areas\Admin\Views\Admin\Index.cshtml"
                                                                                                                 Write(TotalUser);

#line default
#line hidden
#nullable disable
            WriteLiteral(" Üye</span>\r\n            </div>\r\n            <div class=\"card-body\">\r\n                ");
#nullable restore
#line 155 "C:\Users\yuska\Desktop\BlogProject_5175_06062022\BlogProject_5175_06062022.WEB\Areas\Admin\Views\Admin\Index.cshtml"
           Write(await Component.InvokeAsync("CategoryFollowRate"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n        <br />\r\n\r\n        ");
#nullable restore
#line 160 "C:\Users\yuska\Desktop\BlogProject_5175_06062022\BlogProject_5175_06062022.WEB\Areas\Admin\Views\Admin\Index.cshtml"
   Write(await Component.InvokeAsync("LastAddCategory"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<AdminLastArticlesVM>> Html { get; private set; }
    }
}
#pragma warning restore 1591
