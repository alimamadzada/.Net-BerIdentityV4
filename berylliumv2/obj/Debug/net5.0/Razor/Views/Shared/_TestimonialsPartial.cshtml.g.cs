#pragma checksum "C:\Users\Asus\source\repos\berylliumV2\berylliumv2\Views\Shared\_TestimonialsPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7444d2a04001bc442e9155f2d4643abcaa163690"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__TestimonialsPartial), @"mvc.1.0.view", @"/Views/Shared/_TestimonialsPartial.cshtml")]
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
#line 1 "C:\Users\Asus\source\repos\berylliumV2\berylliumv2\Views\_ViewImports.cshtml"
using berylliumv2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Asus\source\repos\berylliumV2\berylliumv2\Views\_ViewImports.cshtml"
using berylliumv2.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Asus\source\repos\berylliumV2\berylliumv2\Views\_ViewImports.cshtml"
using berylliumv2.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7444d2a04001bc442e9155f2d4643abcaa163690", @"/Views/Shared/_TestimonialsPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a4c16960562ccf5932051603c8b4324f4487c40a", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__TestimonialsPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Testimonials>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n\n");
#nullable restore
#line 4 "C:\Users\Asus\source\repos\berylliumV2\berylliumv2\Views\Shared\_TestimonialsPartial.cshtml"
 foreach (Testimonials item in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<blockquote>\n    <p>&ldquo;");
#nullable restore
#line 7 "C:\Users\Asus\source\repos\berylliumV2\berylliumv2\Views\Shared\_TestimonialsPartial.cshtml"
         Write(item.Aphorism);

#line default
#line hidden
#nullable disable
            WriteLiteral("&ldquo;</p>\n    <p class=\"author\"><cite>&mdash; ");
#nullable restore
#line 8 "C:\Users\Asus\source\repos\berylliumV2\berylliumv2\Views\Shared\_TestimonialsPartial.cshtml"
                               Write(item.Author);

#line default
#line hidden
#nullable disable
            WriteLiteral("</cite></p>\n</blockquote>");
#nullable restore
#line 9 "C:\Users\Asus\source\repos\berylliumV2\berylliumv2\Views\Shared\_TestimonialsPartial.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Testimonials>> Html { get; private set; }
    }
}
#pragma warning restore 1591
