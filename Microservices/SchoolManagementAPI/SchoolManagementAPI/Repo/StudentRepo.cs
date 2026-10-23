using Microsoft.Data.SqlClient;
using SchoolManagementAPI.Abstract;
using SchoolManagementAPI.Model;
using System.Data;
namespace SchoolManagementAPI.Repo
{
    public class StudentRepo:DepartmentRepo,IStudent
    {
        public StudentRepo(IConfiguration configuration) : base(configuration)
        {
            //_connString =configuration.GetConnectionString( "SchoolManagementAppDbConnectionString");
        }

        /*---------------------------------------------- Student Data ----------------------------------------------*/
        public List<Student> fetchStudentDetails(int studentId)
        {
            List<Student> stuDet = new List<Student>();

            using (var con = new SqlConnection(_connString))
            using (var cmd = new SqlCommand("fetchStudentDetails", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@studentId", SqlDbType.Int) { Value = studentId });

                var da = new SqlDataAdapter(cmd);
                var ds = new DataSet();

                da.Fill(ds);

                DataTable dt = new DataTable();
                dt = ds.Tables[0];

                foreach (DataRow dr in dt.Rows)
                {
                    Student studentDet = new Student();

                    studentDet.Id = Convert.ToInt32(dr["Id"]);
                   
                    studentDet.StudentFirstName = dr["StudentFirstName"].ToString();
                    studentDet.StudentMiddleName = dr["StudentMiddleName"].ToString();
                    studentDet.StudentLastName = dr["StudentLastName"].ToString();
                    studentDet.StudentName = dr["StudentName"].ToString();
                    studentDet.IsRegisteredStudent = Convert.ToChar(dr["IsRegisteredStudent"]);
                    studentDet.StudentRegistrationId = dr["StudentRegistrationId"].ToString();
                    studentDet.StudentRegistrationDate = Convert.ToDateTime(dr["StudentRegistrationDate"]);

                    studentDet.RollNumber = Convert.ToInt32(dr["RollNumber"]);
                    studentDet.StudentClass = Convert.ToInt32(dr["ClassId"]);
                    studentDet.StudentSectionId = Convert.ToInt32(dr["SectionId"]);
                    studentDet.StudentSectionName = Convert.ToChar(dr["SectionName"]);

                    studentDet.StudentPhoneNumber = dr["StudentPhoneNumber"].ToString();
                    studentDet.StudentAddressLine1 = dr["StudentAddressLine1"].ToString();
                    studentDet.StudentAddressLine2 = dr["StudentAddressLine2"].ToString();
                    studentDet.StudentAddress = dr["StudentAddress"].ToString();
                    studentDet.StudentCity = dr["City"].ToString();
                    studentDet.StudentState = dr["HomeState"].ToString();
                    studentDet.StudentCountry = dr["Country"].ToString();
                    studentDet.StudentZipCode = dr["ZipCode"].ToString();
                    studentDet.StudentEmailId = dr["EmailId"].ToString();

                    
                    

                    stuDet.Add(studentDet);
                }
            }

            return stuDet;


        }


        public List<StudentDetailsForDropDown> getStudentDetailsForDropDown(int studentId)
        {
            List<StudentDetailsForDropDown> lstStdDrpDwn = new List<StudentDetailsForDropDown>();
            using (var con = new SqlConnection(_connString))
            using (var cmd = new SqlCommand("fetchStudentDetails", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@studentId", SqlDbType.Int) { Value = studentId });

                var da = new SqlDataAdapter(cmd);

                var ds = new DataSet();

                da.Fill(ds);

                DataTable dt = new DataTable();
                dt = ds.Tables[1];

                foreach (DataRow dr in dt.Rows)
                {
                    StudentDetailsForDropDown studentDetailsByDropDown = new StudentDetailsForDropDown();
                    studentDetailsByDropDown.StudentIdForDrpDwn = Convert.ToInt32(dr["RelationshipId"]);
                    studentDetailsByDropDown.StudentFullNameForDrpDwn = dr["StudentName"].ToString();


                    lstStdDrpDwn.Add(studentDetailsByDropDown);
                }
                return lstStdDrpDwn;
            }
        }

        public List<Student> getStudentDetailsByRegistrationId(int registrationId)
        {
            List<Student> lstStdDetailsbyRegId = new List<Student>();

            using (var con = new SqlConnection(_connString))
            using (var cmd = new SqlCommand("fetchStudentDetails", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@studentId", SqlDbType.Int) { Value = registrationId });

                var da = new SqlDataAdapter(cmd);

                var ds = new DataSet();

                da.Fill(ds);

                DataTable dt = new DataTable();
                dt = ds.Tables[0];


                foreach (DataRow dr in dt.Rows)
                {
                    Student studentDetByRegId = new Student();

                    studentDetByRegId.StudentFirstName = dr["StudentFirstName"].ToString();
                    studentDetByRegId.StudentMiddleName = dr["StudentMiddleName"].ToString();
                    studentDetByRegId.StudentLastName = dr["StudentLastName"].ToString();
                    studentDetByRegId.StudentName = dr["StudentName"].ToString();
                    studentDetByRegId.IsRegisteredStudent = Convert.ToChar(dr["IsRegisteredStudent"]);
                    studentDetByRegId.StudentRegistrationId = dr["StudentRegistrationId"].ToString();
                    studentDetByRegId.StudentRegistrationDate = Convert.ToDateTime(dr["StudentRegistrationDate"]);

                    studentDetByRegId.RollNumber = Convert.ToInt32(dr["RollNumber"]);
                    studentDetByRegId.StudentClass = Convert.ToInt32(dr["ClassId"]);
                    studentDetByRegId.StudentSectionId = Convert.ToInt32(dr["SectionId"]);
                    studentDetByRegId.StudentSectionName = Convert.ToChar(dr["SectionName"]);

                    studentDetByRegId.StudentPhoneNumber = dr["StudentPhoneNumber"].ToString();
                    studentDetByRegId.StudentAddressLine1 = dr["StudentAddressLine1"].ToString();
                    studentDetByRegId.StudentAddressLine2 = dr["StudentAddressLine2"].ToString();
                    studentDetByRegId.StudentAddress = dr["StudentAddress"].ToString();
                    studentDetByRegId.StudentCity = dr["City"].ToString();
                    studentDetByRegId.StudentState = dr["HomeState"].ToString();
                    studentDetByRegId.StudentCountry = dr["Country"].ToString();
                    studentDetByRegId.StudentZipCode = dr["ZipCode"].ToString();
                    studentDetByRegId.StudentEmailId = dr["EmailId"].ToString();

                    lstStdDetailsbyRegId.Add(studentDetByRegId);


                }

                return lstStdDetailsbyRegId;
            }
        }



    }
}
