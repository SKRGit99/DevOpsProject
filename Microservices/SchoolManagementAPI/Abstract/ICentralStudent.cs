using SchoolManagementAPI.Model;

namespace SchoolManagementAPI.Abstract
{
    public interface ICentralStudent
    {
        Task UpsertStudentAsync(Student student);
    }
}
