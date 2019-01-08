#pragma checksum "F:\Person\BanditLearn\Blog\Blog\Areas\Admin\Views\Home\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d9cb1961d64e9248d5a9e3ee4522dd69d28dd00f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Home_Default), @"mvc.1.0.view", @"/Areas/Admin/Views/Home/Default.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Home/Default.cshtml", typeof(AspNetCore.Areas_Admin_Views_Home_Default))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d9cb1961d64e9248d5a9e3ee4522dd69d28dd00f", @"/Areas/Admin/Views/Home/Default.cshtml")]
    public class Areas_Admin_Views_Home_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "F:\Person\BanditLearn\Blog\Blog\Areas\Admin\Views\Home\Default.cshtml"
  
    Layout = "~/Areas/Admin/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(68, 360, true);
            WriteLiteral(@"
<style>
    a:hover {
        text-decoration: none;
    }
</style>
<div style=""margin:10px;"">
    <a class=""layui-btn"" href=""/Admin/Home/Add"">
        <i class=""layui-icon layui-icon-add-1""></i>
        添加
    </a>

    <table class=""layui-table"">
        <thead>
            <tr>
                <th>博客标题</th>
                <th>博客类型</th>
");
            EndContext();
            BeginContext(461, 173, true);
            WriteLiteral("                <th>访问量</th>\r\n                <th>发布时间</th>\r\n                <th align=\"center\">操作</th>\r\n            </tr>\r\n        </thead>\r\n        <tbody id=\"BlogList\">\r\n");
            EndContext();
            BeginContext(1310, 2989, true);
            WriteLiteral(@"
        </tbody>
    </table>
    <div>
        <div style=""float:left;line-height:55px;margin:0 15px;font-size:14px;"">
            当前共<span id=""totalCount""></span>篇文章，第<span id=""pageIndex""></span>页/共<span id=""pageCount""></span>页
        </div>
    </div>
    <div id=""page""></div>
</div>
<script>
    var PageSize = 7;
    layui.use(['laypage', 'layer'], function () {
        var laypage = layui.laypage;
        var layer = layui.layer;
        var Url = ""/Admin/Home/GetBlogListTotal?t="" + new Date().valueOf();
        var totalCount;
        var total = document.getElementById(""totalCount"");
        var PageIndexs = document.getElementById(""pageIndex"");
        var PageCounts = document.getElementById(""pageCount"");
        $.post(Url, function (data) {
            totalCount = data;
            //console.log(data);
            //console.log(totalCount);
            var PageCount = (totalCount % PageSize == 0 ? totalCount / PageSize : Math.ceil(totalCount / PageSize));
            $(""");
            WriteLiteral(@"#totalCount"").text(data);
            $(""#pageCount"").text(PageCount);
            //PageCounts.value = PageCount;
            // console.log(PageCount);
            //执行一个laypage实例
            laypage.render({
                elem: 'page' //注意，这里的 test1 是 ID，不用加 # 号
                , count: data  //数据总数，从服务端得到
                , limit: PageSize
                , jump: function (obj, first) {
                    // console.log(obj.curr); //得到当前页，以便向服务端请求对应页的数据。
                    //console.log(obj.limit); //得到每页显示的条数
                    $(""#pageIndex"").text(obj.curr);
                    getBlogByPageIndex(obj.curr);

                }
            });
        });


    });
    function Del(id) {
        var Url = ""/Admin/Home/Delete/"" + id;
        layui.use('layer', function () {
            var layer = layui.layer;
            layer.confirm('是否确定删除？', function () {
                $.post(Url, function (mes) {

                    layer.alert(mes, function () { location.reload() }");
            WriteLiteral(@");  // location.reload  // 刷新当前页面
                });
            });
        });
    }

    function getBlogByPageIndex(pageIndex) {

        var Url = ""/Admin/Home/GetBlogListByPaging"";
        var Data = { PageIndex: pageIndex - 1, PageSize: PageSize };
        var BlogListHmtl = document.getElementById(""BlogList"");
        $.post(Url, Data, function (data) {

            var Hmtl = """";
            $.each(data.data, function (i, obj) {
                Hmtl += ""<tr><td>"" + obj.title + ""</td><td>"" + obj.categoryTypeName + ""</td><td>"" + obj.visit + ""</td><td>"" + obj.createDate + ""</td> <td><a href='/Admin/Home/Add/"" + obj.id + ""' title='编辑'><i class='layui-icon layui-icon-edit'></i>编辑</a><a href='javascriprt:void(0);' onclick='Del("" + obj.id + "")' title='删除'><i class='layui-icon layui-icon-delete'></i>删除</a></td></tr>"";
            });
            BlogListHmtl.innerHTML = Hmtl;
        })
    }

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
