#pragma checksum "C:\Users\gof\GerardoReanio\2019\dotnet\projects\bancoapp\BancoApp\Views\Sucursal\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b35aeda9d2b651ce2cccc4ad95aa35dc1bdb6337"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Sucursal_Index), @"mvc.1.0.view", @"/Views/Sucursal/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Sucursal/Index.cshtml", typeof(AspNetCore.Views_Sucursal_Index))]
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
#line 1 "C:\Users\gof\GerardoReanio\2019\dotnet\projects\bancoapp\BancoApp\Views\_ViewImports.cshtml"
using BancoApp;

#line default
#line hidden
#line 2 "C:\Users\gof\GerardoReanio\2019\dotnet\projects\bancoapp\BancoApp\Views\_ViewImports.cshtml"
using BancoApp.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b35aeda9d2b651ce2cccc4ad95aa35dc1bdb6337", @"/Views/Sucursal/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8ab561b750bf6c4ed561531bb036c78250a9b084", @"/Views/_ViewImports.cshtml")]
    public class Views_Sucursal_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<System.Data.DataTable>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\gof\GerardoReanio\2019\dotnet\projects\bancoapp\BancoApp\Views\Sucursal\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(71, 234, true);
            WriteLiteral("\r\n<table class=\"table table-responsive table-bordered table-striped\">\r\n    <tr>\r\n        <th>Nombre</th>\r\n        <th>Direccion</th>\r\n        <th>Fecha Registro</th>\r\n        <th>Banco</th>\r\n        <th>Operaciones</th>\r\n\r\n    </tr>\r\n");
            EndContext();
#line 15 "C:\Users\gof\GerardoReanio\2019\dotnet\projects\bancoapp\BancoApp\Views\Sucursal\Index.cshtml"
     for (int i = 0; i < Model.Rows.Count; i++)
    {

#line default
#line hidden
            BeginContext(361, 30, true);
            WriteLiteral("        <tr>\r\n            <td>");
            EndContext();
            BeginContext(392, 16, false);
#line 18 "C:\Users\gof\GerardoReanio\2019\dotnet\projects\bancoapp\BancoApp\Views\Sucursal\Index.cshtml"
           Write(Model.Rows[i][1]);

#line default
#line hidden
            EndContext();
            BeginContext(408, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(432, 16, false);
#line 19 "C:\Users\gof\GerardoReanio\2019\dotnet\projects\bancoapp\BancoApp\Views\Sucursal\Index.cshtml"
           Write(Model.Rows[i][2]);

#line default
#line hidden
            EndContext();
            BeginContext(448, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(472, 16, false);
#line 20 "C:\Users\gof\GerardoReanio\2019\dotnet\projects\bancoapp\BancoApp\Views\Sucursal\Index.cshtml"
           Write(Model.Rows[i][3]);

#line default
#line hidden
            EndContext();
            BeginContext(488, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(512, 16, false);
#line 21 "C:\Users\gof\GerardoReanio\2019\dotnet\projects\bancoapp\BancoApp\Views\Sucursal\Index.cshtml"
           Write(Model.Rows[i][4]);

#line default
#line hidden
            EndContext();
            BeginContext(528, 68, true);
            WriteLiteral("</td>\r\n            <!--\r\n            <td>\r\n                <a href=\"");
            EndContext();
            BeginContext(597, 59, false);
#line 24 "C:\Users\gof\GerardoReanio\2019\dotnet\projects\bancoapp\BancoApp\Views\Sucursal\Index.cshtml"
                    Write(Url.Action("Details", "Banco", new {@id=@Model.Rows[i][0]}));

#line default
#line hidden
            EndContext();
            BeginContext(656, 40, true);
            WriteLiteral("\">Detalle</a>\r\n                <a href=\"");
            EndContext();
            BeginContext(697, 56, false);
#line 25 "C:\Users\gof\GerardoReanio\2019\dotnet\projects\bancoapp\BancoApp\Views\Sucursal\Index.cshtml"
                    Write(Url.Action("Edit", "Banco", new {@id=@Model.Rows[i][0]}));

#line default
#line hidden
            EndContext();
            BeginContext(753, 39, true);
            WriteLiteral("\">Editar</a>\r\n                <a href=\"");
            EndContext();
            BeginContext(793, 58, false);
#line 26 "C:\Users\gof\GerardoReanio\2019\dotnet\projects\bancoapp\BancoApp\Views\Sucursal\Index.cshtml"
                    Write(Url.Action("Delete", "Banco", new {@id=@Model.Rows[i][0]}));

#line default
#line hidden
            EndContext();
            BeginContext(851, 70, true);
            WriteLiteral("\">Eliminar</a>\r\n            </td>\r\n             -->\r\n\r\n        </tr>\r\n");
            EndContext();
#line 31 "C:\Users\gof\GerardoReanio\2019\dotnet\projects\bancoapp\BancoApp\Views\Sucursal\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(928, 14, true);
            WriteLiteral("</table>\r\n\r\n<a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 942, "\"", 982, 1);
#line 34 "C:\Users\gof\GerardoReanio\2019\dotnet\projects\bancoapp\BancoApp\Views\Sucursal\Index.cshtml"
WriteAttributeValue("", 949, Url.Action("Create", "Sucursal"), 949, 33, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(983, 29, true);
            WriteLiteral(">Crear Nueva Sucursal</a>\r\n\r\n");
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
