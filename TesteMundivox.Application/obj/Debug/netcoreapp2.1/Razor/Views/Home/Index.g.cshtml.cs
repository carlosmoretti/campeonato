#pragma checksum "C:\Users\Moretti\source\repos\TesteMundivox\TesteMundivox.Application\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "74b3a427b41c0386505bdc9019a343a2f06cd62b"
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
#line 1 "C:\Users\Moretti\source\repos\TesteMundivox\TesteMundivox.Application\Views\_ViewImports.cshtml"
using TesteMundivox.Application;

#line default
#line hidden
#line 2 "C:\Users\Moretti\source\repos\TesteMundivox\TesteMundivox.Application\Views\_ViewImports.cshtml"
using TesteMundivox.Application.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"74b3a427b41c0386505bdc9019a343a2f06cd62b", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"02a57d778f095f8c86e2a7668ba55fc908c50689", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TesteMundivox.Application.ViewModels.TabelaVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/chaves.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_ModalEscolherTime", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 49, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "6d58b71208aa4fb0997c39bafa6ce726", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(49, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Moretti\source\repos\TesteMundivox\TesteMundivox.Application\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Início";

#line default
#line hidden
            BeginContext(147, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(321, 2499, true);
            WriteLiteral(@"
<div class=""row"">
    <div class=""col-sm-2"">
        <div class=""card mb-5 line-b"">
            <div class=""card-body"">
                <span data-id=""1""></span>
            </div>
            <div class=""card-footer"">
                <a href=""#"" onclick=""EscolherTime(1)"">Escolher time</a>
            </div>
        </div>
        <div class=""card mb-5"">
            <div class=""card-body"">
                <span data-id=""2""></span>
            </div>
            <div class=""card-footer"">
                <a href=""#"" onclick=""EscolherTime(2)"">Escolher time</a>
            </div>
        </div>
        <div class=""card mb-5"">
            <div class=""card-body"">
                <span data-id=""3""></span>
            </div>
            <div class=""card-footer"">
                <a href=""#"" onclick=""EscolherTime(3)"">Escolher time</a>
            </div>
        </div>
        <div class=""card mb-5"">
            <div class=""card-body"">
                <span data-id=""4""></span>
            ");
            WriteLiteral(@"</div>
            <div class=""card-footer"">
                <a href=""#"" onclick=""EscolherTime(4)"">Escolher time</a>
            </div>
        </div>
    </div>
    <div class=""col-sm-2"">
        <div class=""card"" style=""margin-top: 80px;"">
            <div class=""card-body"">
                <span data-id=""5""></span>
            </div>
            <div class=""card-footer"">
                <a href=""#"" onclick=""EscolherTime(5)"">Escolher time</a>
            </div>
        </div>
        <div class=""card"" style=""margin-top: 200px;"">
            <div class=""card-body"">
                <span data-id=""6""></span>
            </div>
            <div class=""card-footer"">
                <a href=""#"" onclick=""EscolherTime(6)"">Escolher time</a>
            </div>
        </div>
    </div>
    <div class=""col-sm-2"">
        <div class=""card"" style=""margin-top: 250px;"">
            <div class=""card-body"">
                <span data-id=""7""></span>
            </div>
            <div class=""card");
            WriteLiteral(@"-footer"">
                <a href=""#"" onclick=""EscolherTime(7)"">Escolher time</a>
            </div>
        </div>
    </div>
</div>

<button onclick=""cadastrarEvento()"" class=""btn btn-success btn-sm"">Concluir grade.</button>

<hr />
<h5>Últimos Jogos:</h5>
<table class=""table"">
    <thead>
        <tr>
            <th>Time 1</th>
            <th>Time 2</th>
            <th>Vencedor</th>
        </tr>
    </thead>
    <tbody>
");
            EndContext();
#line 92 "C:\Users\Moretti\source\repos\TesteMundivox\TesteMundivox.Application\Views\Home\Index.cshtml"
         foreach (var item in Model.Jogos)
        {

#line default
#line hidden
            BeginContext(2875, 38, true);
            WriteLiteral("            <tr>\r\n                <td>");
            EndContext();
            BeginContext(2914, 15, false);
#line 95 "C:\Users\Moretti\source\repos\TesteMundivox\TesteMundivox.Application\Views\Home\Index.cshtml"
               Write(item.Time1.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(2929, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(2957, 15, false);
#line 96 "C:\Users\Moretti\source\repos\TesteMundivox\TesteMundivox.Application\Views\Home\Index.cshtml"
               Write(item.Time2.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(2972, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(3000, 18, false);
#line 97 "C:\Users\Moretti\source\repos\TesteMundivox\TesteMundivox.Application\Views\Home\Index.cshtml"
               Write(item.Vencedor.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(3018, 26, true);
            WriteLiteral("</td>\r\n            </tr>\r\n");
            EndContext();
#line 99 "C:\Users\Moretti\source\repos\TesteMundivox\TesteMundivox.Application\Views\Home\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(3055, 957, true);
            WriteLiteral(@"    </tbody>
</table>
<script>
    $("".draggable"").draggable({ snap: true });

    function EscolherTime(id) {
        $(""#modalSelectTeam"").modal('show');
        $(""#btnSalvarModal"").attr(""data-id"", id);
    }

    function cadastrarEvento() {
        var obj = {
            Time1: $(""span[data-id=5]"")[0].innerHTML,
            Time2: $(""span[data-id=6]"")[0].innerHTML,
            TimeVencedor: $(""span[data-id=7]"")[0].innerHTML
        };

        $.ajax({
            dataType: ""json"",
            contentType: ""application/json;charset=utf-8"",
            method: ""POST"",
            data: JSON.stringify(obj),
            url: ""/Home/CadastrarEvento"",
            success: (e) => {
                if (e == ""OK"") {
                    window.location.reload();
                } else {
                    alert(""Não foi possível registrar este jogo!"")
                }
            } 
        })
    }
</script>

");
            EndContext();
            BeginContext(4012, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "9d767905585046fab6c5aab2364b5499", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TesteMundivox.Application.ViewModels.TabelaVM> Html { get; private set; }
    }
}
#pragma warning restore 1591