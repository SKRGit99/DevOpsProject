using Microsoft.Data.SqlClient;
using SchoolManagementAPI.Abstract;
using SchoolManagementAPI.Model;
using System.Data;

namespace SchoolManagementAPI.Repo
{
    
    public class CentralRepo: ICentralStudent
    {
        protected readonly string? _connString;

        public CentralRepo(IConfiguration configuration) 
        {
            _connString = configuration.GetConnectionString("SchoolManagementAppDbConnectionString");
        }

       
        public async Task UpsertStudentAsync(Student student)
        {
            using var conn = new SqlConnection(_connString);
            using var cmd = new SqlCommand("UpsertCentralizedStudentTable", conn)
            {
                CommandType = CommandType.StoredProcedure
            };

            cmd.Parameters.Add(new SqlParameter("@StudentId", SqlDbType.Int) { Value = student.Id });
            cmd.Parameters.Add(new SqlParameter("@StudentFirstName", SqlDbType.VarChar, 50) { Value = student.StudentFirstName });
            cmd.Parameters.Add(new SqlParameter("@StudentMiddleName", SqlDbType.VarChar, 50) { Value = student.StudentMiddleName });
            cmd.Parameters.Add(new SqlParameter("@StudentLastName", SqlDbType.VarChar, 50) { Value = student.StudentLastName });
            cmd.Parameters.Add(new SqlParameter("@isRegisteredStudent", SqlDbType.Char, 1) { Value = student.IsRegisteredStudent });
            cmd.Parameters.Add(new SqlParameter("@studentRegistrationId", SqlDbType.VarChar, 50) { Value = student.StudentRegistrationId });
            cmd.Parameters.Add(new SqlParameter("@studentRegistrationDate", SqlDbType.DateTime) { Value = student.StudentRegistrationDate });
            cmd.Parameters.Add(new SqlParameter("@studentRollNumber", SqlDbType.Int) { Value = student.RollNumber });
            cmd.Parameters.Add(new SqlParameter("@StudentClass", SqlDbType.Int) { Value = student.StudentClass });
            cmd.Parameters.Add(new SqlParameter("@studentSectionId", SqlDbType.Int) { Value = student.StudentSectionId });
            cmd.Parameters.Add(new SqlParameter("@studentPhoneNumber", SqlDbType.VarChar, 50) { Value = student.StudentPhoneNumber });
            cmd.Parameters.Add(new SqlParameter("@studentAddressLine1", SqlDbType.VarChar, 100) { Value = student.StudentAddressLine1 });
            cmd.Parameters.Add(new SqlParameter("@studentAddressLine2", SqlDbType.VarChar, 100) { Value = student.StudentAddressLine2 });
            cmd.Parameters.Add(new SqlParameter("@studentCity", SqlDbType.VarChar, 50) { Value = student.StudentCity });
            cmd.Parameters.Add(new SqlParameter("@studentState", SqlDbType.VarChar, 50) { Value = student.StudentState });
            cmd.Parameters.Add(new SqlParameter("@studentCountry", SqlDbType.VarChar, 20) { Value = student.StudentCountry });
            cmd.Parameters.Add(new SqlParameter("@studentZipCode", SqlDbType.VarChar, 20) { Value = student.StudentZipCode });
            cmd.Parameters.Add(new SqlParameter("@studentEmailId", SqlDbType.VarChar, 100) { Value = student.StudentEmailId });

            cmd.Parameters.Add(new SqlParameter("@schoolRelationshipCategoryId", SqlDbType.Int) { Value = student.StudentRelationShipId });

            await conn.OpenAsync();
            await cmd.ExecuteNonQueryAsync();
        }

        
    }

   

}
