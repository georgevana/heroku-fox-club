#pragma checksum "C:\Users\georg\Documents\greenfox\georgevana\week07\day04\FoxClub\Views\home\index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d6d3a1b2f910d59ab39d5dd6ebcba271781aad21"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_home_index), @"mvc.1.0.view", @"/Views/home/index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/home/index.cshtml", typeof(AspNetCore.Views_home_index))]
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
#line 1 "C:\Users\georg\Documents\greenfox\georgevana\week07\day04\FoxClub\Views\home\index.cshtml"
using FoxClub.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d6d3a1b2f910d59ab39d5dd6ebcba271781aad21", @"/Views/home/index.cshtml")]
    public class Views_home_index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Fox>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/greenfox.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(37, 10, true);
            WriteLiteral("\r\n<html>\r\n");
            EndContext();
            BeginContext(47, 109, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "66c905cd72b7493abfc9892d50411f6b", async() => {
                BeginContext(53, 72, true);
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n    <title>");
                EndContext();
                BeginContext(126, 13, false);
#line 7 "C:\Users\georg\Documents\greenfox\georgevana\week07\day04\FoxClub\Views\home\index.cshtml"
      Write(ViewBag.Title);

#line default
#line hidden
                EndContext();
                BeginContext(139, 10, true);
                WriteLiteral("</title>\r\n");
                EndContext();
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
            EndContext();
            BeginContext(156, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(158, 788, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9f079f5c1f6a44abb8ed97d688f11a0f", async() => {
                BeginContext(164, 40, true);
                WriteLiteral("\r\n    <ul>\r\n        <li>\r\n            <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 204, "\"", 234, 2);
                WriteAttributeValue("", 211, "/home/?name=", 211, 12, true);
#line 12 "C:\Users\georg\Documents\greenfox\georgevana\week07\day04\FoxClub\Views\home\index.cshtml"
WriteAttributeValue("", 223, Model.Name, 223, 11, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(235, 61, true);
                WriteLiteral(">information</a>\r\n        </li>\r\n        <li>\r\n            <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 296, "\"", 336, 2);
                WriteAttributeValue("", 303, "/nutritionstore/?name=", 303, 22, true);
#line 15 "C:\Users\georg\Documents\greenfox\georgevana\week07\day04\FoxClub\Views\home\index.cshtml"
WriteAttributeValue("", 325, Model.Name, 325, 11, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(337, 65, true);
                WriteLiteral(">nutrition store</a>\r\n        </li>\r\n        <li>\r\n            <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 402, "\"", 439, 2);
                WriteAttributeValue("", 409, "/trickcenter/?name=", 409, 19, true);
#line 18 "C:\Users\georg\Documents\greenfox\georgevana\week07\day04\FoxClub\Views\home\index.cshtml"
WriteAttributeValue("", 428, Model.Name, 428, 11, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(440, 49, true);
                WriteLiteral(">trick center</a>\r\n        </li>\r\n    </ul>\r\n    ");
                EndContext();
                BeginContext(489, 28, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "955edda5880a4ce196d0accdf1e94de0", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(517, 17, true);
                WriteLiteral("\r\n    <p>This is ");
                EndContext();
                BeginContext(535, 10, false);
#line 22 "C:\Users\georg\Documents\greenfox\georgevana\week07\day04\FoxClub\Views\home\index.cshtml"
          Write(Model.Name);

#line default
#line hidden
                EndContext();
                BeginContext(545, 22, true);
                WriteLiteral(". Currently living on ");
                EndContext();
                BeginContext(568, 10, false);
#line 22 "C:\Users\georg\Documents\greenfox\georgevana\week07\day04\FoxClub\Views\home\index.cshtml"
                                           Write(Model.Food);

#line default
#line hidden
                EndContext();
                BeginContext(578, 5, true);
                WriteLiteral(" and ");
                EndContext();
                BeginContext(584, 11, false);
#line 22 "C:\Users\georg\Documents\greenfox\georgevana\week07\day04\FoxClub\Views\home\index.cshtml"
                                                           Write(Model.Drink);

#line default
#line hidden
                EndContext();
                BeginContext(595, 11, true);
                WriteLiteral(". He knows ");
                EndContext();
                BeginContext(607, 18, false);
#line 22 "C:\Users\georg\Documents\greenfox\georgevana\week07\day04\FoxClub\Views\home\index.cshtml"
                                                                                  Write(Model.Tricks.Count);

#line default
#line hidden
                EndContext();
                BeginContext(625, 45, true);
                WriteLiteral(" trick(s).</p>\r\n    <h2>Known tricks</h2>\r\n\r\n");
                EndContext();
#line 25 "C:\Users\georg\Documents\greenfox\georgevana\week07\day04\FoxClub\Views\home\index.cshtml"
     if (Model.Tricks.Count.Equals(0))
    {

#line default
#line hidden
                BeginContext(717, 49, true);
                WriteLiteral("        <p>This fox doesnt know any tricks.</p>\r\n");
                EndContext();
#line 28 "C:\Users\georg\Documents\greenfox\georgevana\week07\day04\FoxClub\Views\home\index.cshtml"
    }
    else
    {

#line default
#line hidden
                BeginContext(790, 14, true);
                WriteLiteral("        <ul>\r\n");
                EndContext();
#line 32 "C:\Users\georg\Documents\greenfox\georgevana\week07\day04\FoxClub\Views\home\index.cshtml"
             foreach (var trick in Model.Tricks)
            {

#line default
#line hidden
                BeginContext(869, 20, true);
                WriteLiteral("                <li>");
                EndContext();
                BeginContext(890, 5, false);
#line 34 "C:\Users\georg\Documents\greenfox\georgevana\week07\day04\FoxClub\Views\home\index.cshtml"
               Write(trick);

#line default
#line hidden
                EndContext();
                BeginContext(895, 7, true);
                WriteLiteral("</li>\r\n");
                EndContext();
#line 35 "C:\Users\georg\Documents\greenfox\georgevana\week07\day04\FoxClub\Views\home\index.cshtml"
            }

#line default
#line hidden
                BeginContext(917, 15, true);
                WriteLiteral("        </ul>\r\n");
                EndContext();
#line 37 "C:\Users\georg\Documents\greenfox\georgevana\week07\day04\FoxClub\Views\home\index.cshtml"
    }

#line default
#line hidden
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(946, 9, true);
            WriteLiteral("\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Fox> Html { get; private set; }
    }
}
#pragma warning restore 1591
