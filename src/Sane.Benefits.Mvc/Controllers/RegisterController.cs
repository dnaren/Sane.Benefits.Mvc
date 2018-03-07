using System.Net;
using System.Web.Mvc;
using Sane.Benefits.Mvc.ViewModels;

namespace Sane.Benefits.Mvc.Controllers
{
    public class RegisterController : Controller
    {
        public ActionResult AddUser(NewUserViewModel newUser)
        {
            return new HttpStatusCodeResult(HttpStatusCode.Created);
        }
    }
}
