#pragma checksum "C:\Users\ASUS\source\repos\ToDoTest\ToDoTest\Views\Gorev\FirmaGorevleri.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "642a4b6ba9446d1dd49988dbb7d73b3f809eb7c7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Gorev_FirmaGorevleri), @"mvc.1.0.view", @"/Views/Gorev/FirmaGorevleri.cshtml")]
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
#line 1 "C:\Users\ASUS\source\repos\ToDoTest\ToDoTest\Views\_ViewImports.cshtml"
using ToDoTest;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\ASUS\source\repos\ToDoTest\ToDoTest\Views\Gorev\FirmaGorevleri.cshtml"
using ToDoTest.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"642a4b6ba9446d1dd49988dbb7d73b3f809eb7c7", @"/Views/Gorev/FirmaGorevleri.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"48607a62c9d3e5db2bc3d1c59d2d4f2face3d37e", @"/Views/_ViewImports.cshtml")]
    public class Views_Gorev_FirmaGorevleri : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<gorevler>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\ASUS\source\repos\ToDoTest\ToDoTest\Views\Gorev\FirmaGorevleri.cshtml"
  
    ViewData["Title"] = "Görevler";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Görev Listesi</h1>\r\n<a href=\"/Gorev/GorevEkle\" class=\"btn btn-success\"> Yeni Görev Ekle</a>\r\n<br />\r\n<br />\r\n\r\n");
            WriteLiteral("\r\n<table class=\"table table-bordered\">\r\n    <tr class=\"table-active\">\r\n        <th>ID</th>\r\n        <th>Görev</th>\r\n        <th>Son Tarih</th>\r\n        <th>Durumu</th>\r\n        <th>Firma</th>\r\n        <th></th>\r\n    </tr>\r\n");
