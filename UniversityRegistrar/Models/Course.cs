using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System;

namespace UniversityRegistrar.Models
{
  public class Course
  {
    public int CourseId { get; set; }
    [Required(ErrorMessage = "The course's name can't be empty!")]
    public string Description { get; set; }
    public int DepartmentId { get; set; }
    public bool IsComplete { get; set; } = false;
    public Department Department { get; set; }
    public Student Student { get; set; }
    public List<CourseDepartment> JoinDepartment { get; }
    public List<StudentCourse> JoinStudent { get; }
   
  }
}