#pragma checksum "C:\Users\farza\Desktop\Lab Review\AWSDesktopGUI\DesktopAWSGUI\TheCoolMovieApp\Views\Movie\EditMovie.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a0e9b18a3823f39b67b9f4ffeccd61038dafa5a4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Movie_EditMovie), @"mvc.1.0.view", @"/Views/Movie/EditMovie.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a0e9b18a3823f39b67b9f4ffeccd61038dafa5a4", @"/Views/Movie/EditMovie.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"844781e2b15fb8fc1397a49e6f5651b2571514a3", @"/Views/_ViewImports.cshtml")]
    public class Views_Movie_EditMovie : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TheCoolMovieApp.Models.MovieModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\farza\Desktop\Lab Review\AWSDesktopGUI\DesktopAWSGUI\TheCoolMovieApp\Views\Movie\EditMovie.cshtml"
   if (UserModel.LoggedIn == true)
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\farza\Desktop\Lab Review\AWSDesktopGUI\DesktopAWSGUI\TheCoolMovieApp\Views\Movie\EditMovie.cshtml"
         using (Html.BeginForm("DeleteMovie", "Movie", FormMethod.Post))
        {

            

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\farza\Desktop\Lab Review\AWSDesktopGUI\DesktopAWSGUI\TheCoolMovieApp\Views\Movie\EditMovie.cshtml"
       Write(Html.TextBoxFor(model => model.Title, new { style = "display: none;" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\farza\Desktop\Lab Review\AWSDesktopGUI\DesktopAWSGUI\TheCoolMovieApp\Views\Movie\EditMovie.cshtml"
       Write(Html.TextBoxFor(model => model.Creator, new { style = "display: none;" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("            <button class=\"delete-btn\" type=\"submit\">Delete Movie</button>\r\n");
#nullable restore
#line 11 "C:\Users\farza\Desktop\Lab Review\AWSDesktopGUI\DesktopAWSGUI\TheCoolMovieApp\Views\Movie\EditMovie.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        <br />\r\n        <br />\r\n        <br />\r\n");
#nullable restore
#line 15 "C:\Users\farza\Desktop\Lab Review\AWSDesktopGUI\DesktopAWSGUI\TheCoolMovieApp\Views\Movie\EditMovie.cshtml"
         using (Html.BeginForm("DownloadMovie", "Movie", FormMethod.Post))
        {

            

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\farza\Desktop\Lab Review\AWSDesktopGUI\DesktopAWSGUI\TheCoolMovieApp\Views\Movie\EditMovie.cshtml"
       Write(Html.TextBoxFor(model => model.Title, new { style = "display: none;" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\farza\Desktop\Lab Review\AWSDesktopGUI\DesktopAWSGUI\TheCoolMovieApp\Views\Movie\EditMovie.cshtml"
       Write(Html.TextBoxFor(model => model.Year, new { style = "display: none;" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\farza\Desktop\Lab Review\AWSDesktopGUI\DesktopAWSGUI\TheCoolMovieApp\Views\Movie\EditMovie.cshtml"
       Write(Html.TextBoxFor(model => model.Origin, new { style = "display: none;" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "C:\Users\farza\Desktop\Lab Review\AWSDesktopGUI\DesktopAWSGUI\TheCoolMovieApp\Views\Movie\EditMovie.cshtml"
       Write(Html.TextBoxFor(model => model.Length, new { style = "display: none;" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "C:\Users\farza\Desktop\Lab Review\AWSDesktopGUI\DesktopAWSGUI\TheCoolMovieApp\Views\Movie\EditMovie.cshtml"
       Write(Html.TextBoxFor(model => model.Creator, new { style = "display: none;" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("            <button class=\"download-btn\" type=\"submit\">Download Movie</button>\r\n");
#nullable restore
#line 24 "C:\Users\farza\Desktop\Lab Review\AWSDesktopGUI\DesktopAWSGUI\TheCoolMovieApp\Views\Movie\EditMovie.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        <br />\r\n        <br />\r\n        <br />\r\n        <h2>Edit Movie:</h2>\r\n");
#nullable restore
#line 29 "C:\Users\farza\Desktop\Lab Review\AWSDesktopGUI\DesktopAWSGUI\TheCoolMovieApp\Views\Movie\EditMovie.cshtml"
         using (Html.BeginForm("EditMovie", "Movie", FormMethod.Post, new { enctype = "multipart/form-data" }))
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 31 "C:\Users\farza\Desktop\Lab Review\AWSDesktopGUI\DesktopAWSGUI\TheCoolMovieApp\Views\Movie\EditMovie.cshtml"
       Write(Html.Label("Title:"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 32 "C:\Users\farza\Desktop\Lab Review\AWSDesktopGUI\DesktopAWSGUI\TheCoolMovieApp\Views\Movie\EditMovie.cshtml"
       Write(Html.TextBoxFor(model => model.Title));

#line default
#line hidden
#nullable disable
#nullable restore
#line 33 "C:\Users\farza\Desktop\Lab Review\AWSDesktopGUI\DesktopAWSGUI\TheCoolMovieApp\Views\Movie\EditMovie.cshtml"
       Write(Html.ValidationMessageFor(model => model.Title));

#line default
#line hidden
#nullable disable
#nullable restore
#line 34 "C:\Users\farza\Desktop\Lab Review\AWSDesktopGUI\DesktopAWSGUI\TheCoolMovieApp\Views\Movie\EditMovie.cshtml"
       Write(Html.Label("Year:"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 35 "C:\Users\farza\Desktop\Lab Review\AWSDesktopGUI\DesktopAWSGUI\TheCoolMovieApp\Views\Movie\EditMovie.cshtml"
       Write(Html.TextBoxFor(model => model.Year));

#line default
#line hidden
#nullable disable
#nullable restore
#line 36 "C:\Users\farza\Desktop\Lab Review\AWSDesktopGUI\DesktopAWSGUI\TheCoolMovieApp\Views\Movie\EditMovie.cshtml"
       Write(Html.Label("Country of Origin:"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 37 "C:\Users\farza\Desktop\Lab Review\AWSDesktopGUI\DesktopAWSGUI\TheCoolMovieApp\Views\Movie\EditMovie.cshtml"
       Write(Html.TextBoxFor(model => model.Origin));

#line default
#line hidden
#nullable disable
#nullable restore
#line 38 "C:\Users\farza\Desktop\Lab Review\AWSDesktopGUI\DesktopAWSGUI\TheCoolMovieApp\Views\Movie\EditMovie.cshtml"
       Write(Html.Label("Length:"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 39 "C:\Users\farza\Desktop\Lab Review\AWSDesktopGUI\DesktopAWSGUI\TheCoolMovieApp\Views\Movie\EditMovie.cshtml"
       Write(Html.TextBoxFor(model => model.Length));

#line default
#line hidden
#nullable disable
#nullable restore
#line 40 "C:\Users\farza\Desktop\Lab Review\AWSDesktopGUI\DesktopAWSGUI\TheCoolMovieApp\Views\Movie\EditMovie.cshtml"
       Write(Html.TextBoxFor(model => model.Creator, new { style = "display: none;" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("            <button type=\"submit\">Submit Changes</button>\r\n");
#nullable restore
#line 42 "C:\Users\farza\Desktop\Lab Review\AWSDesktopGUI\DesktopAWSGUI\TheCoolMovieApp\Views\Movie\EditMovie.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        <br />\r\n        <br />\r\n        <h2>Rate:</h2>\r\n");
#nullable restore
#line 46 "C:\Users\farza\Desktop\Lab Review\AWSDesktopGUI\DesktopAWSGUI\TheCoolMovieApp\Views\Movie\EditMovie.cshtml"
         using (Html.BeginForm("RateMovie", "Movie", FormMethod.Post))
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 48 "C:\Users\farza\Desktop\Lab Review\AWSDesktopGUI\DesktopAWSGUI\TheCoolMovieApp\Views\Movie\EditMovie.cshtml"
       Write(Html.TextBoxFor(model => model.Title, new { style = "display: none;" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 49 "C:\Users\farza\Desktop\Lab Review\AWSDesktopGUI\DesktopAWSGUI\TheCoolMovieApp\Views\Movie\EditMovie.cshtml"
       Write(Html.TextBoxFor(model => model.Year, new { style = "display: none;" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 50 "C:\Users\farza\Desktop\Lab Review\AWSDesktopGUI\DesktopAWSGUI\TheCoolMovieApp\Views\Movie\EditMovie.cshtml"
       Write(Html.TextBoxFor(model => model.Origin, new { style = "display: none;" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 51 "C:\Users\farza\Desktop\Lab Review\AWSDesktopGUI\DesktopAWSGUI\TheCoolMovieApp\Views\Movie\EditMovie.cshtml"
       Write(Html.TextBoxFor(model => model.Length, new { style = "display: none;" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 52 "C:\Users\farza\Desktop\Lab Review\AWSDesktopGUI\DesktopAWSGUI\TheCoolMovieApp\Views\Movie\EditMovie.cshtml"
       Write(Html.TextBoxFor(model => model.Creator, new { style = "display: none;" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 53 "C:\Users\farza\Desktop\Lab Review\AWSDesktopGUI\DesktopAWSGUI\TheCoolMovieApp\Views\Movie\EditMovie.cshtml"
       Write(Html.DropDownListFor(
            model => model.Rating,
            new SelectList(
                  new List<Object>{
                       new { value = 1, text = "1 Star" },
                       new { value = 2, text = "2 Stars" },
                       new { value = 3, text = "3 Stars" },
                       new { value = 4, text = "4 Stars" },
                       new { value = 5, text = "5 Stars"}
                    },
                  "value",
                  "text",
                   Model.Rating
           )
        ));

#line default
#line hidden
#nullable disable
            WriteLiteral("            <button class=\"download-btn\" type=\"submit\">Leave Rating</button>\r\n");
#nullable restore
#line 69 "C:\Users\farza\Desktop\Lab Review\AWSDesktopGUI\DesktopAWSGUI\TheCoolMovieApp\Views\Movie\EditMovie.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        <br />\r\n        <br />\r\n        <h2>Comments:</h2>\r\n        <br />\r\n        <br />\r\n");
#nullable restore
#line 75 "C:\Users\farza\Desktop\Lab Review\AWSDesktopGUI\DesktopAWSGUI\TheCoolMovieApp\Views\Movie\EditMovie.cshtml"
         using (Html.BeginForm("AddNewComment", "Movie", FormMethod.Post))
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 77 "C:\Users\farza\Desktop\Lab Review\AWSDesktopGUI\DesktopAWSGUI\TheCoolMovieApp\Views\Movie\EditMovie.cshtml"
       Write(Html.TextBoxFor(model => model.Title, new { style = "display: none;" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 78 "C:\Users\farza\Desktop\Lab Review\AWSDesktopGUI\DesktopAWSGUI\TheCoolMovieApp\Views\Movie\EditMovie.cshtml"
       Write(Html.TextBoxFor(model => model.Year, new { style = "display: none;" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 79 "C:\Users\farza\Desktop\Lab Review\AWSDesktopGUI\DesktopAWSGUI\TheCoolMovieApp\Views\Movie\EditMovie.cshtml"
       Write(Html.TextBoxFor(model => model.Origin, new { style = "display: none;" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 80 "C:\Users\farza\Desktop\Lab Review\AWSDesktopGUI\DesktopAWSGUI\TheCoolMovieApp\Views\Movie\EditMovie.cshtml"
       Write(Html.TextBoxFor(model => model.Length, new { style = "display: none;" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 81 "C:\Users\farza\Desktop\Lab Review\AWSDesktopGUI\DesktopAWSGUI\TheCoolMovieApp\Views\Movie\EditMovie.cshtml"
       Write(Html.TextBoxFor(model => model.Creator, new { style = "display: none;" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("            <button type=\"submit\">Edit/Add New Comment</button>\r\n");
#nullable restore
#line 83 "C:\Users\farza\Desktop\Lab Review\AWSDesktopGUI\DesktopAWSGUI\TheCoolMovieApp\Views\Movie\EditMovie.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div>\r\n            <table class=\"table table-striped\">\r\n");
#nullable restore
#line 86 "C:\Users\farza\Desktop\Lab Review\AWSDesktopGUI\DesktopAWSGUI\TheCoolMovieApp\Views\Movie\EditMovie.cshtml"
                 foreach (Tuple<string, string> comment in MovieModel.CommentList)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>");
#nullable restore
#line 89 "C:\Users\farza\Desktop\Lab Review\AWSDesktopGUI\DesktopAWSGUI\TheCoolMovieApp\Views\Movie\EditMovie.cshtml"
                       Write(comment.Item1);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 90 "C:\Users\farza\Desktop\Lab Review\AWSDesktopGUI\DesktopAWSGUI\TheCoolMovieApp\Views\Movie\EditMovie.cshtml"
                       Write(comment.Item2);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    </tr>\r\n");
#nullable restore
#line 92 "C:\Users\farza\Desktop\Lab Review\AWSDesktopGUI\DesktopAWSGUI\TheCoolMovieApp\Views\Movie\EditMovie.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </table>\r\n        </div>\r\n");
#nullable restore
#line 95 "C:\Users\farza\Desktop\Lab Review\AWSDesktopGUI\DesktopAWSGUI\TheCoolMovieApp\Views\Movie\EditMovie.cshtml"

    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <h1>Must sign in first.</h1>\r\n");
#nullable restore
#line 100 "C:\Users\farza\Desktop\Lab Review\AWSDesktopGUI\DesktopAWSGUI\TheCoolMovieApp\Views\Movie\EditMovie.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<style>

    .download-btn, .delete-btn {
        float: right;
        width: 100%;
        transition-duration: 0.4s;
        border-radius: 10px;
        padding: 14px 40px;
    }

        .delete-btn:hover {
            background-color: #f44336;
            color: white;
        }

        .download-btn:hover {
            background-color: #4CAF50;
            color: white;
        }

    .div {
        width: 5px;
        height: 13px;
        display: inline-block;
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
