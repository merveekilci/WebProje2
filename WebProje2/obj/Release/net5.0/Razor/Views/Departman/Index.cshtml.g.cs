#pragma checksum "D:\pc2\WebProgramlama\WebProje2\WebProje2\Views\Departman\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a1320f932eea7edf7c551acc504e700a0919a8b8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Departman_Index), @"mvc.1.0.view", @"/Views/Departman/Index.cshtml")]
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
#line 1 "D:\pc2\WebProgramlama\WebProje2\WebProje2\Views\_ViewImports.cshtml"
using WebProje2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\pc2\WebProgramlama\WebProje2\WebProje2\Views\_ViewImports.cshtml"
using WebProje2.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\pc2\WebProgramlama\WebProje2\WebProje2\Views\Departman\Index.cshtml"
using WebProje2.Models.Siniflar;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a1320f932eea7edf7c551acc504e700a0919a8b8", @"/Views/Departman/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9cfcda52b9d8b9a8ea934f78be13e53636c84d87", @"/Views/_ViewImports.cshtml")]
    public class Views_Departman_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Departman>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 5 "D:\pc2\WebProgramlama\WebProje2\WebProje2\Views\Departman\Index.cshtml"
  
    ViewBag.Title = "Index";
    Layout = "~/Views/Shared/AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<br />
<h2>Departmanlar</h2>
<br />
<table class=""table table-bordered"" style=""margin-top:20px"">
    <tr>
        <th>Departman ID</th>
        <th>Departman Adı</th>
        <th>Sil</th>
        <th>Güncelle</th>
        <th>Detayları Görüntüle</th>
    </tr>
");
#nullable restore
#line 20 "D:\pc2\WebProgramlama\WebProje2\WebProje2\Views\Departman\Index.cshtml"
     foreach (var k in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 24 "D:\pc2\WebProgramlama\WebProje2\WebProje2\Views\Departman\Index.cshtml"
           Write(k.Departmanid);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n\r\n            <td>\r\n                ");
#nullable restore
#line 28 "D:\pc2\WebProgramlama\WebProje2\WebProje2\Views\Departman\Index.cshtml"
           Write(k.DepartmanAd);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 632, "\"", 677, 2);
            WriteAttributeValue("", 639, "/Departman/DepartmanSil/", 639, 24, true);
#nullable restore
#line 30 "D:\pc2\WebProgramlama\WebProje2\WebProje2\Views\Departman\Index.cshtml"
WriteAttributeValue("", 663, k.Departmanid, 663, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger\">Sil</a></td>\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 734, "\"", 781, 2);
            WriteAttributeValue("", 741, "/Departman/DepartmanGetir/", 741, 26, true);
#nullable restore
#line 31 "D:\pc2\WebProgramlama\WebProje2\WebProje2\Views\Departman\Index.cshtml"
WriteAttributeValue("", 767, k.Departmanid, 767, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-success\">Güncelle</a></td>\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 844, "\"", 891, 2);
            WriteAttributeValue("", 851, "/Departman/DepartmanDetay/", 851, 26, true);
#nullable restore
#line 32 "D:\pc2\WebProgramlama\WebProje2\WebProje2\Views\Departman\Index.cshtml"
WriteAttributeValue("", 877, k.Departmanid, 877, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-warning\" style=\"color:white\">Detaylar</a></td>\r\n        </tr>\r\n");
#nullable restore
#line 34 "D:\pc2\WebProgramlama\WebProje2\WebProje2\Views\Departman\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n<a href=\"/Departman/DepartmanEkle\" class=\"btn btn-info\">Departman Ekle</a>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Departman>> Html { get; private set; }
    }
}
#pragma warning restore 1591
