#pragma checksum "C:\Users\Asus\source\repos\berylliumV2\berylliumv2\Views\Shared\_ArchitecturePartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8ca99f2a538f6cc82ef8f3a809dd7e183f58dd86"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__ArchitecturePartial), @"mvc.1.0.view", @"/Views/Shared/_ArchitecturePartial.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8ca99f2a538f6cc82ef8f3a809dd7e183f58dd86", @"/Views/Shared/_ArchitecturePartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a4c16960562ccf5932051603c8b4324f4487c40a", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__ArchitecturePartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<ArchitectureImage>>
    {
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n\n");
#nullable restore
#line 4 "C:\Users\Asus\source\repos\berylliumV2\berylliumv2\Views\Shared\_ArchitecturePartial.cshtml"
 foreach (ArchitectureImage item in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"item\">\n    <a href=\"#\">\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "8ca99f2a538f6cc82ef8f3a809dd7e183f58dd863667", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 132, "~/images/", 132, 9, true);
#nullable restore
#line 8 "C:\Users\Asus\source\repos\berylliumV2\berylliumv2\Views\Shared\_ArchitecturePartial.cshtml"
AddHtmlAttributeValue("", 141, item.Path, 141, 10, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n        <div class=\"slider-copy\">\n            <h2>");
#nullable restore
#line 10 "C:\Users\Asus\source\repos\berylliumV2\berylliumv2\Views\Shared\_ArchitecturePartial.cshtml"
           Write(item.Text);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\n        </div>\n    </a>\n</div>");
#nullable restore
#line 13 "C:\Users\Asus\source\repos\berylliumV2\berylliumv2\Views\Shared\_ArchitecturePartial.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<ArchitectureImage>> Html { get; private set; }
    }
}
#pragma warning restore 1591
