#pragma checksum "C:\Users\farza\Desktop\Lab Review\AWSDesktopGUI\DesktopAWSGUI\TheCoolMovieApp\Views\Movie\ViewAllMovies.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9c9b56854126299377c1b5295ea41929ee383025"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Movie_ViewAllMovies), @"mvc.1.0.view", @"/Views/Movie/ViewAllMovies.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9c9b56854126299377c1b5295ea41929ee383025", @"/Views/Movie/ViewAllMovies.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"844781e2b15fb8fc1397a49e6f5651b2571514a3", @"/Views/_ViewImports.cshtml")]
    public class Views_Movie_ViewAllMovies : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TheCoolMovieApp.Models.MovieModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\farza\Desktop\Lab Review\AWSDesktopGUI\DesktopAWSGUI\TheCoolMovieApp\Views\Movie\ViewAllMovies.cshtml"
   if (UserModel.LoggedIn == true)
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\farza\Desktop\Lab Review\AWSDesktopGUI\DesktopAWSGUI\TheCoolMovieApp\Views\Movie\ViewAllMovies.cshtml"
         using (Html.BeginForm("RedirectToAddNewMovie", "Movie", FormMethod.Post))
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <button type=\"submit\">Add New Movie</button>\r\n");
#nullable restore
#line 7 "C:\Users\farza\Desktop\Lab Review\AWSDesktopGUI\DesktopAWSGUI\TheCoolMovieApp\Views\Movie\ViewAllMovies.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        <br />\r\n        <br />\r\n        <br />\r\n");
#nullable restore
#line 13 "C:\Users\farza\Desktop\Lab Review\AWSDesktopGUI\DesktopAWSGUI\TheCoolMovieApp\Views\Movie\ViewAllMovies.cshtml"
        //List all existing movies

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"head\">\r\n            <h1>All Movies</h1>\r\n        </div>\r\n");
#nullable restore
#line 17 "C:\Users\farza\Desktop\Lab Review\AWSDesktopGUI\DesktopAWSGUI\TheCoolMovieApp\Views\Movie\ViewAllMovies.cshtml"
         foreach (MovieModel movie in MovieModel.MoviesToShow)
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\farza\Desktop\Lab Review\AWSDesktopGUI\DesktopAWSGUI\TheCoolMovieApp\Views\Movie\ViewAllMovies.cshtml"
             using (Html.BeginForm("RedirectToEditMovie", "Movie", FormMethod.Post))
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "C:\Users\farza\Desktop\Lab Review\AWSDesktopGUI\DesktopAWSGUI\TheCoolMovieApp\Views\Movie\ViewAllMovies.cshtml"
           Write(Html.TextBoxFor(model => movie.Title, new { style = "display: none;" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "C:\Users\farza\Desktop\Lab Review\AWSDesktopGUI\DesktopAWSGUI\TheCoolMovieApp\Views\Movie\ViewAllMovies.cshtml"
           Write(Html.TextBoxFor(model => movie.Year, new { style = "display: none;" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "C:\Users\farza\Desktop\Lab Review\AWSDesktopGUI\DesktopAWSGUI\TheCoolMovieApp\Views\Movie\ViewAllMovies.cshtml"
           Write(Html.TextBoxFor(model => movie.Origin, new { style = "display: none;" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "C:\Users\farza\Desktop\Lab Review\AWSDesktopGUI\DesktopAWSGUI\TheCoolMovieApp\Views\Movie\ViewAllMovies.cshtml"
           Write(Html.TextBoxFor(model => movie.Length, new { style = "display: none;" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "C:\Users\farza\Desktop\Lab Review\AWSDesktopGUI\DesktopAWSGUI\TheCoolMovieApp\Views\Movie\ViewAllMovies.cshtml"
           Write(Html.TextBoxFor(model => movie.Creator, new { style = "display: none;" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div>\r\n                    <button class=\"movie-buttons\" type=\"submit\">");
#nullable restore
#line 27 "C:\Users\farza\Desktop\Lab Review\AWSDesktopGUI\DesktopAWSGUI\TheCoolMovieApp\Views\Movie\ViewAllMovies.cshtml"
                                                           Write(movie.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - Current Rating: ");
#nullable restore
#line 27 "C:\Users\farza\Desktop\Lab Review\AWSDesktopGUI\DesktopAWSGUI\TheCoolMovieApp\Views\Movie\ViewAllMovies.cshtml"
                                                                                          Write(movie.Rating);

#line default
#line hidden
#nullable disable
            WriteLiteral("  -</button>\r\n                </div>\r\n");
#nullable restore
#line 29 "C:\Users\farza\Desktop\Lab Review\AWSDesktopGUI\DesktopAWSGUI\TheCoolMovieApp\Views\Movie\ViewAllMovies.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 29 "C:\Users\farza\Desktop\Lab Review\AWSDesktopGUI\DesktopAWSGUI\TheCoolMovieApp\Views\Movie\ViewAllMovies.cshtml"
             
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"button\">\r\n");
#nullable restore
#line 32 "C:\Users\farza\Desktop\Lab Review\AWSDesktopGUI\DesktopAWSGUI\TheCoolMovieApp\Views\Movie\ViewAllMovies.cshtml"
             using (Html.BeginForm("Search", "Movie", FormMethod.Post))
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <button style=\"float:right\" type=\"submit\">Search Based On Rating</button>\r\n");
#nullable restore
#line 35 "C:\Users\farza\Desktop\Lab Review\AWSDesktopGUI\DesktopAWSGUI\TheCoolMovieApp\Views\Movie\ViewAllMovies.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n");
#nullable restore
#line 37 "C:\Users\farza\Desktop\Lab Review\AWSDesktopGUI\DesktopAWSGUI\TheCoolMovieApp\Views\Movie\ViewAllMovies.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <h3> You must sign in for full access!</h3>\r\n");
#nullable restore
#line 41 "C:\Users\farza\Desktop\Lab Review\AWSDesktopGUI\DesktopAWSGUI\TheCoolMovieApp\Views\Movie\ViewAllMovies.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<style>
    .head {
        text-align: center;
    }

    .movie-buttons, .button {
        float: right;
        width: 100%;
        transition-duration: 0.4s;
        border-radius: 10px;
        padding: 14px 40px;
    }

        .movie-buttons:hover {
            background-color: DodgerBlue;
            color: white;
        }
</style>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TheCoolMovieApp.Models.MovieModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
