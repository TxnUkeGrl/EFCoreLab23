#pragma checksum "D:\GCProjects\Labs & HW\EFCoreLab23\Views\Movie\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5c4a294676bd5f0937986d6fcbfe42e73ac1a7cf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Movie_Index), @"mvc.1.0.view", @"/Views/Movie/Index.cshtml")]
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
#line 1 "D:\GCProjects\Labs & HW\EFCoreLab23\Views\_ViewImports.cshtml"
using EFCoreLab23;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\GCProjects\Labs & HW\EFCoreLab23\Views\_ViewImports.cshtml"
using EFCoreLab23.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5c4a294676bd5f0937986d6fcbfe42e73ac1a7cf", @"/Views/Movie/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fbf91a861af317a76ea01e55af79dc1b7ae8bb36", @"/Views/_ViewImports.cshtml")]
    public class Views_Movie_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Movie>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h1>Index</h1>\r\n\r\n<table class=\"table table-bordered\">\r\n    <tr>\r\n        <th>Id</th>\r\n        <th>Title</th>\r\n        <th>Genre</th>\r\n        <th>Runtime</th>\r\n    </tr>\r\n");
#nullable restore
#line 12 "D:\GCProjects\Labs & HW\EFCoreLab23\Views\Movie\Index.cshtml"
     foreach (var movie in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 15 "D:\GCProjects\Labs & HW\EFCoreLab23\Views\Movie\Index.cshtml"
           Write(movie.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 16 "D:\GCProjects\Labs & HW\EFCoreLab23\Views\Movie\Index.cshtml"
           Write(movie.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 17 "D:\GCProjects\Labs & HW\EFCoreLab23\Views\Movie\Index.cshtml"
           Write(movie.Genre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 18 "D:\GCProjects\Labs & HW\EFCoreLab23\Views\Movie\Index.cshtml"
           Write(movie.Runtime);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 407, "\"", 444, 2);
            WriteAttributeValue("", 414, "Movie/DeleteMovie?Id=", 414, 21, true);
#nullable restore
#line 19 "D:\GCProjects\Labs & HW\EFCoreLab23\Views\Movie\Index.cshtml"
WriteAttributeValue("", 435, movie.Id, 435, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger\">Delete ");
#nullable restore
#line 19 "D:\GCProjects\Labs & HW\EFCoreLab23\Views\Movie\Index.cshtml"
                                                                                  Write(movie.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></td>\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 517, "\"", 552, 2);
            WriteAttributeValue("", 524, "Movie/MovieForm?id=", 524, 19, true);
#nullable restore
#line 20 "D:\GCProjects\Labs & HW\EFCoreLab23\Views\Movie\Index.cshtml"
WriteAttributeValue("", 543, movie.Id, 543, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-warning\">Edit ");
#nullable restore
#line 20 "D:\GCProjects\Labs & HW\EFCoreLab23\Views\Movie\Index.cshtml"
                                                                               Write(movie.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></td>\r\n        </tr>\r\n");
#nullable restore
#line 22 "D:\GCProjects\Labs & HW\EFCoreLab23\Views\Movie\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n\r\n<a href=\"Movie/MovieForm\" class=\"btn btn-dark\">Add a new Movie</a>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Movie>> Html { get; private set; }
    }
}
#pragma warning restore 1591