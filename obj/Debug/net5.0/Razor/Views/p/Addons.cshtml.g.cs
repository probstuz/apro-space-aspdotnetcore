#pragma checksum "/home/probstuz/pj/dotnet/first/Views/p/Addons.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d94b19e66f61e5b6a5b9507a1df8d44d53bab42c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_p_Addons), @"mvc.1.0.view", @"/Views/p/Addons.cshtml")]
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
#line 1 "/home/probstuz/pj/dotnet/first/Views/_ViewImports.cshtml"
using first;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/probstuz/pj/dotnet/first/Views/_ViewImports.cshtml"
using first.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d94b19e66f61e5b6a5b9507a1df8d44d53bab42c", @"/Views/p/Addons.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5ef4e17b3a3420b399ffb4ffe5f76343a9a7065b", @"/Views/_ViewImports.cshtml")]
    public class Views_p_Addons : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/home/probstuz/pj/dotnet/first/Views/p/Addons.cshtml"
  
    ViewData["Title"] = "Addons Page";
    var myMsg = "Addons Page - today is "+DateTime.Now.DayOfWeek;
    var currentTime = DateTime.Now;
    

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"text-center white box-shadow\">\r\n    <h1>Addons</h1>\r\n    <p> OMEGALUL ");
#nullable restore
#line 10 "/home/probstuz/pj/dotnet/first/Views/p/Addons.cshtml"
            Write(currentTime);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\r\n\r\n    <p>");
#nullable restore
#line 12 "/home/probstuz/pj/dotnet/first/Views/p/Addons.cshtml"
  Write(myMsg);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\r\n\r\n</div>");
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
