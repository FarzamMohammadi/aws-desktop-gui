#pragma checksum "C:\Users\farza\Desktop\Lab Review\AWSDesktopGUI\DesktopAWSGUI\TheCoolMovieApp\Views\Movie\Search.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c663fc92dc886ffc6298ca07f6f242c812f2804f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Movie_Search), @"mvc.1.0.view", @"/Views/Movie/Search.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c663fc92dc886ffc6298ca07f6f242c812f2804f", @"/Views/Movie/Search.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"844781e2b15fb8fc1397a49e6f5651b2571514a3", @"/Views/_ViewImports.cshtml")]
    public class Views_Movie_Search : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TheCoolMovieApp.Models.SearchModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\farza\Desktop\Lab Review\AWSDesktopGUI\DesktopAWSGUI\TheCoolMovieApp\Views\Movie\Search.cshtml"
   if (UserModel.LoggedIn == true)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <h2>Add Movie:</h2>\r\n");
#nullable restore
#line 6 "C:\Users\farza\Desktop\Lab Review\AWSDesktopGUI\DesktopAWSGUI\TheCoolMovieApp\Views\Movie\Search.cshtml"
         using (Html.BeginForm("ViewSearchResults", "Movie", FormMethod.Post))
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\farza\Desktop\Lab Review\AWSDesktopGUI\DesktopAWSGUI\TheCoolMovieApp\Views\Movie\Search.cshtml"
       Write(Html.Label("First Value: (1-5)"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\farza\Desktop\Lab Review\AWSDesktopGUI\DesktopAWSGUI\TheCoolMovieApp\Views\Movie\Search.cshtml"
       Write(Html.TextBoxFor(model => model.FirstNumber));

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\farza\Desktop\Lab Review\AWSDesktopGUI\DesktopAWSGUI\TheCoolMovieApp\Views\Movie\Search.cshtml"
       Write(Html.DropDownListFor(model => model.TypeOfSearch,
    new SelectList(
          new List<Object>{
           new { value = 1, text = ">" },
           new { value = 2, text = "<" },

},
"value",
"text"
)
));

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "C:\Users\farza\Desktop\Lab Review\AWSDesktopGUI\DesktopAWSGUI\TheCoolMovieApp\Views\Movie\Search.cshtml"
       Write(Html.TextBoxFor(model => model.SecondNumber));

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "C:\Users\farza\Desktop\Lab Review\AWSDesktopGUI\DesktopAWSGUI\TheCoolMovieApp\Views\Movie\Search.cshtml"
       Write(Html.Label("Second Value: (0-5)"));

#line default
#line hidden
#nullable disable
            WriteLiteral("            <button type=\"submit\">Search Titles</button>\r\n");
#nullable restore
#line 25 "C:\Users\farza\Desktop\Lab Review\AWSDesktopGUI\DesktopAWSGUI\TheCoolMovieApp\Views\Movie\Search.cshtml"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "C:\Users\farza\Desktop\Lab Review\AWSDesktopGUI\DesktopAWSGUI\TheCoolMovieApp\Views\Movie\Search.cshtml"
         
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <h3> Please Sign in to upload a movie.</h3>\r\n");
#nullable restore
#line 30 "C:\Users\farza\Desktop\Lab Review\AWSDesktopGUI\DesktopAWSGUI\TheCoolMovieApp\Views\Movie\Search.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TheCoolMovieApp.Models.SearchModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
