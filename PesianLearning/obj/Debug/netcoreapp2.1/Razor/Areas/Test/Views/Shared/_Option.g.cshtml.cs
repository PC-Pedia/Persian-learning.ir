#pragma checksum "E:\Persian_Learning\PesianLearning\Areas\Test\Views\Shared\_Option.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6cf3d3b5567405e2ade7e8580dd1356d7ce9c55a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Test_Views_Shared__Option), @"mvc.1.0.view", @"/Areas/Test/Views/Shared/_Option.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Test/Views/Shared/_Option.cshtml", typeof(AspNetCore.Areas_Test_Views_Shared__Option))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6cf3d3b5567405e2ade7e8580dd1356d7ce9c55a", @"/Areas/Test/Views/Shared/_Option.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4375e114b8bbfbee2553c12edf27eb599019f0ec", @"/Areas/Test/Views/_ViewImports.cshtml")]
    public class Areas_Test_Views_Shared__Option : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<VmOption>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(30, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "E:\Persian_Learning\PesianLearning\Areas\Test\Views\Shared\_Option.cshtml"
  
    Layout = null;

#line default
#line hidden
            BeginContext(59, 2389, true);
            WriteLiteral(@"
<style>
    td {
        padding: 4px !important;
    }
    /* Style the tab */
    .tab {
        overflow: hidden;
        border: 1px solid #ccc;
        background-color: #fff;
    }

        /* Style the buttons inside the tab */
        .tab button {
            width: 25%;
            background-color: inherit;
            float: left;
            border: none;
            outline: none;
            cursor: pointer;
            padding: 14px 16px;
            transition: 0.3s;
            font-size: 17px;
        }

            /* Change background color of buttons on hover */
            .tab button:hover {
                background-color: #ddd;
            }

            /* Create an active/current tablink class */
            .tab button.active {
                background-color: #ccc;
            }

    /* Style the tab content */
    .tabcontent {
        display: none;
        padding: 6px 12px;
        border: 1px solid #ccc;
        border-top: none;
 ");
            WriteLiteral(@"   }

    .tablinks {
        float: right !important;
    }

    th, tr {
        text-align: center;
    }

    .red {
        background-color: red !important;
    }

    .slideup, .slidedown {
        max-height: 0;
        overflow-y: hidden;
        -webkit-transition: max-height .5s ease-in-out;
        -moz-transition: max-height .5s ease-in-out;
        -o-transition: max-height .5s ease-in-out;
        transition: max-height .5s ease-in-out;
    }

    .slidedown {
        max-height: 2000px;
    }

    .img-deactive {
        background-image: url(""/dashboard/img/arrow/down-arrow.png"");
        height: 40px !important;
        width: 40px !important;
        float: left !important;
        background-repeat: no-repeat;
    }

    .img-active {
        background-image: url(""/dashboard/img/arrow/up-arrow.png"");
        height: 40px !important;
        width: 40px !important;
        float: left !important;
        background-repeat: no-repeat;
    }
    .car");
            WriteLiteral(@"d-content{
        padding:8px 20px !important;
    }
</style>

<div class=""card"">
    <div class=""card-header"" data-background-color=""red"">
        <h4 class=""title"">
            رنگ
            <i style=""float:left"" class=""material-icons"">palette</i>
        </h4>
        <p class=""category"">
            تعداد :
            ");
            EndContext();
            BeginContext(2449, 13, false);
#line 102 "E:\Persian_Learning\PesianLearning\Areas\Test\Views\Shared\_Option.cshtml"
       Write(Model.Count());

#line default
#line hidden
            EndContext();
            BeginContext(2462, 510, true);
            WriteLiteral(@"
            <button id=""show-create"" class=""btn btn-sm btn-danger"">جدید</button>
            <div id=""show-table"" style=""width: 73% !important;position: absolute;text-align: left;""
                 class=""img-deactive ""></div>
        </p>

    </div>
    <div id=""table"" class=""card-content table-responsive slideup"">
        <table class=""table"" style=""text-align:center !important"">
            <thead class=""text-primary"">
                <tr>
                    <th>
                        ");
            EndContext();
            BeginContext(2973, 58, false);
#line 114 "E:\Persian_Learning\PesianLearning\Areas\Test\Views\Shared\_Option.cshtml"
                   Write(Html.DisplayNameFor(model => model.FirstOrDefault().Title));

#line default
#line hidden
            EndContext();
            BeginContext(3031, 126, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th></th>\r\n                </tr>\r\n            </thead>\r\n            <tbody>\r\n");
            EndContext();
#line 120 "E:\Persian_Learning\PesianLearning\Areas\Test\Views\Shared\_Option.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
            BeginContext(3222, 84, true);
            WriteLiteral("                    <tr>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(3307, 40, false);
#line 124 "E:\Persian_Learning\PesianLearning\Areas\Test\Views\Shared\_Option.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Title));

#line default
#line hidden
            EndContext();
            BeginContext(3347, 280, true);
            WriteLiteral(@"
                        </td>
                        <td>
                            <button type=""button"" rel=""tooltip"" title=""""
                                    class=""btn btn-primary btn-simple btn-xs""
                                    data-original-title=""ویرایش""");
            EndContext();
            BeginWriteAttribute("onclick", "\r\n                                    onclick=\"", 3627, "\"", 3746, 3);
            WriteAttributeValue("", 3674, "location.href=\'", 3674, 15, true);
#line 130 "E:\Persian_Learning\PesianLearning\Areas\Test\Views\Shared\_Option.cshtml"
WriteAttributeValue("", 3689, Url.Action("EditColor", "Option", new { id = item.ID }), 3689, 56, false);

#line default
#line hidden
            WriteAttributeValue("", 3745, "\'", 3745, 1, true);
            EndWriteAttribute();
            BeginContext(3747, 453, true);
            WriteLiteral(@">
                                <i class=""material-icons"">edit</i>
                                <div class=""ripple-container""></div>
                            </button>
                            <button type=""button"" rel=""tooltip"" title=""""
                                    class=""btn btn-primary btn-simple btn-xs delete-color""
                                    data-original-title=""حذف""
                                    data-us=");
            EndContext();
            BeginContext(4201, 7, false);
#line 137 "E:\Persian_Learning\PesianLearning\Areas\Test\Views\Shared\_Option.cshtml"
                                       Write(item.ID);

#line default
#line hidden
            EndContext();
            BeginContext(4208, 240, true);
            WriteLiteral(">\r\n                                <i class=\"material-icons\">delete</i>\r\n                                <div class=\"ripple-container\"></div>\r\n                            </button>\r\n                        </td>\r\n                    </tr>\r\n");
            EndContext();
#line 143 "E:\Persian_Learning\PesianLearning\Areas\Test\Views\Shared\_Option.cshtml"
                }

#line default
#line hidden
            BeginContext(4467, 147, true);
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n    <div id=\"create\" class=\"card-content table-responsive slideup\">\r\n\r\n    </div>\r\n</div>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<VmOption>> Html { get; private set; }
    }
}
#pragma warning restore 1591
