using System.Collections.Generic;

namespace UniversityRegistrar.Models
{
  public class Department
  {
    public int DepartmentId { get; set; }
    public string CourseName { get; set; }
    public List<CourseDepartment> JoinEntities { get; }
  }
}