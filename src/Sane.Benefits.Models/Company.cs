using Sane.Benefits.DomainModels.Enums;

namespace Sane.Benefits.DomainModels
{
    public class Company
    {
        public string DoingBusinessAs { get; set; }        
        public string LegalName { get; set; }
        public NumberOfEmployees NumberOfEmployees { get; set; }
    }
}
