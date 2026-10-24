using Microsoft.AspNetCore.Mvc;
using SchoolManagementAPI.Abstract;
using SchoolManagementAPI.Model;
using SchoolManagementAPI.Services;

namespace SchoolManagementAPI.Controller
{
    [ApiController]
    [Route("api/[controller]")]
    public class SyncController : ControllerBase
    {
        private readonly IStudentSyncService _syncService;

        public SyncController(IStudentSyncService syncService)
        {
            _syncService = syncService;
        }

        // POST: /api/sync/students
        [HttpPost("students")]
        public async Task<ActionResult<SyncResult>> TriggerSync()
        {
            try
            {
                var result = await _syncService.SyncAllStudentsAsync();
                return Ok(result);
            }
            catch (HttpRequestException ex)
            {
                return StatusCode(502, new { message = "Failed to communicate with source StudentManagementAPI", detail = ex.Message });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = "Sync failed", detail = ex.Message });
            }
        }
    }
}
