#pragma checksum "C:\Users\hp\source\repos\School_Mgt\School_Mgt\Views\Course\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a55831c35aa41588f06379fefb78df7bf4cdbbf5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Course_Details), @"mvc.1.0.view", @"/Views/Course/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a55831c35aa41588f06379fefb78df7bf4cdbbf5", @"/Views/Course/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"febca1644f496d17aab158a4cc7fd4d82565daa6", @"/Views/_ViewImports.cshtml")]
    public class Views_Course_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<School_Mgt.Models.Course>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\hp\source\repos\School_Mgt\School_Mgt\Views\Course\Details.cshtml"
  
    ViewBag.Title = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"card\">\r\n    <div class=\"card-header\">\r\n        <h4 class=\"text-center text-uppercase\">Course Details</h4>\r\n    </div>\r\n    <div class=\"card-body\">\r\n        <dl class=\"dl-horizontal\">\r\n            <dt>\r\n                ");
#nullable restore
#line 14 "C:\Users\hp\source\repos\School_Mgt\School_Mgt\Views\Course\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.CourseName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
#nullable restore
#line 17 "C:\Users\hp\source\repos\School_Mgt\School_Mgt\Views\Course\Details.cshtml"
           Write(Html.DisplayFor(model => model.CourseName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                ");
#nullable restore
#line 20 "C:\Users\hp\source\repos\School_Mgt\School_Mgt\Views\Course\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.CourseUnit));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
#nullable restore
#line 23 "C:\Users\hp\source\repos\School_Mgt\School_Mgt\Views\Course\Details.cshtml"
           Write(Html.DisplayFor(model => model.CourseUnit));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                ");
#nullable restore
#line 26 "C:\Users\hp\source\repos\School_Mgt\School_Mgt\Views\Course\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Grade));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
#nullable restore
#line 29 "C:\Users\hp\source\repos\School_Mgt\School_Mgt\Views\Course\Details.cshtml"
           Write(Html.DisplayFor(model => model.Grade));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                ");
#nullable restore
#line 32 "C:\Users\hp\source\repos\School_Mgt\School_Mgt\Views\Course\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Score));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
#nullable restore
#line 35 "C:\Users\hp\source\repos\School_Mgt\School_Mgt\Views\Course\Details.cshtml"
           Write(Html.DisplayFor(model => model.Score));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                ");
#nullable restore
#line 38 "C:\Users\hp\source\repos\School_Mgt\School_Mgt\Views\Course\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.GradeUnit));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
#nullable restore
#line 41 "C:\Users\hp\source\repos\School_Mgt\School_Mgt\Views\Course\Details.cshtml"
           Write(Html.DisplayFor(model => model.GradeUnit));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                ");
#nullable restore
#line 44 "C:\Users\hp\source\repos\School_Mgt\School_Mgt\Views\Course\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Cumulative));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
#nullable restore
#line 47 "C:\Users\hp\source\repos\School_Mgt\School_Mgt\Views\Course\Details.cshtml"
           Write(Html.DisplayFor(model => model.Cumulative));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n        </dl>\r\n        ");
#nullable restore
#line 50 "C:\Users\hp\source\repos\School_Mgt\School_Mgt\Views\Course\Details.cshtml"
   Write(Html.ActionLink("Edit", "Edit", "Home", new { id = Model.CourseId }, new { @class = "btn btn-sm btn-info rounded-0" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 51 "C:\Users\hp\source\repos\School_Mgt\School_Mgt\Views\Course\Details.cshtml"
   Write(Html.ActionLink("Back To List", "Index", "Course", new { @class = "btn btn-sm btn-primary rounded-0" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n\r\n</div>\r\n\r\n");
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
