#pragma checksum "C:\Users\yuska\Desktop\BlogProject_5175_06062022\BlogProject_5175_06062022.WEB\Areas\Member\Views\AppUser\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "afee9e6e7fbefaa94c2fa3128a9c4a57dbdfe065"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Member_Views_AppUser_Index), @"mvc.1.0.view", @"/Areas/Member/Views/AppUser/Index.cshtml")]
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
#line 1 "C:\Users\yuska\Desktop\BlogProject_5175_06062022\BlogProject_5175_06062022.WEB\Areas\Member\Views\_ViewImports.cshtml"
using BlogProject_5175_06062022.WEB;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\yuska\Desktop\BlogProject_5175_06062022\BlogProject_5175_06062022.WEB\Areas\Member\Views\_ViewImports.cshtml"
using BlogProject_5175_06062022.WEB.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\yuska\Desktop\BlogProject_5175_06062022\BlogProject_5175_06062022.WEB\Areas\Member\Views\_ViewImports.cshtml"
using BlogProject_5175_06062022.Models.Concrete;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\yuska\Desktop\BlogProject_5175_06062022\BlogProject_5175_06062022.WEB\Areas\Member\Views\_ViewImports.cshtml"
using BlogProject_5175_06062022.WEB.Areas.Member.Models.DTOs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\yuska\Desktop\BlogProject_5175_06062022\BlogProject_5175_06062022.WEB\Areas\Member\Views\_ViewImports.cshtml"
using BlogProject_5175_06062022.WEB.Areas.Member.Models.VMs;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"afee9e6e7fbefaa94c2fa3128a9c4a57dbdfe065", @"/Areas/Member/Views/AppUser/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7a4c55d72a69d8f361c1fc8d6c293b7990e6892f", @"/Areas/Member/Views/_ViewImports.cshtml")]
    public class Areas_Member_Views_AppUser_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AppUser>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("text-decoration: none; color: inherit;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Articles", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n\r\n<div class=\"col-md-9\">\r\n    ");
#nullable restore
#line 5 "C:\Users\yuska\Desktop\BlogProject_5175_06062022\BlogProject_5175_06062022.WEB\Areas\Member\Views\AppUser\Index.cshtml"
Write(await Component.InvokeAsync("Articles"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <hr />\r\n    <p> <i class=\"fas fa-newspaper\"></i> Makalelerim</p>\r\n    <div class=\"row\">\r\n");
#nullable restore
#line 9 "C:\Users\yuska\Desktop\BlogProject_5175_06062022\BlogProject_5175_06062022.WEB\Areas\Member\Views\AppUser\Index.cshtml"
         foreach (var item in Model.Articles)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"col-md-12\">\r\n                <div class=\"card\" style=\"box-shadow: 0 0 0; border: 0;\">\r\n                    <div class=\"card-body\" style=\"padding:17px;\">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "afee9e6e7fbefaa94c2fa3128a9c4a57dbdfe0655977", async() => {
                WriteLiteral("\r\n                            <div class=\"row\">\r\n                                <div class=\"col-9\">\r\n                                    <div class=\"profile\" style=\"margin-bottom:10px;\">\r\n                                        <img");
                BeginWriteAttribute("src", " src=\"", 797, "\"", 815, 1);
#nullable restore
#line 18 "C:\Users\yuska\Desktop\BlogProject_5175_06062022\BlogProject_5175_06062022.WEB\Areas\Member\Views\AppUser\Index.cshtml"
WriteAttributeValue("", 803, Model.Image, 803, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" style=\"width: 20px; border-radius: 50%;\" alt=\"Alternate Text\" /> &nbsp;");
#nullable restore
#line 18 "C:\Users\yuska\Desktop\BlogProject_5175_06062022\BlogProject_5175_06062022.WEB\Areas\Member\Views\AppUser\Index.cshtml"
                                                                                                                                  Write(Model.UserName);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                    </div>\r\n                                    <h6 class=\"lead\" style=\"font-size: 22px; font-weight: 500;\"><b>");
