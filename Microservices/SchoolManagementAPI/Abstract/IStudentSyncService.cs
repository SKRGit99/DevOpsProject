using SchoolManagementAPI.Model;

namespace SchoolManagementAPI.Abstract
{
    public interface IStudentSyncService
    {
        Task<SyncResult> SyncAllStudentsAsync();
        
    }
}
