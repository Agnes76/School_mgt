#pragma checksum "C:\Users\hp\source\repos\School_Mgt\School_Mgt\Views\Course\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c536da2087306325a70a245fdae05825f988565a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Course_Edit), @"mvc.1.0.view", @"/Views/Course/Edit.cshtml")]
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
#line 1 "C:\Users\hp\source\repos\School_Mgt\School_Mgt\Views\_ViewImports.cshtml"
using School_Mgt;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\hp\source\repos\School_Mgt\School_Mgt\Views\_ViewImports.cshtml"
using School_Mgt.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c536da2087306325a70a245fdae05825f988565a", @"/Views/Course/Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"febca1644f496d17aab158a4cc7fd4d82565daa6", @"/Views/_ViewImports.cshtml")]
    public class Views_Course_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<School_Mgt.Models.Course>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\hp\source\repos\School_Mgt\School_Mgt\Views\Course\Edit.cshtml"
  
    ViewBag.Title = "Edit";


#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"card\">\r\n        <div class=\"card-header\">\r\n            <h3>Edit Course</h3>\r\n        </div>\r\n        <div class=\"card-body\">\r\n");
#nullable restore
#line 11 "C:\Users\hp\source\repos\School_Mgt\School_Mgt\Views\Course\Edit.cshtml"
             using (Html.BeginForm())
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\hp\source\repos\School_Mgt\School_Mgt\Views\Course\Edit.cshtml"
           Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\hp\source\repos\School_Mgt\School_Mgt\Views\Course\Edit.cshtml"
           Write(Html.HiddenFor(m => m.CourseId));

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"form-group\">\r\n                    ");
#nullable restore
#line 16 "C:\Users\hp\source\repos\School_Mgt\School_Mgt\Views\Course\Edit.cshtml"
               Write(Html.LabelFor(m => m.CourseName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 17 "C:\Users\hp\source\repos\School_Mgt\School_Mgt\Views\Course\Edit.cshtml"
               Write(Html.EditorFor(m => m.CourseName, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 18 "C:\Users\hp\source\repos\School_Mgt\School_Mgt\Views\Course\Edit.cshtml"
               Write(Html.ValidationMessageFor(m => m.CourseName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n                <div class=\"form-group\">\r\n                    ");
#nullable restore
#line 21 "C:\Users\hp\source\repos\School_Mgt\School_Mgt\Views\Course\Edit.cshtml"
               Write(Html.LabelFor(m => m.CourseUnit));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 22 "C:\Users\hp\source\repos\School_Mgt\School_Mgt\Views\Course\Edit.cshtml"
               Write(Html.EditorFor(m => m.CourseUnit, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 23 "C:\Users\hp\source\repos\School_Mgt\School_Mgt\Views\Course\Edit.cshtml"
               Write(Html.ValidationMessageFor(m => m.CourseUnit));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n                <div class=\"form-group\">\r\n                    ");
#nullable restore
#line 26 "C:\Users\hp\source\repos\School_Mgt\School_Mgt\Views\Course\Edit.cshtml"
               Write(Html.LabelFor(m => m.Grade));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 27 "C:\Users\hp\source\repos\School_Mgt\School_Mgt\Views\Course\Edit.cshtml"
               Write(Html.EditorFor(m => m.Grade, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 28 "C:\Users\hp\source\repos\School_Mgt\School_Mgt\Views\Course\Edit.cshtml"
               Write(Html.ValidationMessageFor(m => m.Grade));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n                <div class=\"form-group\">\r\n                    ");
#nullable restore
#line 31 "C:\Users\hp\source\repos\School_Mgt\School_Mgt\Views\Course\Edit.cshtml"
               Write(Html.LabelFor(m => m.Score));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 32 "C:\Users\hp\source\repos\School_Mgt\School_Mgt\Views\Course\Edit.cshtml"
               Write(Html.EditorFor(m => m.Score, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 33 "C:\Users\hp\source\repos\School_Mgt\School_Mgt\Views\Course\Edit.cshtml"
               Write(Html.ValidationMessageFor(m => m.Score));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n                <div class=\"form-group\">\r\n                    ");
#nullable restore
#line 36 "C:\Users\hp\source\repos\School_Mgt\School_Mgt\Views\Course\Edit.cshtml"
               Write(Html.LabelFor(m => m.GradeUnit));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 37 "C:\Users\hp\source\repos\School_Mgt\School_Mgt\Views\Course\Edit.cshtml"
               Write(Html.EditorFor(m => m.GradeUnit, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 38 "C:\Users\hp\source\repos\School_Mgt\School_Mgt\Views\Course\Edit.cshtml"
               Write(Html.ValidationMessageFor(m => m.GradeUnit));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n                <div class=\"form-group\">\r\n                    ");
#nullable restore
#line 41 "C:\Users\hp\source\repos\School_Mgt\School_Mgt\Views\Course\Edit.cshtml"
               Write(Html.LabelFor(m => m.Cumulative));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 42 "C:\Users\hp\source\repos\School_Mgt\School_Mgt\Views\Course\Edit.cshtml"
               Write(Html.EditorFor(m => m.Cumulative, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 43 "C:\Users\hp\source\repos\School_Mgt\School_Mgt\Views\Course\Edit.cshtml"
               Write(Html.ValidationMessageFor(m => m.Cumulative));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n                <div class=\"form-group\">\r\n                    <button type=\"submit\" class=\"btn btn-sm btn-primary rounded-0\">Update</button>\r\n                    ");
#nullable restore
#line 47 "C:\Users\hp\source\repos\School_Mgt\School_Mgt\Views\Course\Edit.cshtml"
               Write(Html.ActionLink("Back to List", "Index", "Course", new { @class = "btn btn-sm btn-primary rounded-0" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n");
#nullable restore
#line 49 "C:\Users\hp\source\repos\School_Mgt\School_Mgt\Views\Course\Edit.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<School_Mgt.Models.Course> Html { get; private set; }
    }
}
#pragma warning restore 1591
