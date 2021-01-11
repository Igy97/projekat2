#pragma checksum "E:\programi\dropbox\Dropbox\faks\master druga\c_taraba\projekat2\Projekat2\Views\Utility\AddCustomersOrCustomersDemographics.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "eeb1072fc89413352be1c764dbaa71c5e9067a58"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Utility_AddCustomersOrCustomersDemographics), @"mvc.1.0.view", @"/Views/Utility/AddCustomersOrCustomersDemographics.cshtml")]
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
#line 1 "E:\programi\dropbox\Dropbox\faks\master druga\c_taraba\projekat2\Projekat2\Views\_ViewImports.cshtml"
using Projekat2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\programi\dropbox\Dropbox\faks\master druga\c_taraba\projekat2\Projekat2\Views\_ViewImports.cshtml"
using Projekat2.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eeb1072fc89413352be1c764dbaa71c5e9067a58", @"/Views/Utility/AddCustomersOrCustomersDemographics.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d3754923b2fe0305e5c653d8deb858f09553371b", @"/Views/_ViewImports.cshtml")]
    public class Views_Utility_AddCustomersOrCustomersDemographics : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Projekat2.Models.CustomerAndCustomerDemographics>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "CreateCustomerPartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "E:\programi\dropbox\Dropbox\faks\master druga\c_taraba\projekat2\Projekat2\Views\Utility\AddCustomersOrCustomersDemographics.cshtml"
  
    ViewData["Title"] = "AddCustomersOrCustomersDemographics";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            DefineSection("Css", async() => {
                WriteLiteral("\r\n    <style>\r\n        #customerDemographics {\r\n            width: 100%;\r\n        }\r\n\r\n    </style>\r\n");
            }
            );
            WriteLiteral("\r\n");
            DefineSection("scripts", async() => {
                WriteLiteral(@"
    <script type=""text/javascript"">
        $(""#button1"").click(function () {
            $(""#collapse2"").removeClass(""show"");
        });
        $(""#button2"").click(function () {
            $(""#collapse1"").removeClass(""show"");
        });
    </script>
");
            }
            );
            WriteLiteral(@"
<h1>AddCustomersOrCustomersDemographics</h1>
<p>
    Here you can add more customer or customerDemographics type. First choose which type you want to add, then select the second type from dropDown list
    and fill the data in form. For example if you choosed customer type, you need to select one customerDemographics type value, and then fill the form for
    the customer. You can add more customers for the only one customerDemographics value.
</p>
<h1>
    Please choose which type you want to add: <br />
    <a class=""btn btn-primary"" id=""button1"" data-toggle=""collapse"" href=""#collapse1"" role=""button"" aria-expanded=""false"" aria-controls=""collapse1"">
        Customer
    </a>
    or
    <a class=""btn btn-primary"" id=""button2"" data-toggle=""collapse"" href=""#collapse2"" role=""button"" aria-expanded=""false"" aria-controls=""collapse2"">
        CustomerDemographics
    </a>
</h1>

<div class=""collapse"" id=""collapse1"">
    <div class=""card card-body"">

        <div class=""row"">
            <div c");
            WriteLiteral("lass=\"col-4\">\r\n                <h2>New Customer</h2>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "eeb1072fc89413352be1c764dbaa71c5e9067a585862", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 51 "E:\programi\dropbox\Dropbox\faks\master druga\c_taraba\projekat2\Projekat2\Views\Utility\AddCustomersOrCustomersDemographics.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model.customers);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("for", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 51 "E:\programi\dropbox\Dropbox\faks\master druga\c_taraba\projekat2\Projekat2\Views\Utility\AddCustomersOrCustomersDemographics.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.ViewData = ViewData;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("view-data", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.ViewData, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n            <div class=\"col-8\">\r\n                <div class=\"row\">\r\n                    <div class=\"col-12\">\r\n                        <h2>Select one customer demographics</h2>\r\n                        ");
#nullable restore
#line 57 "E:\programi\dropbox\Dropbox\faks\master druga\c_taraba\projekat2\Projekat2\Views\Utility\AddCustomersOrCustomersDemographics.cshtml"
                   Write(Html.DropDownListFor(x => x.customerDemographics, new SelectList(Model.customerDemographics, "CustomerTypeId", "CustomerDesc"), "Select First"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n\r\n\r\n    </div>\r\n</div>\r\n\r\n\r\n<div class=\"collapse\" id=\"collapse2\">\r\n    <div class=\"card card-body\">\r\n        Content2\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Projekat2.Models.CustomerAndCustomerDemographics> Html { get; private set; }
    }
}
#pragma warning restore 1591
