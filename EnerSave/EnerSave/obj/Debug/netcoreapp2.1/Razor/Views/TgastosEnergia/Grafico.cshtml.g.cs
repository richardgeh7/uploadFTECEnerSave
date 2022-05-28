#pragma checksum "C:\Projeto\novo\uploadFTECEnerSave\EnerSave\EnerSave\Views\TgastosEnergia\Grafico.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "aea4c9d1715076703c71bac801f97d3a562016e7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_TgastosEnergia_Grafico), @"mvc.1.0.view", @"/Views/TgastosEnergia/Grafico.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/TgastosEnergia/Grafico.cshtml", typeof(AspNetCore.Views_TgastosEnergia_Grafico))]
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
#line 1 "C:\Projeto\novo\uploadFTECEnerSave\EnerSave\EnerSave\Views\_ViewImports.cshtml"
using ConsultasMVC;

#line default
#line hidden
#line 2 "C:\Projeto\novo\uploadFTECEnerSave\EnerSave\EnerSave\Views\_ViewImports.cshtml"
using ConsultasMVC.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aea4c9d1715076703c71bac801f97d3a562016e7", @"/Views/TgastosEnergia/Grafico.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dc1708d709ae3a6985fcc5e605b14b8455b00aad", @"/Views/_ViewImports.cshtml")]
    public class Views_TgastosEnergia_Grafico : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Projeto\novo\uploadFTECEnerSave\EnerSave\EnerSave\Views\TgastosEnergia\Grafico.cshtml"
  
    ViewData["Title"] = "Gráfico";

#line default
#line hidden
            BeginContext(45, 22, true);
            WriteLiteral("\r\n<h2>Gráfico</h2>\r\n\r\n");
            EndContext();
            BeginContext(89, 397, true);
            WriteLiteral(@"<script type=""text/javascript"" src=""https://www.gstatic.com/charts/loader.js""></script> 

<div id=""chart_div"" style=""width: 1200px; height: 500px;""></div>  

<script type=""text/javascript"">  
    google.charts.load('current', {packages: ['corechart', 'bar']});  
    google.charts.setOnLoadCallback(CarregaDados);

    function CarregaDados() {   

        $.ajax({  
            url: '");
            EndContext();
            BeginContext(487, 44, false);
#line 20 "C:\Projeto\novo\uploadFTECEnerSave\EnerSave\EnerSave\Views\TgastosEnergia\Grafico.cshtml"
             Write(Url.Action("DadosGrafico", "TgastosEnergia"));

#line default
#line hidden
            EndContext();
            BeginContext(531, 2505, true);
            WriteLiteral(@"',  
            dataType:
             ""json"",  
            type: ""GET"",  
            error: function(xhr, status, error) {  
                var err = eval(""("" + xhr.responseText + "")"");  
                toastr.error(err.message);  
            },  
            success: function(dados) {  
                console.log(dados);
                MontaGrafico(dados);  
                return false;  
            }  
        });  
        return false;  
    }  

    function MontaGrafico(dados) {  
        var meses = [
            ""Janeiro"",
            ""Fevereiro"",
            ""Março"",
            ""Abril"",
            ""Maio"",
            ""Junho"",
            ""Julho"",
            ""Agosto"",
            ""Setembro"",
            ""Outubro"",
            ""Novembro"",
            ""Dezembro"",
        ];

        var usuarios = dados
            .map(item => item.usuarioId)
            .filter((v, i, a) => a.indexOf(v) === i);

        var primeiraLinha = ['Mês'];

        for (var");
            WriteLiteral(@" usuarioId of usuarios) {
            primeiraLinha.push(""Usuário "" + usuarioId)
        }

        var dataArray = [  
            primeiraLinha,
            ];  

        for (var index in meses) {
            var mes = meses[index];

            var dadosDoMes = dados.filter(item => new Date(item.periodo).getMonth() == index);

            var linha = [mes];

            for (var usuarioId of usuarios) {
                var dadoDoUsuario = dadosDoMes.filter(item => item.usuarioId == usuarioId);
                if (dadoDoUsuario && dadoDoUsuario.length > 0) {
                    linha.push(dadoDoUsuario[0].kilowatts);
                } else {
                    linha.push(0);
                }
            }

            dataArray.push(linha);
        };

         
        var data = google.visualization.arrayToDataTable(dataArray);  
        var options = {  
            title: 'Energia consumida em KWH',  
            chartArea: {  
                width: '70%'  
         ");
            WriteLiteral(@"   },  
            colors: ['#b0120a', '#ffab91'],  
            hAxis: {  
                title: 'Periodo',  
                minValue: 0  
            },  
            vAxis: {  
                title: 'Consumo (KWH)'  
            }  
        };  
        var chart = new google.visualization.LineChart(document.getElementById('chart_div'));  
        chart.draw(data, options);  
        return false;  
    }  
</script> 

<div>
    ");
            EndContext();
            BeginContext(3036, 32, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aea4c9d1715076703c71bac801f97d3a562016e77409", async() => {
                BeginContext(3058, 6, true);
                WriteLiteral("Voltar");
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
            BeginContext(3068, 12, true);
            WriteLiteral("\r\n</div>\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(3098, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 113 "C:\Projeto\novo\uploadFTECEnerSave\EnerSave\EnerSave\Views\TgastosEnergia\Grafico.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
            }
            );
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