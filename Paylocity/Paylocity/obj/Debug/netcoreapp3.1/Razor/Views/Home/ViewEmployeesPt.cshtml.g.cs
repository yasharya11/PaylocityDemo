#pragma checksum "C:\Users\yasha\Desktop\Code\2020\Paylocity\PaylocityDemo\Paylocity\Paylocity\Views\Home\ViewEmployeesPt.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9ac5b0fc97201fa0178477417bbdbfe1136a43e6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ViewEmployeesPt), @"mvc.1.0.view", @"/Views/Home/ViewEmployeesPt.cshtml")]
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
#line 1 "C:\Users\yasha\Desktop\Code\2020\Paylocity\PaylocityDemo\Paylocity\Paylocity\Views\_ViewImports.cshtml"
using Paylocity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\yasha\Desktop\Code\2020\Paylocity\PaylocityDemo\Paylocity\Paylocity\Views\_ViewImports.cshtml"
using Paylocity.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9ac5b0fc97201fa0178477417bbdbfe1136a43e6", @"/Views/Home/ViewEmployeesPt.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9e8b9218dfbb69d1acc29f982cd9c9b2be601539", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ViewEmployeesPt : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Paylocity.Models.PageModels.EmployeesPtPageModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", "~/js/site.js", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\yasha\Desktop\Code\2020\Paylocity\PaylocityDemo\Paylocity\Paylocity\Views\Home\ViewEmployeesPt.cshtml"
  
    Layout = "";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<br />
<hr />
<div>
    <h3>LIST OF EMPLOYEES</h3>
    <center>
        <table class=""table"" style=""text-align:center;"">
            <tr>
                <th>ID</th>
                <th>First Name</th>
                <th>Last Name</th>
                <th>Date of Birth</th>
            </tr>
");
#nullable restore
#line 18 "C:\Users\yasha\Desktop\Code\2020\Paylocity\PaylocityDemo\Paylocity\Paylocity\Views\Home\ViewEmployeesPt.cshtml"
             foreach (PaylocityCore.Entities.Employee emp in Model.Employees)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr class=\"clsEmployeeTr\">\r\n                    <td class=\"clsEmployeeIdTd\">");
#nullable restore
#line 21 "C:\Users\yasha\Desktop\Code\2020\Paylocity\PaylocityDemo\Paylocity\Paylocity\Views\Home\ViewEmployeesPt.cshtml"
                                           Write(emp.EmployeeId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 22 "C:\Users\yasha\Desktop\Code\2020\Paylocity\PaylocityDemo\Paylocity\Paylocity\Views\Home\ViewEmployeesPt.cshtml"
                   Write(emp.Fname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 23 "C:\Users\yasha\Desktop\Code\2020\Paylocity\PaylocityDemo\Paylocity\Paylocity\Views\Home\ViewEmployeesPt.cshtml"
                   Write(emp.Lname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 24 "C:\Users\yasha\Desktop\Code\2020\Paylocity\PaylocityDemo\Paylocity\Paylocity\Views\Home\ViewEmployeesPt.cshtml"
                   Write(emp.Dob);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                </tr>\r\n");
#nullable restore
#line 26 "C:\Users\yasha\Desktop\Code\2020\Paylocity\PaylocityDemo\Paylocity\Paylocity\Views\Home\ViewEmployeesPt.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </table>\r\n    </center>\r\n</div>\r\n<br />\r\n<br />\r\n\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9ac5b0fc97201fa0178477417bbdbfe1136a43e66165", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.Src = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 34 "C:\Users\yasha\Desktop\Code\2020\Paylocity\PaylocityDemo\Paylocity\Paylocity\Views\Home\ViewEmployeesPt.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion = true;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Paylocity.Models.PageModels.EmployeesPtPageModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
