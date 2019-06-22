#pragma checksum "C:\CV\projekat\potvrda\potvrda\Views\Home\ListaOdgovora.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "83a8cc79d23c7de035ad146c6f2bdaf6f88b0861"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ListaOdgovora), @"mvc.1.0.view", @"/Views/Home/ListaOdgovora.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/ListaOdgovora.cshtml", typeof(AspNetCore.Views_Home_ListaOdgovora))]
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
#line 1 "C:\CV\projekat\potvrda\potvrda\Views\_ViewImports.cshtml"
using potvrda.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"83a8cc79d23c7de035ad146c6f2bdaf6f88b0861", @"/Views/Home/ListaOdgovora.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aae48380bc9e5b600491a1f47a56cab9b1e64d8c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ListaOdgovora : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<OdgovoriRoditelja>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(39, 525, true);
            WriteLiteral(@"
<h3 class=""bg-primary p-2 text-white text-center"">Ovo je lista ljudi koji su prijavili prisustvo</h3>

<div class=""container-fluid"">
    <div class=""row p-1"">
        <div class=""col font-weight-bold"">Ime deteta</div>
        <div class=""col font-weight-bold"">Ime roditelja</div>
        <div class=""col font-weight-bold"">Email</div>
        <div class=""col font-weight-bold"">Telefon</div>
        <div class=""col font-weight-bold"">Viber?</div>
        <div class=""col font-weight-bold"">Dolazi?</div>
    </div>
");
            EndContext();
#line 14 "C:\CV\projekat\potvrda\potvrda\Views\Home\ListaOdgovora.cshtml"
     foreach (OdgovoriRoditelja r in Model)    
    {

#line default
#line hidden
            BeginContext(620, 60, true);
            WriteLiteral("        <div class=\"row p-1\">\r\n            <div class=\"col\">");
            EndContext();
            BeginContext(681, 11, false);
#line 17 "C:\CV\projekat\potvrda\potvrda\Views\Home\ListaOdgovora.cshtml"
                        Write(r.ImeDeteta);

#line default
#line hidden
            EndContext();
            BeginContext(692, 37, true);
            WriteLiteral("</div>\r\n            <div class=\"col\">");
            EndContext();
            BeginContext(730, 14, false);
#line 18 "C:\CV\projekat\potvrda\potvrda\Views\Home\ListaOdgovora.cshtml"
                        Write(r.ImeRoditelja);

#line default
#line hidden
            EndContext();
            BeginContext(744, 37, true);
            WriteLiteral("</div>\r\n            <div class=\"col\">");
            EndContext();
            BeginContext(782, 7, false);
#line 19 "C:\CV\projekat\potvrda\potvrda\Views\Home\ListaOdgovora.cshtml"
                        Write(r.Email);

#line default
#line hidden
            EndContext();
            BeginContext(789, 37, true);
            WriteLiteral("</div>\r\n            <div class=\"col\">");
            EndContext();
            BeginContext(827, 9, false);
#line 20 "C:\CV\projekat\potvrda\potvrda\Views\Home\ListaOdgovora.cshtml"
                        Write(r.Telefon);

#line default
#line hidden
            EndContext();
            BeginContext(836, 37, true);
            WriteLiteral("</div>\r\n            <div class=\"col\">");
            EndContext();
            BeginContext(875, 29, false);
#line 21 "C:\CV\projekat\potvrda\potvrda\Views\Home\ListaOdgovora.cshtml"
                         Write(r.Viber == true ? "Da" : "Ne");

#line default
#line hidden
            EndContext();
            BeginContext(905, 37, true);
            WriteLiteral("</div>\r\n            <div class=\"col\">");
            EndContext();
            BeginContext(944, 38, false);
#line 22 "C:\CV\projekat\potvrda\potvrda\Views\Home\ListaOdgovora.cshtml"
                         Write(r.PotvrdaDolaska == true ? "Da" : "Ne");

#line default
#line hidden
            EndContext();
            BeginContext(983, 24, true);
            WriteLiteral("</div>\r\n        </div>\r\n");
            EndContext();
#line 24 "C:\CV\projekat\potvrda\potvrda\Views\Home\ListaOdgovora.cshtml"
    }

#line default
#line hidden
            BeginContext(1014, 13, true);
            WriteLiteral("    Kliknite ");
            EndContext();
            BeginContext(1027, 30, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "83a8cc79d23c7de035ad146c6f2bdaf6f88b08616655", async() => {
                BeginContext(1049, 4, true);
                WriteLiteral("ovde");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1057, 44, true);
            WriteLiteral(" da se vratite na naslovnu stranu.\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<OdgovoriRoditelja>> Html { get; private set; }
    }
}
#pragma warning restore 1591