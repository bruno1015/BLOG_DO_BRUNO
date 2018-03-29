using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BLOG_DO_BRUNO.Models
{
    public class BlogContext : DbContext
    {
        public DbSet<Post> Post { get; set; }
        public BlogContext() : base("DefaultConnection")
        {

        }
    }
}