using System;

namespace InventoryApp.Models
{
    public class PerformanceReview
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public Employee? Employee { get; set; }

        public DateTime ReviewDate { get; set; }
        public int PunctualityScore { get; set; }
        public int TeamworkScore { get; set; }
        public int ProductivityScore { get; set; }
        public string Comments { get; set; } = string.Empty;

        public double AverageScore =>
            (PunctualityScore + TeamworkScore + ProductivityScore) / 3.0;
    }
}
