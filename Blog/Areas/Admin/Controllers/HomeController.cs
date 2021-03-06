﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Blog.DAL;
using Blog.Model;
using System.Net.Http.Headers;
using System.IO;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
namespace Blog.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HomeController : Controller
    {
        CategoryDAL _CategoryDAL;
        BlogDAL _BlogDAL;
        AdminDAL _AdminDAL;
        private IHostingEnvironment hostingEnv;

        public HomeController(CategoryDAL categoryDal, BlogDAL blogDal, IHostingEnvironment hostingEnvironment, AdminDAL adminDAL)
        {
            _CategoryDAL = categoryDal;
            _BlogDAL = blogDal;
            _AdminDAL = adminDAL;
            hostingEnv = hostingEnvironment;
        }
        public IActionResult Index()
        {
            string UserName = string.Empty;

            UserName = HttpContext.Session.GetString("User");
            if (string.IsNullOrEmpty(UserName))
            {
                Response.Redirect("/Admin/Home/UserLogin");
            }
            ViewBag.UserName = UserName;
            return View();
        }

        public IActionResult Default()
        {
            ViewBag.calist = _CategoryDAL.GetList();
            return View();
        }

        [HttpGet]
        public IActionResult Add(int? Id)
        {
            ViewBag.CategoryList = _CategoryDAL.GetList();
            var Blog = new BLOG();
            if (Id != null)
            {
                Blog = _BlogDAL.GetOne(Id.Value);
            }
            return View(Blog);
        }

        /// <summary>
        /// 添加博客
        /// </summary>
        /// <param name="blog"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Add(BLOG blog)
        {
            if (blog.Id == 0)
            {
                var Type = _CategoryDAL.GetOne(int.Parse(blog.CategoryTypeId));
                if (Type != null)
                {
                    blog.CategoryTypeName = Type.CName;
                }
                blog.Content_Md = blog.Content;
                blog.Remark = "";
                blog.BlogId = Guid.NewGuid().ToString();
                blog.UserID = "100";
                _BlogDAL.Add(blog);
            }
            else
            {
                blog.Content_Md = blog.Content;
                var Type = _CategoryDAL.GetOne(int.Parse(blog.CategoryTypeId));
                if (Type != null)
                {
                    blog.CategoryTypeName = Type.CName;
                }
                blog.Content_Md = blog.Content;
                _BlogDAL.Update(blog);
            }
            return Redirect("/Admin/Home/Default");
        }

        /// <summary>
        ///  获取博客总数量
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public IActionResult GetBlogListTotal()
        {
            var Total = _BlogDAL.GetCount();

            return Content(Total.ToString());
        }

        /// <summary>
        ///  根据分页获取博客数据
        /// </summary>
        /// <param name="PageIndex">页码</param>
        /// <param name="PageSize">页面显示多少条</param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult GetBlogListByPaging(int PageIndex, int PageSize, string Title, string startdate, string enddate, string CategoryType)
        {

            string where = " 1 = 1 and state = 0 ";
            //var BlogList = _BlogDAL.GetList();
            if (!string.IsNullOrEmpty(Title))
            {
                //BlogList = BlogList.Where(o => o.Title.Contains(Title));
                where += $" and Title like '%{Title}%' or Content like '%{Title}%'";
            }
            if (!string.IsNullOrEmpty(startdate))
            {
                where += $" and createdate >= {startdate}";
                //BlogList = BlogList.Where(o => o.CreateDate >= DateTime.Parse(startdate));
            }
            if (!string.IsNullOrEmpty(enddate))
            {
                where += $" and createdate <= {enddate}";
                //BlogList = BlogList.Where(o => o.CreateDate <= DateTime.Parse(enddate));
            }
            if (!string.IsNullOrEmpty(CategoryType) && CategoryType != "0")
            {
                where += $" and CategoryTypeId = {CategoryType}";
                //BlogList = BlogList.Where(o => o.CategoryTypeId.Equals(CategoryType));
            }
            var list = _BlogDAL.GetBlogListByPaging("id ", PageSize, PageIndex, where);
            //var list = BlogList.Skip(PageSize * PageIndex).Take(PageSize).ToList();
            int Count = _BlogDAL.GetCount(where);
            var PageCount = Count % PageSize == 0 ? Count / PageSize : Count / PageSize + 1;
            return Json(new { data = list, PageCount = PageCount, total = Count });
        }

        [HttpPost]
        public IActionResult Delete(int Id)
        {
            if (_BlogDAL.Delete(Id))
            {
                return Content("删除成功！");
            }
            return Content("删除失败！.请联系管理员。");
        }


        /// layui在线编辑器里的上传图片功能
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public IActionResult UploadImage()
        {
            #region 文件上传
            var imgFile = Request.Form.Files[0];
            if (imgFile != null && !string.IsNullOrEmpty(imgFile.FileName))
            {
                long size = 0;
                string tempname = "";
                var filename = ContentDispositionHeaderValue
                                .Parse(imgFile.ContentDisposition)
                                .FileName
                                .Trim('"');
                var extname = filename.Substring(filename.LastIndexOf("."), filename.Length - filename.LastIndexOf(".")); // 文件扩展名

                var filename1 = System.Guid.NewGuid().ToString().Substring(0, 6) + extname;     //随机生成文件名称
                tempname = filename1;
                var path = hostingEnv.WebRootPath;
                string dir = DateTime.Now.ToString("yyyyMMdd");
                if (!System.IO.Directory.Exists(hostingEnv.WebRootPath + $@"/upload/{dir}"))
                {
                    System.IO.Directory.CreateDirectory(hostingEnv.WebRootPath + $@"/upload/{dir}");
                }
                filename = hostingEnv.WebRootPath + $@"/upload/{dir}/{filename1}";
                size += imgFile.Length;

                using (FileStream fs = System.IO.File.Create(filename))
                {
                    imgFile.CopyTo(fs);
                    fs.Flush();
                }
                return Json(new { code = 0, msg = "上传成功", data = new { src = $"/upload/{dir}/{filename1}", title = filename.Split('.')[0] } });
            }
            return Json(new { code = 1, msg = "上传失败", });
            #endregion
        }

        public IActionResult UserLogin()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(string UserName, string Password)
        {

            if (_AdminDAL.UserLogin(UserName, Password) > 0)
            {
                HttpContext.Session.SetString("User", UserName);
                return Json(new { status = "y", msg = "登入成功！" });
            }
            else
            {
                return Json(new { status = "n", msg = "用户名或密码错误！" });
            }
        }

    }
}