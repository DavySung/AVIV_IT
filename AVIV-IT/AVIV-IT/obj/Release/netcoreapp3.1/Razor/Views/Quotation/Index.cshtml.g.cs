#pragma checksum "D:\Diploma\IntermediateC#\Assessment\AST2\AVI-IT\AVI-IT\Views\Quotation\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ddc1e8c64299dcb2e8a6a26837a438dafa596445"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Quotation_Index), @"mvc.1.0.view", @"/Views/Quotation/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ddc1e8c64299dcb2e8a6a26837a438dafa596445", @"/Views/Quotation/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4a67a43cf407f18f586d3ca6bf8b9f4eef577060", @"/Views/_ViewImports.cshtml")]
    public class Views_Quotation_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AVI_IT.Models.Quotation>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
            WriteLiteral(@"
    <div class=""container"">

        <div class=""row m-5"">
            <div class=""col-4"">
                <h2 style=""text-align:center;font-weight:bold"">Get A Quote</h2>
            </div>
            <div class=""col-8"">

            </div>
        </div>

        <div class=""row m-3"">
            <div class=""col-4"" style=""text-align:left"">
                ");
#nullable restore
#line 49 "D:\Diploma\IntermediateC#\Assessment\AST2\AVI-IT\AVI-IT\Views\Quotation\Index.cshtml"
           Write(Html.LabelFor(m => m.firstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n            <div class=\"col-8\">\r\n                ");
#nullable restore
#line 52 "D:\Diploma\IntermediateC#\Assessment\AST2\AVI-IT\AVI-IT\Views\Quotation\Index.cshtml"
           Write(Html.TextBoxFor(m => m.firstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"row m-3\">\r\n            <div class=\"col-4\" style=\"text-align:left\">\r\n                ");
#nullable restore
#line 58 "D:\Diploma\IntermediateC#\Assessment\AST2\AVI-IT\AVI-IT\Views\Quotation\Index.cshtml"
           Write(Html.LabelFor(m => m.lastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n            <div class=\"col-8\">\r\n                ");
#nullable restore
#line 61 "D:\Diploma\IntermediateC#\Assessment\AST2\AVI-IT\AVI-IT\Views\Quotation\Index.cshtml"
           Write(Html.TextBoxFor(m => m.lastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"row m-3\">\r\n            <div class=\"col-4\" style=\"text-align:left\">\r\n                ");
#nullable restore
#line 67 "D:\Diploma\IntermediateC#\Assessment\AST2\AVI-IT\AVI-IT\Views\Quotation\Index.cshtml"
           Write(Html.LabelFor(m => m.email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n            <div class=\"col-8\">\r\n                ");
#nullable restore
#line 70 "D:\Diploma\IntermediateC#\Assessment\AST2\AVI-IT\AVI-IT\Views\Quotation\Index.cshtml"
           Write(Html.TextBoxFor(m => m.email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"row m-3\">\r\n            <div class=\"col-4\" style=\"text-align:left\">\r\n                ");
#nullable restore
#line 76 "D:\Diploma\IntermediateC#\Assessment\AST2\AVI-IT\AVI-IT\Views\Quotation\Index.cshtml"
           Write(Html.LabelFor(m => m.phone));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n            <div class=\"col-8\">\r\n                ");
#nullable restore
#line 79 "D:\Diploma\IntermediateC#\Assessment\AST2\AVI-IT\AVI-IT\Views\Quotation\Index.cshtml"
           Write(Html.TextBoxFor(m => m.phone));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"row m-3\">\r\n            <div class=\"col-4\" style=\"text-align:left\">\r\n                ");
#nullable restore
#line 85 "D:\Diploma\IntermediateC#\Assessment\AST2\AVI-IT\AVI-IT\Views\Quotation\Index.cshtml"
           Write(Html.LabelFor(m => m.description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n            <div class=\"col-8\">\r\n                ");
#nullable restore
#line 88 "D:\Diploma\IntermediateC#\Assessment\AST2\AVI-IT\AVI-IT\Views\Quotation\Index.cshtml"
           Write(Html.TextAreaFor(m => m.description));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
            </div>
        </div>

        <div class=""row m-3"">
            <div class=""col-4"">

            </div>

            <div class=""col-8"" style=""text-align:left"">
                <input class=""btn btn-primary"" type=""submit"" value=""Submit"">
            </div>

        </div>

    </div>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AVI_IT.Models.Quotation> Html { get; private set; }
    }
}
#pragma warning restore 1591
