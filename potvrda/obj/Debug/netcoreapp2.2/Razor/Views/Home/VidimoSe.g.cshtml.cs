#pragma checksum "C:\CV\projekat\potvrda\potvrda\Views\Home\VidimoSe.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3c566bc32ab7bc8a21bd110e77a9bb2cb43592b7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_VidimoSe), @"mvc.1.0.view", @"/Views/Home/VidimoSe.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/VidimoSe.cshtml", typeof(AspNetCore.Views_Home_VidimoSe))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3c566bc32ab7bc8a21bd110e77a9bb2cb43592b7", @"/Views/Home/VidimoSe.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aae48380bc9e5b600491a1f47a56cab9b1e64d8c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_VidimoSe : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<OdgovoriRoditelja>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ListaOdgovora", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(27, 53, true);
            WriteLiteral("\r\n<div class=\"text-center mt-3\">\r\n    <h1>Hvala vam, ");
            EndContext();
            BeginContext(81, 18, false);
#line 4 "C:\CV\projekat\potvrda\potvrda\Views\Home\VidimoSe.cshtml"
              Write(Model.ImeRoditelja);

#line default
#line hidden
            EndContext();
            BeginContext(99, 8, true);
            WriteLiteral("!</h1>\r\n");
            EndContext();
#line 5 "C:\CV\projekat\potvrda\potvrda\Views\Home\VidimoSe.cshtml"
     if (Model.PotvrdaDolaska == true)
    {

#line default
#line hidden
            BeginContext(154, 89, true);
            WriteLiteral("        <div>\r\n            Odlično, jedva čekamo da se družimo zajedno.\r\n        </div>\r\n");
            EndContext();
#line 10 "C:\CV\projekat\potvrda\potvrda\Views\Home\VidimoSe.cshtml"
    }
    else
    {

#line default
#line hidden
            BeginContext(267, 124, true);
            WriteLiteral("        <div>\r\n            Žao nam je što nam se vaš mališan neće moći pridružiti. Hvala vam na javljanju.\r\n        </div>\r\n");
            EndContext();
#line 16 "C:\CV\projekat\potvrda\potvrda\Views\Home\VidimoSe.cshtml"
    }

#line default
#line hidden
            BeginContext(398, 13, true);
            WriteLiteral("    Kliknite ");
            EndContext();
            BeginContext(411, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3c566bc32ab7bc8a21bd110e77a9bb2cb43592b74610", async() => {
                BeginContext(441, 4, true);
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
            BeginContext(449, 35, true);
            WriteLiteral(" da vidite ko još dolazi.\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<OdgovoriRoditelja> Html { get; private set; }
    }
}
#pragma warning restore 1591
