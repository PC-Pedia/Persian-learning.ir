#pragma checksum "E:\Persian_Learning\PesianLearning\Areas\Test\Views\Images\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "db01b7c456f1c9801f1fdb49ed570c5175089fca"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Test_Views_Images_Details), @"mvc.1.0.view", @"/Areas/Test/Views/Images/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Test/Views/Images/Details.cshtml", typeof(AspNetCore.Areas_Test_Views_Images_Details))]
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
#line 1 "E:\Persian_Learning\PesianLearning\Areas\Test\Views\_ViewImports.cshtml"
using PesianLearning;

#line default
#line hidden
#line 2 "E:\Persian_Learning\PesianLearning\Areas\Test\Views\_ViewImports.cshtml"
using ViewModel;

#line default
#line hidden
#line 3 "E:\Persian_Learning\PesianLearning\Areas\Test\Views\_ViewImports.cshtml"
using Consts;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"db01b7c456f1c9801f1fdb49ed570c5175089fca", @"/Areas/Test/Views/Images/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4375e114b8bbfbee2553c12edf27eb599019f0ec", @"/Areas/Test/Views/_ViewImports.cshtml")]
    public class Areas_Test_Views_Images_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Models.Image>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(21, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "E:\Persian_Learning\PesianLearning\Areas\Test\Views\Images\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(66, 103, true);
            WriteLiteral("\r\n\r\n\r\n<div>\r\n    <h4>Image</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(170, 44, false);
#line 14 "E:\Persian_Learning\PesianLearning\Areas\Test\Views\Images\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.FileName));

#line default
#line hidden
            EndContext();
            BeginContext(214, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(258, 40, false);
#line 17 "E:\Persian_Learning\PesianLearning\Areas\Test\Views\Images\Details.cshtml"
       Write(Html.DisplayFor(model => model.FileName));

#line default
#line hidden
            EndContext();
            BeginContext(298, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(342, 39, false);
#line 20 "E:\Persian_Learning\PesianLearning\Areas\Test\Views\Images\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Alt));

#line default
#line hidden
            EndContext();
            BeginContext(381, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(425, 35, false);
#line 23 "E:\Persian_Learning\PesianLearning\Areas\Test\Views\Images\Details.cshtml"
       Write(Html.DisplayFor(model => model.Alt));

#line default
#line hidden
            EndContext();
            BeginContext(460, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(504, 42, false);
#line 26 "E:\Persian_Learning\PesianLearning\Areas\Test\Views\Images\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Server));

#line default
#line hidden
            EndContext();
            BeginContext(546, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(590, 44, false);
#line 29 "E:\Persian_Learning\PesianLearning\Areas\Test\Views\Images\Details.cshtml"
       Write(Html.DisplayFor(model => model.Server.Title));

#line default
#line hidden
            EndContext();
            BeginContext(634, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(678, 42, false);
#line 32 "E:\Persian_Learning\PesianLearning\Areas\Test\Views\Images\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Course));

#line default
#line hidden
            EndContext();
            BeginContext(720, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(764, 43, false);
#line 35 "E:\Persian_Learning\PesianLearning\Areas\Test\Views\Images\Details.cshtml"
       Write(Html.DisplayFor(model => model.Course.Text));

#line default
#line hidden
            EndContext();
            BeginContext(807, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(851, 44, false);
#line 38 "E:\Persian_Learning\PesianLearning\Areas\Test\Views\Images\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Category));

#line default
#line hidden
            EndContext();
            BeginContext(895, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(939, 46, false);
#line 41 "E:\Persian_Learning\PesianLearning\Areas\Test\Views\Images\Details.cshtml"
       Write(Html.DisplayFor(model => model.Category.Title));

#line default
#line hidden
            EndContext();
            BeginContext(985, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1029, 51, false);
#line 44 "E:\Persian_Learning\PesianLearning\Areas\Test\Views\Images\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ApplicationUser));

#line default
#line hidden
            EndContext();
            BeginContext(1080, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1124, 50, false);
#line 47 "E:\Persian_Learning\PesianLearning\Areas\Test\Views\Images\Details.cshtml"
       Write(Html.DisplayFor(model => model.ApplicationUser.Id));

#line default
#line hidden
            EndContext();
            BeginContext(1174, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(1221, 56, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "35e62a451d8344e8b1fb61e8a4bb67cf", async() => {
                BeginContext(1267, 6, true);
                WriteLiteral("ویرایش");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 52 "E:\Persian_Learning\PesianLearning\Areas\Test\Views\Images\Details.cshtml"
                           WriteLiteral(Model.ID);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1277, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(1285, 55, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0144f8a543d64528be35c982004423c2", async() => {
                BeginContext(1330, 6, true);
                WriteLiteral("بازگشت");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1340, 10, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Models.Image> Html { get; private set; }
    }
}
#pragma warning restore 1591
