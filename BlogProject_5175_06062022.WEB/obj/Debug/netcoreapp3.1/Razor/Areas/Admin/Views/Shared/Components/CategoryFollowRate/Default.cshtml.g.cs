#pragma checksum "C:\Users\yuska\Desktop\BlogProject_5175_06062022\BlogProject_5175_06062022.WEB\Areas\Admin\Views\Shared\Components\CategoryFollowRate\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f05670c5f0443380ad7a05e08f3235a844f0c13b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Shared_Components_CategoryFollowRate_Default), @"mvc.1.0.view", @"/Areas/Admin/Views/Shared/Components/CategoryFollowRate/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f05670c5f0443380ad7a05e08f3235a844f0c13b", @"/Areas/Admin/Views/Shared/Components/CategoryFollowRate/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d6af702b171cdbdbdaf7c0907417e322b541f60f", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Shared_Components_CategoryFollowRate_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<CategoryFollowRateVM>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\yuska\Desktop\BlogProject_5175_06062022\BlogProject_5175_06062022.WEB\Areas\Admin\Views\Shared\Components\CategoryFollowRate\Default.cshtml"
 foreach (var item in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"control\" style=\"margin-bottom:10px;\">\r\n    <small style=\"font-size: 14px; color: #7c8695;\">");
#nullable restore
#line 6 "C:\Users\yuska\Desktop\BlogProject_5175_06062022\BlogProject_5175_06062022.WEB\Areas\Admin\Views\Shared\Components\CategoryFollowRate\Default.cshtml"
                                               Write(item.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</small>\r\n    <span style=\"float: right; font-size: 14px; position: relative; color: #7c8695;\">");
#nullable restore
#line 7 "C:\Users\yuska\Desktop\BlogProject_5175_06062022\BlogProject_5175_06062022.WEB\Areas\Admin\Views\Shared\Components\CategoryFollowRate\Default.cshtml"
                                                                                Write(item.RateCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("%</span>\r\n    <div class=\"progress\" style=\"height:4px;\">\r\n        <div class=\"progress-bar\" role=\"progressbar\"");
            BeginWriteAttribute("style", " style=\"", 411, "\"", 453, 3);
            WriteAttributeValue("", 419, "width:", 419, 6, true);
#nullable restore
#line 9 "C:\Users\yuska\Desktop\BlogProject_5175_06062022\BlogProject_5175_06062022.WEB\Areas\Admin\Views\Shared\Components\CategoryFollowRate\Default.cshtml"
WriteAttributeValue(" ", 425, item.RateCount.ToString(), 426, 26, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 452, "%", 452, 1, true);
            EndWriteAttribute();
            BeginWriteAttribute("aria-valuenow", " aria-valuenow=\"", 454, "\"", 485, 1);
#nullable restore
#line 9 "C:\Users\yuska\Desktop\BlogProject_5175_06062022\BlogProject_5175_06062022.WEB\Areas\Admin\Views\Shared\Components\CategoryFollowRate\Default.cshtml"
WriteAttributeValue("", 470, item.RateCount, 470, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" aria-valuemin=\"0\" aria-valuemax=\"100\"></div>\r\n    </div>\r\n</div>\r\n");
#nullable restore
#line 12 "C:\Users\yuska\Desktop\BlogProject_5175_06062022\BlogProject_5175_06062022.WEB\Areas\Admin\Views\Shared\Components\CategoryFollowRate\Default.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<CategoryFollowRateVM>> Html { get; private set; }
    }
}
#pragma warning restore 1591
