#pragma checksum "C:\Users\SwitchTechnology\Desktop\estagio\IntershipxPatreon\xPatreon\xPatreon\Views\Home\CreatorPosts.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "57a73de5b6b91ffb42df1622b755af485d9cec3d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_CreatorPosts), @"mvc.1.0.view", @"/Views/Home/CreatorPosts.cshtml")]
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
#nullable restore
#line 1 "C:\Users\SwitchTechnology\Desktop\estagio\IntershipxPatreon\xPatreon\xPatreon\Views\Home\CreatorPosts.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"57a73de5b6b91ffb42df1622b755af485d9cec3d", @"/Views/Home/CreatorPosts.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9cb676b9ee1f536932e6cbd1f94126be36150bbd", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_CreatorPosts : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Services.Dto.PageDto>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/imgs/default user.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("90"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("90"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("rounded-circle"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/imgs/find_creators.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 6 "C:\Users\SwitchTechnology\Desktop\estagio\IntershipxPatreon\xPatreon\xPatreon\Views\Home\CreatorPosts.cshtml"
  
    ViewData["Title"] = "CreatorPosts";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<style>
    .mouseHover:hover {
        background-color: rgba(0,0,0,0.1);
        cursor: pointer;
    }
</style>

<div class=""container mt-3"">
    <div class=""row"">
        <div class=""col-3"">
            <div class=""border p-3 bg-white rounded-top"">
                <div class=""d-flex justify-content-center mt-2"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "57a73de5b6b91ffb42df1622b755af485d9cec3d6261", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n                <div class=\"d-flex justify-content-center mt-3\">\r\n                    ");
#nullable restore
#line 26 "C:\Users\SwitchTechnology\Desktop\estagio\IntershipxPatreon\xPatreon\xPatreon\Views\Home\CreatorPosts.cshtml"
               Write(HttpContextAccessor.HttpContext.Session.GetString("Username").ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n            <div class=\"border p-2 bg-white font-weight-bold\">\r\n                <div class=\"p-2\">\r\n                    SUPPORTING\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 34 "C:\Users\SwitchTechnology\Desktop\estagio\IntershipxPatreon\xPatreon\xPatreon\Views\Home\CreatorPosts.cshtml"
             if (Model.Count() < 1)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"border p-3 rounded-bottom bg-white\">\r\n                    <p>You aren’t supporting any creators yet.</p>\r\n                </div>\r\n");
#nullable restore
#line 39 "C:\Users\SwitchTechnology\Desktop\estagio\IntershipxPatreon\xPatreon\xPatreon\Views\Home\CreatorPosts.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <table class=\"table table-borderless\">\r\n");
#nullable restore
#line 43 "C:\Users\SwitchTechnology\Desktop\estagio\IntershipxPatreon\xPatreon\xPatreon\Views\Home\CreatorPosts.cshtml"
                     foreach (var item in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr class=\"border mouseHover\">\r\n                            <th>\r\n                                <a");
            BeginWriteAttribute("href", " href=\"", 1558, "\"", 1611, 2);
            WriteAttributeValue("", 1565, "/Home/LaunchedPage?UserPageName=", 1565, 32, true);
#nullable restore
#line 47 "C:\Users\SwitchTechnology\Desktop\estagio\IntershipxPatreon\xPatreon\xPatreon\Views\Home\CreatorPosts.cshtml"
WriteAttributeValue("", 1597, item.PageName, 1597, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"text-decoration-none\">\r\n                                    <div class=\"d-flex pl-2\">\r\n                                        <div class=\"rounded-circle\" style=\"width:50px; height:50px;\">\r\n                                            <img");
            BeginWriteAttribute("src", " src=\"", 1858, "\"", 1882, 1);
#nullable restore
#line 50 "C:\Users\SwitchTechnology\Desktop\estagio\IntershipxPatreon\xPatreon\xPatreon\Views\Home\CreatorPosts.cshtml"
WriteAttributeValue("", 1864, item.ProfileImage, 1864, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"rounded-circle\" style=\"width:50px; height:50px;\"");
            BeginWriteAttribute("alt", " alt=\"", 1939, "\"", 1945, 0);
            EndWriteAttribute();
            WriteLiteral(" />\r\n                                        </div>\r\n                                        <div class=\"pl-3 pt-2\">\r\n                                            <p style=\"color:black;\">");
