#pragma checksum "C:\Users\potts\desktop\csharp\Recipebox.solution\recipebox\Views\Tags\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "25c45dfbbd25bcbf17f3e3977537cc69279c3a9c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Tags_Details), @"mvc.1.0.view", @"/Views/Tags/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Tags/Details.cshtml", typeof(AspNetCore.Views_Tags_Details))]
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
#line 1 "C:\Users\potts\desktop\csharp\Recipebox.solution\recipebox\Views\Tags\Details.cshtml"
using RecipeBox.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"25c45dfbbd25bcbf17f3e3977537cc69279c3a9c", @"/Views/Tags/Details.cshtml")]
    public class Views_Tags_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RecipeBox.Models.Tag>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(54, 30, true);
            WriteLiteral("\r\n<h2>Tag Details</h2>\r\n\r\n<h2>");
            EndContext();
            BeginContext(85, 39, false);
#line 6 "C:\Users\potts\desktop\csharp\Recipebox.solution\recipebox\Views\Tags\Details.cshtml"
Write(Html.DisplayFor(model => model.TagName));

#line default
#line hidden
            EndContext();
            BeginContext(124, 29, true);
            WriteLiteral("</h2>\r\n\r\n<h3>Recipes</h3>\r\n\r\n");
            EndContext();
#line 10 "C:\Users\potts\desktop\csharp\Recipebox.solution\recipebox\Views\Tags\Details.cshtml"
 if (@Model.Recipes.Count == 0)
{

#line default
#line hidden
            BeginContext(189, 56, true);
            WriteLiteral("  <p>There are no recipes associated with this tag</p>\r\n");
            EndContext();
#line 13 "C:\Users\potts\desktop\csharp\Recipebox.solution\recipebox\Views\Tags\Details.cshtml"
}

else
{

#line default
#line hidden
            BeginContext(259, 8, true);
            WriteLiteral("  <ul>\r\n");
            EndContext();
#line 18 "C:\Users\potts\desktop\csharp\Recipebox.solution\recipebox\Views\Tags\Details.cshtml"
   foreach(var join in Model.Recipes)
  {

#line default
#line hidden
            BeginContext(311, 8, true);
            WriteLiteral("    <li>");
            EndContext();
            BeginContext(320, 22, false);
#line 20 "C:\Users\potts\desktop\csharp\Recipebox.solution\recipebox\Views\Tags\Details.cshtml"
   Write(join.Recipe.RecipeName);

#line default
#line hidden
            EndContext();
            BeginContext(342, 6, true);
            WriteLiteral("</li> ");
            EndContext();
#line 20 "C:\Users\potts\desktop\csharp\Recipebox.solution\recipebox\Views\Tags\Details.cshtml"
                                     //make these action links? 
  }

#line default
#line hidden
            BeginContext(382, 9, true);
            WriteLiteral("  </ul>\r\n");
            EndContext();
#line 23 "C:\Users\potts\desktop\csharp\Recipebox.solution\recipebox\Views\Tags\Details.cshtml"
}

#line default
#line hidden
            BeginContext(394, 5, true);
            WriteLiteral("\r\n<p>");
            EndContext();
            BeginContext(400, 61, false);
#line 25 "C:\Users\potts\desktop\csharp\Recipebox.solution\recipebox\Views\Tags\Details.cshtml"
Write(Html.ActionLink("Edit Tag", "Edit", new { id = Model.TagId }));

#line default
#line hidden
            EndContext();
            BeginContext(461, 9, true);
            WriteLiteral("</p>\r\n<p>");
            EndContext();
            BeginContext(471, 65, false);
#line 26 "C:\Users\potts\desktop\csharp\Recipebox.solution\recipebox\Views\Tags\Details.cshtml"
Write(Html.ActionLink("Delete Tag", "Delete", new { id = Model.TagId }));

#line default
#line hidden
            EndContext();
            BeginContext(536, 9, true);
            WriteLiteral("</p>\r\n<p>");
            EndContext();
            BeginContext(546, 44, false);
#line 27 "C:\Users\potts\desktop\csharp\Recipebox.solution\recipebox\Views\Tags\Details.cshtml"
Write(Html.ActionLink("Back to Tag List", "Index"));

#line default
#line hidden
            EndContext();
            BeginContext(590, 9, true);
            WriteLiteral("</p>\r\n<p>");
            EndContext();
            BeginContext(600, 45, false);
#line 28 "C:\Users\potts\desktop\csharp\Recipebox.solution\recipebox\Views\Tags\Details.cshtml"
Write(Html.ActionLink("Back Home", "Index", "Home"));

#line default
#line hidden
            EndContext();
            BeginContext(645, 4, true);
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
