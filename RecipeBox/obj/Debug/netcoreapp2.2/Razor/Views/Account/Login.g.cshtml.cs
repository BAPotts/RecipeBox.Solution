#pragma checksum "C:\Users\potts\desktop\csharp\Recipebox.solution\recipebox\Views\Account\Login.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e21c56f1dc152f57c31d6e5bdaa0de5a0e6869ee"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_Login), @"mvc.1.0.view", @"/Views/Account/Login.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Account/Login.cshtml", typeof(AspNetCore.Views_Account_Login))]
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
#line 5 "C:\Users\potts\desktop\csharp\Recipebox.solution\recipebox\Views\Account\Login.cshtml"
using RecipeBox.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e21c56f1dc152f57c31d6e5bdaa0de5a0e6869ee", @"/Views/Account/Login.cshtml")]
    public class Views_Account_Login : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<LoginViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\potts\desktop\csharp\Recipebox.solution\recipebox\Views\Account\Login.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
            BeginContext(30, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(61, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(86, 47, true);
            WriteLiteral("\r\n<h2>Log in with your account</h2>\r\n<hr />\r\n\r\n");
            EndContext();
#line 12 "C:\Users\potts\desktop\csharp\Recipebox.solution\recipebox\Views\Account\Login.cshtml"
 using (Html.BeginForm())
{
  

#line default
#line hidden
            BeginContext(166, 27, false);
#line 14 "C:\Users\potts\desktop\csharp\Recipebox.solution\recipebox\Views\Account\Login.cshtml"
Write(Html.LabelFor(m => m.Email));

#line default
#line hidden
            EndContext();
            BeginContext(198, 29, false);
#line 15 "C:\Users\potts\desktop\csharp\Recipebox.solution\recipebox\Views\Account\Login.cshtml"
Write(Html.TextBoxFor(m => m.Email));

#line default
#line hidden
            EndContext();
            BeginContext(234, 30, false);
#line 17 "C:\Users\potts\desktop\csharp\Recipebox.solution\recipebox\Views\Account\Login.cshtml"
Write(Html.LabelFor(m => m.Password));

#line default
#line hidden
            EndContext();
            BeginContext(269, 33, false);
#line 18 "C:\Users\potts\desktop\csharp\Recipebox.solution\recipebox\Views\Account\Login.cshtml"
Write(Html.PasswordFor(m => m.Password));

#line default
#line hidden
            EndContext();
            BeginContext(306, 66, true);
            WriteLiteral("  <input type=\"submit\" value=\"Log in\" class=\"btn btn-default\" />\r\n");
            EndContext();
#line 21 "C:\Users\potts\desktop\csharp\Recipebox.solution\recipebox\Views\Account\Login.cshtml"
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<LoginViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
