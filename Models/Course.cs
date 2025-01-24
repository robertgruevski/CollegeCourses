using System.ComponentModel.DataAnnotations;

namespace CollegeCourses.Models
{
	public class Course
	{
		public Course()
		{
			Students = new List<Student>();
		}
		public int CourseId { get; set; } // Primary Key and Identity
		[Required]
		public string? Title { get; set; }
		public List<Student> Students { get; set; }
	}
}
