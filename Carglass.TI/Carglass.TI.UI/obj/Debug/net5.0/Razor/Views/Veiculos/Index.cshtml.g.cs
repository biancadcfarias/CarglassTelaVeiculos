#pragma checksum "C:\DSV\CarglassTelaVeiculos\Carglass.TI\Carglass.TI.UI\Views\Veiculos\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8f826ccab4f268c13481fc0f935433c04dbd56d6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Veiculos_Index), @"mvc.1.0.view", @"/Views/Veiculos/Index.cshtml")]
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
#line 1 "C:\DSV\CarglassTelaVeiculos\Carglass.TI\Carglass.TI.UI\Views\_ViewImports.cshtml"
using Carglass.TI.Domain.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\DSV\CarglassTelaVeiculos\Carglass.TI\Carglass.TI.UI\Views\_ViewImports.cshtml"
using Carglass.TI.UI.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8f826ccab4f268c13481fc0f935433c04dbd56d6", @"/Views/Veiculos/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"15a8a72acd468466e6bd9380dc39b91dd82bdb83", @"/Views/_ViewImports.cshtml")]
    public class Views_Veiculos_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Veiculo>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<h2>Listagem</h2>

<div style=""margin-bottom:20px;"">
    <a href=""/Veiculos/AddEdit"" class=""btn btn-outline-secondary"">Adicionar Veículo</a>
</div>


<table class=""table  table-striped"">
    <thead class=""table-dark"">
        <tr>
            <th>VehicleBrandId</th>
            <th>VehicleTypeId</th>
            <th>Name</th>
            <th>Active</th>
            <th>VehicleCode</th>
            <th colspan=""2"">Marca</th>
        </tr>
    </thead>

    <tbody>
");
#nullable restore
#line 22 "C:\DSV\CarglassTelaVeiculos\Carglass.TI\Carglass.TI.UI\Views\Veiculos\Index.cshtml"
         foreach (var veiculo in Model)
        {


#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr");
            BeginWriteAttribute("id", " id=\"", 582, "\"", 610, 2);
            WriteAttributeValue("", 587, "item-", 587, 5, true);
#nullable restore
#line 25 "C:\DSV\CarglassTelaVeiculos\Carglass.TI\Carglass.TI.UI\Views\Veiculos\Index.cshtml"
WriteAttributeValue("", 592, veiculo.VehicleId, 592, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n            <td>");
#nullable restore
#line 26 "C:\DSV\CarglassTelaVeiculos\Carglass.TI\Carglass.TI.UI\Views\Veiculos\Index.cshtml"
           Write(veiculo.VehicleBrandId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 27 "C:\DSV\CarglassTelaVeiculos\Carglass.TI\Carglass.TI.UI\Views\Veiculos\Index.cshtml"
           Write(veiculo.VehicleTypeId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 28 "C:\DSV\CarglassTelaVeiculos\Carglass.TI\Carglass.TI.UI\Views\Veiculos\Index.cshtml"
           Write(veiculo.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 29 "C:\DSV\CarglassTelaVeiculos\Carglass.TI\Carglass.TI.UI\Views\Veiculos\Index.cshtml"
           Write(veiculo.Active);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 30 "C:\DSV\CarglassTelaVeiculos\Carglass.TI\Carglass.TI.UI\Views\Veiculos\Index.cshtml"
           Write(veiculo.VehicleCode);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 31 "C:\DSV\CarglassTelaVeiculos\Carglass.TI\Carglass.TI.UI\Views\Veiculos\Index.cshtml"
           Write(veiculo.Marca.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>\r\n                <a class=\"btn btn-outline-success btn-sm\"");
            BeginWriteAttribute("href", " href=\"", 939, "\"", 982, 2);
            WriteAttributeValue("", 946, "/Veiculos/AddEdit/", 946, 18, true);
#nullable restore
#line 33 "C:\DSV\CarglassTelaVeiculos\Carglass.TI\Carglass.TI.UI\Views\Veiculos\Index.cshtml"
WriteAttributeValue("", 964, veiculo.VehicleId, 964, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Editar</a>\r\n                <button class=\"btn btn-outline-danger btn-sm\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1057, "\"", 1111, 6);
            WriteAttributeValue("", 1067, "excluir(", 1067, 8, true);
#nullable restore
#line 34 "C:\DSV\CarglassTelaVeiculos\Carglass.TI\Carglass.TI.UI\Views\Veiculos\Index.cshtml"
WriteAttributeValue("", 1075, veiculo.VehicleId, 1075, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1093, ",", 1093, 1, true);
            WriteAttributeValue(" ", 1094, "\'", 1095, 2, true);
#nullable restore
#line 34 "C:\DSV\CarglassTelaVeiculos\Carglass.TI\Carglass.TI.UI\Views\Veiculos\Index.cshtml"
WriteAttributeValue("", 1096, veiculo.Name, 1096, 13, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1109, "\')", 1109, 2, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                    Excluir\r\n                </button>\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 39 "C:\DSV\CarglassTelaVeiculos\Carglass.TI\Carglass.TI.UI\Views\Veiculos\Index.cshtml"

        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    </tbody>
</table>



<!-- Modal -->
<div class=""modal fade"" id=""excluirVeiculo"">
    <div class=""modal-dialog"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"" id=""exampleModalLabel"">Excluir Veiculo</h5>
                <button type=""button"" class=""btn-close"" data-bs-dismiss=""modal"" aria-label=""Close""></button>
            </div>
            <div class=""modal-body"">
                Tem certeza que quer excluir o veiculo <strong><span id=""veiculo-name""></span></strong>?
            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-secondary"" data-bs-dismiss=""modal"">Fechar</button>
                <button type=""button"" class=""btn btn-danger"" onclick=""confirmar()"">Confirmar</button>
            </div>
        </div>
    </div>
</div>


");
            DefineSection("scripts", async() => {
                WriteLiteral(@"
    <script>
        let myModal = new bootstrap.Modal(document.getElementById('excluirVeiculo'), {
            keyboard: false
        });
        let _id = 0;
        function excluir(id, nome) {
            _id = id;
            document.querySelector(""#veiculo-name"").innerHTML = `<em>""${name}""</em>`;
            myModal.show();
        }

        function confirmar() {

            fetch('/veiculo/delete/' + _id, { method: 'Delete' })
                .then(function (x) {
                    console.log(x);
                    myModal.hide();
                    switch (x.status) {
                        case 200:
                            document.getElementById('item-' + _id).remove();
                            toastr.success('Veículo excluído com sucesso', 'Excluir Veículo');
                            break;
                        case 400:
                            console.log(xhr)
                            toastr.error(x.responseText, 'Excluir Veiculo');
        ");
                WriteLiteral("                    break;\r\n                        default:\r\n                            toastr.error(\'Não foi possível excluir o veículo.<br>Verifique o log da aplicação.\', \'Excluir Veículo\');\r\n                    }});\r\n            }\r\n    </script>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Veiculo>> Html { get; private set; }
    }
}
#pragma warning restore 1591
