using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StudentExeciseMVC.Models
{
    public class Instructor
    {
        [Required]
        [Display(Name = "Instructor Id")]
        public int Id { get; set; }

        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required]
        [Display(Name = "Slack Handle")]
        public string SlackHandle { get; set; }

        [Required]
        [Display(Name = "Specialty")]
        public string Specialty { get; set; }

        [Required]
        [Display(Name = "Cohort")]
        public int CohortId { get; set; }

        public string FullName
        {
            get
            {
                return $"{FirstName} {LastName}";
            }
        }
    }
}
