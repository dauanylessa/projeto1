#pragma checksum "/home/igor/Documentos/projeto1/Views/Clientes/Incluir.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c2a73e0209a4b061db6407145f67fc90b0986106"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Clientes_Incluir), @"mvc.1.0.view", @"/Views/Clientes/Incluir.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Clientes/Incluir.cshtml", typeof(AspNetCore.Views_Clientes_Incluir))]
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
#line 1 "/home/igor/Documentos/projeto1/Views/_ViewImports.cshtml"
using projeto1;

#line default
#line hidden
#line 2 "/home/igor/Documentos/projeto1/Views/_ViewImports.cshtml"
using projeto1.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c2a73e0209a4b061db6407145f67fc90b0986106", @"/Views/Clientes/Incluir.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9179c468abaaa3b9aaf8298cdd1a3299fdc67475", @"/Views/_ViewImports.cshtml")]
    public class Views_Clientes_Incluir : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/home/igor/Documentos/projeto1/Views/Clientes/Incluir.cshtml"
  

    ViewData["Title"] = "Página inicial de clientes";


#line default
#line hidden
            BeginContext(61, 92, true);
            WriteLiteral("\n<h2>Clientes incluir</h2>\n\n<p>Página do método incluir</p>\n\n<br/>\n<br/>\n\nCliente incluído: ");
            EndContext();
            BeginContext(154, 16, false);
#line 14 "/home/igor/Documentos/projeto1/Views/Clientes/Incluir.cshtml"
             Write(ViewData["nome"]);

#line default
#line hidden
            EndContext();
            BeginContext(170, 11, true);
            WriteLiteral("\n\n<br/>\n\n\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
