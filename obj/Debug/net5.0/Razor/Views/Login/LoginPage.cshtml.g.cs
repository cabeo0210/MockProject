#pragma checksum "C:\Users\cabeo\Desktop\App\Views\Login\LoginPage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8caedf78c9317f0ededbfe854ff36ad2efc0c342"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Login_LoginPage), @"mvc.1.0.view", @"/Views/Login/LoginPage.cshtml")]
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
#line 1 "C:\Users\cabeo\Desktop\App\Views\_ViewImports.cshtml"
using App;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\cabeo\Desktop\App\Views\_ViewImports.cshtml"
using App.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8caedf78c9317f0ededbfe854ff36ad2efc0c342", @"/Views/Login/LoginPage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5faed75b525dea5d0e576e458ec87e49cb31bf06", @"/Views/_ViewImports.cshtml")]
    public class Views_Login_LoginPage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
#nullable restore
#line 1 "C:\Users\cabeo\Desktop\App\Views\Login\LoginPage.cshtml"
  
    ViewData["Title"] = "Login Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8caedf78c9317f0ededbfe854ff36ad2efc0c3423366", async() => {
                WriteLiteral(@"
    <meta charset=""UTF-8"">
    <meta http-equiv=""X-UA-Compatible"" content=""IE=edge"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
    <link rel=""stylesheet"" href=""css/styleLogin.css"">
    <link rel=""stylesheet"" href=""https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.0.0-beta2/css/all.min.css""
        integrity=""sha512-YWzhKL2whUzgiheMoBFwW8CKV4qpHQAEuvilg9FAn5VJUDwKZZxkJNuGM4XkWuk94WCrrwslk8yWNGmY1EduTA==""
        crossorigin=""anonymous"" referrerpolicy=""no-referrer"" />
    <title>Split Screen</title>
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8caedf78c9317f0ededbfe854ff36ad2efc0c3424907", async() => {
                WriteLiteral(@"
    <div class=""wrapper1"">
        <div class=""content-left"">
            <div class=""container-left"">
                <h1 class=""left-header"">
                    Hello Guys
                </h1>
                <p class=""left-message"">
                    Login for booking right now
                </p>
                <a href=""#"" class=""frame-btn"">
                    <span class=""frame-btn__outline frame-btn__outline--tall"">
                        <span class=""frame-btn__line frame-btn__line--tall"">
                        </span>
                        <span class=""frame-btn__line frame-btn__line--flat"">
                        </span>
                    </span>
                    <span class=""frame-btn__outline frame-btn__outline--flat"">
                        <span class=""frame-btn__line frame-btn__line--tall"">
                        </span>
                        <span class=""frame-btn__line frame-btn__line--flat"">
                        </span>
                    </spa");
                WriteLiteral(@"n>
                    <span class=""frame-btn__solid""></span>
                    <span class=""frame-btn__text"">SIGN UP</span>
                </a>
                <!-- Đoạn này sẽ hơi phức tạp tí do lát mình sẽ tạo hiệu ứng hover cho button Sign In nên các bạn làm theo chậm chậm kẻo sai nhé ♥ -->
            </div>
        </div>

        <div class=""content-right"">
            <h2 class=""right-header"">SIGN IN</h2>
            <div class=""right-socials"">
                <div class=""socials-btn facebook-border"">
                    <i class=""fab fa-facebook-f""></i>
                </div>
                <div class=""socials-btn google-border"">
                    <i class=""fab fa-google""></i>
                </div>
                <div class=""socials-btn instagram-border"">
                    <i class=""fab fa-instagram""></i>
                </div>
            </div>
            <div class=""right-message"">or use your account</div>
            <div class=""right-input_email"">
              ");
                WriteLiteral(@"  <input type=""text"" class=""right-input right-email"" placeholder=""E-mail"">
                <i class=""fas fa-envelope modifier""></i>
            </div>
            <div class=""right-input_password"">
                <input type=""password"" class=""right-input right-password"" placeholder=""Password"">
                <i class=""fas fa-eye modifier""></i>
            </div>
            <p class=""right-warning"">
                Forgot your password?
            </p>
            <a href=""#"" class=""btn btn--diagonal btn--orange"">Sign In</a>
        </div>

    </div>
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
