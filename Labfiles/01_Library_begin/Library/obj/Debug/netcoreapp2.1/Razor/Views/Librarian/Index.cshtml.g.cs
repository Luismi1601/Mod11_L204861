#pragma checksum "C:\Curso\20486\Luismi\LabFiles\Mod11\Labfiles\01_Library_begin\Library\Views\Librarian\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "eceb533180054f5cd54c4f4af39272e2215f596b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Librarian_Index), @"mvc.1.0.view", @"/Views/Librarian/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Librarian/Index.cshtml", typeof(AspNetCore.Views_Librarian_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eceb533180054f5cd54c4f4af39272e2215f596b", @"/Views/Librarian/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b35857dd199098649926cf8d40cf1622e149676b", @"/Views/_ViewImports.cshtml")]
    public class Views_Librarian_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\n\n");
            EndContext();
#line 3 "C:\Curso\20486\Luismi\LabFiles\Mod11\Labfiles\01_Library_begin\Library\Views\Librarian\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(40, 122, true);
            WriteLiteral("\n<h1 class=\"title\">Welcome to Workers Portal</h1>\n<div class=\"text-center\">\n    <button class=\"btn btn-info\" type=\"button\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 162, "\"", 223, 3);
            WriteAttributeValue("", 172, "location.href=\'", 172, 15, true);
#line 9 "C:\Curso\20486\Luismi\LabFiles\Mod11\Labfiles\01_Library_begin\Library\Views\Librarian\Index.cshtml"
WriteAttributeValue("", 187, Url.Action("AddBook", "Librarian"), 187, 35, false);

#line default
#line hidden
            WriteAttributeValue("", 222, "\'", 222, 1, true);
            EndWriteAttribute();
            BeginContext(224, 41, true);
            WriteLiteral(">Add Book to the Library</button>\n</div>\n");
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
