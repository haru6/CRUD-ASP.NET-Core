#pragma checksum "C:\Users\rpres\source\repos\CRUD\CRUD\Views\Formulario\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4848496cf50293a87273f2e8d12971a4e2ab1e8f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Formulario_Index), @"mvc.1.0.view", @"/Views/Formulario/Index.cshtml")]
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
#line 1 "C:\Users\rpres\source\repos\CRUD\CRUD\Views\_ViewImports.cshtml"
using CRUD;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\rpres\source\repos\CRUD\CRUD\Views\_ViewImports.cshtml"
using CRUD.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\rpres\source\repos\CRUD\CRUD\Views\Formulario\Index.cshtml"
using CRUD.Models.Classe;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4848496cf50293a87273f2e8d12971a4e2ab1e8f", @"/Views/Formulario/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"813d028d5e7480ef09b6d196de8cd6b00c3ad294", @"/Views/_ViewImports.cshtml")]
    public class Views_Formulario_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IList<Cliente>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral(@"<h4> Cadastrar Empresa</h4>
<i type=""button"" class=""btn btn-success mt-3 mb-4 btn_cadastrar material-icons"">add</i>
<table class=""table table-hover text-center"">
    <thead>
        <tr>
            <th>ID</th>
            <th>Razao Social</th>
            <th>CNPJ</th>
            <th>Data de Fundação</th>
            <th>Capital</th>
            <th>Quarentena</th>
            <th>Status Cliente</th>
            <th>Classificação</th>
            <th>Detalhar</th>
            <th>Editar</th>
            <th>Remover</th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 23 "C:\Users\rpres\source\repos\CRUD\CRUD\Views\Formulario\Index.cshtml"
         foreach (var cliente in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 26 "C:\Users\rpres\source\repos\CRUD\CRUD\Views\Formulario\Index.cshtml"
               Write(cliente.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 27 "C:\Users\rpres\source\repos\CRUD\CRUD\Views\Formulario\Index.cshtml"
               Write(cliente.Razao_Social);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 28 "C:\Users\rpres\source\repos\CRUD\CRUD\Views\Formulario\Index.cshtml"
               Write(cliente.Cnpj);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 29 "C:\Users\rpres\source\repos\CRUD\CRUD\Views\Formulario\Index.cshtml"
               Write(cliente.Data_Fundacao.ToString("dd/MM/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>R$ ");
#nullable restore
#line 30 "C:\Users\rpres\source\repos\CRUD\CRUD\Views\Formulario\Index.cshtml"
                  Write(cliente.Capital);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 31 "C:\Users\rpres\source\repos\CRUD\CRUD\Views\Formulario\Index.cshtml"
               Write(cliente.Quarentena);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 32 "C:\Users\rpres\source\repos\CRUD\CRUD\Views\Formulario\Index.cshtml"
               Write(cliente.status_cliente);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 33 "C:\Users\rpres\source\repos\CRUD\CRUD\Views\Formulario\Index.cshtml"
               Write(cliente.classificacao);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td><i type=\"button\" class=\"btn btn-block btn-info details material-icons\" data-id=\"");
#nullable restore
#line 34 "C:\Users\rpres\source\repos\CRUD\CRUD\Views\Formulario\Index.cshtml"
                                                                                               Write(cliente.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">comment</i></td>\r\n                <td><i type=\"button\" style=\"color:white\" class=\"btn btn-block btn-warning edit material-icons\" data-id=\"");
#nullable restore
#line 35 "C:\Users\rpres\source\repos\CRUD\CRUD\Views\Formulario\Index.cshtml"
                                                                                                                   Write(cliente.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">edit</i></td>\r\n                <td><i type=\"button\" class=\"btn btn-block btn-danger delete material-icons\"  data-id=\"");
#nullable restore
#line 36 "C:\Users\rpres\source\repos\CRUD\CRUD\Views\Formulario\Index.cshtml"
                                                                                                 Write(cliente.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">delete</i></td>\r\n            </tr>\r\n");
#nullable restore
#line 38 "C:\Users\rpres\source\repos\CRUD\CRUD\Views\Formulario\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    </tbody>
</table>
<!--Modal Centralizado-->
<div class=""modal fade"" id=""myModal"" data-backdrop=""static"" tabindex=""-1"" role=""dialog"" aria-labelledby=""myLargeModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog modal-dialog-centered"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-body"" style=""background-color:silver"">
                <div id=""conteudoModal"">

                </div>
            </div>
        </div>
    </div>
</div>


");
            DefineSection("scripts", async() => {
                WriteLiteral(@"
    <script>
        $(function () {
            $("".details"").click(function () {
                let id = $(this).attr(""data-id"");
                $(""#conteudoModal"").load(""Formulario/Detalhar/"" + id, function () {
                    $(""#myModal"").modal(""show"");
                })
            });

            $("".edit"").click(function () {
                let id = $(this).attr(""data-id"");
                $(""#conteudoModal"").load(""Formulario/Atualizar/"" + id, function () {
                    $(""#myModal"").modal(""show"");
                })
            });

            $("".delete"").click(function () {
                let id = $(this).attr(""data-id"");
                $(""#conteudoModal"").load(""Formulario/Deletar/"" + id, function () {
                    $(""#myModal"").modal(""show"");
                })
            });

            $("".btn_cadastrar"").click(function () {
                $(""#conteudoModal"").load(""Formulario/Cadastro"", function () {
                    $(""#myModal"").modal");
                WriteLiteral("(\"show\");\r\n                })\r\n            });\r\n\r\n        });\r\n    </script>\r\n");
            }
            );
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IList<Cliente>> Html { get; private set; }
    }
}
#pragma warning restore 1591
