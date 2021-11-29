#pragma checksum "C:\Users\cabeo\Desktop\MockProject\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6c3d9b3c6a5473ec11fd22cd396354522488cac9"
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
#line 1 "C:\Users\cabeo\Desktop\MockProject\Views\_ViewImports.cshtml"
using MockProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\cabeo\Desktop\MockProject\Views\_ViewImports.cshtml"
using MockProject.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6c3d9b3c6a5473ec11fd22cd396354522488cac9", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5faed75b525dea5d0e576e458ec87e49cb31bf06", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString(" btn btn-default"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Login", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "LoginPage", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\cabeo\Desktop\MockProject\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6c3d9b3c6a5473ec11fd22cd396354522488cac94728", async() => {
                WriteLiteral(@"
    <title>Dine Out - Restaurant</title>
    <meta charset=""utf-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1"">
    <link rel=""stylesheet"" href=""css/font-awesome.css"">
    <link rel=""stylesheet"" href=""css/aos.css"">
    <link rel=""stylesheet"" href=""css/style.css"">
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6c3d9b3c6a5473ec11fd22cd396354522488cac96014", async() => {
                WriteLiteral(@"


    <div class=""page-loader""></div>

    <header class=""header"">
        <div class=""container"">
            <div class=""row justify-content-between align-items-center"">
                <div class=""logo"">
                    <span class=""first"">Mio</span> <span class=""second"">Rooftop</span>
                </div>
                <button type=""button"" class=""nav-toggler"">
                    <span></span>
                </button>
                <nav class=""nav"">
                    <ul>
                        <li class=""nav-item""><a href=""#home"">home</a></li>
                        <li class=""nav-item""><a href=""#about"">about</a></li>
                        <li class=""nav-item""><a href=""#our-menu"">our menu</a></li>
                        <li class=""nav-item""><a href=""#testimonials"">testimonials</a></li>
                        <li class=""nav-item""><a href=""#team"">team</a></li>
                        <li class=""nav-item""><a href=""#footer"">contact us</a></li>
                    </");
                WriteLiteral(@"ul>
                </nav>
            </div>
        </div>
    </header>

    <section class=""home-section"" id=""home"">
        <div class=""home-bg""></div>
        <div class=""container"">
            <div class=""row min-vh-100 align-items-center"">
                <div class=""home-text"" data-aos=""fade-up"" data-aos-duration=""1000"">
                    <h1>Mio Drink&Chill</h1>
                    <p>The beer you might hate today you might love tomorrow</p>
                    <a href=""#our-menu"" class=""btn btn-default"">our menu</a>
                    <br>
                    <br>
                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6c3d9b3c6a5473ec11fd22cd396354522488cac98015", async() => {
                    WriteLiteral(" Login ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                </div>
            </div>
        </div>
    </section>

    <section class=""about-section sec-padding"" id=""about"">
        <div class=""container"">
            <div class=""row"">
                <div class=""section-title"">
                    <h2 data-title=""our story"" data-aos=""fade-up"">about us</h2>
                </div>
            </div>
            <div class=""row"">
                <div class=""about-text"" data-aos=""fade-right"">
                    <h3>Welcome To Mio Rooftop</h3>
                    <p>With 20 years of experience, we are proud to give you the best experience</p>
                    <a href=""#our-menu"" class=""btn btn-default"">check our menu</a>
                </div>
                <div class=""about-img"" data-aos=""fade-left"">
                    <div class=""img-box"">
                        <h3>20+ year experience</h3>
                        <img src=""img/about.jpg"" alt=""about img"">
                    </div>
                </div>
            </");
                WriteLiteral(@"div>
        </div>
    </section>

    <section class=""menu-section sec-padding"" id=""our-menu"">
        <div class=""container"">
            <div class=""row"">
                <div class=""section-title"">
                    <h2 data-title=""order now"" data-aos=""fade-up"">our menu</h2>
                </div>
            </div>
            <div class=""row"">
                <div class=""menu-tabs"" data-aos=""fade-up"">
                    <button type=""button"" class=""menu-tab-item active"" data-target=""#lunch"">lunch</button>
                    <button type=""button"" class=""menu-tab-item"" data-target=""#dinner"">dinner</button>
                    <button type=""button"" class=""menu-tab-item"" data-target=""#drinks"">drinks</button>
                    <button type=""button"" class=""menu-tab-item"" data-target=""#desserts"">desserts</button>
                </div>
            </div>
            <div class=""row menu-tab-content active"" id=""lunch"">
                <div class=""menu-item"" data-aos=""fade-up-right"">
");
                WriteLiteral(@"                    <div class=""menu-item-title"">
                        <img src=""img/menu/1.jpg"" alt=""menu item thumbnail"">
                        <h3>lunch item</h3>
                    </div>
                    <div class=""menu-item-price"">
                        $40.00
                    </div>
                </div>
                <div class=""menu-item"" data-aos=""fade-up-left"">
                    <div class=""menu-item-title"">
                        <img src=""img/menu/2.jpg"" alt=""menu item thumbnail"">
                        <h3>lunch item</h3>
                    </div>
                    <div class=""menu-item-price"">
                        $40.00
                    </div>
                </div>
                <div class=""menu-item"" data-aos=""fade-up-right"">
                    <div class=""menu-item-title"">
                        <img src=""img/menu/3.jpg"" alt=""menu item thumbnail"">
                        <h3>lunch item</h3>
                    </div>
                 ");
                WriteLiteral(@"   <div class=""menu-item-price"">
                        $40.00
                    </div>
                </div>
                <div class=""menu-item"" data-aos=""fade-up-left"">
                    <div class=""menu-item-title"">
                        <img src=""img/menu/4.jpg"" alt=""menu item thumbnail"">
                        <h3>lunch item</h3>
                    </div>
                    <div class=""menu-item-price"">
                        $40.00
                    </div>
                </div>
                <div class=""menu-item"" data-aos=""fade-up-right"">
                    <div class=""menu-item-title"">
                        <img src=""img/menu/5.jpg"" alt=""menu item thumbnail"">
                        <h3>lunch item</h3>
                    </div>
                    <div class=""menu-item-price"">
                        $40.00
                    </div>
                </div>
                <div class=""menu-item"" data-aos=""fade-up-left"">
                    <div class=""menu");
                WriteLiteral(@"-item-title"">
                        <img src=""img/menu/6.jpg"" alt=""menu item thumbnail"">
                        <h3>lunch item</h3>
                    </div>
                    <div class=""menu-item-price"">
                        $40.00
                    </div>
                </div>
                <div class=""menu-item"" data-aos=""fade-up-right"">
                    <div class=""menu-item-title"">
                        <img src=""img/menu/7.jpg"" alt=""menu item thumbnail"">
                        <h3>lunch item</h3>
                    </div>
                    <div class=""menu-item-price"">
                        $40.00
                    </div>
                </div>
                <div class=""menu-item"" data-aos=""fade-up-left"">
                    <div class=""menu-item-title"">
                        <img src=""img/menu/8.jpg"" alt=""menu item thumbnail"">
                        <h3>lunch item</h3>
                    </div>
                    <div class=""menu-item-price"">
  ");
                WriteLiteral(@"                      $40.00
                    </div>
                </div>
            </div>
            <div class=""row menu-tab-content"" id=""dinner"">
                <div class=""menu-item"" data-aos=""fade-up-right"">
                    <div class=""menu-item-title"">
                        <img src=""img/menu/1.jpg"" alt=""menu item thumbnail"">
                        <h3>dinner item</h3>
                    </div>
                    <div class=""menu-item-price"">
                        $30.00
                    </div>
                </div>
                <div class=""menu-item"" data-aos=""fade-up-left"">
                    <div class=""menu-item-title"">
                        <img src=""img/menu/2.jpg"" alt=""menu item thumbnail"">
                        <h3>dinner item</h3>
                    </div>
                    <div class=""menu-item-price"">
                        $30.00
                    </div>
                </div>
                <div class=""menu-item"" data-aos=""fade-u");
                WriteLiteral(@"p-right"">
                    <div class=""menu-item-title"">
                        <img src=""img/menu/3.jpg"" alt=""menu item thumbnail"">
                        <h3>dinner item</h3>
                    </div>
                    <div class=""menu-item-price"">
                        $30.00
                    </div>
                </div>
                <div class=""menu-item"" data-aos=""fade-up-left"">
                    <div class=""menu-item-title"">
                        <img src=""img/menu/4.jpg"" alt=""menu item thumbnail"">
                        <h3>dinner item</h3>
                    </div>
                    <div class=""menu-item-price"">
                        $30.00
                    </div>
                </div>
            </div>
            <div class=""row menu-tab-content"" id=""drinks"">
                <div class=""menu-item"" data-aos=""fade-up-right"">
                    <div class=""menu-item-title"">
                        <img src=""img/menu/9.jpg"" alt=""menu item thumbnail""");
                WriteLiteral(@">
                        <h3>Modelo Beer</h3>
                    </div>
                    <div class=""menu-item-price"">
                        $20.00
                    </div>
                </div>
                <div class=""menu-item"" data-aos=""fade-up-left"">
                    <div class=""menu-item-title"">
                        <img src=""img/menu/10.jpg"" alt=""menu item thumbnail"">
                        <h3>Tiger Beer</h3>
                    </div>
                    <div class=""menu-item-price"">
                        $20.00
                    </div>
                </div>
                <div class=""menu-item"" data-aos=""fade-up-left"">
                    <div class=""menu-item-title"">
                        <img src=""img/menu/11.jpg"" alt=""menu item thumbnail"">
                        <h3>Cocktail</h3>
                    </div>
                    <div class=""menu-item-price"">
                        $20.00
                    </div>
                </div>
        ");
                WriteLiteral(@"        <div class=""menu-item"" data-aos=""fade-up-left"">
                    <div class=""menu-item-title"">
                        <img src=""img/menu/11.jpg"" alt=""menu item thumbnail"">
                        <h3>Budweiser</h3>
                    </div>
                    <div class=""menu-item-price"">
                        $20.00
                    </div>
                </div>
            </div>
            <div class=""row menu-tab-content"" id=""desserts"">
                <div class=""menu-item"" data-aos=""fade-up-right"">
                    <div class=""menu-item-title"">
                        <img src=""img/menu/1.jpg"" alt=""menu item thumbnail"">
                        <h3>dessert item</h3>
                    </div>
                    <div class=""menu-item-price"">
                        $10.00
                    </div>
                </div>
                <div class=""menu-item"" data-aos=""fade-up-left"">
                    <div class=""menu-item-title"">
                        <im");
                WriteLiteral(@"g src=""img/menu/2.jpg"" alt=""menu item thumbnail"">
                        <h3>dessert item</h3>
                    </div>
                    <div class=""menu-item-price"">
                        $10.00
                    </div>
                </div>
            </div>
        </div>
    </section>
    <!-- menu section end -->

    <!-- testimonials section start -->
    <section class=""testimonials-section sec-padding"" id=""testimonials"">
        <div class=""container"">
            <div class=""row"">
                <div class=""section-title"">
                    <h2 data-title=""testimonials"" data-aos=""fade-up"">some feedbacks</h2>
                </div>
            </div>
            <div class=""row"">
                <div class=""testi-item"" data-aos=""zoom-in"">
                    <div class=""testi-author"">
                        <div class=""testi-author-name"">
                            <h3>Hani</h3>
                            <span>food specialist</span>
                      ");
                WriteLiteral(@"  </div>
                        <div class=""testi-author-img"">
                            <img src=""img/testimonials/1.jpg"" alt=""testi author img"">
                        </div>
                    </div>
                    <p>Really good</p>
                    <div class=""ratings"">
                        <i class=""fas fa-star""></i>
                        <i class=""fas fa-star""></i>
                        <i class=""fas fa-star""></i>
                        <i class=""fas fa-star""></i>
                        <i class=""fas fa-star""></i>
                    </div>
                </div>
                <div class=""testi-item"" data-aos=""zoom-in"">
                    <div class=""testi-author"">
                        <div class=""testi-author-name"">
                            <h3>Jenny</h3>
                            <span>food specialist</span>
                        </div>
                        <div class=""testi-author-img"">
                            <img src=""img/testimonials/");
                WriteLiteral(@"2.jpg"" alt=""testi author img"">
                        </div>
                    </div>
                    <p>Delicious</p>
                    <div class=""ratings"">
                        <i class=""fas fa-star""></i>
                        <i class=""fas fa-star""></i>
                        <i class=""fas fa-star""></i>
                        <i class=""fas fa-star""></i>
                        <i class=""fas fa-star""></i>
                    </div>
                </div>
                <div class=""testi-item"" data-aos=""zoom-in"">
                    <div class=""testi-author"">
                        <div class=""testi-author-name"">
                            <h3>Micheal</h3>
                            <span>food specialist</span>
                        </div>
                        <div class=""testi-author-img"">
                            <img src=""img/testimonials/3.jpg"" alt=""testi author img"">
                        </div>
                    </div>
                    <p>Sound ");
                WriteLiteral(@"good</p>
                    <div class=""ratings"">
                        <i class=""fas fa-star""></i>
                        <i class=""fas fa-star""></i>
                        <i class=""fas fa-star""></i>
                        <i class=""fas fa-star""></i>
                        <i class=""fas fa-star""></i>
                    </div>
                </div>
            </div>
        </div>
    </section>

    <section class=""team-section sec-padding"" id=""team"">
        <div class=""container"">
            <div class=""row"">
                <div class=""section-title"">
                    <h2 data-title=""team"" data-aos=""fade-up"">our chefs</h2>
                </div>
            </div>
            <div class=""row"">
                <div class=""team-item"" data-aos=""flip-left"" data-aos-duration=""1000"">
                    <img src=""img/team/1.jpg"" alt=""team item"">
                    <div class=""team-item-info"">
                        <h3>Fanny</h3>
                        <p>head chef</p>");
                WriteLiteral(@"
                    </div>
                </div>
                <div class=""team-item"" data-aos=""flip-left"" data-aos-duration=""1000"">
                    <img src=""img/team/2.jpg"" alt=""team item"">
                    <div class=""team-item-info"">
                        <h3>Johnson</h3>
                        <p>head chef</p>
                    </div>
                </div>
                <div class=""team-item"" data-aos=""flip-left"" data-aos-duration=""1000"">
                    <img src=""img/team/3.jpg"" alt=""team item"">
                    <div class=""team-item-info"">
                        <h3>Kelly</h3>
                        <p>head chef</p>
                    </div>
                </div>
            </div>
        </div>
    </section>

    <footer class=""footer"" id=""footer"">
        <div class=""container"">
            <div class=""row"">
                <div class=""footer-item"" data-aos=""fade-up"">
                    <h3>our location</h3>
                    <p>61 D1 Stree");
                WriteLiteral(@"t <br> Tan Hung </p>
                </div>
                <div class=""footer-item"" data-aos=""fade-up"">
                    <h3>opening hours</h3>
                    <p>Monday to Sunday <br> 9:00 AM - 10:00 PM </p>
                </div>
                <div class=""footer-item"" data-aos=""fade-up"">
                    <h3>contact us</h3>
                    <p>84 914 494 085</p>
                    <p>miorooftop@gmail.com</p>
                    <div class=""social-links"">
                        <a href=""#""><i class=""fab fa-facebook-f""></i></a>
                        <a href=""#""><i class=""fab fa-instagram""></i></a>
                        <a href=""#""><i class=""fab fa-twitter""></i></a>
                        <a href=""#""><i class=""fab fa-youtube""></i></a>
                    </div>
                </div>
            </div>
            <div class=""row"">
                <div class=""copyright"">
                    &copy; 2021 - Designed by MioRooftop
                </div>
            </di");
                WriteLiteral("v>\r\n        </div>\r\n    </footer>\r\n\r\n    <script src=\"js/aos.js\"></script>\r\n    <script src=\"js/script.js\"></script>\r\n");
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
            WriteLiteral("\r\n");
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
