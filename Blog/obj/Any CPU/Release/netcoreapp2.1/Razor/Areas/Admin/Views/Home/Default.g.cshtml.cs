#pragma checksum "F:\Person\BanditLearn\Blog\Blog\Areas\Admin\Views\Home\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f4068599f74f7ddd1e24f575918e758cdbe9e8ba"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f4068599f74f7ddd1e24f575918e758cdbe9e8ba", @"/Areas/Admin/Views/Home/Default.cshtml")]
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
            BeginContext(68, 847, true);
            WriteLiteral(@"
<style>
    a:hover {
        text-decoration: none;
    }
</style>
<div style=""margin:10px;"">
    <div class=""layui-input-inline"">
        <a class=""layui-btn"" href=""/Admin/Home/Add"">
            <i class=""layui-icon layui-icon-add-1""></i>
            添加
        </a>
    </div>
    <div class=""layui-input-inline"">
        <input id=""txtkey"" placeholder=""标题关键字"" type=""text"" class=""layui-input"" />
    </div>
    <div class=""layui-input-inline"">
        <input id=""txtstartdate"" placeholder=""开始日期"" type=""text"" class=""layui-input"" />
    </div>
    ~
    <div class=""layui-input-inline"">
        <input id=""txtenddate"" placeholder=""结束日期"" type=""text"" class=""layui-input"" />
    </div>
    <div class=""layui-input-inline"">
        <select id=""CategoryType"" class=""layui-input"">
            <option value=""0"">所有分类</option>
");
            EndContext();
#line 31 "F:\Person\BanditLearn\Blog\Blog\Areas\Admin\Views\Home\Default.cshtml"
             foreach (Blog.Model.CATEGORY item in ViewBag.calist)
            {

#line default
#line hidden
            BeginContext(997, 23, true);
            WriteLiteral("                <option");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1020, "\"", 1036, 1);
#line 33 "F:\Person\BanditLearn\Blog\Blog\Areas\Admin\Views\Home\Default.cshtml"
WriteAttributeValue("", 1028, item.Id, 1028, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1037, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(1039, 10, false);
#line 33 "F:\Person\BanditLearn\Blog\Blog\Areas\Admin\Views\Home\Default.cshtml"
                                    Write(item.CName);

#line default
#line hidden
            EndContext();
            BeginContext(1049, 11, true);
            WriteLiteral("</option>\r\n");
            EndContext();
#line 34 "F:\Person\BanditLearn\Blog\Blog\Areas\Admin\Views\Home\Default.cshtml"
            }

#line default
#line hidden
            BeginContext(1075, 3853, true);
            WriteLiteral(@"        </select>
    </div>
    <button type=""button"" class=""layui-btn"" id=""btnSearch""><i class=""layui-icon"">&#xe615;</i> 查 询</button>
    <table class=""layui-table"">
        <thead>
            <tr>
                <th>博客标题</th>
                <th>博客类型</th>
                <th>访问量</th>
                <th>发布时间</th>
                <th align=""center"">操作</th>
            </tr>
        </thead>
        <tbody id=""BlogList""></tbody>
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
    function Del(id) {
        var Url = ""/Admin/Home/Delete/"" + id;
        layui.use('layer', function () {
            var layer = layui.layer;
            layer.confirm('是否确定删除？', function () {
                $.post(Url, function (mes) {

        ");
            WriteLiteral(@"            layer.alert(mes, function () { location.reload() });  // location.reload  // 刷新当前页面
                });
            });
        });
    }

    LoadPagingByPageIndex(1);

    function LoadPagingByPageIndex(pageIndex) {
        layui.use(['laypage', 'layer', 'laydate'], function () {
            var laypage = layui.laypage;
            var layer = layui.layer;
            var laydate = layui.laydate;
            laydate.render({
                elem: '#txtstartdate'
            });
            laydate.render({
                elem: '#txtenddate'
            });
            var key = $.trim($('#txtkey').val());  //标题关键字
            var startdate = $('#txtstartdate').val(); // 开始时间
            var enddate = $('#txtenddate').val();  // 结束时间
            var cabh = $('#CategoryType').val();    //分类编号
            var postdata = {
                Title: key,
                startdate: startdate,
                enddate: enddate,
                CategoryType: cabh,
              ");
            WriteLiteral(@"  PageSize: PageSize,
                PageIndex: pageIndex - 1
            };
            var Url = ""/Admin/Home/GetBlogListByPaging"";
            var BlogListHmtl = document.getElementById(""BlogList"");
            $.post(Url, postdata, function (data) {
                //console.log(data);
                // 第一页
                if (pageIndex == 1) {
                    laypage.render({
                        elem: 'page',
                        count: data.total,
                        //skin: '#5fb878',
                        //skip: false,
                        limit: PageSize,
                        jump: function (obj, first) {
                            if (!first) {
                                $('#pageIndex').html(obj.curr);
                                LoadPagingByPageIndex(obj.curr);
                            }
                        }
                    });
                }
                $(""#pageCount"").html(data.pageCount);  // 共多少页
                $(""#");
            WriteLiteral(@"totalCount"").html(data.total);    // 多少条记录
                $('#pageIndex').html(pageIndex);
                var Hmtl = """";
                $.each(data.data, function (i, obj) {
                    Hmtl += ""<tr><td>"" + obj.title + ""</td><td>"" + obj.categoryTypeName + ""</td><td>"" + obj.visit + ""</td><td>"" + obj.createDate + ""</td> <td><a href='/Admin/Home/Add/"" + obj.id + ""' title='编辑'><i class='layui-icon layui-icon-edit'></i>编辑</a><a href='javascriprt:void(0);' onclick='Del("" + obj.id + "")' title='删除'><i class='layui-icon layui-icon-delete'></i>删除</a></td></tr>"";
                });
                BlogListHmtl.innerHTML = Hmtl;

            })
        })
    }
    $(""#btnSearch"").click(function () {
        LoadPagingByPageIndex(1);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