#nullable restore
#line 53 "C:\Users\SwitchTechnology\Desktop\estagio\IntershipxPatreon\xPatreon\xPatreon\Views\Home\CreatorPosts.cshtml"
                                                               Write(Html.DisplayFor(modelItem => item.PageName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                        </div>\r\n                                    </div>\r\n                                </a>\r\n                            </th>\r\n                        </tr>\r\n");
#nullable restore
#line 59 "C:\Users\SwitchTechnology\Desktop\estagio\IntershipxPatreon\xPatreon\xPatreon\Views\Home\CreatorPosts.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </table>\r\n");
#nullable restore
#line 61 "C:\Users\SwitchTechnology\Desktop\estagio\IntershipxPatreon\xPatreon\xPatreon\Views\Home\CreatorPosts.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n\r\n        <div class=\"col-6\">\r\n");
#nullable restore
#line 65 "C:\Users\SwitchTechnology\Desktop\estagio\IntershipxPatreon\xPatreon\xPatreon\Views\Home\CreatorPosts.cshtml"
             if (Model.Count() < 1)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <div class=""border mb-5 bg-white rounded"">
                    <div class=""d-flex justify-content-center mt-5"">
                        <p>Support or follow creators to see posts in your feed.</p>
                    </div>
                    <div class=""d-flex justify-content-center"">
                        <a href=""#"" class=""btn btn-primary rounded-pill btn-lg"">Find Creators you love</a>
                    </div>
                    <div class=""mt-3"">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "57a73de5b6b91ffb42df1622b755af485d9cec3d12856", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 78 "C:\Users\SwitchTechnology\Desktop\estagio\IntershipxPatreon\xPatreon\xPatreon\Views\Home\CreatorPosts.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <table class=\"table table-borderless\">\r\n");
#nullable restore
#line 82 "C:\Users\SwitchTechnology\Desktop\estagio\IntershipxPatreon\xPatreon\xPatreon\Views\Home\CreatorPosts.cshtml"
                     foreach (var item in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr class=\"border mouseHover\">\r\n                            <th>\r\n                                <a");
            BeginWriteAttribute("href", " href=\"", 3461, "\"", 3514, 2);
            WriteAttributeValue("", 3468, "/Home/LaunchedPage?UserPageName=", 3468, 32, true);
#nullable restore
#line 86 "C:\Users\SwitchTechnology\Desktop\estagio\IntershipxPatreon\xPatreon\xPatreon\Views\Home\CreatorPosts.cshtml"
WriteAttributeValue("", 3500, item.PageName, 3500, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"text-decoration-none\">\r\n                                    <div class=\"d-flex pl-2\">\r\n                                        <div class=\"rounded-circle\" style=\"width:50px; height:50px;\">\r\n                                            <img");
            BeginWriteAttribute("src", " src=\"", 3761, "\"", 3785, 1);
#nullable restore
#line 89 "C:\Users\SwitchTechnology\Desktop\estagio\IntershipxPatreon\xPatreon\xPatreon\Views\Home\CreatorPosts.cshtml"
WriteAttributeValue("", 3767, item.ProfileImage, 3767, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"rounded-circle\" style=\"width:50px; height:50px;\"");
            BeginWriteAttribute("alt", " alt=\"", 3842, "\"", 3848, 0);
            EndWriteAttribute();
            WriteLiteral(" />\r\n                                        </div>\r\n                                        <div class=\"pl-3 pt-2\">\r\n                                            <p style=\"color:black;\">");
#nullable restore
#line 92 "C:\Users\SwitchTechnology\Desktop\estagio\IntershipxPatreon\xPatreon\xPatreon\Views\Home\CreatorPosts.cshtml"
                                                               Write(Html.DisplayFor(modelItem => item.PageName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                        </div>\r\n                                    </div>\r\n                                </a>\r\n                            </th>\r\n                        </tr>\r\n");
#nullable restore
#line 98 "C:\Users\SwitchTechnology\Desktop\estagio\IntershipxPatreon\xPatreon\xPatreon\Views\Home\CreatorPosts.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </table>\r\n");
#nullable restore
#line 100 "C:\Users\SwitchTechnology\Desktop\estagio\IntershipxPatreon\xPatreon\xPatreon\Views\Home\CreatorPosts.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
        </div>




        <div class=""col-3"">
            <div class=""border p-2 bg-white font-weight-bold"">
                <div class=""p-2"">
                    BECOME A CREATOR
                </div>
            </div>
            <div class=""border p-3 rounded-bottom bg-white"">
                <p>You're almost there! Complete your page and take it live.</p>
                <a href=""#"" class=""btn btn-info rounded-pill"">Finish my page</a>
            </div>

            <div class=""border p-2 mt-3 bg-white font-weight-bold"">
                <div class=""p-2"">
                    FIND CREATORS YOU LOVE
                </div>
            </div>
            <div class=""border p-3 rounded-bottom bg-white"">
                <p>The creators you already love may be on Patreon – connect your social media to find them.</p>
                <a href=""#"" class=""btn btn-info rounded-pill"">Find creators</a>
            </div>
        </div>
    </div>
</div>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public Microsoft.AspNetCore.Http.IHttpContextAccessor HttpContextAccessor { get; private set; } = default!;
        #nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Services.Dto.PageDto>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
