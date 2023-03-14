using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System;

namespace UniversityRegistrar.Models
{
  public class Course
  {
    public int CourseId { get; set; }
    [Required(ErrorMessage = "The course's daprtment can't be empty!")]
    public string Description { get; set; }
    [Range(1, int.MaxValue, ErrorMessage = "You must add your course to a student. Have you created a student yet?")]
    public int StudentId { get; set; }
    public bool IsComplete { get; set; } = false;
    //public DateTime? DueDate { get; set; }
    public Student Student { get; set; }
    public List<CourseDepartment> JoinEntities { get;}
  }
}