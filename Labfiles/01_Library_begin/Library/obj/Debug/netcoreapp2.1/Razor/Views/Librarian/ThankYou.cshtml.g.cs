#pragma checksum "C:\Curso\20486\Luismi\LabFiles\Mod11\Labfiles\01_Library_begin\Library\Views\Librarian\ThankYou.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "db3f33ad5208648902241726b31f30ccea8d3dd7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Librarian_ThankYou), @"mvc.1.0.view", @"/Views/Librarian/ThankYou.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Librarian/ThankYou.cshtml", typeof(AspNetCore.Views_Librarian_ThankYou))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"db3f33ad5208648902241726b31f30ccea8d3dd7", @"/Views/Librarian/ThankYou.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b35857dd199098649926cf8d40cf1622e149676b", @"/Views/_ViewImports.cshtml")]
    public class Views_Librarian_ThankYou : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 2 "C:\Curso\20486\Luismi\LabFiles\Mod11\Labfiles\01_Library_begin\Library\Views\Librarian\ThankYou.cshtml"
  
    ViewData["Title"] = "ThankYou";

#line default
#line hidden
            BeginContext(42, 142, true);
            WriteLiteral("\n<h1 class=\"title\">Thank You For Adding a Book to the Inventory</h1>\n\n<div class=\"text-center\">\n    <button class=\"btn btn-info\" type=\"button\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 184, "\"", 245, 3);
            WriteAttributeValue("", 194, "location.href=\'", 194, 15, true);
#line 9 "C:\Curso\20486\Luismi\LabFiles\Mod11\Labfiles\01_Library_begin\Library\Views\Librarian\ThankYou.cshtml"
WriteAttributeValue("", 209, Url.Action("AddBook", "Librarian"), 209, 35, false);

#line default
#line hidden
            WriteAttributeValue("", 244, "\'", 244, 1, true);
            EndWriteAttribute();
            BeginContext(246, 80, true);
            WriteLiteral(">Add Book to the Library</button>\n    <button class=\"btn btn-info\" type=\"button\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 326, "\"", 393, 3);
            WriteAttributeValue("", 336, "location.href=\'", 336, 15, true);
#line 10 "C:\Curso\20486\Luismi\LabFiles\Mod11\Labfiles\01_Library_begin\Library\Views\Librarian\ThankYou.cshtml"
WriteAttributeValue("", 351, Url.Action("GetBooksByGener", "Library"), 351, 41, false);

#line default
#line hidden
            WriteAttributeValue("", 392, "\'", 392, 1, true);
            EndWriteAttribute();
            BeginContext(394, 35, true);
            WriteLiteral(">Back to Our Books</button>\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
