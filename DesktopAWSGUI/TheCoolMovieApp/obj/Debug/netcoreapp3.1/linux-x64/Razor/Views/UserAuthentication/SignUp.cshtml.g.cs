#pragma checksum "C:\Users\farza\Desktop\Lab Review\AWSDesktopGUI\DesktopAWSGUI\TheCoolMovieApp\Views\UserAuthentication\SignUp.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2b52b5e37ab4fe606bb1ceb2af4fb8021cdd577e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_UserAuthentication_SignUp), @"mvc.1.0.view", @"/Views/UserAuthentication/SignUp.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2b52b5e37ab4fe606bb1ceb2af4fb8021cdd577e", @"/Views/UserAuthentication/SignUp.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"844781e2b15fb8fc1397a49e6f5651b2571514a3", @"/Views/_ViewImports.cshtml")]
    public class Views_UserAuthentication_SignUp : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TheCoolMovieApp.Models.UserModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\farza\Desktop\Lab Review\AWSDesktopGUI\DesktopAWSGUI\TheCoolMovieApp\Views\UserAuthentication\SignUp.cshtml"
   if (UserModel.LoggedIn == false)
    {

        

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\farza\Desktop\Lab Review\AWSDesktopGUI\DesktopAWSGUI\TheCoolMovieApp\Views\UserAuthentication\SignUp.cshtml"
         using (Html.BeginForm("Register", "UserAuthentication", FormMethod.Post))
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\farza\Desktop\Lab Review\AWSDesktopGUI\DesktopAWSGUI\TheCoolMovieApp\Views\UserAuthentication\SignUp.cshtml"
       Write(Html.Label("First Name:"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\farza\Desktop\Lab Review\AWSDesktopGUI\DesktopAWSGUI\TheCoolMovieApp\Views\UserAuthentication\SignUp.cshtml"
       Write(Html.TextBoxFor(model => model.FirstName));

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\farza\Desktop\Lab Review\AWSDesktopGUI\DesktopAWSGUI\TheCoolMovieApp\Views\UserAuthentication\SignUp.cshtml"
       Write(Html.ValidationMessageFor(model => model.FirstName));

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\farza\Desktop\Lab Review\AWSDesktopGUI\DesktopAWSGUI\TheCoolMovieApp\Views\UserAuthentication\SignUp.cshtml"
       Write(Html.Label("Last Name:"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\farza\Desktop\Lab Review\AWSDesktopGUI\DesktopAWSGUI\TheCoolMovieApp\Views\UserAuthentication\SignUp.cshtml"
       Write(Html.TextBoxFor(model => model.LastName));

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\farza\Desktop\Lab Review\AWSDesktopGUI\DesktopAWSGUI\TheCoolMovieApp\Views\UserAuthentication\SignUp.cshtml"
       Write(Html.ValidationMessageFor(model => model.LastName));

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\farza\Desktop\Lab Review\AWSDesktopGUI\DesktopAWSGUI\TheCoolMovieApp\Views\UserAuthentication\SignUp.cshtml"
       Write(Html.Label("Email:"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\farza\Desktop\Lab Review\AWSDesktopGUI\DesktopAWSGUI\TheCoolMovieApp\Views\UserAuthentication\SignUp.cshtml"
       Write(Html.TextBoxFor(model => model.Email));

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\farza\Desktop\Lab Review\AWSDesktopGUI\DesktopAWSGUI\TheCoolMovieApp\Views\UserAuthentication\SignUp.cshtml"
       Write(Html.ValidationMessageFor(model => model.Email));

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\farza\Desktop\Lab Review\AWSDesktopGUI\DesktopAWSGUI\TheCoolMovieApp\Views\UserAuthentication\SignUp.cshtml"
       Write(Html.Label("Password:"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\farza\Desktop\Lab Review\AWSDesktopGUI\DesktopAWSGUI\TheCoolMovieApp\Views\UserAuthentication\SignUp.cshtml"
       Write(Html.TextBoxFor(model => model.Password));

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\farza\Desktop\Lab Review\AWSDesktopGUI\DesktopAWSGUI\TheCoolMovieApp\Views\UserAuthentication\SignUp.cshtml"
       Write(Html.ValidationMessageFor(model => model.Password));

#line default
#line hidden
#nullable disable
            WriteLiteral("            <button type=\"submit\">Register</button>\r\n");
#nullable restore
#line 20 "C:\Users\farza\Desktop\Lab Review\AWSDesktopGUI\DesktopAWSGUI\TheCoolMovieApp\Views\UserAuthentication\SignUp.cshtml"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\farza\Desktop\Lab Review\AWSDesktopGUI\DesktopAWSGUI\TheCoolMovieApp\Views\UserAuthentication\SignUp.cshtml"
         
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <h3> You are aready logged in!</h3>\r\n");
#nullable restore
#line 25 "C:\Users\farza\Desktop\Lab Review\AWSDesktopGUI\DesktopAWSGUI\TheCoolMovieApp\Views\UserAuthentication\SignUp.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TheCoolMovieApp.Models.UserModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
