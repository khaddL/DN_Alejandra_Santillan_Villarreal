#pragma checksum "C:\Users\aly-s\Desktop\T2_PartialViews\GymManager.web\GymManager.web\Views\Members\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c8377549f46882fed74aaa76e182740be84df8a9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Members_Index), @"mvc.1.0.view", @"/Views/Members/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c8377549f46882fed74aaa76e182740be84df8a9", @"/Views/Members/Index.cshtml")]
    #nullable restore
    public class Views_Members_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<GymManager.web.Models.MemberListViewModel>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 6 "C:\Users\aly-s\Desktop\T2_PartialViews\GymManager.web\GymManager.web\Views\Members\Index.cshtml"
  

    Layout = "~/Views/Shared/_Layout.cshtml";


#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            DefineSection("HeaderRight", async() => {
                WriteLiteral(@"
     <form class=""d-flex"">
                        <input class=""form-control me-2"" type=""search"" placeholder=""Search"" aria-label=""Search"">
                        <button class=""btn btn-outline-success"" type=""submit"">Search</button>
                    </form>
 
 
 ");
            }
            );
            WriteLiteral("\r\n      <!-- Begin page content -->\r\n \r\n        <div class=\"container\">\r\n            <h1 class=\"mt-5\">Sticky footer with fixed navbar</h1>\r\n\r\n            <p>New Members of Week: ");
#nullable restore
#line 26 "C:\Users\aly-s\Desktop\T2_PartialViews\GymManager.web\GymManager.web\Views\Members\Index.cshtml"
                               Write(Model.NewMembersCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n            ");
#nullable restore
#line 28 "C:\Users\aly-s\Desktop\T2_PartialViews\GymManager.web\GymManager.web\Views\Members\Index.cshtml"
       Write(await Html.PartialAsync("~/Views/Shared/_MemberList.cshtml", Model.Members));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n            \r\n        </div>\r\n\r\n    \r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<GymManager.web.Models.MemberListViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
