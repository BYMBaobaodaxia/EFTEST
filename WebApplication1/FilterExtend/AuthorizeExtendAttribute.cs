using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
namespace WebApplication1.FilterExtend
{
    public class AuthorizeExtendAttribute: AuthorizeAttribute
    {
        public override void OnAuthorization(AuthorizationContext filterContext)
        {
       
           if (filterContext.RequestContext.HttpContext.Session["UserInfo"] == null)
           {

               filterContext.Result = new RedirectResult("~/Shared/Error");
               
           }else
           {
               return;
           }
        }
    }
}