#nullable restore
#line 23 "C:\Users\ASUS\source\repos\ToDoTest\ToDoTest\Views\Gorev\FirmaGorevleri.cshtml"
     foreach (var g in Model)
    {
        if (g.Firma != null)
        {
            string firmaadi = Ayarlar.FirmaGetir(g.Firma);
            if (@g.Durumu == "Acil")
            {




#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr class=\"table-danger\">\r\n                    <th>");
#nullable restore
#line 34 "C:\Users\ASUS\source\repos\ToDoTest\ToDoTest\Views\Gorev\FirmaGorevleri.cshtml"
                   Write(g.id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                    <td>");
#nullable restore
#line 35 "C:\Users\ASUS\source\repos\ToDoTest\ToDoTest\Views\Gorev\FirmaGorevleri.cshtml"
                   Write(g.GorevDetay);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 36 "C:\Users\ASUS\source\repos\ToDoTest\ToDoTest\Views\Gorev\FirmaGorevleri.cshtml"
                   Write(g.OlusturmaTarihi);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 37 "C:\Users\ASUS\source\repos\ToDoTest\ToDoTest\Views\Gorev\FirmaGorevleri.cshtml"
                   Write(g.Durumu);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 38 "C:\Users\ASUS\source\repos\ToDoTest\ToDoTest\Views\Gorev\FirmaGorevleri.cshtml"
                   Write(firmaadi);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 935, "\"", 965, 2);
            WriteAttributeValue("", 942, "/Gorev/GorevGetir/", 942, 18, true);
#nullable restore
#line 40 "C:\Users\ASUS\source\repos\ToDoTest\ToDoTest\Views\Gorev\FirmaGorevleri.cshtml"
WriteAttributeValue("", 960, g.id, 960, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-warning\"> Düzenle </a>\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 1032, "\"", 1060, 2);
            WriteAttributeValue("", 1039, "/Gorev/GorevSil/", 1039, 16, true);
#nullable restore
#line 41 "C:\Users\ASUS\source\repos\ToDoTest\ToDoTest\Views\Gorev\FirmaGorevleri.cshtml"
WriteAttributeValue("", 1055, g.id, 1055, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger\"> SİL </a>\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 1122, "\"", 1157, 2);
            WriteAttributeValue("", 1129, "/Gorev/YapildiIsaretle/", 1129, 23, true);
#nullable restore
#line 42 "C:\Users\ASUS\source\repos\ToDoTest\ToDoTest\Views\Gorev\FirmaGorevleri.cshtml"
WriteAttributeValue("", 1152, g.id, 1152, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-success\">Yapıldı İşaretle</a>\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 45 "C:\Users\ASUS\source\repos\ToDoTest\ToDoTest\Views\Gorev\FirmaGorevleri.cshtml"
            }
            else if (@g.Durumu == "Normal")
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr class=\"table-info\">\r\n                    <th>");
#nullable restore
#line 49 "C:\Users\ASUS\source\repos\ToDoTest\ToDoTest\Views\Gorev\FirmaGorevleri.cshtml"
                   Write(g.id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                    <td>");
#nullable restore
#line 50 "C:\Users\ASUS\source\repos\ToDoTest\ToDoTest\Views\Gorev\FirmaGorevleri.cshtml"
                   Write(g.GorevDetay);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 51 "C:\Users\ASUS\source\repos\ToDoTest\ToDoTest\Views\Gorev\FirmaGorevleri.cshtml"
                   Write(g.OlusturmaTarihi);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 52 "C:\Users\ASUS\source\repos\ToDoTest\ToDoTest\Views\Gorev\FirmaGorevleri.cshtml"
                   Write(g.Durumu);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 53 "C:\Users\ASUS\source\repos\ToDoTest\ToDoTest\Views\Gorev\FirmaGorevleri.cshtml"
                   Write(firmaadi);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 1632, "\"", 1662, 2);
            WriteAttributeValue("", 1639, "/Gorev/GorevGetir/", 1639, 18, true);
#nullable restore
#line 55 "C:\Users\ASUS\source\repos\ToDoTest\ToDoTest\Views\Gorev\FirmaGorevleri.cshtml"
WriteAttributeValue("", 1657, g.id, 1657, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-warning\"> Düzenle </a>\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 1729, "\"", 1757, 2);
            WriteAttributeValue("", 1736, "/Gorev/GorevSil/", 1736, 16, true);
#nullable restore
#line 56 "C:\Users\ASUS\source\repos\ToDoTest\ToDoTest\Views\Gorev\FirmaGorevleri.cshtml"
WriteAttributeValue("", 1752, g.id, 1752, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger\"> SİL </a>\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 1819, "\"", 1854, 2);
            WriteAttributeValue("", 1826, "/Gorev/YapildiIsaretle/", 1826, 23, true);
#nullable restore
#line 57 "C:\Users\ASUS\source\repos\ToDoTest\ToDoTest\Views\Gorev\FirmaGorevleri.cshtml"
WriteAttributeValue("", 1849, g.id, 1849, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-success\">Yapıldı İşaretle</a>\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 60 "C:\Users\ASUS\source\repos\ToDoTest\ToDoTest\Views\Gorev\FirmaGorevleri.cshtml"
            }
        }
        else if (g.Durumu != "Yapıldı")
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr class=\"table-warning\">\r\n                <th>");
#nullable restore
#line 65 "C:\Users\ASUS\source\repos\ToDoTest\ToDoTest\Views\Gorev\FirmaGorevleri.cshtml"
               Write(g.id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <td>");
#nullable restore
#line 66 "C:\Users\ASUS\source\repos\ToDoTest\ToDoTest\Views\Gorev\FirmaGorevleri.cshtml"
               Write(g.GorevDetay);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 67 "C:\Users\ASUS\source\repos\ToDoTest\ToDoTest\Views\Gorev\FirmaGorevleri.cshtml"
               Write(g.OlusturmaTarihi);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 68 "C:\Users\ASUS\source\repos\ToDoTest\ToDoTest\Views\Gorev\FirmaGorevleri.cshtml"
               Write(g.Durumu);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>\r\n                    Atanmamış\r\n                </td>\r\n                <td>\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 2343, "\"", 2373, 2);
            WriteAttributeValue("", 2350, "/Gorev/GorevGetir/", 2350, 18, true);
