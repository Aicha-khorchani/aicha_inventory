using System;
using System.Collections.Generic;

namespace InventoryApp.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string FullName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
        public DateTime HireDate { get; set; }
        public decimal Salary { get; set; }

        public int DepartmentId { get; set; }
        public Department? Department { get; set; }

        public int ContractId { get; set; }
        public Contract? Contract { get; set; }

        public double AccruedLeaveDays { get; set; } = 0;
        public double UsedLeaveDays { get; set; } = 0;
        public double CurrentAvailableLeave => AccruedLeaveDays - UsedLeaveDays;

        public List<LeaveRequest> LeaveRequests { get; set; } = new();
        public List<AttendanceRecord> AttendanceRecords { get; set; } = new();
        public List<PerformanceReview> PerformanceReviews { get; set; } = new();

        public void AddMonthlyLeave(double days = 2) => AccruedLeaveDays += days;
        public void UseLeave(double days) => UsedLeaveDays += days;
    }
}
