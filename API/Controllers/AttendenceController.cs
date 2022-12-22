using Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace API.Controllers
{
    public class AttendenceController : BaseApiController
    {
        private readonly DataContext _context;
        public AttendenceController(DataContext context) 
        {
            _context = context;   
        }

        [HttpGet] //api/attendence
        public async Task<ActionResult<List<Attendence>>> GetAttendences()
        {
            return await _context.Attendences.ToListAsync();
        }

        [HttpGet("{id}")]  // api/attendence/id
        public async Task<ActionResult<Attendence>> GetAttendence(Guid id)
        {
            return await _context.Attendences.FindAsync(id);
        }
    }
}