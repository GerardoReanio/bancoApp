#pragma checksum "/Users/GerardoReanio/Desktop/projects/projectcsharp/bancoapp/BancoApp/Views/Banco/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "056f28c2ce4ea467a9ee8ea6638d5d27513a762b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Banco_Index), @"mvc.1.0.view", @"/Views/Banco/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Banco/Index.cshtml", typeof(AspNetCore.Views_Banco_Index))]
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
#line 1 "/Users/GerardoReanio/Desktop/projects/projectcsharp/bancoapp/BancoApp/Views/_ViewImports.cshtml"
using BancoApp;

#line default
#line hidden
#line 2 "/Users/GerardoReanio/Desktop/projects/projectcsharp/bancoapp/BancoApp/Views/_ViewImports.cshtml"
using BancoApp.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"056f28c2ce4ea467a9ee8ea6638d5d27513a762b", @"/Views/Banco/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1745f9603ca517504f3fce93fe93abc7f042e54a", @"/Views/_ViewImports.cshtml")]
    public class Views_Banco_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<System.Data.DataTable>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "/Users/GerardoReanio/Desktop/projects/projectcsharp/bancoapp/BancoApp/Views/Banco/Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(67, 202, true);
            WriteLiteral("\n<table class=\"table table-responsive table-bordered table-striped\" >\n    <tr>\n        <th>Nombre</th>\n        <th>Direccion</th>\n        <th>Fecha Registro</th>\n        <th>Operaciones</th>\n\n    </tr>\n");
            EndContext();
#line 14 "/Users/GerardoReanio/Desktop/projects/projectcsharp/bancoapp/BancoApp/Views/Banco/Index.cshtml"
     for (int i = 0; i < Model.Rows.Count; i++) {

#line default
#line hidden
            BeginContext(319, 21, true);
            WriteLiteral("    <tr>\n        <td>");
            EndContext();
            BeginContext(341, 16, false);
#line 16 "/Users/GerardoReanio/Desktop/projects/projectcsharp/bancoapp/BancoApp/Views/Banco/Index.cshtml"
       Write(Model.Rows[i][1]);

#line default
#line hidden
            EndContext();
            BeginContext(357, 18, true);
            WriteLiteral("</td>\n        <td>");
            EndContext();
            BeginContext(376, 16, false);
#line 17 "/Users/GerardoReanio/Desktop/projects/projectcsharp/bancoapp/BancoApp/Views/Banco/Index.cshtml"
       Write(Model.Rows[i][2]);

#line default
#line hidden
            EndContext();
            BeginContext(392, 18, true);
            WriteLiteral("</td>\n        <td>");
            EndContext();
            BeginContext(411, 16, false);
#line 18 "/Users/GerardoReanio/Desktop/projects/projectcsharp/bancoapp/BancoApp/Views/Banco/Index.cshtml"
       Write(Model.Rows[i][3]);

#line default
#line hidden
            EndContext();
            BeginContext(427, 33, true);
            WriteLiteral("</td>\n        <td>\n            <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 460, "\"", 527, 1);
#line 20 "/Users/GerardoReanio/Desktop/projects/projectcsharp/bancoapp/BancoApp/Views/Banco/Index.cshtml"
WriteAttributeValue("", 467, Url.Action("Details", "Banco", new {@id=@Model.Rows[i][0]}), 467, 60, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(528, 27, true);
            WriteLiteral(">Detalle</a>\n            <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 555, "\"", 619, 1);
#line 21 "/Users/GerardoReanio/Desktop/projects/projectcsharp/bancoapp/BancoApp/Views/Banco/Index.cshtml"
WriteAttributeValue("", 562, Url.Action("Edit", "Banco", new {@id=@Model.Rows[i][0]}), 562, 57, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(620, 26, true);
            WriteLiteral(">Editar</a>\n            <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 646, "\"", 712, 1);
#line 22 "/Users/GerardoReanio/Desktop/projects/projectcsharp/bancoapp/BancoApp/Views/Banco/Index.cshtml"
WriteAttributeValue("", 653, Url.Action("Delete", "Banco", new {@id=@Model.Rows[i][0]}), 653, 59, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(713, 38, true);
            WriteLiteral(">Eliminar</a>\n        </td>\n    </tr>\n");
            EndContext();
#line 25 "/Users/GerardoReanio/Desktop/projects/projectcsharp/bancoapp/BancoApp/Views/Banco/Index.cshtml"
    }

#line default
#line hidden
            BeginContext(757, 12, true);
            WriteLiteral("</table>\n\n<a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 769, "\"", 806, 1);
#line 28 "/Users/GerardoReanio/Desktop/projects/projectcsharp/bancoapp/BancoApp/Views/Banco/Index.cshtml"
WriteAttributeValue("", 776, Url.Action("Create", "Banco"), 776, 30, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(807, 23, true);
            WriteLiteral(">Crear Nuevo Banco</a>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<System.Data.DataTable> Html { get; private set; }
    }
}
#pragma warning restore 1591
