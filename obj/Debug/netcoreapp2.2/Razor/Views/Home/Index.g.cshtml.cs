#pragma checksum "/home/flake/Desktop/Itrans/Task4/Views/Home/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8cabf9d3312ffeede096954c2bcc76c1a3db3a12"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "/home/flake/Desktop/Itrans/Task4/Views/_ViewImports.cshtml"
using Task4;

#line default
#line hidden
#line 2 "/home/flake/Desktop/Itrans/Task4/Views/_ViewImports.cshtml"
using Task4.Models;

#line default
#line hidden
#line 3 "/home/flake/Desktop/Itrans/Task4/Views/_ViewImports.cshtml"
using HtmlAgilityPack;

#line default
#line hidden
#line 4 "/home/flake/Desktop/Itrans/Task4/Views/_ViewImports.cshtml"
using System.Linq;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8cabf9d3312ffeede096954c2bcc76c1a3db3a12", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c6c3c20d8b4ec1e723adcbe93906d7e63e3e31ba", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IList<Table>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("card card-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "/home/flake/Desktop/Itrans/Task4/Views/Home/Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(66, 141, true);
            WriteLiteral(" <div class=\"container\">\r\n    <br/>\r\n\t<div class=\"row justify-content-center\">\r\n        <div class=\"col-12 col-md-10 col-lg-8\">\r\n            ");
            EndContext();
            BeginContext(207, 804, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8cabf9d3312ffeede096954c2bcc76c1a3db3a124049", async() => {
                BeginContext(234, 770, true);
                WriteLiteral(@"
                <div class=""card-body row no-gutters align-items-center"">
                    <div class=""col-auto"">
                        <i class=""fas fa-search h4 text-body""></i>
                    </div>
                    <!--end of col-->
                    <div class=""col"">
                        <input class=""form-control form-control-sm form-control-borderless"" name=""searchInput"" type=""search"" placeholder=""Search topics or keywords"">
                    </div>
                    <!--end of col-->
                    <div class=""col-auto"">
                        <button class=""btn btn-sm btn-success"" type=""submit"">Search</button>
                    </div>
                    <!--end of col-->
                </div>
            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1011, 76, true);
            WriteLiteral("\r\n        </div>\r\n        <!--end of col-->\r\n    </div>\r\n</div> -->\r\n<div>\r\n");
            EndContext();
#line 30 "/home/flake/Desktop/Itrans/Task4/Views/Home/Index.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
            BeginContext(1128, 12, true);
            WriteLiteral("        <tr>");
            EndContext();
            BeginContext(1141, 9, false);
#line 32 "/home/flake/Desktop/Itrans/Task4/Views/Home/Index.cshtml"
       Write(item.Href);

#line default
#line hidden
            EndContext();
            BeginContext(1150, 7, true);
            WriteLiteral("</tr>\r\n");
            EndContext();
#line 33 "/home/flake/Desktop/Itrans/Task4/Views/Home/Index.cshtml"
    }

#line default
#line hidden
            BeginContext(1164, 6, true);
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IList<Table>> Html { get; private set; }
    }
}
#pragma warning restore 1591
