#pragma checksum "D:\User\Downloads\uploadFTECEnerSave-master\uploadFTECEnerSave-master\EnerSave\EnerSave\Views\TgastosAgua\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a555d7e4494ef91bfa58faf60c047a8f153b23d4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_TgastosAgua_Details), @"mvc.1.0.view", @"/Views/TgastosAgua/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/TgastosAgua/Details.cshtml", typeof(AspNetCore.Views_TgastosAgua_Details))]
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
#line 1 "D:\User\Downloads\uploadFTECEnerSave-master\uploadFTECEnerSave-master\EnerSave\EnerSave\Views\_ViewImports.cshtml"
using ConsultasMVC;

#line default
#line hidden
#line 2 "D:\User\Downloads\uploadFTECEnerSave-master\uploadFTECEnerSave-master\EnerSave\EnerSave\Views\_ViewImports.cshtml"
using ConsultasMVC.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a555d7e4494ef91bfa58faf60c047a8f153b23d4", @"/Views/TgastosAgua/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e456e78e7b0601d5d923a4a66b8893dd89f1012a", @"/Views/_ViewImports.cshtml")]
    public class Views_TgastosAgua_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ConsultasMVC.dbenersave.TgastosAgua>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(43, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 3 "D:\User\Downloads\uploadFTECEnerSave-master\uploadFTECEnerSave-master\EnerSave\EnerSave\Views\TgastosAgua\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(84, 171, true);
            WriteLiteral("\n<h2>Detalhes do Gastos de Água</h2>\n\n<div>\n    <hr />\n    <dl class=\"dl-horizontal\">\n        <dt>\n            Metros Cúbicos (m3):\n        </dt>\n        <dd>\n            ");
            EndContext();
            BeginContext(256, 45, false);
#line 16 "D:\User\Downloads\uploadFTECEnerSave-master\uploadFTECEnerSave-master\EnerSave\EnerSave\Views\TgastosAgua\Details.cshtml"
       Write(Html.DisplayFor(model => model.MetrosCubicos));

#line default
#line hidden
            EndContext();
            BeginContext(301, 88, true);
            WriteLiteral("\n        </dd>\n        <dt>\n            Período:\n        </dt>\n        <dd>\n            ");
            EndContext();
            BeginContext(390, 39, false);
#line 22 "D:\User\Downloads\uploadFTECEnerSave-master\uploadFTECEnerSave-master\EnerSave\EnerSave\Views\TgastosAgua\Details.cshtml"
       Write(Html.DisplayFor(model => model.Periodo));

#line default
#line hidden
            EndContext();
            BeginContext(429, 88, true);
            WriteLiteral("\n        </dd>\n        <dt>\n            Usuário:\n        </dt>\n        <dd>\n            ");
            EndContext();
            BeginContext(518, 44, false);
#line 28 "D:\User\Downloads\uploadFTECEnerSave-master\uploadFTECEnerSave-master\EnerSave\EnerSave\Views\TgastosAgua\Details.cshtml"
       Write(Html.DisplayFor(model => model.Usuario.Nome));

#line default
#line hidden
            EndContext();
            BeginContext(562, 57, true);
            WriteLiteral("\n        </dd>\n        <br />\n    </dl>\n</div>\n<div>\n    ");
            EndContext();
            BeginContext(619, 57, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a555d7e4494ef91bfa58faf60c047a8f153b23d45953", async() => {
                BeginContext(665, 7, true);
                WriteLiteral("Alterar");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 34 "D:\User\Downloads\uploadFTECEnerSave-master\uploadFTECEnerSave-master\EnerSave\EnerSave\Views\TgastosAgua\Details.cshtml"
                           WriteLiteral(Model.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(676, 7, true);
            WriteLiteral(" |\n    ");
            EndContext();
            BeginContext(683, 32, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a555d7e4494ef91bfa58faf60c047a8f153b23d48313", async() => {
                BeginContext(705, 6, true);
                WriteLiteral("Voltar");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(715, 8, true);
            WriteLiteral("\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ConsultasMVC.dbenersave.TgastosAgua> Html { get; private set; }
    }
}
#pragma warning restore 1591
