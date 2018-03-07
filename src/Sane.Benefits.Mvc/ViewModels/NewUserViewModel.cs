using Sane.Benefits.Models.Enums;

namespace Sane.Benefits.Mvc.ViewModels
{
    public class NewUserViewModel
    {
        public string FullName { get; set; }
        public string Email { get; set; }
        public string CompanyName { get; set; }
        public string PhoneNumber { get; set; }
        public string Title { get; set; }
        public NumberOfEmployees NumberOfEmployees { get; set; }
    }
}
