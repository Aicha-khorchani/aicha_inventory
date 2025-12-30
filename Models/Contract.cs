using System;
using System.Collections.Generic;

namespace InventoryApp.Models
{
    public enum ContractType
    {
        Permanent,
        Temporary,
        Internship,
        PartTime
    }

    public class Contract
    {
        public int Id { get; set; }
        public ContractType Type { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int AllowedLeavePerYear { get; set; } = 24;

        public List<Employee> Employees { get; set; } = new();
    }
}
