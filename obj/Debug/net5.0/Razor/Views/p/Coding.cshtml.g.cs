#pragma checksum "/home/probstuz/pj/dotnet/apro-space-aspdotnetcore/Views/p/Coding.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e049e204adc5554bcbc7beeaa95d85bbf7616b00"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_p_Coding), @"mvc.1.0.view", @"/Views/p/Coding.cshtml")]
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
#line 1 "/home/probstuz/pj/dotnet/apro-space-aspdotnetcore/Views/_ViewImports.cshtml"
using first;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/probstuz/pj/dotnet/apro-space-aspdotnetcore/Views/_ViewImports.cshtml"
using first.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e049e204adc5554bcbc7beeaa95d85bbf7616b00", @"/Views/p/Coding.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5ef4e17b3a3420b399ffb4ffe5f76343a9a7065b", @"/Views/_ViewImports.cshtml")]
    public class Views_p_Coding : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/home/probstuz/pj/dotnet/apro-space-aspdotnetcore/Views/p/Coding.cshtml"
  
    ViewData["Title"] = "Coding Page";
    var myMsg = "Coding Page - today is "+DateTime.Now.DayOfWeek;
    var currentTime = DateTime.Now;
    

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"text-center white box-shadow\">\r\n    <h1>Coding</h1>\r\n    <p> OMEGALUL ");
#nullable restore
#line 10 "/home/probstuz/pj/dotnet/apro-space-aspdotnetcore/Views/p/Coding.cshtml"
            Write(currentTime);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\r\n\r\n    <p>");
#nullable restore
#line 12 "/home/probstuz/pj/dotnet/apro-space-aspdotnetcore/Views/p/Coding.cshtml"
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
