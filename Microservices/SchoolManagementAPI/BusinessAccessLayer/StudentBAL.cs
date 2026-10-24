using SchoolManagementAPI.Abstract;
using SchoolManagementAPI.Model;

namespace SchoolManagementAPI.BusinessAccessLayer
{
    public class StudentBAL
    {
        private readonly IStudent stdet;

        public StudentBAL(IStudent studentRepo)
        {
            stdet = studentRepo;
        }
        public List<Student> fetchStudentDetails(int _inputStudentId)
        {
            List<Student> detStudent = new List<Student>();
            detStudent = stdet.fetchStudentDetails(_inputStudentId);
            return detStudent;
        }

        public List<StudentDetailsForDropDown> GetStudentDetailsForDropdown(int studentId)
        {
            List<StudentDetailsForDropDown> detStudentDrpDwn = new List<StudentDetailsForDropDown>();
            detStudentDrpDwn = stdet.getStudentDetailsForDropDown(studentId);
            return detStudentDrpDwn;
        }

        public List<Student> GetStudentDetailsByRegistrationId(int selectedStudentRegId)
        {
            List<Student> detStudentbyRegId = new List<Student>();
            detStudentbyRegId = stdet.getStudentDetailsByRegistrationId(selectedStudentRegId);
            return detStudentbyRegId;
        }



    }
}
