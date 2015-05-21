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

        [DisplayName("Hospital/Clinic name")]
        public string HospitalName { get; set; }

        [DisplayName("Any comments?")]
        public string Comments { get; set; }

        [DisplayName("Do you wish to be contacted regarding your feedback?")]
        public bool CallBack { get; set; }
    }
}
