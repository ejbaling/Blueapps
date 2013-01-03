using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Blueapps.Core.Validation;

namespace Blueapps.Web.Controllers
{
    public abstract class BaseController : Controller
    {
        [NonAction]
        protected void ConsumeError(string field, string error)
        {
            ModelState.AddModelError(field, error);
        }

        [NonAction]
        protected void ConsumeError(IValidationError error)
        {
            ModelState.AddModelError(error.Field, error.Error);
        }

        [NonAction]
        protected void ConsumeErrors(IValidationErrors errors)
        {
            //ModelState.Clear();
            foreach (IValidationError error in errors)
            {
                ConsumeError(error);
            }
        }

        [NonAction]
        protected void ConsumeException(Exception exception)
        {
            ConsumeError("_FORM", exception.Message);
        }
    }
}