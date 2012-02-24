﻿    using System.Web.Mvc;

    namespace Website.Models
    {
        public class RestHttpVerbFilter : ActionFilterAttribute
        {
            public override void OnActionExecuting(ActionExecutingContext filterContext)
            {
                var httpMethod = filterContext.HttpContext.Request.HttpMethod;
                filterContext.ActionParameters["httpVerb"] = httpMethod;
                base.OnActionExecuting(filterContext);
            }
        }
    }