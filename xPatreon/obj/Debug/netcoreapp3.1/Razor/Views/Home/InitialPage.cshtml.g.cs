#pragma checksum "C:\Users\thek1\Desktop\estagio\xPatreon\xPatreon\Views\Home\InitialPage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "88542d43909795bdc640cd1c3ed38cc02486485c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_InitialPage), @"mvc.1.0.view", @"/Views/Home/InitialPage.cshtml")]
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
#line 1 "C:\Users\thek1\Desktop\estagio\xPatreon\xPatreon\Views\_ViewImports.cshtml"
using xPatreon;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\thek1\Desktop\estagio\xPatreon\xPatreon\Views\_ViewImports.cshtml"
using xPatreon.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"88542d43909795bdc640cd1c3ed38cc02486485c", @"/Views/Home/InitialPage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9cb676b9ee1f536932e6cbd1f94126be36150bbd", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_InitialPage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<DataBase.Page>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "InitialPage", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\thek1\Desktop\estagio\xPatreon\xPatreon\Views\Home\InitialPage.cshtml"
  
    ViewData["Title"] = "InitialPage";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"container\">\r\n    <div class=\"mt-4\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "88542d43909795bdc640cd1c3ed38cc02486485c4246", async() => {
                WriteLiteral(@"
            <div class=""d-flex"">
                <div class=""box mt-4 rounded-pill w-100"" style=""height:50px;"">
                    <svg width=""25"" height=""25"" style=""cursor:pointer;"" viewBox=""0 0 24 24"" xmlns=""http://www.w3.org/2000/svg"">
                        <path fill-rule=""evenodd"" clip-rule=""evenodd"" d=""M14.258 15.804a6.5 6.5 0 1 1 1.546-1.546l3.277 2.804c.404.344.835.712.906 1.238.06.448-.087.918-.43 1.258-.34.342-.81.49-1.257.429-.526-.07-.894-.502-1.238-.906l-2.804-3.277zM15.5 10.5a5 5 0 1 1-10 0 5 5 0 0 1 10 0z""></path>
                    </svg>

                    <input class=""searchbarinput"" type=""text"" style=""height:50px;"" placeholder=""Find a creator"" name=""pagename"" id=""searchInput"" />
                </div>
                <div class=""pl-4 mt-4"">
                    <input type=""submit"" class=""btn btn-danger btn-lg rounded-pill pl-4 pr-4"" style=""height:50px;"" name=""name"" value=""Search"" />
                </div>
            </div>
        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n    <div class=\"row pt-3\">\r\n");
#nullable restore
#line 26 "C:\Users\thek1\Desktop\estagio\xPatreon\xPatreon\Views\Home\InitialPage.cshtml"
         foreach (var item in Model)
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 28 "C:\Users\thek1\Desktop\estagio\xPatreon\xPatreon\Views\Home\InitialPage.cshtml"
             if (item != null)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col-md-3 mt-3\">\r\n                    <div class=\"card\">\r\n                        <img class=\"card-img-top\" width=\"250\" height=\"280\"");
            BeginWriteAttribute("src", " src=\"", 1533, "\"", 1557, 1);
#nullable restore
#line 32 "C:\Users\thek1\Desktop\estagio\xPatreon\xPatreon\Views\Home\InitialPage.cshtml"
WriteAttributeValue("", 1539, item.ProfileImage, 1539, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"Card image cap\">\r\n                        <div class=\"card-body border-top\" style=\"height:200px;\">\r\n                            <a");
            BeginWriteAttribute("href", " href=\"", 1694, "\"", 1747, 2);
            WriteAttributeValue("", 1701, "/Home/LaunchedPage?UserPageName=", 1701, 32, true);
#nullable restore
#line 34 "C:\Users\thek1\Desktop\estagio\xPatreon\xPatreon\Views\Home\InitialPage.cshtml"
WriteAttributeValue("", 1733, item.PageName, 1733, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"card-title h3\" style=\"color:black;\">");
#nullable restore
#line 34 "C:\Users\thek1\Desktop\estagio\xPatreon\xPatreon\Views\Home\InitialPage.cshtml"
                                                                                                                           Write(item.PageName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                            <p class=\"card-text\">Creating ");
#nullable restore
#line 35 "C:\Users\thek1\Desktop\estagio\xPatreon\xPatreon\Views\Home\InitialPage.cshtml"
                                                     Write(item.CreatingWhat);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                            <p class=\"card-text\">");
#nullable restore
#line 36 "C:\Users\thek1\Desktop\estagio\xPatreon\xPatreon\Views\Home\InitialPage.cshtml"
                                            Write(item.AboutPage);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 40 "C:\Users\thek1\Desktop\estagio\xPatreon\xPatreon\Views\Home\InitialPage.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 40 "C:\Users\thek1\Desktop\estagio\xPatreon\xPatreon\Views\Home\InitialPage.cshtml"
             
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<DataBase.Page>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
