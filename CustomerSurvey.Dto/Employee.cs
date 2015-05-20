using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

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
    }
}
