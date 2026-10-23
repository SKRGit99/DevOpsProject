using SchoolManagementAPI.Model;

namespace SchoolManagementAPI.Abstract
{
    public interface IStudent
    {
        List<Student> fetchStudentDetails(int studentId);
        List<StudentDetailsForDropDown> getStudentDetailsForDropDown(int studentId);
        List<Student> getStudentDetailsByRegistrationId(int registrationId);
    }
}
