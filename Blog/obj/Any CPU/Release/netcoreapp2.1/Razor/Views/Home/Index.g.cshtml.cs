#pragma checksum "F:\Person\BanditLearn\Blog\Blog\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "389ff5617ce3e43eb2d468b9ade7bfdc259520df"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "F:\Person\BanditLearn\Blog\Blog\Views\_ViewImports.cshtml"
using Blog;

#line default
#line hidden
#line 3 "F:\Person\BanditLearn\Blog\Blog\Views\_ViewImports.cshtml"
using Blog.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"389ff5617ce3e43eb2d468b9ade7bfdc259520df", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"efc58aef16cab77291020153f0ef68690b09c646", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery/dist/jquery.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/snow.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "F:\Person\BanditLearn\Blog\Blog\Views\Home\Index.cshtml"
  

    Blog.DAL.BlogDAL blogDAL = ViewBag.BlogDAL;

#line default
#line hidden
            BeginContext(60, 8, true);
            WriteLiteral("<html>\r\n");
            EndContext();
            BeginContext(68, 441, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fed744762a384efb96f828ce44e96b91", async() => {
                BeginContext(74, 205, true);
                WriteLiteral("\r\n    <meta charset=\"utf-8\">\r\n    <meta http-equiv=\"X-UA-Compatible\" content=\"IE=edge\">\r\n    <title></title>\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1, maximum-scale=1\">\r\n    ");
                EndContext();
                BeginContext(279, 51, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "56e401526d2f4330888caad428c69294", async() => {
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
                BeginContext(330, 134, true);
                WriteLiteral("\r\n    <link href=\"/assets/Hexo/css/style.css\" rel=\"stylesheet\" />\r\n    <link href=\"/lib/layui/css/layui.css\" rel=\"stylesheet\" />\r\n    ");
                EndContext();
                BeginContext(464, 36, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9e922ee798f14c6a807c55cf39a361fa", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(500, 2, true);
                WriteLiteral("\r\n");
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
            BeginContext(509, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(513, 6494, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a08f902b1e734fabb34d8c986214454c", async() => {
                BeginContext(519, 999, true);
                WriteLiteral(@"
    <style type=""text/css"">
        .snow-container {
            position: fixed;
            top: 0;
            left: 0;
            width: 100%;
            height: 100%;
            pointer-events: none;
            z-index: 100001;
        }
    </style>
    <div class=""snow-container""></div>
    <div id=""container"">
        <div class=""left-col"">
            <div class=""overlay""></div>
            <div class=""intrude-less"">
                <header id=""header"" class=""inner"">
                    <a href=""/"" class=""profilepic"">
                        <img lazy-src=""images/WRQ.png"" class=""js-avatar"">
                    </a>
                    <hgroup>
                        <h1 class=""header-author""><a href=""/"">一条咸鱼</a></h1>
                    </hgroup>
                    <p class=""header-subtitle"">
                        <div class="""">
                            <input type=""text"" class=""layui-input"" id=""txtkey"" placeholder=""关键字  Enter 回车搜索"" />
");
                EndContext();
                BeginContext(1674, 329, true);
                WriteLiteral(@"                        </div>
                    </p>
                    <div class=""switch-area"">
                        <div class=""switch-wrap"">
                            <section class=""switch-part switch-part1"">
                                <nav class=""header-menu"">
                                    <ul>
");
                EndContext();
#line 53 "F:\Person\BanditLearn\Blog\Blog\Views\Home\Index.cshtml"
                                         foreach (Blog.Model.CATEGORY item in ViewBag.CategoryList)
                                        {

#line default
#line hidden
                BeginContext(2147, 70, true);
                WriteLiteral("                                            <li><a href=\"javascript:;\"");
                EndContext();
                BeginWriteAttribute("onclick", " onclick=\"", 2217, "\"", 2260, 3);
                WriteAttributeValue("", 2227, "LoadPagingByPageIndex(1,", 2227, 24, true);
#line 55 "F:\Person\BanditLearn\Blog\Blog\Views\Home\Index.cshtml"
WriteAttributeValue("", 2251, item.Id, 2251, 8, false);

#line default
#line hidden
                WriteAttributeValue("", 2259, ")", 2259, 1, true);
                EndWriteAttribute();
                BeginContext(2261, 1, true);
                WriteLiteral(">");
                EndContext();
                BeginContext(2263, 10, false);
#line 55 "F:\Person\BanditLearn\Blog\Blog\Views\Home\Index.cshtml"
                                                                                                              Write(item.CName);

#line default
#line hidden
                EndContext();
                BeginContext(2273, 2, true);
                WriteLiteral(" （");
                EndContext();
                BeginContext(2277, 41, false);
#line 55 "F:\Person\BanditLearn\Blog\Blog\Views\Home\Index.cshtml"
                                                                                                                            Write(blogDAL.GetCountByCategoryTypeId(item.Id));

#line default
#line hidden
                EndContext();
                BeginContext(2319, 12, true);
                WriteLiteral("）</a></li>\r\n");
                EndContext();
#line 56 "F:\Person\BanditLearn\Blog\Blog\Views\Home\Index.cshtml"
                                        }

#line default
#line hidden
                BeginContext(2374, 1513, true);
                WriteLiteral(@"                                        <div class=""clearfix""></div>
                                    </ul>
                                </nav>
                                <nav class=""header-nav"">
                                    <div class=""social"">
                                        <a class=""github"" target=""_blank"" href=""https://github.com/Ihone8"" title=""github"">github</a>
                                        <a class=""mail"" target=""_blank"" href=""mailto:2213629594qq.com"" title=""Email"">Email</a>
                                    </div>
                                </nav>
                            </section>
                        </div>
                    </div>
                </header>
            </div>

        </div>
        <div class=""mid-col"">
            <nav id=""mobile-nav"">
                <div class=""overlay"">
                    <h1 class=""header-author js-mobile-header hide"">一条咸鱼</h1>
                </div>
                <div class=""intrude-");
                WriteLiteral(@"less"">
                    <header id=""header"" class=""inner"">
                        <div class=""profilepic"">
                            <img src="""" class=""js-avatar"">
                        </div>
                        <hgroup>
                            <h1 class=""header-author"">WRQ</h1>
                        </hgroup>

                        <p class=""header-subtitle"">一条咸鱼</p>

                        <nav class=""header-menu"">
                            <ul>
");
                EndContext();
#line 91 "F:\Person\BanditLearn\Blog\Blog\Views\Home\Index.cshtml"
                                 foreach (Blog.Model.CATEGORY item in ViewBag.CategoryList)
                                {

#line default
#line hidden
                BeginContext(4015, 62, true);
                WriteLiteral("                                    <li><a href=\"javascript:;\"");
                EndContext();
                BeginWriteAttribute("onclick", " onclick=\"", 4077, "\"", 4120, 3);
                WriteAttributeValue("", 4087, "LoadPagingByPageIndex(1,", 4087, 24, true);
#line 93 "F:\Person\BanditLearn\Blog\Blog\Views\Home\Index.cshtml"
WriteAttributeValue("", 4111, item.Id, 4111, 8, false);

#line default
#line hidden
                WriteAttributeValue("", 4119, ")", 4119, 1, true);
                EndWriteAttribute();
                BeginContext(4121, 1, true);
                WriteLiteral(">");
                EndContext();
                BeginContext(4123, 10, false);
#line 93 "F:\Person\BanditLearn\Blog\Blog\Views\Home\Index.cshtml"
                                                                                                      Write(item.CName);

#line default
#line hidden
                EndContext();
                BeginContext(4133, 2, true);
                WriteLiteral(" （");
                EndContext();
                BeginContext(4137, 41, false);
#line 93 "F:\Person\BanditLearn\Blog\Blog\Views\Home\Index.cshtml"
                                                                                                                    Write(blogDAL.GetCountByCategoryTypeId(item.Id));

#line default
#line hidden
                EndContext();
                BeginContext(4179, 12, true);
                WriteLiteral("）</a></li>\r\n");
                EndContext();
#line 94 "F:\Person\BanditLearn\Blog\Blog\Views\Home\Index.cshtml"
                                }

#line default
#line hidden
                BeginContext(4226, 1279, true);
                WriteLiteral(@"                                <div class=""clearfix""></div>
                            </ul>
                        </nav>
                        <nav class=""header-nav"">
                            <div class=""social"">
                                <a class=""github"" target=""_blank"" href=""https://github.com/Ihone8"" title=""github"">github</a>
                                <a class=""mail"" target=""_blank"" href=""mailto:2213629594qq.com"" title=""Email"">Email</a>
                            </div>
                        </nav>
                    </header>
                </div>
            </nav>

            <div class=""body-wrap"">
                <div id=""BlogList""></div>
                <div>
                    <div style=""float:left;line-height:55px;margin:0 15px;font-size:14px;"">
                        当前共<span id=""totalCount""></span>篇文章，第<span id=""pageIndex""></span>页/共<span id=""pageCount""></span>页
                    </div>
                </div>
                <div id=""page"" st");
                WriteLiteral("yle=\"margin-left:32px;\"></div>\r\n            </div>\r\n\r\n            <footer id=\"footer\">\r\n                <div class=\"outer\">\r\n                    <div id=\"footer-info\">\r\n                        <div class=\"footer-left\">\r\n                            &copy; ");
                EndContext();
                BeginContext(5506, 17, false);
#line 122 "F:\Person\BanditLearn\Blog\Blog\Views\Home\Index.cshtml"
                              Write(DateTime.Now.Year);

#line default
#line hidden
                EndContext();
                BeginContext(5523, 1477, true);
                WriteLiteral(@" <a href=""https://github.com/Ihone8"">Ihone8</a>, Template

                        </div>
                        <div class=""footer-right"">
                            Powered by <a href=""https://github.com/Ihone8/dotnetCoreBlog"" target=""_blank"">XYBlog</a>
                        </div>
                    </div>
                </div>
            </footer>
        </div>
        <link href=""/assets/Hexo/css/fancybox.css"" rel=""stylesheet"" />
        <link href=""/assets/Hexo/css/fancybox.css"" rel=""stylesheet"" />
        <script src=""/assets/Hexo/js/highlight.js""></script>
        <script src=""/assets/Hexo/js/r.js""></script>
        <script src=""/assets/Hexo/js/main.js""></script>
        <script>
            var yiliaConfig = {
                fancybox: true,
                mathjax: true,
                animate: true,
                isHome: true,
                isPost: false,
                isArchive: false,
                isTag: false,
                isCategory: false,
        ");
                WriteLiteral(@"        open_in_new: false
            }
        </script>
    </div>
    <script src=""/lib/layui/layui.js""></script>
    <script src=""/js/Home/index.js""></script>
    <script>
        var PageSize = 3;
        LoadPagingByPageIndex(1, """");
        $(""#txtkey"").keyup(function () {
            if (event.keyCode == 13) {
                LoadPagingByPageIndex(1, """");
                //这里写你要执行的事件;
            }
        });
    </script>
");
                EndContext();
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
            BeginContext(7007, 9, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
