#pragma checksum "C:\DEV\LinkedIn Learning\V2\Ex_Files_Building_Web_App_Azure\Ex_Files_Web_App_Microsoft_Azure\Exercise Files\CH03\01\Begin\HPlusSportsWeb\Views\Admin\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3704c7cd189dc5409d5be750ffce793408a4bcf2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Index), @"mvc.1.0.view", @"/Views/Admin/Index.cshtml")]
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
#line 1 "C:\DEV\LinkedIn Learning\V2\Ex_Files_Building_Web_App_Azure\Ex_Files_Web_App_Microsoft_Azure\Exercise Files\CH03\01\Begin\HPlusSportsWeb\Views\_ViewImports.cshtml"
using HPlusSportsWeb;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\DEV\LinkedIn Learning\V2\Ex_Files_Building_Web_App_Azure\Ex_Files_Web_App_Microsoft_Azure\Exercise Files\CH03\01\Begin\HPlusSportsWeb\Views\_ViewImports.cshtml"
using HPlusSportsWeb.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3704c7cd189dc5409d5be750ffce793408a4bcf2", @"/Views/Admin/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"56d9b2d36eb5893f857a8d9ced006e6f6b501a01", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\DEV\LinkedIn Learning\V2\Ex_Files_Building_Web_App_Azure\Ex_Files_Web_App_Microsoft_Azure\Exercise Files\CH03\01\Begin\HPlusSportsWeb\Views\Admin\Index.cshtml"
  
    ViewData["Title"] = "Create New Product";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>Add a new product</h2>\r\n<p class=\"text-info text-center\">");
#nullable restore
#line 6 "C:\DEV\LinkedIn Learning\V2\Ex_Files_Building_Web_App_Azure\Ex_Files_Web_App_Microsoft_Azure\Exercise Files\CH03\01\Begin\HPlusSportsWeb\Views\Admin\Index.cshtml"
                            Write(ViewData["ProgressMessage"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n");
#nullable restore
#line 8 "C:\DEV\LinkedIn Learning\V2\Ex_Files_Building_Web_App_Azure\Ex_Files_Web_App_Microsoft_Azure\Exercise Files\CH03\01\Begin\HPlusSportsWeb\Views\Admin\Index.cshtml"
Write(Html.Partial("CreateClothing_Partial", ViewData["ClothingModel"]));

#line default
#line hidden
#nullable disable
            WriteLiteral(";\r\n\r\n");
#nullable restore
#line 10 "C:\DEV\LinkedIn Learning\V2\Ex_Files_Building_Web_App_Azure\Ex_Files_Web_App_Microsoft_Azure\Exercise Files\CH03\01\Begin\HPlusSportsWeb\Views\Admin\Index.cshtml"
Write(Html.Partial("CreateNutritional_Partial", ViewData["NutritionalModel"]));

#line default
#line hidden
#nullable disable
            WriteLiteral(";\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
