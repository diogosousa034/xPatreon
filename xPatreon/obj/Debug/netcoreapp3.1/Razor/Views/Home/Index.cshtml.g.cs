#pragma checksum "C:\Users\SwitchTechnology\Desktop\estagio\IntershipxPatreon\xPatreon\xPatreon\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "704ea4f16fc55a17d422378adf545b2150cb3abb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\SwitchTechnology\Desktop\estagio\IntershipxPatreon\xPatreon\xPatreon\Views\Home\Index.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"704ea4f16fc55a17d422378adf545b2150cb3abb", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9cb676b9ee1f536932e6cbd1f94126be36150bbd", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<DataBase.UserContent>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ContentList", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CreateContent", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info btn-lg rounded-pill"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("rounded"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:80px; height:80px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 6 "C:\Users\SwitchTechnology\Desktop\estagio\IntershipxPatreon\xPatreon\xPatreon\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"container\">\r\n    <h1>Hi, ");
#nullable restore
#line 11 "C:\Users\SwitchTechnology\Desktop\estagio\IntershipxPatreon\xPatreon\xPatreon\Views\Home\Index.cshtml"
       Write(HttpContextAccessor.HttpContext.Session.GetString("Username").ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h1>
    <div class=""row"">
        <div class=""col-7"">
            <p class=""text-muted"">Overview</p>
            <div class=""border p-3  mb-5 bg-white rounded"">
                <table class=""table table-borderless"">
                    <tr>
                        <th>
                            <p>0</p>
                            <p class=""text-muted"">active patreons</p>
                            <a href=""#"">View relationship manager</a>
                        </th>
                        <th class=""border-left"" style=""padding-left:60px;"">
                            <p>$0</p>
                            <p>per month</p>
                            <a href=""#"">View earnings dashboard</a>
                        </th>
                    </tr>
                </table>
            </div>

            <p class=""text-muted"">Next steps</p>
            <div class=""border p-3 mb-5 bg-white rounded font-weight-bold"">
                <p>Need ideas for a post?</p>
                <table");
            WriteLiteral(@" class=""table table-borderless"">
                    <tr>
                        <th>
                            <ul>
                                <li><a href=""#"">Behind the scenes</a></li>
                                <li><a href=""#"">Livestream, Q&A</a></li>
                                <li><a href=""#"">Early access</a></li>
                            </ul>
                        </th>
                        <th>
                            <ul>
                                <li><a href=""#"">Polls</a></li>
                                <li><a href=""#"">Exclusive downloads</a></li>
                                <li><a href=""#"">Life & work updates</a></li>
                            </ul>
                        </th>
                    </tr>
                </table>
            </div>

            <div class=""border p-3 mb-5 bg-white rounded font-weight-bold"">
                <p>Ideas for promoting on social media</p>
                <p class=""text-muted font-weight-no");
            WriteLiteral(@"rmal"">To help you build your audience and get your amazing works out to more people, here are 8 quick tips for posting on social media.</p>
                <a href=""#"" class=""btn btn-outline-secondary rounded-pill"">Get examples</a>
            </div>
        </div>


        <div class=""col-5"">
            <p class=""text-muted"">Recent activity</p>
            <div class=""border p-3 mb-5 bg-white rounded font-weight-bold"">
                <p>No unread messages from patrons</p>
                <a href=""#"">View messages</a>
            </div>

            <div class=""border bg-white font-weight-bold rounded"">
                <div class=""p-3"">
                    <div>
                        RECENT POSTS
                    </div>

                    <div class=""font-weight-normal text-right"">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "704ea4f16fc55a17d422378adf545b2150cb3abb9525", async() => {
                WriteLiteral("View all posts");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 80 "C:\Users\SwitchTechnology\Desktop\estagio\IntershipxPatreon\xPatreon\xPatreon\Views\Home\Index.cshtml"
                 if (Model.Count() < 1)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    <div class=""border p-3 rounded-bottom bg-white"">
                        <div class=""d-flex justify-content-center"">
                            <p class=""text-muted"">You haven't posted anything yet</p>
                        </div>
                        <div class=""d-flex justify-content-center"">
                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "704ea4f16fc55a17d422378adf545b2150cb3abb11588", async() => {
                WriteLiteral("Make a post");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 90 "C:\Users\SwitchTechnology\Desktop\estagio\IntershipxPatreon\xPatreon\xPatreon\Views\Home\Index.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <table class=\"table table-borderless\">\r\n");
#nullable restore
#line 94 "C:\Users\SwitchTechnology\Desktop\estagio\IntershipxPatreon\xPatreon\xPatreon\Views\Home\Index.cshtml"
                         foreach (var item in Model)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            <tr class=""border-top"">
                                <th>
                                    <div class=""d-flex"">
                                        <div class=""bg-secondary rounded m-2"" style=""width:80px; height:80px;"">
");
#nullable restore
#line 100 "C:\Users\SwitchTechnology\Desktop\estagio\IntershipxPatreon\xPatreon\xPatreon\Views\Home\Index.cshtml"
                                             if (item.Image != null)
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <div class=\"bg-white\" style=\"width:80px; height:80px;\">\r\n                                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "704ea4f16fc55a17d422378adf545b2150cb3abb14501", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 4663, "~/images/", 4663, 9, true);
#nullable restore
#line 103 "C:\Users\SwitchTechnology\Desktop\estagio\IntershipxPatreon\xPatreon\xPatreon\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 4672, item.Image, 4672, 11, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                                </div>\r\n");
#nullable restore
#line 105 "C:\Users\SwitchTechnology\Desktop\estagio\IntershipxPatreon\xPatreon\xPatreon\Views\Home\Index.cshtml"
                                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        </div>\r\n                                        <div class=\"p-2\">\r\n                                            ");
#nullable restore
#line 108 "C:\Users\SwitchTechnology\Desktop\estagio\IntershipxPatreon\xPatreon\xPatreon\Views\Home\Index.cshtml"
                                       Write(Html.DisplayFor(modelItem => item.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                            <p class=""text-muted font-weight-normal"">hora(falta meter)</p>
                                        </div>
                                    </div>
                                </th>
                            </tr>
");
#nullable restore
#line 114 "C:\Users\SwitchTechnology\Desktop\estagio\IntershipxPatreon\xPatreon\xPatreon\Views\Home\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </table>\r\n");
#nullable restore
#line 116 "C:\Users\SwitchTechnology\Desktop\estagio\IntershipxPatreon\xPatreon\xPatreon\Views\Home\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n\r\n        </div>\r\n    </div>\r\n</div>\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public Microsoft.AspNetCore.Http.IHttpContextAccessor HttpContextAccessor { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<DataBase.UserContent>> Html { get; private set; }
    }
}
#pragma warning restore 1591
