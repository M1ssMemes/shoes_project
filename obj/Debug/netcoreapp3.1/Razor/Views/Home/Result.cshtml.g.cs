#pragma checksum "C:\Users\memes\Desktop\homework\rgu\4\kyrsach\back\WebApplication1\Views\Home\Result.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a611fc86ea8cdb99191eb19f2c74d31c50c63607"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Result), @"mvc.1.0.view", @"/Views/Home/Result.cshtml")]
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
#line 1 "C:\Users\memes\Desktop\homework\rgu\4\kyrsach\back\WebApplication1\Views\_ViewImports.cshtml"
using WebApplication1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\memes\Desktop\homework\rgu\4\kyrsach\back\WebApplication1\Views\_ViewImports.cshtml"
using WebApplication1.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a611fc86ea8cdb99191eb19f2c74d31c50c63607", @"/Views/Home/Result.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"729efaa87342638aecfe1a972ce9f9f8dff55b4c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Result : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!doctype html>\r\n<html lang=\"ru\">\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a611fc86ea8cdb99191eb19f2c74d31c50c636073304", async() => {
                WriteLiteral(@"
    <meta charset=""utf-8"" />
    <title>Project 1</title>
    <link href=""https://cdn.jsdelivr.net/npm/bootstrap@5.0.1/dist/css/bootstrap.min.css"" rel=""stylesheet""
          integrity=""sha384-+0n0xVW2eSR5OomGNYDnhzAbDsOXxcvSN1TPprVMTNDbiYZCxYbOOl7+AMvyTG2x"" crossorigin=""anonymous"">
    <link rel=""stylesheet"" href=""/css/style.css"" />
");
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a611fc86ea8cdb99191eb19f2c74d31c50c636074627", async() => {
                WriteLiteral(@"
    <nav class=""navbar-wrapper"">
        <div class=""navbar-content"">
            <a class=""main nav-link"" href=""index.html"">Главная</a>
            <a class=""contacts nav-link"" href=""#contacts"">Контакты</a>
        </div>
    </nav>
    <div class=""page3"">
        <span>ТРЕТЬЯ СТРАНИЦА В РАБОТЕ, ПОДОЖДИТЕ ЧУТЬ ЧУТЬ!</span>
    </div>
    <footer class=""footer-wrapper"">
        <div class=""flex-container-center footer-content"">
            <div>
                <div class=""contact-item"">
                    <a name=""contacts"" class=""contact-item-url"" href=""https://vk.com/medvedeva94"">
                        <img src=""/images/vk.svg""");
                BeginWriteAttribute("alt", "\r\n                             alt=\"", 1059, "\"", 1095, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n                    </a>\r\n                    <a class=\"contact-item-url\" href=\"https://www.instagram.com/olyamedvedeva\">\r\n                        <img src=\"/images/inst.svg\"");
                BeginWriteAttribute("alt", "\r\n                             alt=\"", 1273, "\"", 1309, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                    </a>
                    <p>Project by Olga Medvedeva</p>
                </div>
                <div class=""contact-item"">
                    <a class=""contact-item-url"" href=""https://vk.com/missmemes""><img src=""/images/vk.svg""");
                BeginWriteAttribute("alt", " alt=\"", 1566, "\"", 1572, 0);
                EndWriteAttribute();
                WriteLiteral("></a>\r\n                    <a class=\"contact-item-url\" href=\"https://www.instagram.com/m1ss_memes\"><img src=\"/images/inst.svg\"");
                BeginWriteAttribute("alt", " alt=\"", 1699, "\"", 1705, 0);
                EndWriteAttribute();
                WriteLiteral("></a>\r\n                    <p>Programmed by Anastasya Sokolova</p>\r\n                </div>\r\n                <div class=\"contact-item\">\r\n                    <a class=\"contact-item-url\" href=\"https://vk.com/sophame\"><img src=\"/images/vk.svg\"");
                BeginWriteAttribute("alt", " alt=\"", 1945, "\"", 1951, 0);
                EndWriteAttribute();
                WriteLiteral("></a>\r\n                    <a class=\"contact-item-url\" href=\"https://www.instagram.com/sopha.izmaylova\">\r\n                        <img src=\"/images/inst.svg\"");
                BeginWriteAttribute("alt", "\r\n                             alt=\"", 2109, "\"", 2145, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                    </a>
                    <p>Designed by Sophia Izmaylova</p>
                </div>
            </div>
            <p class=""rgy"">
                РГУ им. А.Н.Косыгина<br>
                (Технологии. Дизайн. Искусство) <br>
                г. Москва
            </p>
            <p>Medvedeva2509@gmail.com</p>
            <p>2021</p>
        </div>
    </footer>
");
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
            WriteLiteral("\r\n\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591