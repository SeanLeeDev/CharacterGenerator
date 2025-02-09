﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CharacterGeneratorWeb.Models
{
    public class MustBeLoggedInAttribute : AuthorizeAttribute
    {
        public override void OnAuthorization(AuthorizationContext filterContext)
        {
            if(filterContext.HttpContext.User.Identity.IsAuthenticated)
            {
                //call base class to allow user into the action method
                base.OnAuthorization(filterContext);
            }
            else
            {
                string ReturnURL = filterContext.RequestContext.HttpContext.Request.Path.ToString();
                filterContext.Controller.TempData.Add("Message", $"You must be logged into any account to access this resouce, you are currently not logged in at all");
                filterContext.Controller.TempData.Add("ReturnURL", ReturnURL);
                System.Web.Routing.RouteValueDictionary dict = new System.Web.Routing.RouteValueDictionary();
                dict.Add("Controller", "Home");
                dict.Add("Action", "Login");
                filterContext.Result = new RedirectToRouteResult(dict);
            }
        }
    }
}