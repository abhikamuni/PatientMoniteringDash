using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace PatinetMo.Models
{
    public class AlertHistory
    {
        public int Id { get; set; }

        // This is the Foreign Key
        public int PatientId { get; set; }

        // ✅ THIS IS THE MISSING PART (Navigation Property)
        [ForeignKey("PatientId")]
        public virtual Patient Patient { get; set; }

        public string Severity { get; set; }
        public string Message { get; set; }
        public DateTime Timestamp { get; set; }
    }
}




