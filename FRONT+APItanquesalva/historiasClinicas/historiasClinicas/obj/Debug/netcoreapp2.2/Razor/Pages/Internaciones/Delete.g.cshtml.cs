#pragma checksum "C:\Users\salva\source\repos\historiasClinicas\historiasClinicas\Pages\Internaciones\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "afdffd1965a0012ce7d3bc9aa2b8103668ddedc4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(historiasClinicas.Pages.Internaciones.Pages_Internaciones_Delete), @"mvc.1.0.razor-page", @"/Pages/Internaciones/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Internaciones/Delete.cshtml", typeof(historiasClinicas.Pages.Internaciones.Pages_Internaciones_Delete), null)]
namespace historiasClinicas.Pages.Internaciones
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\salva\source\repos\historiasClinicas\historiasClinicas\Pages\_ViewImports.cshtml"
using historiasClinicas;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"afdffd1965a0012ce7d3bc9aa2b8103668ddedc4", @"/Pages/Internaciones/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3cd91ba32b709e3d93203c3b33815e1525f7223f", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Internaciones_Delete : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(65, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\salva\source\repos\historiasClinicas\historiasClinicas\Pages\Internaciones\Delete.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
            BeginContext(109, 184, true);
            WriteLiteral("\r\n<h1>Delete</h1>\r\n\r\n<h3>Are you sure you want to delete this?</h3>\r\n<div>\r\n    <h4>InternacPaciente</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(294, 66, false);
#line 16 "C:\Users\salva\source\repos\historiasClinicas\historiasClinicas\Pages\Internaciones\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.InternacPaciente.Id_expediente));

#line default
#line hidden
            EndContext();
            BeginContext(360, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(422, 62, false);
#line 19 "C:\Users\salva\source\repos\historiasClinicas\historiasClinicas\Pages\Internaciones\Delete.cshtml"
       Write(Html.DisplayFor(model => model.InternacPaciente.Id_expediente));

#line default
#line hidden
            EndContext();
            BeginContext(484, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(545, 64, false);
#line 22 "C:\Users\salva\source\repos\historiasClinicas\historiasClinicas\Pages\Internaciones\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.InternacPaciente.Id_personal));

#line default
#line hidden
            EndContext();
            BeginContext(609, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(671, 60, false);
#line 25 "C:\Users\salva\source\repos\historiasClinicas\historiasClinicas\Pages\Internaciones\Delete.cshtml"
       Write(Html.DisplayFor(model => model.InternacPaciente.Id_personal));

#line default
#line hidden
            EndContext();
            BeginContext(731, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(792, 66, false);
#line 28 "C:\Users\salva\source\repos\historiasClinicas\historiasClinicas\Pages\Internaciones\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.InternacPaciente.Fecha_ingreso));

#line default
#line hidden
            EndContext();
            BeginContext(858, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(920, 62, false);
#line 31 "C:\Users\salva\source\repos\historiasClinicas\historiasClinicas\Pages\Internaciones\Delete.cshtml"
       Write(Html.DisplayFor(model => model.InternacPaciente.Fecha_ingreso));

#line default
#line hidden
            EndContext();
            BeginContext(982, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1043, 68, false);
#line 34 "C:\Users\salva\source\repos\historiasClinicas\historiasClinicas\Pages\Internaciones\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.InternacPaciente.Imp_diagnostica));

#line default
#line hidden
            EndContext();
            BeginContext(1111, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1173, 64, false);
#line 37 "C:\Users\salva\source\repos\historiasClinicas\historiasClinicas\Pages\Internaciones\Delete.cshtml"
       Write(Html.DisplayFor(model => model.InternacPaciente.Imp_diagnostica));

#line default
#line hidden
            EndContext();
            BeginContext(1237, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1298, 64, false);
#line 40 "C:\Users\salva\source\repos\historiasClinicas\historiasClinicas\Pages\Internaciones\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.InternacPaciente.Tratamiento));

#line default
#line hidden
            EndContext();
            BeginContext(1362, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1424, 60, false);
#line 43 "C:\Users\salva\source\repos\historiasClinicas\historiasClinicas\Pages\Internaciones\Delete.cshtml"
       Write(Html.DisplayFor(model => model.InternacPaciente.Tratamiento));

#line default
#line hidden
            EndContext();
            BeginContext(1484, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1545, 72, false);
#line 46 "C:\Users\salva\source\repos\historiasClinicas\historiasClinicas\Pages\Internaciones\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.InternacPaciente.HistoriaClinicaGral));

#line default
#line hidden
            EndContext();
            BeginContext(1617, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1679, 68, false);
#line 49 "C:\Users\salva\source\repos\historiasClinicas\historiasClinicas\Pages\Internaciones\Delete.cshtml"
       Write(Html.DisplayFor(model => model.InternacPaciente.HistoriaClinicaGral));

#line default
#line hidden
            EndContext();
            BeginContext(1747, 38, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n    \r\n    ");
            EndContext();
            BeginContext(1785, 229, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "afdffd1965a0012ce7d3bc9aa2b8103668ddedc410522", async() => {
                BeginContext(1805, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(1815, 65, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "afdffd1965a0012ce7d3bc9aa2b8103668ddedc410915", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 54 "C:\Users\salva\source\repos\historiasClinicas\historiasClinicas\Pages\Internaciones\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.InternacPaciente.Id_internacion);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1880, 83, true);
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Delete\" class=\"btn btn-danger\" /> |\r\n        ");
                EndContext();
                BeginContext(1963, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "afdffd1965a0012ce7d3bc9aa2b8103668ddedc412868", async() => {
                    BeginContext(1985, 12, true);
                    WriteLiteral("Back to List");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2001, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2014, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<historiasClinicas.Pages.Internaciones.DeleteModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<historiasClinicas.Pages.Internaciones.DeleteModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<historiasClinicas.Pages.Internaciones.DeleteModel>)PageContext?.ViewData;
        public historiasClinicas.Pages.Internaciones.DeleteModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591