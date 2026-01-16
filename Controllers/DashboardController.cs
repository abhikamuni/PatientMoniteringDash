using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PatinetMo.Data;
using PatinetMo.Models.ViewModels;

namespace PatinetMo.Controllers
{
    public class DashboardController : Controller
    {
        private readonly AppDbContext _context;

        public DashboardController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var viewModel = new DashboardViewModel
            {
                // Include Doctor to display their name
                Patients = _context.Patients.Include(p => p.Doctor).ToList(),

                // Fetch last 50 alerts, newest first, including Patient/Doctor details
                RecentAlerts = _context.AlertHistory
                                       .Include(a => a.Patient) // Assuming AlertHistory has navigation property to Patient
                                       .ThenInclude(p => p.Doctor)
                                       .OrderByDescending(a => a.Timestamp)
                                       .Take(50)
                                       .ToList()
            };

            return View(viewModel);
        }
    }
}
