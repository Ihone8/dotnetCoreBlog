#pragma checksum "F:\Person\BanditLearn\Blog\Blog\Areas\Admin\Views\System\ChangePassWord.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1fb5ae626072ebee56f4b9ccd86c09f24f039e60"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_System_ChangePassWord), @"mvc.1.0.view", @"/Areas/Admin/Views/System/ChangePassWord.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/System/ChangePassWord.cshtml", typeof(AspNetCore.Areas_Admin_Views_System_ChangePassWord))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1fb5ae626072ebee56f4b9ccd86c09f24f039e60", @"/Areas/Admin/Views/System/ChangePassWord.cshtml")]
    public class Areas_Admin_Views_System_ChangePassWord : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "F:\Person\BanditLearn\Blog\Blog\Areas\Admin\Views\System\ChangePassWord.cshtml"
  
    Layout = "~/Areas/Admin/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(68, 1459, true);
            WriteLiteral(@"
<style>
    .layui-form {
        margin: 5px;
    }
</style>
<form class=""layui-form"" action="""">
    <div class=""layui-form-item"">
        <label class=""layui-form-label"" style=""width:100px;"">新密码：</label>
        <div class=""layui-input-block"">
            <input type=""password"" name=""password"" id=""password"" required lay-verify=""required"" placeholder=""新密码"" autocomplete=""off"" class=""layui-input"" maxlength=""16"">
        </div>
    </div>
    <div class=""layui-form-item"">
        <div class=""layui-input-block"">
            <button class=""layui-btn"" lay-submit lay-filter=""formDemo"" id=""btnChange"">保存</button>
        </div>
    </div>
</form>
<script>
    layui.use(['layer', 'form'], function () {
        var layer = layui.layer;
        var form = layui.form;

        //监听提交
        form.on('submit(formDemo)', function (data) {
            //layer.msg(JSON.stringify(data.field));
            //layer.msg(""通过验证"");
            var Url = ""/Admin/System/ChangePassWord"";
            var d");
            WriteLiteral(@"ata = { passWord: $(""#password"").val() };
            $.post(Url, data, function (data) {
                if (data.state == ""y"") {
                    layer.alert(data.msg, function () { parent.location.href = ""/Admin/Home/UserLogin"" });

                }
                else {
                    layer.alert(data.msg);
                }
            }, 'json');
            return false;
        });

    });
</script>");
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
