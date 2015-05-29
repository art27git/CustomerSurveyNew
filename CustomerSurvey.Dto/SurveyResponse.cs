using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace CustomerSurvey.Dto
{
    public class SurveyResponse
    {
        [Required]
        public int ID { get; set; }

        [Required]
        [DisplayName("Rating")]
        public string Rating { get; set; }

        [DisplayName("Hospital name")]
        public string HospitalName { get; set; }

        [DisplayName("Any comments?")]
        public string Comments { get; set; }

        public string EmployeeName { get; set; }
    }
}
