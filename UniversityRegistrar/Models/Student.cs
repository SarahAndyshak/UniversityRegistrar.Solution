using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System;

namespace UniversityRegistrar.Models
{
  public class Student
  {
    public int StudentId { get; set; }
    [Required(ErrorMessage = "The students name can't be empty!")]
    public string StudentName { get; set; }
    public DateTime? EnrollmentDate { get; set; }
    public List<Course> Courses { get; set; }
  }
}