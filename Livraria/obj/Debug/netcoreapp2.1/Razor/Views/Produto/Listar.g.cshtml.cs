#pragma checksum "C:\Users\caroline.afsouza\CSharp\POO\Livraria\Views\Produto\Listar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b58dd0c248cb8b618e9359c5c2688ba939e6a995"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Produto_Listar), @"mvc.1.0.view", @"/Views/Produto/Listar.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Produto/Listar.cshtml", typeof(AspNetCore.Views_Produto_Listar))]
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
#line 7 "C:\Users\caroline.afsouza\CSharp\POO\Livraria\Views\Produto\Listar.cshtml"
using Livraria.Models.Domain;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b58dd0c248cb8b618e9359c5c2688ba939e6a995", @"/Views/Produto/Listar.cshtml")]
    public class Views_Produto_Listar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 213, true);
            WriteLiteral("<!--\r\n    A diretiva using foi utilizada para importar a camada Domain(dominio) com a Classe Cliente, pois essa será utilizada na contrução\r\n    da lista de clientes abaixo mo foreach(para cada)\r\n    \r\n    \r\n-->\r\n");
            EndContext();
            BeginContext(244, 12, true);
            WriteLiteral("<html>\r\n    ");
            EndContext();
            BeginContext(256, 1839, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c025680b54e04e6f9ccc28582796fe40", async() => {
                BeginContext(262, 1826, true);
                WriteLiteral(@"
        <title>Produtos Cadastrados</title>

        
       <link href=""https://fonts.googleapis.com/css?family=Boogaloo|Handlee|Luckiest+Guy|Rubik&display=swap"" rel=""stylesheet"">


        <script src=""https://kit.fontawesome.com/973d36562b.js""></script>


        <style>
            h1{
                text-align: center;
                font-family: Boogaloo;
                font-size: 15pt;
                border-bottom: 1px solid silver;
                padding-top:20px;
                padding-bottom: 20px;
            }
            table{
                width: 60%;
                margin-left:auto;
                margin-right:auto;
            }
            th{
                border-bottom: 1px solid silver;
                font-family: Boogaloo;
                font-size:15pt;
                padding: 5px;
            }
            td{
                padding: 5px;
                background-color:silver;
                font-family: Rubik; 
            }
      ");
                WriteLiteral(@"      tr:hover{
                background-color: red;
                color:white;
                cursor:pointer;
            }
            footer{
                background-color: rgba(255, 255, 255, );
                padding-top:20px;
                padding-bottom: 20px;
                text-align: center;
                font-family: Rubik;
                position: fixed;
                bottom: 0px;
                width: 100%;
            }
            a{
            margin:10px;
            text-decoration: none;
            font-family: Boogaloo;
            font-size:15pt;
            color:black;
            transition: ease .5s;
        }

        a:hover{
            margin-left: 15px;
            color:black;


        </style>






    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2095, 8, true);
            WriteLiteral("\r\n\r\n    ");
            EndContext();
            BeginContext(2103, 1240, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f6e62e1c714e435986fac4af6d0f60e1", async() => {
                BeginContext(2109, 77, true);
                WriteLiteral("\r\n\r\n        <header>\r\n            <h1>Clientes Cadastrados</h1>\r\n            ");
                EndContext();
                BeginContext(2187, 41, false);
#line 86 "C:\Users\caroline.afsouza\CSharp\POO\Livraria\Views\Produto\Listar.cshtml"
       Write(Html.ActionLink("Home","Index","Produto"));

#line default
#line hidden
                EndContext();
                BeginContext(2228, 392, true);
                WriteLiteral(@"
        </header>
        <main>

            <table>
                <tr>
                    <th>Nome</th>
                    <th>Descricao</th>
                    <th>Preco</th>
                    <th>Quantidade</th>
                    <th>Imagem</th>
                    <th>Atualizar</th>
                    <th>Apagar</th>
                </tr>

       
        
");
                EndContext();
#line 103 "C:\Users\caroline.afsouza\CSharp\POO\Livraria\Views\Produto\Listar.cshtml"
             foreach (var item in ViewData["Lista"] as IList<Produto>)
            {
                

#line default
#line hidden
                BeginContext(2725, 46, true);
                WriteLiteral("                <tr>\r\n                    <td>");
                EndContext();
                BeginContext(2772, 9, false);
#line 107 "C:\Users\caroline.afsouza\CSharp\POO\Livraria\Views\Produto\Listar.cshtml"
                   Write(item.Nome);

#line default
#line hidden
                EndContext();
                BeginContext(2781, 31, true);
                WriteLiteral("</td>\r\n                    <td>");
                EndContext();
                BeginContext(2813, 14, false);
#line 108 "C:\Users\caroline.afsouza\CSharp\POO\Livraria\Views\Produto\Listar.cshtml"
                   Write(item.Descricao);

#line default
#line hidden
                EndContext();
                BeginContext(2827, 31, true);
                WriteLiteral("</td>\r\n                    <td>");
                EndContext();
                BeginContext(2859, 10, false);
#line 109 "C:\Users\caroline.afsouza\CSharp\POO\Livraria\Views\Produto\Listar.cshtml"
                   Write(item.Preco);

#line default
#line hidden
                EndContext();
                BeginContext(2869, 31, true);
                WriteLiteral("</td>\r\n                    <td>");
                EndContext();
                BeginContext(2901, 15, false);
#line 110 "C:\Users\caroline.afsouza\CSharp\POO\Livraria\Views\Produto\Listar.cshtml"
                   Write(item.Quantidade);

#line default
#line hidden
                EndContext();
                BeginContext(2916, 31, true);
                WriteLiteral("</td>\r\n                    <td>");
                EndContext();
                BeginContext(2948, 11, false);
#line 111 "C:\Users\caroline.afsouza\CSharp\POO\Livraria\Views\Produto\Listar.cshtml"
                   Write(item.Imagem);

#line default
#line hidden
                EndContext();
                BeginContext(2959, 157, true);
                WriteLiteral("</td>\r\n                    <td> <i class=\"fas fa-sync-alt\"></i> </td>\r\n\r\n                    <td> <i class=\"fas fa-trash\"></i> </td>\r\n                </tr>\r\n");
                EndContext();
#line 116 "C:\Users\caroline.afsouza\CSharp\POO\Livraria\Views\Produto\Listar.cshtml"
                
            }

#line default
#line hidden
                BeginContext(3149, 187, true);
                WriteLiteral("\r\n            </table>\r\n\r\n         </main>\r\n\r\n         <footer>\r\n            <h3>© Copyright - Todos os direitos reservados - Por Caroline Souza</h3>\r\n         </footer>\r\n\r\n        \r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3343, 11, true);
            WriteLiteral("\r\n\r\n</html>");
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
