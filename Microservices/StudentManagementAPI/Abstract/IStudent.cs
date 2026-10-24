using StudentManagementAPI.Model;
namespace StudentManagementAPI.Abstract
{
    public interface IStudent
    {
        List<Student> fetchStudentDetails(int studentId);
        List<StudentDetailsForDropDown> getStudentDetailsForDropDown(int studentId);
        List<Student> getStudentDetailsByRegistrationId(int registrationId);
    }
}
