#pragma checksum "C:\Users\Asus\source\repos\berylliumV2\berylliumv2\Views\Home\Contact.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "55fa57da06110fcaaad5d0456a8dcec10df5283e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Contact), @"mvc.1.0.view", @"/Views/Home/Contact.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"55fa57da06110fcaaad5d0456a8dcec10df5283e", @"/Views/Home/Contact.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a4c16960562ccf5932051603c8b4324f4487c40a", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Contact : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/home/sendmessage"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""gtco-section"">
    <div class=""gtco-container"">
        <div class=""row gtco-heading"">
            <div class=""col-md-7 text-left"">
                <h2>Contact</h2>
                <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus placerat enim et urna sagittis, rhoncus euismod erat tincidunt. Donec tincidunt volutpat erat.</p>
            </div>
            <div class=""col-md-3 col-md-push-2 text-center"">
                <p class=""mt-md""><a href=""#"" class=""btn btn-special btn-block"">Contact us</a></p>
            </div>
        </div>
        <div class=""row"">
            <div class=""col-md-6"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "55fa57da06110fcaaad5d0456a8dcec10df5283e4428", async() => {
                WriteLiteral(@"
                    <div class=""form-group"">
                        <label for=""name"">Name</label>
                        <input type=""text"" class=""form-control"" id=""name"" name=""SenderName"">
                    </div>
                    <div class=""form-group"">
                        <label for=""name"">Email</label>
                        <input type=""text"" class=""form-control"" id=""email"" name=""SenderEmail"">
                    </div>
                    <div class=""form-group"">
                        <label for=""message""></label>
                        <textarea  id=""message"" cols=""30"" rows=""10"" class=""form-control""  name=""MessageText""></textarea>
                    </div>
                    <div class=""form-group"">
                        <input type=""submit"" class=""btn btn btn-special"" value=""Submit Message"">
                    </div>
                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
            </div>
            <div class=""col-md-5 col-md-push-1"">
                <div class=""gtco-contact-info"">
                    <h3>Our Address</h3>
                    <p>Far far away, behind the word mountains, far from the countries Vokalia and Consonantia, there live the blind texts.</p>
                    <ul>
                        <li class=""address"">198 West 21th Street, Suite 721 New York NY 10016</li>
                        <li class=""phone""><a");
            BeginWriteAttribute("href", " href=\"", 2037, "\"", 2044, 0);
            EndWriteAttribute();
            WriteLiteral(@">1235 2355 980</a></li>
                        <li class=""email""><a href=""#"">info@yoursite.com</a></li>
                        <li class=""url""><a href=""#"">www.yoursite.com</a></li>
                    </ul>
                </div>
            </div>
        </div>
    </div>
</div>
<!-- END Contact -->

<div id=""map""></div>



<div class=""gtco-section gto-features"">
    <div class=""gtco-container"">
        <div class=""row"">
            <div class=""col-md-4"">
                <div class=""feature-left"">
                    <i class=""ti-zip icon""></i>
                    <div class=""copy"">
                        <h3>Architect</h3>
                        <p>Lorem ipsum dolor sit ameteista, consectetur adipiscing is not elitistaris.</p>
                        <p><a href=""#"" class=""gtco-more"">Learn more</a></p>
                    </div>
                </div>
            </div>
            <div class=""col-md-4"">
                <div class=""feature-left"">
                    <i class=""ti-hummer icon""></i>
      ");
            WriteLiteral(@"              <div class=""copy"">
                        <h3>Planning</h3>
                        <p>Lorem ipsum dolor sit ameteista, consectetur adipiscing is not elitistaris.</p>
                        <p><a href=""#"" class=""gtco-more"">Learn more</a></p>
                    </div>
                </div>
            </div>
            <div class=""col-md-4"">
                <div class=""feature-left"">
                    <i class=""ti-plug icon""></i>
                    <div class=""copy"">
                        <h3>Parks &amp; Events</h3>
                        <p>Lorem ipsum dolor sit ameteista, consectetur adipiscing is not elitistaris.</p>
                        <p><a href=""#"" class=""gtco-more"">Learn more</a></p>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>
");
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
