using SchoolManagementAPI.Abstract;
using SchoolManagementAPI.Model;
using SchoolManagementAPI.Repo;

namespace SchoolManagementAPI.Services
{
    public class StudentSyncService: IStudentSyncService
    {
        private readonly HttpClient _httpClient;
        private readonly ICentralStudent _repo;
        private readonly ILogger<StudentSyncService> _logger;

        public StudentSyncService(HttpClient httpClient, ICentralStudent repo, ILogger<StudentSyncService> logger)
        {
            _httpClient = httpClient;
            _repo = repo;
            _logger = logger;
        }

        public async Task<SyncResult> SyncAllStudentsAsync()
        {
            // 1. Fetch JSON from StudentAPI
            var response = await _httpClient.GetAsync("/api/student");
            response.EnsureSuccessStatusCode();

            var students = await response.Content.ReadFromJsonAsync<List<Student>>() ?? new List<Student>();

            // 2. Upsert into Central Database
            int syncedCount = 0;
            foreach (var student in students)
            {
                await _repo.UpsertStudentAsync(student);
                syncedCount++;
            }

            _logger.LogInformation("Successfully synced {Count} students to central DB.", syncedCount);

            return new SyncResult
            {
                TotalFetched = students.Count,
                TotalSynced = syncedCount,
                Status = "Completed"
            };
        }

    }
}
