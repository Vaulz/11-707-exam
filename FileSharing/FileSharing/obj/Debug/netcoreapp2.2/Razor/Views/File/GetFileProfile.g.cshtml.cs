#pragma checksum "C:\Users\Anton\Desktop\11-707-exam\FileSharing\FileSharing\Views\File\GetFileProfile.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "083d8d1ffcd10f3046e2757b158e7f5be002be74"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_File_GetFileProfile), @"mvc.1.0.view", @"/Views/File/GetFileProfile.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/File/GetFileProfile.cshtml", typeof(AspNetCore.Views_File_GetFileProfile))]
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
#line 1 "C:\Users\Anton\Desktop\11-707-exam\FileSharing\FileSharing\Views\_ViewImports.cshtml"
using FileSharing;

#line default
#line hidden
#line 2 "C:\Users\Anton\Desktop\11-707-exam\FileSharing\FileSharing\Views\_ViewImports.cshtml"
using FileSharing.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"083d8d1ffcd10f3046e2757b158e7f5be002be74", @"/Views/File/GetFileProfile.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"93a11bdab95aceb82ff30b58334a029eb76f806c", @"/Views/_ViewImports.cshtml")]
    public class Views_File_GetFileProfile : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FileModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(18, 15, true);
            WriteLiteral("<div>\r\n    <h4>");
            EndContext();
            BeginContext(34, 10, false);
#line 3 "C:\Users\Anton\Desktop\11-707-exam\FileSharing\FileSharing\Views\File\GetFileProfile.cshtml"
   Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(44, 15, true);
            WriteLiteral("</h4>\r\n    <h4>");
            EndContext();
            BeginContext(60, 22, false);
#line 4 "C:\Users\Anton\Desktop\11-707-exam\FileSharing\FileSharing\Views\File\GetFileProfile.cshtml"
   Write(Model.ShortDescription);

#line default
#line hidden
            EndContext();
            BeginContext(82, 15, true);
            WriteLiteral("</h4>\r\n    <h4>");
            EndContext();
            BeginContext(98, 17, false);
#line 5 "C:\Users\Anton\Desktop\11-707-exam\FileSharing\FileSharing\Views\File\GetFileProfile.cshtml"
   Write(Model.Description);

#line default
#line hidden
            EndContext();
            BeginContext(115, 13, true);
            WriteLiteral("</h4>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FileModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
