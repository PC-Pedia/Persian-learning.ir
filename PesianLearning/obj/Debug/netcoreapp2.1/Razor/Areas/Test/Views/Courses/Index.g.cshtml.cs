#pragma checksum "C:\Users\Mohamad Pc\Desktop\Persian_Learning\PesianLearning\Areas\Test\Views\Courses\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c2f798306a78208c9119f96d503e05b0a0795bef"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Test_Views_Courses_Index), @"mvc.1.0.view", @"/Areas/Test/Views/Courses/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Test/Views/Courses/Index.cshtml", typeof(AspNetCore.Areas_Test_Views_Courses_Index))]
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
#line 1 "C:\Users\Mohamad Pc\Desktop\Persian_Learning\PesianLearning\Areas\Test\Views\_ViewImports.cshtml"
using PesianLearning;

#line default
#line hidden
#line 2 "C:\Users\Mohamad Pc\Desktop\Persian_Learning\PesianLearning\Areas\Test\Views\_ViewImports.cshtml"
using ViewModel;

#line default
#line hidden
#line 3 "C:\Users\Mohamad Pc\Desktop\Persian_Learning\PesianLearning\Areas\Test\Views\_ViewImports.cshtml"
using Consts;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c2f798306a78208c9119f96d503e05b0a0795bef", @"/Areas/Test/Views/Courses/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4375e114b8bbfbee2553c12edf27eb599019f0ec", @"/Areas/Test/Views/_ViewImports.cshtml")]
    public class Areas_Test_Views_Courses_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Models.Course>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(35, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Mohamad Pc\Desktop\Persian_Learning\PesianLearning\Areas\Test\Views\Courses\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(78, 15, true);
            WriteLiteral("\r\n\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(93, 55, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "88fc794663bb4b958ee83b430140ece4", async() => {
                BeginContext(140, 4, true);
                WriteLiteral("جدید");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(148, 92, true);
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(241, 43, false);
#line 16 "C:\Users\Mohamad Pc\Desktop\Persian_Learning\PesianLearning\Areas\Test\Views\Courses\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.TitleFa));

#line default
#line hidden
            EndContext();
            BeginContext(284, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(340, 43, false);
#line 19 "C:\Users\Mohamad Pc\Desktop\Persian_Learning\PesianLearning\Areas\Test\Views\Courses\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.TitleEn));

#line default
#line hidden
            EndContext();
            BeginContext(383, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(439, 40, false);
#line 22 "C:\Users\Mohamad Pc\Desktop\Persian_Learning\PesianLearning\Areas\Test\Views\Courses\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Text));

#line default
#line hidden
            EndContext();
            BeginContext(479, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(535, 45, false);
#line 25 "C:\Users\Mohamad Pc\Desktop\Persian_Learning\PesianLearning\Areas\Test\Views\Courses\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.StartDate));

#line default
#line hidden
            EndContext();
            BeginContext(580, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(636, 43, false);
#line 28 "C:\Users\Mohamad Pc\Desktop\Persian_Learning\PesianLearning\Areas\Test\Views\Courses\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.EndDate));

#line default
#line hidden
            EndContext();
            BeginContext(679, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(735, 41, false);
#line 31 "C:\Users\Mohamad Pc\Desktop\Persian_Learning\PesianLearning\Areas\Test\Views\Courses\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Count));

#line default
#line hidden
            EndContext();
            BeginContext(776, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(832, 41, false);
#line 34 "C:\Users\Mohamad Pc\Desktop\Persian_Learning\PesianLearning\Areas\Test\Views\Courses\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Visit));

#line default
#line hidden
            EndContext();
            BeginContext(873, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(929, 44, false);
#line 37 "C:\Users\Mohamad Pc\Desktop\Persian_Learning\PesianLearning\Areas\Test\Views\Courses\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Category));

#line default
#line hidden
            EndContext();
            BeginContext(973, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1029, 48, false);
#line 40 "C:\Users\Mohamad Pc\Desktop\Persian_Learning\PesianLearning\Areas\Test\Views\Courses\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.CourseBefore));

#line default
#line hidden
            EndContext();
            BeginContext(1077, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1133, 46, false);
#line 43 "C:\Users\Mohamad Pc\Desktop\Persian_Learning\PesianLearning\Areas\Test\Views\Courses\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.CourseType));

#line default
#line hidden
            EndContext();
            BeginContext(1179, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1235, 47, false);
#line 46 "C:\Users\Mohamad Pc\Desktop\Persian_Learning\PesianLearning\Areas\Test\Views\Courses\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.CourseState));

#line default
#line hidden
            EndContext();
            BeginContext(1282, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1338, 45, false);
#line 49 "C:\Users\Mohamad Pc\Desktop\Persian_Learning\PesianLearning\Areas\Test\Views\Courses\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.professor));

#line default
#line hidden
            EndContext();
            BeginContext(1383, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 55 "C:\Users\Mohamad Pc\Desktop\Persian_Learning\PesianLearning\Areas\Test\Views\Courses\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(1501, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1550, 42, false);
#line 58 "C:\Users\Mohamad Pc\Desktop\Persian_Learning\PesianLearning\Areas\Test\Views\Courses\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.TitleFa));

#line default
#line hidden
            EndContext();
            BeginContext(1592, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1648, 42, false);
#line 61 "C:\Users\Mohamad Pc\Desktop\Persian_Learning\PesianLearning\Areas\Test\Views\Courses\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.TitleEn));

#line default
#line hidden
            EndContext();
            BeginContext(1690, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1746, 39, false);
#line 64 "C:\Users\Mohamad Pc\Desktop\Persian_Learning\PesianLearning\Areas\Test\Views\Courses\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Text));

#line default
#line hidden
            EndContext();
            BeginContext(1785, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1841, 44, false);
#line 67 "C:\Users\Mohamad Pc\Desktop\Persian_Learning\PesianLearning\Areas\Test\Views\Courses\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.StartDate));

#line default
#line hidden
            EndContext();
            BeginContext(1885, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1941, 42, false);
#line 70 "C:\Users\Mohamad Pc\Desktop\Persian_Learning\PesianLearning\Areas\Test\Views\Courses\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.EndDate));

#line default
#line hidden
            EndContext();
            BeginContext(1983, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2039, 40, false);
#line 73 "C:\Users\Mohamad Pc\Desktop\Persian_Learning\PesianLearning\Areas\Test\Views\Courses\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Count));

#line default
#line hidden
            EndContext();
            BeginContext(2079, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2135, 40, false);
#line 76 "C:\Users\Mohamad Pc\Desktop\Persian_Learning\PesianLearning\Areas\Test\Views\Courses\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Visit));

#line default
#line hidden
            EndContext();
            BeginContext(2175, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2231, 49, false);
#line 79 "C:\Users\Mohamad Pc\Desktop\Persian_Learning\PesianLearning\Areas\Test\Views\Courses\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Category.Title));

#line default
#line hidden
            EndContext();
            BeginContext(2280, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2336, 52, false);
#line 82 "C:\Users\Mohamad Pc\Desktop\Persian_Learning\PesianLearning\Areas\Test\Views\Courses\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.CourseBefore.Text));

#line default
#line hidden
            EndContext();
            BeginContext(2388, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2444, 51, false);
#line 85 "C:\Users\Mohamad Pc\Desktop\Persian_Learning\PesianLearning\Areas\Test\Views\Courses\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.CourseType.Title));

#line default
#line hidden
            EndContext();
            BeginContext(2495, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2551, 52, false);
#line 88 "C:\Users\Mohamad Pc\Desktop\Persian_Learning\PesianLearning\Areas\Test\Views\Courses\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.CourseState.Title));

#line default
#line hidden
            EndContext();
            BeginContext(2603, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2659, 53, false);
#line 91 "C:\Users\Mohamad Pc\Desktop\Persian_Learning\PesianLearning\Areas\Test\Views\Courses\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.professor.Evidence));

#line default
#line hidden
            EndContext();
            BeginContext(2712, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2767, 53, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a14120f00a2f42248a53f84a42721aa3", async() => {
                BeginContext(2812, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 94 "C:\Users\Mohamad Pc\Desktop\Persian_Learning\PesianLearning\Areas\Test\Views\Courses\Index.cshtml"
                                       WriteLiteral(item.ID);

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
            BeginContext(2820, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(2840, 59, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ec501a49b2a34bd193a62420a204cdd6", async() => {
                BeginContext(2888, 7, true);
                WriteLiteral("Details");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 95 "C:\Users\Mohamad Pc\Desktop\Persian_Learning\PesianLearning\Areas\Test\Views\Courses\Index.cshtml"
                                          WriteLiteral(item.ID);

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
            BeginContext(2899, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(2919, 57, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ce5431601044410f858ce799e9f81199", async() => {
                BeginContext(2966, 6, true);
                WriteLiteral("Delete");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 96 "C:\Users\Mohamad Pc\Desktop\Persian_Learning\PesianLearning\Areas\Test\Views\Courses\Index.cshtml"
                                         WriteLiteral(item.ID);

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
            BeginContext(2976, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 99 "C:\Users\Mohamad Pc\Desktop\Persian_Learning\PesianLearning\Areas\Test\Views\Courses\Index.cshtml"
}

#line default
#line hidden
            BeginContext(3015, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Models.Course>> Html { get; private set; }
    }
}
#pragma warning restore 1591
