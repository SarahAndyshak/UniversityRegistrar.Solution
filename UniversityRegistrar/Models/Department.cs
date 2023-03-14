using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace UniversityRegistrar.Models
{
  public class Department
  {
    public int DepartmentId { get; set; }
    [Required(ErrorMessage = "The course's daprtment can't be empty!")]
    public string CourseName { get; set; }//Actually handling department name
    public List<CourseDepartment> JoinEntities { get; }
  }
}