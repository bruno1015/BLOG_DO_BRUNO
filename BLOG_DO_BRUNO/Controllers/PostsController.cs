using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BLOG_DO_BRUNO.Models;

namespace BLOG_DO_BRUNO.Controllers
{
    public class PostsController : Controller
    {
        private BlogContext _context = new BlogContext();
        // GET: Posts
        public ActionResult Index()
        {
            var posts = _context.Post.ToList();
            return View(posts);
        }
        public ActionResult Edit(int Id)
        {
            return View();
        }
        public ActionResult Details(int id)
        {
            var post = _context.Post.SingleOrDefault(p => p.Id == id);
            if(post == null)
            {
                return HttpNotFound();
            }
            return View(post);
        }
        public ActionResult Delete(int Id)
        {
            return View();
        }
        [HttpPost]
        public ActionResult DeleteComplete(int Id)
        {
            return View();
        }
        [HttpPost]
        public ActionResult Save(Post post)
        {
            return View();
        }
    }
}