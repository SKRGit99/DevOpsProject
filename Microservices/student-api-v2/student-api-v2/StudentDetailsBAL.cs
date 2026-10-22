namespace student_api_v2
{
    public class StudentDetailsBAL
    {
        
        private readonly IStudent stdet;

        public StudentDetailsBAL(IStudent studentRepo)
        {
            stdet = studentRepo;
        }
        public List<StudentDetails> fetchStudentDetails(int _inputStudentId)
        {
            List<StudentDetails> detStudent = new List<StudentDetails>();
            detStudent = stdet.fetchStudentDetails(_inputStudentId);
            return detStudent;
        }

        public List<StudentDetailsForDropDown> GetStudentDetailsForDropdown(int studentId)
        {
            List<StudentDetailsForDropDown> detStudentDrpDwn = new List<StudentDetailsForDropDown>();
            detStudentDrpDwn = stdet.getStudentDetailsForDropDown(studentId);
            return detStudentDrpDwn;
        }

        public List<StudentDetails> GetStudentDetailsByRegistrationId(int selectedStudentRegId)
        {
            List<StudentDetails> detStudentbyRegId = new List<StudentDetails>();
            detStudentbyRegId = stdet.getStudentDetailsByRegistrationId(selectedStudentRegId);
            return detStudentbyRegId;
        }





    }
}
