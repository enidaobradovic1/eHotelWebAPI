#pragma checksum "C:\RS1 API\OneDrive_2019-09-12 (1)\Hotel-Reservation-WebAPI-master\Hotel.Web\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1ab070646e59817b517f62b8d976fece1211c426"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "C:\RS1 API\OneDrive_2019-09-12 (1)\Hotel-Reservation-WebAPI-master\Hotel.Web\Views\_ViewImports.cshtml"
using RestaurantReservation.Web;

#line default
#line hidden
#line 2 "C:\RS1 API\OneDrive_2019-09-12 (1)\Hotel-Reservation-WebAPI-master\Hotel.Web\Views\_ViewImports.cshtml"
using RestaurantReservation.Web.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1ab070646e59817b517f62b8d976fece1211c426", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7d093077628846ec6a7ca0fdceb890fa13e3b402", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\RS1 API\OneDrive_2019-09-12 (1)\Hotel-Reservation-WebAPI-master\Hotel.Web\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(42, 997, true);
            WriteLiteral(@"<h1>Hotel Reservation </h1>
<p>
    Seminarski rad iz predmeta RKS, radi se o Android aplikaciji za rezervaciju soba u Hotelu.
    Kratki opis funkcionalnosti:
    <ul>
        <li>Logiranje/Registracija </li>
        <li>Pregled liste soba</li>
        <li>Pregled detalja o sobi</li>
        <li>Dodavanje nove rezervacije</li>
        <li>Pregled i upravljanje rezervacijama</li>im
    </ul>
    
   
</p>
<h3>Link za download aplikacije:</h3>
<a href=""https://rks1640.app.fit.ba/app-debug.apk"">Restaurant Reservation apk file</a> <br />
<h3>Link za ulaz u aplikaciju preko online emulatora:</h3>
<a href=""https://appetize.io/app/1d8crarut3v5w8hv7gbktmfym0?device=nexus5&scale=75&orientation=portrait&osVersion=8.1"">Hotel Reservation Online Emulator</a> <br />
<br />

<h4><strong>Podaci za logiranje:</strong></h4>
<p> Username:Enida</p>
<p> Password:test</p>
<br />
<h4><strong>Sourcecode::</strong></h4>
<a href="""">Hotel_Reservation_Android</a> <br />
<a href="""">Hotel_Reservation_WebAPI</a>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591