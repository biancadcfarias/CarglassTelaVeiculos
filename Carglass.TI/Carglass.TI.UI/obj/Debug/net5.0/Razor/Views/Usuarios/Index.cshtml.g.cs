#pragma checksum "C:\Iago_Carglass\Carglass.TI\Carglass.TI.UI\Views\Usuarios\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7cd5402007ef1e73bee1471a731d8f8f03d0e543"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Usuarios_Index), @"mvc.1.0.view", @"/Views/Usuarios/Index.cshtml")]
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
#line 1 "C:\Iago_Carglass\Carglass.TI\Carglass.TI.UI\Views\_ViewImports.cshtml"
using Carglass.TI.Domain.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Iago_Carglass\Carglass.TI\Carglass.TI.UI\Views\_ViewImports.cshtml"
using Carglass.TI.UI.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7cd5402007ef1e73bee1471a731d8f8f03d0e543", @"/Views/Usuarios/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"15a8a72acd468466e6bd9380dc39b91dd82bdb83", @"/Views/_ViewImports.cshtml")]
    public class Views_Usuarios_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Usuario>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h2>Listagem de Usuários</h2>\r\n<div>\r\n    <a class=\"btn btn-outline-secondary\"");
            BeginWriteAttribute("href", " href=\"", 107, "\"", 147, 1);
#nullable restore
#line 4 "C:\Iago_Carglass\Carglass.TI\Carglass.TI.UI\Views\Usuarios\Index.cshtml"
WriteAttributeValue("", 114, Url.Action("AddEdit","Usuarios"), 114, 33, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">Adicionar</a>
</div>


<table class=""table  table-striped"">
    <thead class=""table-dark"">
        <tr>
            <th>Nome</th>
            <th>Email</th>
            <th>Gênero</th>
            <th colspan=""2"">Perfis</th>
        </tr>
    </thead>

    <tbody>
");
#nullable restore
#line 19 "C:\Iago_Carglass\Carglass.TI\Carglass.TI.UI\Views\Usuarios\Index.cshtml"
         foreach (var usuario in Model)
        {


#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr");
            BeginWriteAttribute("id", " id=\"", 494, "\"", 515, 2);
            WriteAttributeValue("", 499, "item-", 499, 5, true);
#nullable restore
#line 22 "C:\Iago_Carglass\Carglass.TI\Carglass.TI.UI\Views\Usuarios\Index.cshtml"
WriteAttributeValue("", 504, usuario.Id, 504, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n            <td>");
#nullable restore
#line 23 "C:\Iago_Carglass\Carglass.TI\Carglass.TI.UI\Views\Usuarios\Index.cshtml"
           Write(usuario.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 24 "C:\Iago_Carglass\Carglass.TI\Carglass.TI.UI\Views\Usuarios\Index.cshtml"
           Write(usuario.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 25 "C:\Iago_Carglass\Carglass.TI\Carglass.TI.UI\Views\Usuarios\Index.cshtml"
           Write(usuario.Genero);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>\r\n");
            WriteLiteral("            </td>\r\n            <td>\r\n                <a class=\"btn btn-outline-success btn-sm\"");
            BeginWriteAttribute("href", " href=\"", 811, "\"", 863, 3);
#nullable restore
#line 30 "C:\Iago_Carglass\Carglass.TI\Carglass.TI.UI\Views\Usuarios\Index.cshtml"
WriteAttributeValue("", 818, Url.Action("AddEdit","Usuarios"), 818, 33, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 851, "/", 851, 1, true);
#nullable restore
#line 30 "C:\Iago_Carglass\Carglass.TI\Carglass.TI.UI\Views\Usuarios\Index.cshtml"
WriteAttributeValue("", 852, usuario.Id, 852, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Editar</a>\r\n                <button class=\"btn btn-outline-danger btn-sm\"");
            BeginWriteAttribute("onclick", " onclick=\"", 938, "\"", 985, 6);
            WriteAttributeValue("", 948, "excluir(", 948, 8, true);
#nullable restore
#line 31 "C:\Iago_Carglass\Carglass.TI\Carglass.TI.UI\Views\Usuarios\Index.cshtml"
WriteAttributeValue("", 956, usuario.Id, 956, 11, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 967, ",", 967, 1, true);
            WriteAttributeValue(" ", 968, "\'", 969, 2, true);
#nullable restore
#line 31 "C:\Iago_Carglass\Carglass.TI\Carglass.TI.UI\Views\Usuarios\Index.cshtml"
WriteAttributeValue("", 970, usuario.Nome, 970, 13, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 983, "\')", 983, 2, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                    Excluir\r\n                </button>\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 36 "C:\Iago_Carglass\Carglass.TI\Carglass.TI.UI\Views\Usuarios\Index.cshtml"

        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Usuario>> Html { get; private set; }
    }
}
#pragma warning restore 1591
