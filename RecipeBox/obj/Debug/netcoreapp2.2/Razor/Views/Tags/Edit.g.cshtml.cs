#pragma checksum "C:\Users\potts\Desktop\csharp\Recipebox.solution\recipebox\Views\Tags\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d201bff5bb826b730431f7d4b0187c3857b81b67"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Tags_Edit), @"mvc.1.0.view", @"/Views/Tags/Edit.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Tags/Edit.cshtml", typeof(AspNetCore.Views_Tags_Edit))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d201bff5bb826b730431f7d4b0187c3857b81b67", @"/Views/Tags/Edit.cshtml")]
    public class Views_Tags_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RecipeBox.Models.Tag>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(29, 28, true);
            WriteLiteral("\r\n<h2>Edit this Tag</h2>\r\n\r\n");
            EndContext();
#line 5 "C:\Users\potts\Desktop\csharp\Recipebox.solution\recipebox\Views\Tags\Edit.cshtml"
 using(Html.BeginForm())
{
  

#line default
#line hidden
            BeginContext(89, 36, false);
#line 7 "C:\Users\potts\Desktop\csharp\Recipebox.solution\recipebox\Views\Tags\Edit.cshtml"
Write(Html.HiddenFor(model => model.TagId));

#line default
#line hidden
            EndContext();
            BeginContext(132, 37, false);
#line 9 "C:\Users\potts\Desktop\csharp\Recipebox.solution\recipebox\Views\Tags\Edit.cshtml"
Write(Html.LabelFor(model => model.TagName));

#line default
#line hidden
            EndContext();
            BeginContext(174, 39, false);
#line 10 "C:\Users\potts\Desktop\csharp\Recipebox.solution\recipebox\Views\Tags\Edit.cshtml"
Write(Html.TextBoxFor(model => model.TagName));

#line default
#line hidden
            EndContext();
            BeginContext(220, 29, false);
#line 12 "C:\Users\potts\Desktop\csharp\Recipebox.solution\recipebox\Views\Tags\Edit.cshtml"
Write(Html.Label("Select a Recipe"));

#line default
#line hidden
            EndContext();
            BeginContext(254, 29, false);
#line 13 "C:\Users\potts\Desktop\csharp\Recipebox.solution\recipebox\Views\Tags\Edit.cshtml"
Write(Html.DropDownList("RecipeId"));

#line default
#line hidden
            EndContext();
            BeginContext(287, 66, true);
            WriteLiteral("  <input type=\"submit\" value=\"Submit\" class=\"btn btn-default\" />\r\n");
            EndContext();
#line 16 "C:\Users\potts\Desktop\csharp\Recipebox.solution\recipebox\Views\Tags\Edit.cshtml"
}

#line default
#line hidden
            BeginContext(356, 5, true);
            WriteLiteral("\r\n<p>");
            EndContext();
            BeginContext(362, 44, false);
#line 18 "C:\Users\potts\Desktop\csharp\Recipebox.solution\recipebox\Views\Tags\Edit.cshtml"
Write(Html.ActionLink("Back to Tag List", "Index"));

#line default
#line hidden
            EndContext();
            BeginContext(406, 4, true);
            WriteLiteral("</p>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RecipeBox.Models.Tag> Html { get; private set; }
    }
}
#pragma warning restore 1591
