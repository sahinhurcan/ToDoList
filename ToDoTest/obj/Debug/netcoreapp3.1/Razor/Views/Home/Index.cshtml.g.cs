#pragma checksum "C:\Users\ASUS\source\repos\ToDoTest\ToDoTest\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b9547e1d992ac2e549a59a50a180a08bff462a79"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 4 "C:\Users\ASUS\source\repos\ToDoTest\ToDoTest\Views\Home\Index.cshtml"
using ToDoTest.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b9547e1d992ac2e549a59a50a180a08bff462a79", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"48607a62c9d3e5db2bc3d1c59d2d4f2face3d37e", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<gorevler>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\ASUS\source\repos\ToDoTest\ToDoTest\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Ana Sayfa";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<h3>Size Atanan Görevler</h3>
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
#line 19 "C:\Users\ASUS\source\repos\ToDoTest\ToDoTest\Views\Home\Index.cshtml"
     foreach (var g in Model)
    {
        if (g.KullaniciID == @ViewBag.userID)
        {

            if (@g.Durumu == "Acil")
            {


#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr class=\"table-danger\">\r\n                    <th>");
#nullable restore
#line 28 "C:\Users\ASUS\source\repos\ToDoTest\ToDoTest\Views\Home\Index.cshtml"
                   Write(g.id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                    <td>");
#nullable restore
#line 29 "C:\Users\ASUS\source\repos\ToDoTest\ToDoTest\Views\Home\Index.cshtml"
                   Write(g.GorevDetay);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 30 "C:\Users\ASUS\source\repos\ToDoTest\ToDoTest\Views\Home\Index.cshtml"
                   Write(g.OlusturmaTarihi);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 31 "C:\Users\ASUS\source\repos\ToDoTest\ToDoTest\Views\Home\Index.cshtml"
                   Write(g.Durumu);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 32 "C:\Users\ASUS\source\repos\ToDoTest\ToDoTest\Views\Home\Index.cshtml"
                   Write(g.Firma);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 806, "\"", 836, 2);
            WriteAttributeValue("", 813, "/Gorev/GorevGetir/", 813, 18, true);
#nullable restore
#line 34 "C:\Users\ASUS\source\repos\ToDoTest\ToDoTest\Views\Home\Index.cshtml"
WriteAttributeValue("", 831, g.id, 831, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-warning\"> Düzenle </a>\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 903, "\"", 931, 2);
            WriteAttributeValue("", 910, "/Gorev/GorevSil/", 910, 16, true);
#nullable restore
#line 35 "C:\Users\ASUS\source\repos\ToDoTest\ToDoTest\Views\Home\Index.cshtml"
WriteAttributeValue("", 926, g.id, 926, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger\"> SİL </a>\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 993, "\"", 1028, 2);
            WriteAttributeValue("", 1000, "/Gorev/YapildiIsaretle/", 1000, 23, true);
#nullable restore
#line 36 "C:\Users\ASUS\source\repos\ToDoTest\ToDoTest\Views\Home\Index.cshtml"
WriteAttributeValue("", 1023, g.id, 1023, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-success\">Yapıldı İşaretle</a>\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 39 "C:\Users\ASUS\source\repos\ToDoTest\ToDoTest\Views\Home\Index.cshtml"
            }
            else if (@g.Durumu == "Normal")
            {


#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr class=\"table-info\">\r\n                    <th>");
#nullable restore
#line 44 "C:\Users\ASUS\source\repos\ToDoTest\ToDoTest\Views\Home\Index.cshtml"
                   Write(g.id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                    <td>");
#nullable restore
#line 45 "C:\Users\ASUS\source\repos\ToDoTest\ToDoTest\Views\Home\Index.cshtml"
                   Write(g.GorevDetay);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 46 "C:\Users\ASUS\source\repos\ToDoTest\ToDoTest\Views\Home\Index.cshtml"
                   Write(g.OlusturmaTarihi);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 47 "C:\Users\ASUS\source\repos\ToDoTest\ToDoTest\Views\Home\Index.cshtml"
                   Write(g.Durumu);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 48 "C:\Users\ASUS\source\repos\ToDoTest\ToDoTest\Views\Home\Index.cshtml"
                   Write(g.Firma);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 1504, "\"", 1534, 2);
            WriteAttributeValue("", 1511, "/Gorev/GorevGetir/", 1511, 18, true);
#nullable restore
#line 50 "C:\Users\ASUS\source\repos\ToDoTest\ToDoTest\Views\Home\Index.cshtml"
WriteAttributeValue("", 1529, g.id, 1529, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-warning\"> Düzenle </a>\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 1601, "\"", 1629, 2);
            WriteAttributeValue("", 1608, "/Gorev/GorevSil/", 1608, 16, true);
#nullable restore
#line 51 "C:\Users\ASUS\source\repos\ToDoTest\ToDoTest\Views\Home\Index.cshtml"
WriteAttributeValue("", 1624, g.id, 1624, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger\"> SİL </a>\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 1691, "\"", 1726, 2);
            WriteAttributeValue("", 1698, "/Gorev/YapildiIsaretle/", 1698, 23, true);
#nullable restore
#line 52 "C:\Users\ASUS\source\repos\ToDoTest\ToDoTest\Views\Home\Index.cshtml"
WriteAttributeValue("", 1721, g.id, 1721, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-success\">Yapıldı İşaretle</a>\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 55 "C:\Users\ASUS\source\repos\ToDoTest\ToDoTest\Views\Home\Index.cshtml"
            }
            else if (@g.Durumu == "")
            {


#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr class=\"table-warning\">\r\n                    <th>");
#nullable restore
#line 60 "C:\Users\ASUS\source\repos\ToDoTest\ToDoTest\Views\Home\Index.cshtml"
                   Write(g.id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                    <td>");
#nullable restore
#line 61 "C:\Users\ASUS\source\repos\ToDoTest\ToDoTest\Views\Home\Index.cshtml"
                   Write(g.GorevDetay);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 62 "C:\Users\ASUS\source\repos\ToDoTest\ToDoTest\Views\Home\Index.cshtml"
                   Write(g.OlusturmaTarihi);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 63 "C:\Users\ASUS\source\repos\ToDoTest\ToDoTest\Views\Home\Index.cshtml"
                   Write(g.Durumu);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 64 "C:\Users\ASUS\source\repos\ToDoTest\ToDoTest\Views\Home\Index.cshtml"
                   Write(g.Firma);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 2199, "\"", 2229, 2);
            WriteAttributeValue("", 2206, "/Gorev/GorevGetir/", 2206, 18, true);
#nullable restore
#line 66 "C:\Users\ASUS\source\repos\ToDoTest\ToDoTest\Views\Home\Index.cshtml"
WriteAttributeValue("", 2224, g.id, 2224, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-warning\"> Düzenle </a>\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 2296, "\"", 2324, 2);
            WriteAttributeValue("", 2303, "/Gorev/GorevSil/", 2303, 16, true);
#nullable restore
#line 67 "C:\Users\ASUS\source\repos\ToDoTest\ToDoTest\Views\Home\Index.cshtml"
WriteAttributeValue("", 2319, g.id, 2319, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger\"> SİL </a>\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 2386, "\"", 2421, 2);
            WriteAttributeValue("", 2393, "/Gorev/YapildiIsaretle/", 2393, 23, true);
#nullable restore
#line 68 "C:\Users\ASUS\source\repos\ToDoTest\ToDoTest\Views\Home\Index.cshtml"
WriteAttributeValue("", 2416, g.id, 2416, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-success\">Yapıldı İşaretle</a>\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 71 "C:\Users\ASUS\source\repos\ToDoTest\ToDoTest\Views\Home\Index.cshtml"
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
