#pragma checksum "C:\Users\ASUS\source\repos\ToDoTest\ToDoTest\Views\kullanici\KullaniciGetir.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4ff41d82e7d71f368f246cb3ddf1701079b22bdb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_kullanici_KullaniciGetir), @"mvc.1.0.view", @"/Views/kullanici/KullaniciGetir.cshtml")]
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
#line 2 "C:\Users\ASUS\source\repos\ToDoTest\ToDoTest\Views\_ViewImports.cshtml"
using ToDoTest.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4ff41d82e7d71f368f246cb3ddf1701079b22bdb", @"/Views/kullanici/KullaniciGetir.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"48607a62c9d3e5db2bc3d1c59d2d4f2face3d37e", @"/Views/_ViewImports.cshtml")]
    public class Views_kullanici_KullaniciGetir : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ToDoTest.Models.kullanicilar>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\ASUS\source\repos\ToDoTest\ToDoTest\Views\kullanici\KullaniciGetir.cshtml"
  
    ViewData["Title"] = "KullaniciGetir";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>KullaniciGetir</h1>\r\n\r\n");
#nullable restore
#line 8 "C:\Users\ASUS\source\repos\ToDoTest\ToDoTest\Views\kullanici\KullaniciGetir.cshtml"
 using (Html.BeginForm("KullaniciGuncelle", "kullanici", FormMethod.Post))
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\ASUS\source\repos\ToDoTest\ToDoTest\Views\kullanici\KullaniciGetir.cshtml"
Write(Html.TextBoxFor(k => k.ID, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <b>Ad Soyad</b>\r\n    <br />\r\n");
#nullable restore
#line 14 "C:\Users\ASUS\source\repos\ToDoTest\ToDoTest\Views\kullanici\KullaniciGetir.cshtml"
Write(Html.TextBoxFor(k => k.PersonelAd, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <b>Yetki Türü</b>\r\n    <br />\r\n");
#nullable restore
#line 17 "C:\Users\ASUS\source\repos\ToDoTest\ToDoTest\Views\kullanici\KullaniciGetir.cshtml"
Write(Html.TextBoxFor(k => k.YetkiID, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <b>Kullanıcı Adı</b>\r\n    <br />\r\n");
#nullable restore
#line 20 "C:\Users\ASUS\source\repos\ToDoTest\ToDoTest\Views\kullanici\KullaniciGetir.cshtml"
Write(Html.TextBoxFor(k => k.KullaniciAdi, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <b>Şifre</b>\r\n    <br />\r\n");
#nullable restore
#line 23 "C:\Users\ASUS\source\repos\ToDoTest\ToDoTest\Views\kullanici\KullaniciGetir.cshtml"
Write(Html.TextBoxFor(k => k.Sifre, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <button class=\"btn btn-warning\">Kullanıcı Ekle</button>\r\n");
#nullable restore
#line 25 "C:\Users\ASUS\source\repos\ToDoTest\ToDoTest\Views\kullanici\KullaniciGetir.cshtml"


}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ToDoTest.Models.kullanicilar> Html { get; private set; }
    }
}
#pragma warning restore 1591