#nullable restore
#line 20 "C:\Users\yuska\Desktop\BlogProject_5175_06062022\BlogProject_5175_06062022.WEB\Areas\Member\Views\AppUser\Index.cshtml"
                                                                                              Write(item.Title);

#line default
#line hidden
#nullable disable
                WriteLiteral("</b></h6>\r\n                                    <p class=\"text-muted text-sm\">");
#nullable restore
#line 21 "C:\Users\yuska\Desktop\BlogProject_5175_06062022\BlogProject_5175_06062022.WEB\Areas\Member\Views\AppUser\Index.cshtml"
                                                             Write(item.Content.Substring(0, 52));

#line default
#line hidden
#nullable disable
                WriteLiteral("...</p>\r\n                                    <ul class=\"ml-0 mb-0 fa-ul text-muted\">\r\n                                        <li>\r\n                                            ");
#nullable restore
#line 24 "C:\Users\yuska\Desktop\BlogProject_5175_06062022\BlogProject_5175_06062022.WEB\Areas\Member\Views\AppUser\Index.cshtml"
                                       Write(item.CreateDate.ToString("dd.MM.yyyy"));

#line default
#line hidden
#nullable disable
                WriteLiteral(" ?? ");
#nullable restore
#line 24 "C:\Users\yuska\Desktop\BlogProject_5175_06062022\BlogProject_5175_06062022.WEB\Areas\Member\Views\AppUser\Index.cshtml"
                                                                                       foreach (var itemC in item.Categorys)
                                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                                <span style=\" border: 1px solid rgba(230, 230, 230, 1); padding: 3px 7px; border-radius: 5px;\">");
#nullable restore
#line 26 "C:\Users\yuska\Desktop\BlogProject_5175_06062022\BlogProject_5175_06062022.WEB\Areas\Member\Views\AppUser\Index.cshtml"
                                                                                                                                          Write(itemC.Category.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\r\n");
#nullable restore
#line 27 "C:\Users\yuska\Desktop\BlogProject_5175_06062022\BlogProject_5175_06062022.WEB\Areas\Member\Views\AppUser\Index.cshtml"
                                            }

#line default
#line hidden
#nullable disable
                WriteLiteral("                                        </li>\r\n                                    </ul>\r\n                                </div>\r\n                                <div class=\"col-3 text-center\">\r\n                                    <img");
                BeginWriteAttribute("src", " src=\"", 1925, "\"", 1942, 1);
#nullable restore
#line 32 "C:\Users\yuska\Desktop\BlogProject_5175_06062022\BlogProject_5175_06062022.WEB\Areas\Member\Views\AppUser\Index.cshtml"
WriteAttributeValue("", 1931, item.Image, 1931, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" alt=\"user-avatar\" style=\"width:200px; height:134px;\" class=\"img-fluid\">\r\n                                </div>\r\n                            </div>\r\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 14 "C:\Users\yuska\Desktop\BlogProject_5175_06062022\BlogProject_5175_06062022.WEB\Areas\Member\Views\AppUser\Index.cshtml"
                                                                                                                           WriteLiteral(item.ID);

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
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 39 "C:\Users\yuska\Desktop\BlogProject_5175_06062022\BlogProject_5175_06062022.WEB\Areas\Member\Views\AppUser\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</div>\r\n<div class=\"col-md-3\">\r\n    ");
#nullable restore
#line 43 "C:\Users\yuska\Desktop\BlogProject_5175_06062022\BlogProject_5175_06062022.WEB\Areas\Member\Views\AppUser\Index.cshtml"
Write(await Component.InvokeAsync("UserFollowCategory", new { id = Model.ID }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <hr />\r\n    ");
#nullable restore
#line 45 "C:\Users\yuska\Desktop\BlogProject_5175_06062022\BlogProject_5175_06062022.WEB\Areas\Member\Views\AppUser\Index.cshtml"
Write(await Component.InvokeAsync("GetAllCategories"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AppUser> Html { get; private set; }
    }
}
#pragma warning restore 1591
