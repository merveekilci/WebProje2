#pragma checksum "D:\pc2\WebProgramlama\WebProje2\WebProje2\Views\CariPanel\SiparislerimEN.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d4e93b5ecb44f24da6ee01435688cb2e1e7c38bf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_CariPanel_SiparislerimEN), @"mvc.1.0.view", @"/Views/CariPanel/SiparislerimEN.cshtml")]
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
#line 1 "D:\pc2\WebProgramlama\WebProje2\WebProje2\Views\CariPanel\SiparislerimEN.cshtml"
using WebProje2.Models.Siniflar;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d4e93b5ecb44f24da6ee01435688cb2e1e7c38bf", @"/Views/CariPanel/SiparislerimEN.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9cfcda52b9d8b9a8ea934f78be13e53636c84d87", @"/Views/_ViewImports.cshtml")]
    public class Views_CariPanel_SiparislerimEN : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<SatisHareket>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\pc2\WebProgramlama\WebProje2\WebProje2\Views\CariPanel\SiparislerimEN.cshtml"
  
    ViewData["Title"] = "SiparislerimEN";
    Layout = "~/Views/Shared/_CariLayoutEN.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<br />\r\n<h1>Order History</h1>\r\n<br />\r\n<table class=\"table table-bordered\">\r\n    <tr>\r\n        <th>Product Name</th>\r\n        <th>quantity</th>\r\n        <th>Total Amount</th>\r\n        <th>Deliverer</th>\r\n        <th>Date</th>\r\n    </tr>\r\n");
#nullable restore
#line 19 "D:\pc2\WebProgramlama\WebProje2\WebProje2\Views\CariPanel\SiparislerimEN.cshtml"
     foreach (var x in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 22 "D:\pc2\WebProgramlama\WebProje2\WebProje2\Views\CariPanel\SiparislerimEN.cshtml"
           Write(x.Urun.UrunAd);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 23 "D:\pc2\WebProgramlama\WebProje2\WebProje2\Views\CariPanel\SiparislerimEN.cshtml"
           Write(x.Adet);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 24 "D:\pc2\WebProgramlama\WebProje2\WebProje2\Views\CariPanel\SiparislerimEN.cshtml"
           Write(x.ToplamTutar);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 25 "D:\pc2\WebProgramlama\WebProje2\WebProje2\Views\CariPanel\SiparislerimEN.cshtml"
           Write(x.Personel.PersonelAd);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 25 "D:\pc2\WebProgramlama\WebProje2\WebProje2\Views\CariPanel\SiparislerimEN.cshtml"
                                  Write(x.Personel.PersonelSoyad);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 26 "D:\pc2\WebProgramlama\WebProje2\WebProje2\Views\CariPanel\SiparislerimEN.cshtml"
           Write(Convert.ToDateTime(x.Tarih).ToString("dd/MM/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n");
#nullable restore
#line 28 "D:\pc2\WebProgramlama\WebProje2\WebProje2\Views\CariPanel\SiparislerimEN.cshtml"

    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<SatisHareket>> Html { get; private set; }
    }
}
#pragma warning restore 1591