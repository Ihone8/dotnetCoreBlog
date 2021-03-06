#pragma checksum "F:\Person\BanditLearn\Blog\Blog\Areas\Admin\Views\Home\Add.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "db097ee9771d4bb76b018e6476304e26be1dcfab"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Home_Add), @"mvc.1.0.view", @"/Areas/Admin/Views/Home/Add.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Home/Add.cshtml", typeof(AspNetCore.Areas_Admin_Views_Home_Add))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"db097ee9771d4bb76b018e6476304e26be1dcfab", @"/Areas/Admin/Views/Home/Add.cshtml")]
    public class Areas_Admin_Views_Home_Add : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Blog.Model.BLOG>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/layui/layui.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "F:\Person\BanditLearn\Blog\Blog\Areas\Admin\Views\Home\Add.cshtml"
  
    Layout = "~/Areas/Admin/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(90, 354, true);
            WriteLiteral(@"
<blockquote class=""layui-elem-quote"" style=""height:30px;font-size:14px;line-height:0px;font-weight:bold;"">添加新文章</blockquote>
<form class=""layui-form"" action="""" method=""post"" style=""padding:10px;height:100%;"">
    <div class=""layui-form-item"">
        <label class=""layui-form-label"">标题：</label>
        <div class=""layui-input-block"">
            ");
            EndContext();
            BeginContext(445, 132, false);
#line 11 "F:\Person\BanditLearn\Blog\Blog\Areas\Admin\Views\Home\Add.cshtml"
       Write(Html.TextBoxFor(model => model.Title, htmlAttributes: new { @class = "layui-input", @placeholder = "请输入标题", @autocomplete = "off" }));

#line default
#line hidden
            EndContext();
            BeginContext(577, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(719, 222, true);
            WriteLiteral("        </div>\r\n    </div>\r\n    <div class=\"layui-form-item\">\r\n        <label class=\"layui-form-label\">类型：</label>\r\n        <div class=\"layui-input-block\" style=\"width:200px;\">\r\n            <select name=\"CategoryTypeId\">\r\n");
            EndContext();
#line 19 "F:\Person\BanditLearn\Blog\Blog\Areas\Admin\Views\Home\Add.cshtml"
                 foreach (Blog.Model.CATEGORY item in ViewBag.CategoryList)
                {
                    if (item.Id.ToString() == Model.CategoryTypeId)
                    {

#line default
#line hidden
            BeginContext(1129, 31, true);
            WriteLiteral("                        <option");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1160, "\"", 1176, 1);
#line 23 "F:\Person\BanditLearn\Blog\Blog\Areas\Admin\Views\Home\Add.cshtml"
WriteAttributeValue("", 1168, item.Id, 1168, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1177, 21, true);
            WriteLiteral(" selected=\"selected\">");
            EndContext();
            BeginContext(1199, 10, false);
#line 23 "F:\Person\BanditLearn\Blog\Blog\Areas\Admin\Views\Home\Add.cshtml"
                                                                Write(item.CName);

#line default
#line hidden
            EndContext();
            BeginContext(1209, 11, true);
            WriteLiteral("</option>\r\n");
            EndContext();
#line 24 "F:\Person\BanditLearn\Blog\Blog\Areas\Admin\Views\Home\Add.cshtml"
                    }

#line default
#line hidden
            BeginContext(1243, 27, true);
            WriteLiteral("                    <option");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1270, "\"", 1286, 1);
#line 25 "F:\Person\BanditLearn\Blog\Blog\Areas\Admin\Views\Home\Add.cshtml"
WriteAttributeValue("", 1278, item.Id, 1278, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1287, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(1289, 10, false);
#line 25 "F:\Person\BanditLearn\Blog\Blog\Areas\Admin\Views\Home\Add.cshtml"
                                        Write(item.CName);

#line default
#line hidden
            EndContext();
            BeginContext(1299, 11, true);
            WriteLiteral("</option>\r\n");
            EndContext();
#line 26 "F:\Person\BanditLearn\Blog\Blog\Areas\Admin\Views\Home\Add.cshtml"
                }

#line default
#line hidden
            BeginContext(1329, 208, true);
            WriteLiteral("            </select>\r\n        </div>\r\n    </div>\r\n    <div class=\"layui-form-item layui-form-text\">\r\n        <label class=\"layui-form-label\">内容：</label>\r\n        <div class=\"layui-input-block\">\r\n            ");
            EndContext();
            BeginContext(1538, 115, false);
#line 33 "F:\Person\BanditLearn\Blog\Blog\Areas\Admin\Views\Home\Add.cshtml"
       Write(Html.TextAreaFor(model => model.Content, htmlAttributes: new { @class = "layui-textarea", @placeholder = "请输入内容" }));

#line default
#line hidden
            EndContext();
            BeginContext(1653, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(1771, 188, true);
            WriteLiteral("        </div>\r\n    </div>\r\n    <div class=\"layui-form-item\">\r\n        <div class=\"layui-input-block\">\r\n            <button class=\"layui-btn\" lay-submit lay-filter=\"formDemo\">保存</button>\r\n");
            EndContext();
            BeginContext(2045, 107, true);
            WriteLiteral("            <a href=\"/Admin/Home/Default\" class=\"layui-btn\">返回列表</a>\r\n        </div>\r\n    </div>\r\n</form>\r\n");
            EndContext();
            BeginContext(2152, 44, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e6719067b155437fb6b7a7e8fbbcf12f", async() => {
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
            BeginContext(2196, 846, true);
            WriteLiteral(@"
<style>
    textarea {
        min-height: 200px;
    }
</style>
<script>
    //Demo
    layui.use(['form', 'layedit'], function () {
        var form = layui.form;
        var layedit = layui.layedit;

        // 配置 LayUi 上传图片接口
        layedit.set({
            uploadImage: {
                url: '/Admin/Home/UploadImage' //接口url
                , type: 'post' //默认post
            }
        });


        layedit.build('Content', {
            height: 200 //设置编辑器高度
        }); //建立编辑器
        //监听提交
        form.on('submit(formDemo)', function (data) {
            console.log(data.field);
            if (data.field[""Title""] == """" || data.field[""Title""] == null) {
                layer.msg(""标题不能为空！"");
                return false;
            }
            return true;
        });
    });
</script>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Blog.Model.BLOG> Html { get; private set; }
    }
}
#pragma warning restore 1591
