using System;
using System.Net;
using System.Web.Mvc;
using Sane.Benefits.Core.Interfaces;
using Sane.Benefits.DomainModels;
using Sane.Benefits.DomainModels.Enums;
using Sane.Benefits.Mvc.ViewModels;

namespace Sane.Benefits.Mvc.Controllers
{
    public class RegisterController : Controller
    {
        private readonly ICompanyService _companyService;
        private readonly IUserService _userService;

        public RegisterController(ICompanyService companyService, IUserService userService)
        {
            _companyService = companyService;
            _userService = userService;
        }

        public ActionResult AddUser(NewUserViewModel newUser)
        {
            var company = new Company
            {
                DoingBusinessAs = newUser.CompanyName,
                LegalName = newUser.CompanyName,
                NumberOfEmployees = newUser.NumberOfEmployees
            };
            var user = new User
            {
                FullName = newUser.FullName,
                Title = newUser.Title,
                EmailAddress = newUser.Email,
                PhoneNumber = newUser.PhoneNumber
            };

            try
            {
                _companyService.Add(company);
                _userService.Add(user);
            
                return new HttpStatusCodeResult(HttpStatusCode.Created);
            }
            catch (Exception ex)
            {
                return new HttpStatusCodeResult(HttpStatusCode.InternalServerError);
            }
        }
    }
}
