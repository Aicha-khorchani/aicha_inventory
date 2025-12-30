using System;

namespace InventoryApp.Models
{
    public class AttendanceRecord
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public Employee? Employee { get; set; }

        public DateTime CheckIn { get; set; }
        public DateTime? CheckOut { get; set; }

        public double HoursWorked => CheckOut.HasValue
            ? (CheckOut.Value - CheckIn).TotalHours
            : 0;
    }
}
