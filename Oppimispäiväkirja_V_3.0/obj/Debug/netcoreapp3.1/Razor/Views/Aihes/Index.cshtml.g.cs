#pragma checksum "C:\Users\Anders\source\repos\Oppimispäiväkirja_V_3.0\Oppimispäiväkirja_V_3.0\Views\Aihes\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f7e0629481ed6eba1e82af161761b405e0139a39"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Aihes_Index), @"mvc.1.0.view", @"/Views/Aihes/Index.cshtml")]
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
#line 1 "C:\Users\Anders\source\repos\Oppimispäiväkirja_V_3.0\Oppimispäiväkirja_V_3.0\Views\_ViewImports.cshtml"
using Oppimispäiväkirja_V_3._0;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Anders\source\repos\Oppimispäiväkirja_V_3.0\Oppimispäiväkirja_V_3.0\Views\_ViewImports.cshtml"
using Oppimispäiväkirja_V_3._0.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f7e0629481ed6eba1e82af161761b405e0139a39", @"/Views/Aihes/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c6e71f51b4c79f4495abdf41d46da4b11a38a207", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Aihes_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Oppimispäiväkirja_V_3._0.Models.Aihe>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/site.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success btn-muokkaa"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("bootstrap-override"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Anders\source\repos\Oppimispäiväkirja_V_3.0\Oppimispäiväkirja_V_3.0\Views\Aihes\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f7e0629481ed6eba1e82af161761b405e0139a395631", async() => {
                WriteLiteral("\r\n    <meta charset=\"UTF-8\" />\r\n    <meta http-equiv=\"X-UA-Compatible\" content=\"IE=edge\" />\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\" />\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "f7e0629481ed6eba1e82af161761b405e0139a396078", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
    <link href=""https://cdn.jsdelivr.net/npm/bootstrap@5.2.0-beta1/dist/css/bootstrap.min.css""
          rel=""stylesheet""
          integrity=""sha384-0evHe/X+R7YkIZDRvuzKMRqM+OrBnVFBL6DOitfPri4tjfHxaWutUpFmBp4vmVor""
          crossorigin=""anonymous"" />
");
                WriteLiteral("    <title>Document</title>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f7e0629481ed6eba1e82af161761b405e0139a398294", async() => {
                WriteLiteral("\r\n    <h1>Aiheet</h1>\r\n    <br />\r\n\r\n");
#nullable restore
#line 23 "C:\Users\Anders\source\repos\Oppimispäiväkirja_V_3.0\Oppimispäiväkirja_V_3.0\Views\Aihes\Index.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <div class=\"card text-center topic-card\">\r\n            <p>ID: ");
#nullable restore
#line 26 "C:\Users\Anders\source\repos\Oppimispäiväkirja_V_3.0\Oppimispäiväkirja_V_3.0\Views\Aihes\Index.cshtml"
              Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n            <p>Otsikko: ");
#nullable restore
#line 27 "C:\Users\Anders\source\repos\Oppimispäiväkirja_V_3.0\Oppimispäiväkirja_V_3.0\Views\Aihes\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Title));

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n            <p>Kuvaus:  ");
#nullable restore
#line 28 "C:\Users\Anders\source\repos\Oppimispäiväkirja_V_3.0\Oppimispäiväkirja_V_3.0\Views\Aihes\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Description));

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n            <p>Arvioitu kesto: ");
#nullable restore
#line 29 "C:\Users\Anders\source\repos\Oppimispäiväkirja_V_3.0\Oppimispäiväkirja_V_3.0\Views\Aihes\Index.cshtml"
                          Write(Html.DisplayFor(modelItem => item.TimeToMaster));

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n            <p>Käytetty aika: ");
#nullable restore
#line 30 "C:\Users\Anders\source\repos\Oppimispäiväkirja_V_3.0\Oppimispäiväkirja_V_3.0\Views\Aihes\Index.cshtml"
                         Write(Html.DisplayFor(modelItem => item.TimeSpent));

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n            <p>Lähde:  ");
#nullable restore
#line 31 "C:\Users\Anders\source\repos\Oppimispäiväkirja_V_3.0\Oppimispäiväkirja_V_3.0\Views\Aihes\Index.cshtml"
                  Write(Html.DisplayFor(modelItem => item.Source));

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n            <p>Aloitus ajankohta: ");
#nullable restore
#line 32 "C:\Users\Anders\source\repos\Oppimispäiväkirja_V_3.0\Oppimispäiväkirja_V_3.0\Views\Aihes\Index.cshtml"
                             Write(Html.DisplayFor(modelItem => item.StartLearningDate));

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n            <p>Aihe yhä kesken:  ");
#nullable restore
#line 33 "C:\Users\Anders\source\repos\Oppimispäiväkirja_V_3.0\Oppimispäiväkirja_V_3.0\Views\Aihes\Index.cshtml"
                            Write(Html.DisplayFor(modelItem => item.InProgress));

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n            <p>Lopetus ajankohta: ");
#nullable restore
#line 34 "C:\Users\Anders\source\repos\Oppimispäiväkirja_V_3.0\Oppimispäiväkirja_V_3.0\Views\Aihes\Index.cshtml"
                             Write(Html.DisplayFor(modelItem => item.CompletionDate));

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n");
#nullable restore
#line 35 "C:\Users\Anders\source\repos\Oppimispäiväkirja_V_3.0\Oppimispäiväkirja_V_3.0\Views\Aihes\Index.cshtml"
             using (Html.BeginForm("Delete", "Aihes", new { id = item.Id }))
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <input onclick=\"return confirm(\'Haluatko varmasti poistaa tämän aiheen?\')\" class=\"btn btn-danger btn-poista\" type=\"submit\" value=\"Delete\" />\r\n");
#nullable restore
#line 38 "C:\Users\Anders\source\repos\Oppimispäiväkirja_V_3.0\Oppimispäiväkirja_V_3.0\Views\Aihes\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f7e0629481ed6eba1e82af161761b405e0139a3912617", async() => {
                    WriteLiteral("Muokkaa");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 39 "C:\Users\Anders\source\repos\Oppimispäiväkirja_V_3.0\Oppimispäiväkirja_V_3.0\Views\Aihes\Index.cshtml"
                                                                       WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
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
                WriteLiteral("\r\n");
                WriteLiteral("        </div>\r\n");
#nullable restore
#line 42 "C:\Users\Anders\source\repos\Oppimispäiväkirja_V_3.0\Oppimispäiväkirja_V_3.0\Views\Aihes\Index.cshtml"


    }

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Oppimispäiväkirja_V_3._0.Models.Aihe>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
