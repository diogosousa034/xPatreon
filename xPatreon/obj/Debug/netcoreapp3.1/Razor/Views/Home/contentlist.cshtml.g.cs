#pragma checksum "C:\Users\SwitchTechnology\Desktop\estagio\IntershipxPatreon\xPatreon\xPatreon\Views\Home\contentlist.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5ea3ca73ddb30b1e635dd9c22f50ce07133ca838"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_contentlist), @"mvc.1.0.view", @"/Views/Home/contentlist.cshtml")]
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
#line 1 "C:\Users\SwitchTechnology\Desktop\estagio\IntershipxPatreon\xPatreon\xPatreon\Views\_ViewImports.cshtml"
using xPatreon;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\SwitchTechnology\Desktop\estagio\IntershipxPatreon\xPatreon\xPatreon\Views\_ViewImports.cshtml"
using xPatreon.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5ea3ca73ddb30b1e635dd9c22f50ce07133ca838", @"/Views/Home/contentlist.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9cb676b9ee1f536932e6cbd1f94126be36150bbd", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_contentlist : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Services.Dto.CreateContentDto>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("rounded"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:70px; height:70px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\SwitchTechnology\Desktop\estagio\IntershipxPatreon\xPatreon\xPatreon\Views\Home\contentlist.cshtml"
  
    ViewData["Title"] = "Contentlist";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<style>
    .buttonDelete {
        border: none;
        outline: none;
        background-color: transparent;
    }

        .buttonDelete:hover, buttonDelete:focus {
            border: none;
            outline: none;
            background-color: transparent;
        }
</style>


<div class=""container mt-3"">
    <div class=""row"">
        <div class=""col-12"">
");
#nullable restore
#line 26 "C:\Users\SwitchTechnology\Desktop\estagio\IntershipxPatreon\xPatreon\xPatreon\Views\Home\contentlist.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"border rounded rounded-top rounded-left rounded-right mt-3\">\r\n                    <div class=\"d-flex\">\r\n                        <p class=\"pt-3 pl-3 w-100\">Edited at <span class=\"text-muted font-weight-bold\">");
#nullable restore
#line 30 "C:\Users\SwitchTechnology\Desktop\estagio\IntershipxPatreon\xPatreon\xPatreon\Views\Home\contentlist.cshtml"
                                                                                                  Write(item.PublicationData);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></p>\r\n");
#nullable restore
#line 31 "C:\Users\SwitchTechnology\Desktop\estagio\IntershipxPatreon\xPatreon\xPatreon\Views\Home\contentlist.cshtml"
                         if (item.Active == true)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <p class=\"pt-3 pr-3 font-weight-bold\">Active</p>\r\n");
#nullable restore
#line 34 "C:\Users\SwitchTechnology\Desktop\estagio\IntershipxPatreon\xPatreon\xPatreon\Views\Home\contentlist.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <p class=\"pt-3 pr-3 font-weight-bold\">Desactive</p>\r\n");
#nullable restore
#line 38 "C:\Users\SwitchTechnology\Desktop\estagio\IntershipxPatreon\xPatreon\xPatreon\Views\Home\contentlist.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </div>\r\n                    <div class=\"d-flex pl-3 pb-3\">\r\n                        <div class=\"bg-secondary rounded m-2\" style=\"width:70px; height:70px;\">\r\n");
#nullable restore
#line 42 "C:\Users\SwitchTechnology\Desktop\estagio\IntershipxPatreon\xPatreon\xPatreon\Views\Home\contentlist.cshtml"
                             if (item.Image != null)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <div class=\"bg-white\" style=\"width:70px; height:70px;\">\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "5ea3ca73ddb30b1e635dd9c22f50ce07133ca8387546", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1604, "~/images/", 1604, 9, true);
#nullable restore
#line 45 "C:\Users\SwitchTechnology\Desktop\estagio\IntershipxPatreon\xPatreon\xPatreon\Views\Home\contentlist.cshtml"
AddHtmlAttributeValue("", 1613, item.Image, 1613, 11, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                </div>\r\n");
#nullable restore
#line 47 "C:\Users\SwitchTechnology\Desktop\estagio\IntershipxPatreon\xPatreon\xPatreon\Views\Home\contentlist.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </div>\r\n                        <div class=\"p-2\">\r\n                            ");
#nullable restore
#line 50 "C:\Users\SwitchTechnology\Desktop\estagio\IntershipxPatreon\xPatreon\xPatreon\Views\Home\contentlist.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            <p class=\"pt-3\">");
#nullable restore
#line 51 "C:\Users\SwitchTechnology\Desktop\estagio\IntershipxPatreon\xPatreon\xPatreon\Views\Home\contentlist.cshtml"
                                       Write(Html.DisplayFor(modelItem => item.MainContent));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        </div>\r\n\r\n                    </div>\r\n                    <div class=\"border-top p-3 text-right\">\r\n\r\n                        <span");
            BeginWriteAttribute("id", "  id=\"", 2154, "\"", 2194, 2);
            WriteAttributeValue("", 2160, "confirmDeleteSpan_", 2160, 18, true);
