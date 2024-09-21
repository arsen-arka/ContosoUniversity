using System;
using System.ComponentModel.DataAnnotations;

namespace ContosoUniversity.Models
{
    public class EnrollmentDateGroup
    {
        public int EnrollmentDateGroupID { get; set; }

        [DataType(DataType.Date)]
        public DateTime? EnrollmentDate { get; set; }

        public int StudentCount { get; set; }
    }
}