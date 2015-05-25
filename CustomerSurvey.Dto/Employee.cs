using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Web.Configuration;

namespace CustomerSurvey.Dto
{
    public class Employee
    {
        [Required]
        public int ID { get; set; }

        [Required]
        [DisplayName("First Name *")]
        public string FirstName { get; set; }

        [Required]
        [DisplayName("Last Name *")]
        public string LastName { get; set; }

        [Required]
        [DisplayName("Unique Link")]
        public string UniqueLink {
            get
            {
                return WebConfigurationManager.AppSettings["Site.BaseUrl"] + "/SurveyResponse/Create/" + ID.ToString();
            }}
    }
}
