using Microsoft.AspNetCore.Mvc;

    namespace student_api_v2
    {
        [ApiController]
        [Route("api/[controller]")] // Base route: /api/student
        public class StudentController : ControllerBase
        {
            private readonly StudentDetailsBAL _studentsDetailsBal;

            public StudentController(StudentDetailsBAL studentsDetailsBal)
            {
                _studentsDetailsBal = studentsDetailsBal;
            }

            // GET: /api/student
            // Fetches all student records
            [HttpGet]
            public IActionResult GetStudentDetails()
            {
                int inputStudentId = 0;
                var stuDet = _studentsDetailsBal.fetchStudentDetails(inputStudentId);
                return Ok(stuDet); // Returns 200 OK with JSON array
            }

            // GET: /api/student/dropdown
            // Fetches student records for dropdown binding
            [HttpGet("dropdown")]
            public IActionResult GetStudentDetailsForDropdown()
            {
                int inputStudentId = 0;
                var dropdownList = _studentsDetailsBal.GetStudentDetailsForDropdown(inputStudentId);
                return Ok(dropdownList);
            }

            // GET: /api/student/101
            // REST standard uses GET with a route parameter to retrieve by ID
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







