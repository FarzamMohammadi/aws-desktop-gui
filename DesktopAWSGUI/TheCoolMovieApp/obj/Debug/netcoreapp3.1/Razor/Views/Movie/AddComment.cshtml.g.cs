#pragma checksum "C:\Users\farza\Desktop\Lab Review\AWSDesktopGUI\DesktopAWSGUI\TheCoolMovieApp\Views\Movie\AddComment.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3daaa2a12d30034a0e17725dac4b1f4d4440c6de"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Movie_AddComment), @"mvc.1.0.view", @"/Views/Movie/AddComment.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3daaa2a12d30034a0e17725dac4b1f4d4440c6de", @"/Views/Movie/AddComment.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"844781e2b15fb8fc1397a49e6f5651b2571514a3", @"/Views/_ViewImports.cshtml")]
    public class Views_Movie_AddComment : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TheCoolMovieApp.Models.CommentModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\farza\Desktop\Lab Review\AWSDesktopGUI\DesktopAWSGUI\TheCoolMovieApp\Views\Movie\AddComment.cshtml"
 if (UserModel.LoggedIn == true)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h1>Comment:</h1>\r\n");
#nullable restore
#line 5 "C:\Users\farza\Desktop\Lab Review\AWSDesktopGUI\DesktopAWSGUI\TheCoolMovieApp\Views\Movie\AddComment.cshtml"
     using (Html.BeginForm("AddNewComment", "Movie", FormMethod.Post))
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\farza\Desktop\Lab Review\AWSDesktopGUI\DesktopAWSGUI\TheCoolMovieApp\Views\Movie\AddComment.cshtml"
   Write(Html.TextBoxFor(model => model.Comment, new { @class = "form-control form-control-custom", @style = "width:1000px; height:100px;" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("        <button class=\"delete-btn\" type=\"submit\">Submit</button>\r\n");
#nullable restore
#line 9 "C:\Users\farza\Desktop\Lab Review\AWSDesktopGUI\DesktopAWSGUI\TheCoolMovieApp\Views\Movie\AddComment.cshtml"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\farza\Desktop\Lab Review\AWSDesktopGUI\DesktopAWSGUI\TheCoolMovieApp\Views\Movie\AddComment.cshtml"
     
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h1>Must be signed in to leave comment.</h1>\r\n");
#nullable restore
#line 14 "C:\Users\farza\Desktop\Lab Review\AWSDesktopGUI\DesktopAWSGUI\TheCoolMovieApp\Views\Movie\AddComment.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TheCoolMovieApp.Models.CommentModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
