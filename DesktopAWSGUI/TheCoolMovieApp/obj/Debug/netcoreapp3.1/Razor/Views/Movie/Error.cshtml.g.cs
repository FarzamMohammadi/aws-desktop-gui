#pragma checksum "C:\Users\farza\Desktop\Lab Review\AWSDesktopGUI\DesktopAWSGUI\TheCoolMovieApp\Views\Movie\Error.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e91196beb0b64c94933312bd4e4fbf71178a6a4f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Movie_Error), @"mvc.1.0.view", @"/Views/Movie/Error.cshtml")]
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
#line 1 "C:\Users\farza\Desktop\Lab Review\AWSDesktopGUI\DesktopAWSGUI\TheCoolMovieApp\Views\_ViewImports.cshtml"
using TheCoolMovieApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\farza\Desktop\Lab Review\AWSDesktopGUI\DesktopAWSGUI\TheCoolMovieApp\Views\_ViewImports.cshtml"
using TheCoolMovieApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e91196beb0b64c94933312bd4e4fbf71178a6a4f", @"/Views/Movie/Error.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"844781e2b15fb8fc1397a49e6f5651b2571514a3", @"/Views/_ViewImports.cshtml")]
    public class Views_Movie_Error : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MyStringModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h1>Error! ");
#nullable restore
#line 3 "C:\Users\farza\Desktop\Lab Review\AWSDesktopGUI\DesktopAWSGUI\TheCoolMovieApp\Views\Movie\Error.cshtml"
      Write(Html.Label(Model.Message));

#line default
#line hidden
#nullable disable
            WriteLiteral(". Please try again!</h1>\r\n\r\n");
#nullable restore
#line 6 "C:\Users\farza\Desktop\Lab Review\AWSDesktopGUI\DesktopAWSGUI\TheCoolMovieApp\Views\Movie\Error.cshtml"
Write(Html.Label("Exception:"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 7 "C:\Users\farza\Desktop\Lab Review\AWSDesktopGUI\DesktopAWSGUI\TheCoolMovieApp\Views\Movie\Error.cshtml"
Write(Html.Label(Model.Exception));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MyStringModel> Html { get; private set; }
    }
}
#pragma warning restore 1591