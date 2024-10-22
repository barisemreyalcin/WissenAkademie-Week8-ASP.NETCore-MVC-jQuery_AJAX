using JQueryAJAX.Models;
using Microsoft.AspNetCore.Mvc;

namespace JQueryAJAX.Controllers
{
	public class StudentController : Controller
	{
		List<Student> students = new List<Student>()
		{
			new Student(){StudentID = 1, FirstName = "Owen", LastName = "Doe", StudentNumber = "A0001", StudentClass = 1 },
			new Student(){StudentID = 2, FirstName = "Ashley", LastName = "Doe", StudentNumber = "A0002", StudentClass = 1 },
			new Student(){StudentID = 3, FirstName = "Tim", LastName = "Doe", StudentNumber = "A0003", StudentClass = 1 },
			new Student(){StudentID = 4, FirstName = "Ursula", LastName = "Doe", StudentNumber = "A0004", StudentClass = 2 },
		};
		public IActionResult Index()
		{
			return View();
		}

		// Numarasını girdiğimizde data dönderen bir method
		public JsonResult GetStudent(int id)
		{
			Student student = students.FirstOrDefault(x => x.StudentID == id);
			return Json(student);
		}

		public IActionResult GetStudents()
		{
			return View(); 
		}
		public JsonResult GetAllStudents()
		{
			return Json(students);
		}
	}
}
