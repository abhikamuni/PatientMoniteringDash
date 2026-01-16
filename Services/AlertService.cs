namespace PatinetMo.Services
{
    public class AlertService
    {
        public string GetStatus(int heartRate, int oxygen, float temperature)
        {
            // CRITICAL CONDITIONS
            if (heartRate > 140 || heartRate < 40 || oxygen < 85 || temperature > 39)
                return "Critical";

            // WARNING CONDITIONS
            if (heartRate > 110 || heartRate < 55 || oxygen < 92 || temperature > 37.8)
                return "Warning";

            return "Normal";
        }
    }
}
