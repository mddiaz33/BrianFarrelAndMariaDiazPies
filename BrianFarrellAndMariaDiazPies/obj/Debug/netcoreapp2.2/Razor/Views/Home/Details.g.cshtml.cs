#pragma checksum "E:\PS\BrianFarrellAndMariaDiazPies\BrianFarrellAndMariaDiazPies\Views\Home\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "07a919b6ac1540f0b0e914f07d56636757ceb32a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Details), @"mvc.1.0.view", @"/Views/Home/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Details.cshtml", typeof(AspNetCore.Views_Home_Details))]
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
#line 1 "E:\PS\BrianFarrellAndMariaDiazPies\BrianFarrellAndMariaDiazPies\Views\_ViewImports.cshtml"
using BrianFarrellAndMariaDiazPies.Models;

#line default
#line hidden
#line 2 "E:\PS\BrianFarrellAndMariaDiazPies\BrianFarrellAndMariaDiazPies\Views\_ViewImports.cshtml"
using BrianFarrellAndMariaDiazPies.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"07a919b6ac1540f0b0e914f07d56636757ceb32a", @"/Views/Home/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"53a2478cefabbaeeb3e4446be19874f13138e053", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Pie>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(12, 8, true);
            WriteLiteral("\r\n\r\n<h2>");
            EndContext();
            BeginContext(21, 10, false);
#line 4 "E:\PS\BrianFarrellAndMariaDiazPies\BrianFarrellAndMariaDiazPies\Views\Home\Details.cshtml"
Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(31, 42, true);
            WriteLiteral("</h2>\r\n\r\n<div class=\"thumbnail\">\r\n    <img");
            EndContext();
            BeginWriteAttribute("alt", " alt=\"", 73, "\"", 90, 1);
#line 7 "E:\PS\BrianFarrellAndMariaDiazPies\BrianFarrellAndMariaDiazPies\Views\Home\Details.cshtml"
WriteAttributeValue("", 79, Model.Name, 79, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("src", " src=\"", 91, "\"", 112, 1);
#line 7 "E:\PS\BrianFarrellAndMariaDiazPies\BrianFarrellAndMariaDiazPies\Views\Home\Details.cshtml"
WriteAttributeValue("", 97, Model.ImageUrl, 97, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(113, 66, true);
            WriteLiteral(">\r\n    <div class=\"caption-full\">\r\n        <h3 class=\"pull-right\">");
            EndContext();
            BeginContext(180, 11, false);
#line 9 "E:\PS\BrianFarrellAndMariaDiazPies\BrianFarrellAndMariaDiazPies\Views\Home\Details.cshtml"
                          Write(Model.Price);

#line default
#line hidden
            EndContext();
            BeginContext(191, 45, true);
            WriteLiteral("</h3>\r\n        <h3>\r\n            <a href=\"#\">");
            EndContext();
            BeginContext(237, 10, false);
#line 11 "E:\PS\BrianFarrellAndMariaDiazPies\BrianFarrellAndMariaDiazPies\Views\Home\Details.cshtml"
                   Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(247, 33, true);
            WriteLiteral("</a>\r\n        </h3>\r\n        <h4>");
            EndContext();
            BeginContext(281, 22, false);
#line 13 "E:\PS\BrianFarrellAndMariaDiazPies\BrianFarrellAndMariaDiazPies\Views\Home\Details.cshtml"
       Write(Model.ShortDescription);

#line default
#line hidden
            EndContext();
            BeginContext(303, 18, true);
            WriteLiteral("</h4>\r\n        <p>");
            EndContext();
            BeginContext(322, 21, false);
#line 14 "E:\PS\BrianFarrellAndMariaDiazPies\BrianFarrellAndMariaDiazPies\Views\Home\Details.cshtml"
      Write(Model.LongDescription);

#line default
#line hidden
            EndContext();
            BeginContext(343, 24, true);
            WriteLiteral("</p>\r\n    </div>\r\n</div>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Pie> Html { get; private set; }
    }
}
#pragma warning restore 1591
