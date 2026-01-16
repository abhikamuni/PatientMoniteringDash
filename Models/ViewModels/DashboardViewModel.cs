using PatinetMo.Models;

namespace PatinetMo.Models.ViewModels
{
    public class DashboardViewModel
    {
        public List<Patient> Patients { get; set; }
        public List<AlertHistory> RecentAlerts { get; set; }
    }
}