#nullable restore
#line 57 "C:\Users\SwitchTechnology\Desktop\estagio\IntershipxPatreon\xPatreon\xPatreon\Views\Home\contentlist.cshtml"
WriteAttributeValue("", 2178, item.Content_ID, 2178, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"display:none;\">\r\n                            <a");
            BeginWriteAttribute("href", " href=\"", 2250, "\"", 2309, 2);
            WriteAttributeValue("", 2257, "/Home/Contentlist?ContentIdToDelete=", 2257, 36, true);
#nullable restore
#line 58 "C:\Users\SwitchTechnology\Desktop\estagio\IntershipxPatreon\xPatreon\xPatreon\Views\Home\contentlist.cshtml"
WriteAttributeValue("", 2293, item.Content_ID, 2293, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"pr-3\">Delete</a>\r\n                            <a href=\"#\" class=\"pr-3\"");
            BeginWriteAttribute("onclick", " onclick=\"", 2388, "\"", 2438, 4);
            WriteAttributeValue("", 2398, "ConfirmDelete(\'", 2398, 15, true);
#nullable restore
#line 59 "C:\Users\SwitchTechnology\Desktop\estagio\IntershipxPatreon\xPatreon\xPatreon\Views\Home\contentlist.cshtml"
WriteAttributeValue("", 2413, item.Content_ID, 2413, 16, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2429, "\',", 2429, 2, true);
            WriteAttributeValue(" ", 2431, "false)", 2432, 7, true);
            EndWriteAttribute();
            WriteLiteral(">Cancel</a>\r\n                        </span>\r\n\r\n                        <span");
            BeginWriteAttribute("id", " id=\"", 2516, "\"", 2544, 2);
            WriteAttributeValue("", 2521, "delete_", 2521, 7, true);
#nullable restore
#line 62 "C:\Users\SwitchTechnology\Desktop\estagio\IntershipxPatreon\xPatreon\xPatreon\Views\Home\contentlist.cshtml"
WriteAttributeValue("", 2528, item.Content_ID, 2528, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                            <a href=\"#\" class=\"pr-3\"");
            BeginWriteAttribute("onclick", " onclick=\"", 2600, "\"", 2649, 4);
            WriteAttributeValue("", 2610, "ConfirmDelete(\'", 2610, 15, true);
#nullable restore
#line 63 "C:\Users\SwitchTechnology\Desktop\estagio\IntershipxPatreon\xPatreon\xPatreon\Views\Home\contentlist.cshtml"
WriteAttributeValue("", 2625, item.Content_ID, 2625, 16, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2641, "\',", 2641, 2, true);
            WriteAttributeValue(" ", 2643, "true)", 2644, 6, true);
            EndWriteAttribute();
            WriteLiteral(">Delete</a>\r\n                        </span>\r\n\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 2724, "\"", 2796, 2);
            WriteAttributeValue("", 2731, "/Home/PostHistoryList?ContentIdSelectedToHistory=", 2731, 49, true);
#nullable restore
#line 66 "C:\Users\SwitchTechnology\Desktop\estagio\IntershipxPatreon\xPatreon\xPatreon\Views\Home\contentlist.cshtml"
WriteAttributeValue("", 2780, item.Content_ID, 2780, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"pr-3\">See History posts</a>\r\n");
#nullable restore
#line 67 "C:\Users\SwitchTechnology\Desktop\estagio\IntershipxPatreon\xPatreon\xPatreon\Views\Home\contentlist.cshtml"
                         if (@item.Image != null)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <a");
            BeginWriteAttribute("href", " href=\"", 2942, "\"", 3002, 2);
            WriteAttributeValue("", 2949, "/Home/CreateImageContent?EditContent=", 2949, 37, true);
#nullable restore
#line 69 "C:\Users\SwitchTechnology\Desktop\estagio\IntershipxPatreon\xPatreon\xPatreon\Views\Home\contentlist.cshtml"
WriteAttributeValue("", 2986, item.Content_ID, 2986, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Edit</a>\r\n");
#nullable restore
#line 70 "C:\Users\SwitchTechnology\Desktop\estagio\IntershipxPatreon\xPatreon\xPatreon\Views\Home\contentlist.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <a");
            BeginWriteAttribute("href", " href=\"", 3128, "\"", 3187, 2);
            WriteAttributeValue("", 3135, "/Home/CreateTextContent?EditContent=", 3135, 36, true);
#nullable restore
#line 73 "C:\Users\SwitchTechnology\Desktop\estagio\IntershipxPatreon\xPatreon\xPatreon\Views\Home\contentlist.cshtml"
WriteAttributeValue("", 3171, item.Content_ID, 3171, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Edit</a>\r\n");
#nullable restore
#line 74 "C:\Users\SwitchTechnology\Desktop\estagio\IntershipxPatreon\xPatreon\xPatreon\Views\Home\contentlist.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </div>\r\n\r\n                </div>\r\n");
#nullable restore
#line 78 "C:\Users\SwitchTechnology\Desktop\estagio\IntershipxPatreon\xPatreon\xPatreon\Views\Home\contentlist.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        </div>
    </div>
</div>


<script>
    function ConfirmDelete(uniqueId, isTrue){
        var DeleteSpan = 'delete_' + uniqueId;
        var confirmDelete = 'confirmDeleteSpan_' + uniqueId;

        if(isTrue){
            $('#' + DeleteSpan).hide();
            $('#' + confirmDelete).show();
        } else{
            $('#' + DeleteSpan).show();
            $('#' + confirmDelete).hide();
        }
    }
</script>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Services.Dto.CreateContentDto>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
