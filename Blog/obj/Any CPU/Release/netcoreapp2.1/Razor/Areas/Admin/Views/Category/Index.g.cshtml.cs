#pragma checksum "F:\Person\BanditLearn\Blog\Blog\Areas\Admin\Views\Category\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ee455cc3344c79410c04000542b99bcde28cc912"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Category_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Category/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Category/Index.cshtml", typeof(AspNetCore.Areas_Admin_Views_Category_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ee455cc3344c79410c04000542b99bcde28cc912", @"/Areas/Admin/Views/Category/Index.cshtml")]
    public class Areas_Admin_Views_Category_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "F:\Person\BanditLearn\Blog\Blog\Areas\Admin\Views\Category\Index.cshtml"
  

    Layout = "~/Areas/Admin/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(70, 3472, true);
            WriteLiteral(@"
<style>
    a:hover {
        text-decoration: none;
    }
</style>
<div style=""margin:10px;"">
    <a class=""layui-btn"" href=""/Admin/Category/Add"">
        <i class=""layui-icon layui-icon-add-1""></i>
        添加
    </a>

    <table class=""layui-table"">
        <thead>
            <tr>
                <th>分类编号</th>
                <th>分类名称</th>
                <th>分类描述</th>
                <th align=""center"">操作</th>
            </tr>
        </thead>
        <tbody id=""CategoryList""></tbody>
    </table>
    <div>
        <div style=""float:left;line-height:55px;margin:0 15px;font-size:14px;"">
            当前共<span id=""totalCount""></span>条类型，第<span id=""pageIndex""></span>页/共<span id=""pageCount""></span>页
        </div>
    </div>
    <div id=""page""></div>
</div>
<script>
    var PageSize = 7;
    layui.use(['laypage', 'layer'], function () {
        var laypage = layui.laypage;
        var layer = layui.layer;
        var Url = ""/Admin/Category/GetCategoryListTotal?t="" + new Dat");
            WriteLiteral(@"e().valueOf();
        var totalCount;
        var total = document.getElementById(""totalCount"");
        var PageIndexs = document.getElementById(""pageIndex"");
        var PageCounts = document.getElementById(""pageCount"");
        $.post(Url, function (data) {
            totalCount = data;
            //console.log(data);
            //console.log(totalCount);
            var PageCount = (totalCount % PageSize == 0 ? totalCount / PageSize : Math.ceil(totalCount / PageSize));
            $(""#totalCount"").text(data);
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
                    //console.log(obj.lim");
            WriteLiteral(@"it); //得到每页显示的条数
                    $(""#pageIndex"").text(obj.curr);
                    getBlogByPageIndex(obj.curr);

                }
            });
        });


    });
    function Del(id) {
        var Url = ""/Admin/Category/Delete/"" + id;
        layui.use('layer', function () {
            var layer = layui.layer;
            layer.confirm('是否确定删除？', function () {
                $.post(Url, function (mes) {

                    layer.alert(mes, function () { location.reload() });  // location.reload  // 刷新当前页面
                });
            });
        });
    }

    function getBlogByPageIndex(pageIndex) {

        var Url = ""/Admin/Category/GetCategorListByPaging"";
        var Data = { PageIndex: pageIndex - 1, PageSize: PageSize };
        var BlogListHmtl = document.getElementById(""CategoryList"");
        $.post(Url, Data, function (data) {

            var Hmtl = """";
            $.each(data.data, function (i, obj) {
                Hmtl += ""<tr><td>"" + obj.id ");
            WriteLiteral(@"+ ""</td><td>"" + obj.cName + ""</td><td>"" + obj.remark + ""</td><td><a href='/Admin/Category/Add/"" + obj.id + ""' title='编辑'><i class='layui-icon layui-icon-edit'></i>编辑</a><a href='javascriprt:void(0);' onclick='Del("" + obj.id + "")' title='删除'><i class='layui-icon layui-icon-delete'></i>删除</a></td></tr>"";
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
