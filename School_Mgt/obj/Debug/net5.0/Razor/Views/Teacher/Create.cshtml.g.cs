#pragma checksum "C:\Users\hp\source\repos\School_Mgt\School_Mgt\Views\Teacher\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6dec161c6266f579813a2221204c06691e1bb921"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Teacher_Create), @"mvc.1.0.view", @"/Views/Teacher/Create.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6dec161c6266f579813a2221204c06691e1bb921", @"/Views/Teacher/Create.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"febca1644f496d17aab158a4cc7fd4d82565daa6", @"/Views/_ViewImports.cshtml")]
    public class Views_Teacher_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<School_Mgt.Models.Teacher>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\hp\source\repos\School_Mgt\School_Mgt\Views\Teacher\Create.cshtml"
  
    ViewBag.Title = "Create";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"card\">\r\n    <div class=\"card-header\">\r\n        <h5>New Teacher</h5>\r\n    </div>\r\n    <div class=\"card-body\">\r\n");
#nullable restore
#line 10 "C:\Users\hp\source\repos\School_Mgt\School_Mgt\Views\Teacher\Create.cshtml"
         using (Html.BeginForm())
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\hp\source\repos\School_Mgt\School_Mgt\Views\Teacher\Create.cshtml"
       Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"form-group\">\r\n                ");
#nullable restore
#line 14 "C:\Users\hp\source\repos\School_Mgt\School_Mgt\Views\Teacher\Create.cshtml"
           Write(Html.LabelFor(m => m.TeacherName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 15 "C:\Users\hp\source\repos\School_Mgt\School_Mgt\Views\Teacher\Create.cshtml"
           Write(Html.TextBoxFor(m => m.TeacherName, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 16 "C:\Users\hp\source\repos\School_Mgt\School_Mgt\Views\Teacher\Create.cshtml"
           Write(Html.ValidationMessageFor(m => m.TeacherName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n            <div class=\"form-group\">\r\n                ");
#nullable restore
#line 19 "C:\Users\hp\source\repos\School_Mgt\School_Mgt\Views\Teacher\Create.cshtml"
           Write(Html.LabelFor(m => m.JobTitle));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 20 "C:\Users\hp\source\repos\School_Mgt\School_Mgt\Views\Teacher\Create.cshtml"
           Write(Html.TextBoxFor(m => m.JobTitle, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 21 "C:\Users\hp\source\repos\School_Mgt\School_Mgt\Views\Teacher\Create.cshtml"
           Write(Html.ValidationMessageFor(m => m.JobTitle));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n            <div class=\"form-group\">\r\n                ");
#nullable restore
#line 24 "C:\Users\hp\source\repos\School_Mgt\School_Mgt\Views\Teacher\Create.cshtml"
           Write(Html.LabelFor(m => m.ReportTo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 25 "C:\Users\hp\source\repos\School_Mgt\School_Mgt\Views\Teacher\Create.cshtml"
           Write(Html.TextBoxFor(m => m.ReportTo, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 26 "C:\Users\hp\source\repos\School_Mgt\School_Mgt\Views\Teacher\Create.cshtml"
           Write(Html.ValidationMessageFor(m => m.ReportTo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n            <div class=\"form-group\">\r\n                <button type=\"submit\" class=\"btn btn-sm btn-primary rounded-0\">Submit</button>\r\n            </div>\r\n");
#nullable restore
#line 31 "C:\Users\hp\source\repos\School_Mgt\School_Mgt\Views\Teacher\Create.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<School_Mgt.Models.Teacher> Html { get; private set; }
    }
}
#pragma warning restore 1591
