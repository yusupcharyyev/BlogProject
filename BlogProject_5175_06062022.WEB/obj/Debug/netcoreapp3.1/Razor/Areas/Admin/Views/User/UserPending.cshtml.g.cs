#pragma checksum "C:\Users\yuska\Desktop\BlogProject_5175_06062022\BlogProject_5175_06062022.WEB\Areas\Admin\Views\User\UserPending.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3b1a3e3a1124b27a72a026113e93cbac81b56c29"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_User_UserPending), @"mvc.1.0.view", @"/Areas/Admin/Views/User/UserPending.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3b1a3e3a1124b27a72a026113e93cbac81b56c29", @"/Areas/Admin/Views/User/UserPending.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d6af702b171cdbdbdaf7c0907417e322b541f60f", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_User_UserPending : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<GetUserPendingDTO>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "UserActive", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "User", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success text-center"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n<div class=\"row\">\r\n");
#nullable restore
#line 4 "C:\Users\yuska\Desktop\BlogProject_5175_06062022\BlogProject_5175_06062022.WEB\Areas\Admin\Views\User\UserPending.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""col-lg-3"">
            <div class=""card card-primary"" style=""border-top: 3px solid #007bff;"">
                <div class=""card-body box-profile"" style=""flex: 1 1 auto; padding: 35px;text-align:center;"">
                    <div class=""text-center"">
                        <img class=""profile-user-img img-fluid img-circle""");
            BeginWriteAttribute("src", " src=\"", 431, "\"", 448, 1);
#nullable restore
#line 9 "C:\Users\yuska\Desktop\BlogProject_5175_06062022\BlogProject_5175_06062022.WEB\Areas\Admin\Views\User\UserPending.cshtml"
WriteAttributeValue("", 437, item.Image, 437, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"User profile picture\" style=\"border: 3px solid #adb5bd; margin: 0 auto; padding: 3px; width: 100px; border-radius: 50%; \">\r\n                    </div>\r\n\r\n                    <h3 class=\"profile-username text-center\">");
#nullable restore
#line 12 "C:\Users\yuska\Desktop\BlogProject_5175_06062022\BlogProject_5175_06062022.WEB\Areas\Admin\Views\User\UserPending.cshtml"
                                                        Write(item.FullName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n\r\n                    <p class=\"text-muted text-center\">");
#nullable restore
#line 14 "C:\Users\yuska\Desktop\BlogProject_5175_06062022\BlogProject_5175_06062022.WEB\Areas\Admin\Views\User\UserPending.cshtml"
                                                 Write(item.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <p class=\"text-muted text-center\">");
#nullable restore
#line 15 "C:\Users\yuska\Desktop\BlogProject_5175_06062022\BlogProject_5175_06062022.WEB\Areas\Admin\Views\User\UserPending.cshtml"
                                                 Write(item.CreateDate.ToString("dd.MM.yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3b1a3e3a1124b27a72a026113e93cbac81b56c297700", async() => {
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
#line 17 "C:\Users\yuska\Desktop\BlogProject_5175_06062022\BlogProject_5175_06062022.WEB\Areas\Admin\Views\User\UserPending.cshtml"
                                                                       WriteLiteral(item.ID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 21 "C:\Users\yuska\Desktop\BlogProject_5175_06062022\BlogProject_5175_06062022.WEB\Areas\Admin\Views\User\UserPending.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<GetUserPendingDTO>> Html { get; private set; }
    }
}
#pragma warning restore 1591
