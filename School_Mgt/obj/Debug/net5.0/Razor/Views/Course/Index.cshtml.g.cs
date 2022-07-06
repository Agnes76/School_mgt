#pragma checksum "C:\Users\hp\source\repos\School_Mgt\School_Mgt\Views\Course\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4069abe5e2b229454ddad0302654c688470fa706"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Course_Index), @"mvc.1.0.view", @"/Views/Course/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4069abe5e2b229454ddad0302654c688470fa706", @"/Views/Course/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"febca1644f496d17aab158a4cc7fd4d82565daa6", @"/Views/_ViewImports.cshtml")]
    public class Views_Course_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IList<School_Mgt.Models.Course>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\hp\source\repos\School_Mgt\School_Mgt\Views\Course\Index.cshtml"
  
    ViewData["Title"] = "Course Page";
    var serial = 1;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h1 class=\"display-4\">Welcome</h1>\r\n    <p>Learn about <a href=\"https://docs.microsoft.com/aspnet/core\">building Web apps with ASP.NET Core</a>.</p>\r\n</div>\r\n<div style=\"margin-bottom: 10px;\">\r\n    ");
#nullable restore
#line 12 "C:\Users\hp\source\repos\School_Mgt\School_Mgt\Views\Course\Index.cshtml"
Write(Html.ActionLink("Create New", "Create", "Course", "", new { @class = "btn btn-sm btn-primary rounded-0" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
</div>

<h4 class=""text-center text-uppercase"">List Of Courses</h4>

<table class=""table"">
    <thead class=""thead-dark"">
        <tr>
            <th scope=""col"">CourseId</th>
            <th scope=""col"">CourseName</th>
            <th scope=""col"">CourseUnit</th>
            <th scope=""col"">Grade</th>
            <th scope=""col"">Score</th>
            <th scope=""col"">GradeUnit</th>
            <th scope=""col"">Cumulative</th>
            <th scope=""col"">Action(s)</th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 31 "C:\Users\hp\source\repos\School_Mgt\School_Mgt\Views\Course\Index.cshtml"
         foreach (var course in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 34 "C:\Users\hp\source\repos\School_Mgt\School_Mgt\Views\Course\Index.cshtml"
               Write(serial);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 35 "C:\Users\hp\source\repos\School_Mgt\School_Mgt\Views\Course\Index.cshtml"
               Write(course.CourseName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 36 "C:\Users\hp\source\repos\School_Mgt\School_Mgt\Views\Course\Index.cshtml"
               Write(course.CourseUnit);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 37 "C:\Users\hp\source\repos\School_Mgt\School_Mgt\Views\Course\Index.cshtml"
               Write(course.Grade);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 38 "C:\Users\hp\source\repos\School_Mgt\School_Mgt\Views\Course\Index.cshtml"
               Write(course.Score);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 39 "C:\Users\hp\source\repos\School_Mgt\School_Mgt\Views\Course\Index.cshtml"
               Write(course.GradeUnit);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 40 "C:\Users\hp\source\repos\School_Mgt\School_Mgt\Views\Course\Index.cshtml"
               Write(course.Cumulative);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 1384, "\"", 1450, 1);
#nullable restore
#line 42 "C:\Users\hp\source\repos\School_Mgt\School_Mgt\Views\Course\Index.cshtml"
WriteAttributeValue("", 1391, Url.Action("Details", "Course", new {id=course.CourseId }), 1391, 59, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-sm btn-primary\"><i class=\"fa fa-eye\"></i></a>\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 1536, "\"", 1599, 1);
#nullable restore
#line 43 "C:\Users\hp\source\repos\School_Mgt\School_Mgt\Views\Course\Index.cshtml"
WriteAttributeValue("", 1543, Url.Action("Edit", "Course", new {id=course.CourseId }), 1543, 56, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-sm btn-primary\"><i class=\"fa fa-pencil-square\"></i></a>\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 1695, "\"", 1760, 1);
#nullable restore
#line 44 "C:\Users\hp\source\repos\School_Mgt\School_Mgt\Views\Course\Index.cshtml"
WriteAttributeValue("", 1702, Url.Action("Delete", "Course", new {id=course.CourseId }), 1702, 58, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-sm btn-primary\"><i class=\"fa fa-trash-can\"></i></a>\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 47 "C:\Users\hp\source\repos\School_Mgt\School_Mgt\Views\Course\Index.cshtml"
            serial++;
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </tbody>\r\n</table>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IList<School_Mgt.Models.Course>> Html { get; private set; }
    }
}
#pragma warning restore 1591
