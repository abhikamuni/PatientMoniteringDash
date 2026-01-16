namespace PatinetMo.Models
{
    public class Patient
    {
        public int PatientId { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        // New Relationship
        public int? DoctorId { get; set; }
        public Doctor Doctor { get; set; } // Navigation Property
    }
}

