﻿using System.Web;
using System.Web.Mvc;

namespace BLOG_DO_BRUNO
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
