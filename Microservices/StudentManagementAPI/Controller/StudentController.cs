using Microsoft.AspNetCore.Mvc;
using StudentManagementAPI.BusinessAccessLayer;

namespace StudentManagementAPI.Controller
{
    [ApiController]
    [Route("api/[controller]")] // Base route: /api/student
    public class StudentController : ControllerBase
    {
        private readonly StudentBAL _studentsDetailsBal;

        public StudentController(StudentBAL studentsDetailsBal)
        {
            _studentsDetailsBal = studentsDetailsBal;
        }

        [HttpGet]
        public IActionResult GetStudentDetails()
        {
            int inputStudentId = 0;
            var stuDet = _studentsDetailsBal.fetchStudentDetails(inputStudentId);
            return Ok(stuDet); 
        }

        
        [HttpGet("dropdown")]
        public IActionResult GetStudentDetailsForDropdown()
        {
            int inputStudentId = 0;
            var dropdownList = _studentsDetailsBal.GetStudentDetailsForDropdown(inputStudentId);
            return Ok(dropdownList);
        }

        [HttpGet("{registrationId:int}")]
        public IActionResult GetIndividualStudentDetailsByRegistrationId(int registrationId)
        {
            var studentDetails = _studentsDetailsBal.GetStudentDetailsByRegistrationId(registrationId);

            if (studentDetails == null)
            {
                return NotFound(new { message = $"No details found for registration ID {registrationId}" });
            }

            return Ok(studentDetails);
        }
    }
}
