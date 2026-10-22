namespace student_api_v2
{
    public interface IStudent
    {
        List<StudentDetails> fetchStudentDetails(int studentId);
        List<StudentDetailsForDropDown> getStudentDetailsForDropDown(int studentId);
        List<StudentDetails> getStudentDetailsByRegistrationId(int registrationId);


    }

}
