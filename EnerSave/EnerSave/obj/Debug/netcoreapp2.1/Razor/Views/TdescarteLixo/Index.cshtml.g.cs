#pragma checksum "C:\Users\User\Desktop\ftecMain\uploadFTECEnerSave\EnerSave\EnerSave\Views\TdescarteLixo\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e2dec5565ef9daccddc9b1e722c2ff1713236d60"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_TdescarteLixo_Index), @"mvc.1.0.view", @"/Views/TdescarteLixo/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/TdescarteLixo/Index.cshtml", typeof(AspNetCore.Views_TdescarteLixo_Index))]
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
#line 1 "C:\Users\User\Desktop\ftecMain\uploadFTECEnerSave\EnerSave\EnerSave\Views\_ViewImports.cshtml"
using ConsultasMVC;

#line default
#line hidden
#line 2 "C:\Users\User\Desktop\ftecMain\uploadFTECEnerSave\EnerSave\EnerSave\Views\_ViewImports.cshtml"
using ConsultasMVC.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e2dec5565ef9daccddc9b1e722c2ff1713236d60", @"/Views/TdescarteLixo/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e456e78e7b0601d5d923a4a66b8893dd89f1012a", @"/Views/_ViewImports.cshtml")]
    public class Views_TdescarteLixo_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ConsultasMVC.Entities.DescarteLixoEntity>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(61, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 3 "C:\Users\User\Desktop\ftecMain\uploadFTECEnerSave\EnerSave\EnerSave\Views\TdescarteLixo\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(100, 114, true);
            WriteLiteral("\n<h2>Descarte de Lixo</h2>\n<h5>Abaixo são exibidos os descartes de lixo cadastrados.</h5>\n<hr />\n\n<br />\n\n<p>\n    ");
            EndContext();
            BeginContext(214, 116, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e2dec5565ef9daccddc9b1e722c2ff1713236d605002", async() => {
                BeginContext(237, 89, true);
                WriteLiteral("\n        <input type=\"submit\" value=\"Novo Descarte de Lixo\" class=\"btn btn-default\">\n    ");
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
            BeginContext(330, 496, true);
            WriteLiteral(@"
</p>
<table class=""table"">
    <thead>
        <tr>
            <th>
                Peso total (Kg)
            </th>
            <th>
                Orgânico
            </th>
            <th>
                Seletivo
            </th>
            <th>
                Eletrônico
            </th>
            <th>
                Observação
            </th>
            <th>
                Período do descarte
            </th>
            <th></th>
        </tr>
    </thead>
    <tbody>
");
            EndContext();
#line 43 "C:\Users\User\Desktop\ftecMain\uploadFTECEnerSave\EnerSave\EnerSave\Views\TdescarteLixo\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(873, 58, true);
            WriteLiteral("            <tr>\n                <td>\n                    ");
            EndContext();
            BeginContext(932, 39, false);
#line 47 "C:\Users\User\Desktop\ftecMain\uploadFTECEnerSave\EnerSave\EnerSave\Views\TdescarteLixo\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Peso));

#line default
#line hidden
            EndContext();
            BeginContext(971, 44, true);
            WriteLiteral("\n                </td>\n                <td>\n");
            EndContext();
#line 50 "C:\Users\User\Desktop\ftecMain\uploadFTECEnerSave\EnerSave\EnerSave\Views\TdescarteLixo\Index.cshtml"
                       if (item.Organico)
                        {

#line default
#line hidden
            BeginContext(1083, 28, true);
            WriteLiteral("                            ");
            EndContext();
            BeginContext(1113, 4, true);
            WriteLiteral("Sim\n");
            EndContext();
#line 53 "C:\Users\User\Desktop\ftecMain\uploadFTECEnerSave\EnerSave\EnerSave\Views\TdescarteLixo\Index.cshtml"
                        }
                        else
                        {

#line default
#line hidden
            BeginContext(1198, 28, true);
            WriteLiteral("                            ");
            EndContext();
            BeginContext(1228, 4, true);
            WriteLiteral("Não\n");
            EndContext();
#line 57 "C:\Users\User\Desktop\ftecMain\uploadFTECEnerSave\EnerSave\EnerSave\Views\TdescarteLixo\Index.cshtml"
                        }
                    

#line default
#line hidden
            BeginContext(1280, 43, true);
            WriteLiteral("                </td>\n                <td>\n");
            EndContext();
#line 61 "C:\Users\User\Desktop\ftecMain\uploadFTECEnerSave\EnerSave\EnerSave\Views\TdescarteLixo\Index.cshtml"
                       if (item.Reciclavel)
                        {

#line default
#line hidden
            BeginContext(1393, 28, true);
            WriteLiteral("                            ");
            EndContext();
            BeginContext(1423, 4, true);
            WriteLiteral("Sim\n");
            EndContext();
#line 64 "C:\Users\User\Desktop\ftecMain\uploadFTECEnerSave\EnerSave\EnerSave\Views\TdescarteLixo\Index.cshtml"
                        }
                        else
                        {

#line default
#line hidden
            BeginContext(1508, 28, true);
            WriteLiteral("                            ");
            EndContext();
            BeginContext(1538, 4, true);
            WriteLiteral("Não\n");
            EndContext();
#line 68 "C:\Users\User\Desktop\ftecMain\uploadFTECEnerSave\EnerSave\EnerSave\Views\TdescarteLixo\Index.cshtml"
                        }
                    

#line default
#line hidden
            BeginContext(1590, 43, true);
            WriteLiteral("                </td>\n                <td>\n");
            EndContext();
#line 72 "C:\Users\User\Desktop\ftecMain\uploadFTECEnerSave\EnerSave\EnerSave\Views\TdescarteLixo\Index.cshtml"
                       if (item.Eletronico)
                        {

#line default
#line hidden
            BeginContext(1703, 28, true);
            WriteLiteral("                            ");
            EndContext();
            BeginContext(1733, 4, true);
            WriteLiteral("Sim\n");
            EndContext();
#line 75 "C:\Users\User\Desktop\ftecMain\uploadFTECEnerSave\EnerSave\EnerSave\Views\TdescarteLixo\Index.cshtml"
                        }
                        else
                        {

#line default
#line hidden
            BeginContext(1818, 28, true);
            WriteLiteral("                            ");
            EndContext();
            BeginContext(1848, 4, true);
            WriteLiteral("Não\n");
            EndContext();
#line 79 "C:\Users\User\Desktop\ftecMain\uploadFTECEnerSave\EnerSave\EnerSave\Views\TdescarteLixo\Index.cshtml"
                        }
                    

#line default
#line hidden
            BeginContext(1900, 63, true);
            WriteLiteral("                </td>\n                <td>\n                    ");
            EndContext();
            BeginContext(1964, 42, false);
#line 83 "C:\Users\User\Desktop\ftecMain\uploadFTECEnerSave\EnerSave\EnerSave\Views\TdescarteLixo\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Periodo));

#line default
#line hidden
            EndContext();
            BeginContext(2006, 64, true);
            WriteLiteral("\n                </td>\n                <td>\n                    ");
            EndContext();
            BeginContext(2071, 47, false);
#line 86 "C:\Users\User\Desktop\ftecMain\uploadFTECEnerSave\EnerSave\EnerSave\Views\TdescarteLixo\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Usuario.Nome));

#line default
#line hidden
            EndContext();
            BeginContext(2118, 64, true);
            WriteLiteral("\n                </td>\n                <td>\n                    ");
            EndContext();
            BeginContext(2182, 266, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e2dec5565ef9daccddc9b1e722c2ff1713236d6012396", async() => {
                BeginContext(2227, 217, true);
                WriteLiteral("\n                        <button type=\"button\" class=\"btn btn-sm\">\n                            <span class=\"glyphicon glyphicon-pencil\" aria-hidden=\"true\"></span>\n                        </button>\n                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 89 "C:\Users\User\Desktop\ftecMain\uploadFTECEnerSave\EnerSave\EnerSave\Views\TdescarteLixo\Index.cshtml"
                                           WriteLiteral(item.Id);

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
            BeginContext(2448, 21, true);
            WriteLiteral("\n                    ");
            EndContext();
            BeginContext(2469, 269, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e2dec5565ef9daccddc9b1e722c2ff1713236d6014995", async() => {
                BeginContext(2517, 217, true);
                WriteLiteral("\n                        <button type=\"button\" class=\"btn btn-sm\">\n                            <span class=\"glyphicon glyphicon-search\" aria-hidden=\"true\"></span>\n                        </button>\n                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 94 "C:\Users\User\Desktop\ftecMain\uploadFTECEnerSave\EnerSave\EnerSave\Views\TdescarteLixo\Index.cshtml"
                                              WriteLiteral(item.Id);

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
            BeginContext(2738, 21, true);
            WriteLiteral("\n                    ");
            EndContext();
            BeginContext(2759, 267, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e2dec5565ef9daccddc9b1e722c2ff1713236d6017597", async() => {
                BeginContext(2806, 216, true);
                WriteLiteral("\n                        <button type=\"button\" class=\"btn btn-sm\">\n                            <span class=\"glyphicon glyphicon-trash\" aria-hidden=\"true\"></span>\n                        </button>\n                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 99 "C:\Users\User\Desktop\ftecMain\uploadFTECEnerSave\EnerSave\EnerSave\Views\TdescarteLixo\Index.cshtml"
                                             WriteLiteral(item.Id);

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
            BeginContext(3026, 41, true);
            WriteLiteral("\n                </td>\n            </tr>\n");
            EndContext();
#line 106 "C:\Users\User\Desktop\ftecMain\uploadFTECEnerSave\EnerSave\EnerSave\Views\TdescarteLixo\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(3077, 22, true);
            WriteLiteral("    </tbody>\n</table>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ConsultasMVC.Entities.DescarteLixoEntity>> Html { get; private set; }
    }
}
#pragma warning restore 1591
