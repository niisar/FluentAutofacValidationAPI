﻿using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http.Controllers;
using System.Web.Http.Filters;

namespace FluentAutofacValidationAPI.Infrastructure
{
    public class ValidateFilterAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(HttpActionContext actionContext)
        {
            if (!actionContext.ModelState.IsValid)
            {
                actionContext.Response =
                    actionContext.Request.CreateErrorResponse(HttpStatusCode.BadRequest, actionContext.ModelState);
            }
            else if (actionContext.ActionArguments.FirstOrDefault().Value == null)
            {
                actionContext.ModelState.AddModelError("Model Null", "Form is empty. Please enter some value");
                actionContext.Response =
                   actionContext.Request.CreateErrorResponse(HttpStatusCode.BadRequest, actionContext.ModelState);
            }
            base.OnActionExecuting(actionContext);
        }
    }
}