#nullable restore
#line 73 "C:\Users\ASUS\source\repos\ToDoTest\ToDoTest\Views\Gorev\FirmaGorevleri.cshtml"
WriteAttributeValue("", 2368, g.id, 2368, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-warning\"> Düzenle </a>\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 2436, "\"", 2464, 2);
            WriteAttributeValue("", 2443, "/Gorev/GorevSil/", 2443, 16, true);
#nullable restore
#line 74 "C:\Users\ASUS\source\repos\ToDoTest\ToDoTest\Views\Gorev\FirmaGorevleri.cshtml"
WriteAttributeValue("", 2459, g.id, 2459, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger\"> SİL </a>\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 2522, "\"", 2557, 2);
            WriteAttributeValue("", 2529, "/Gorev/YapildiIsaretle/", 2529, 23, true);
#nullable restore
#line 75 "C:\Users\ASUS\source\repos\ToDoTest\ToDoTest\Views\Gorev\FirmaGorevleri.cshtml"
WriteAttributeValue("", 2552, g.id, 2552, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-success\">Yapıldı İşaretle</a>\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 78 "C:\Users\ASUS\source\repos\ToDoTest\ToDoTest\Views\Gorev\FirmaGorevleri.cshtml"
        }

    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
</table>

<h3>Tamamlanmış Görevler</h3>
<table class=""table table-bordered"">
    <tr class=""table-active"">
        <th>ID</th>
        <th>Görev</th>
        <th>Son Tarih</th>
        <th>Durumu</th>
        <th>Firma</th>
        <th></th>
    </tr>

");
#nullable restore
#line 95 "C:\Users\ASUS\source\repos\ToDoTest\ToDoTest\Views\Gorev\FirmaGorevleri.cshtml"
     foreach (var g in Model)
    {

        if (g.Firma != null)
        {
            string firmaadi = Ayarlar.FirmaGetir(g.Firma);

            if (@g.Durumu == "Yapıldı")
            {


#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr class=\"table-success\">\r\n                    <th>");
#nullable restore
#line 106 "C:\Users\ASUS\source\repos\ToDoTest\ToDoTest\Views\Gorev\FirmaGorevleri.cshtml"
                   Write(g.id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                    <td>");
#nullable restore
#line 107 "C:\Users\ASUS\source\repos\ToDoTest\ToDoTest\Views\Gorev\FirmaGorevleri.cshtml"
                   Write(g.GorevDetay);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 108 "C:\Users\ASUS\source\repos\ToDoTest\ToDoTest\Views\Gorev\FirmaGorevleri.cshtml"
                   Write(g.OlusturmaTarihi);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 109 "C:\Users\ASUS\source\repos\ToDoTest\ToDoTest\Views\Gorev\FirmaGorevleri.cshtml"
                   Write(g.Durumu);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 110 "C:\Users\ASUS\source\repos\ToDoTest\ToDoTest\Views\Gorev\FirmaGorevleri.cshtml"
                   Write(firmaadi);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 3441, "\"", 3476, 2);
            WriteAttributeValue("", 3448, "/GoreFirmav/GorevGetir/", 3448, 23, true);
#nullable restore
#line 112 "C:\Users\ASUS\source\repos\ToDoTest\ToDoTest\Views\Gorev\FirmaGorevleri.cshtml"
WriteAttributeValue("", 3471, g.id, 3471, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-warning\"> Düzenle </a>\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 3543, "\"", 3571, 2);
            WriteAttributeValue("", 3550, "/Gorev/GorevSil/", 3550, 16, true);
#nullable restore
#line 113 "C:\Users\ASUS\source\repos\ToDoTest\ToDoTest\Views\Gorev\FirmaGorevleri.cshtml"
WriteAttributeValue("", 3566, g.id, 3566, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger\"> SİL </a>\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 116 "C:\Users\ASUS\source\repos\ToDoTest\ToDoTest\Views\Gorev\FirmaGorevleri.cshtml"
            }
        }
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<gorevler>> Html { get; private set; }
    }
}
#pragma warning restore 1591