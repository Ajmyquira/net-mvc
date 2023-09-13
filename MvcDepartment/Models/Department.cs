using System.ComponentModel.DataAnnotations;

namespace MvcDepartment.Models;

public class Department
{
    public int Id { get; set; }
    public string? Address { get; set; }
    [DataType(DataType.Date)]
    public DateTime PaymentDay { get; set; }
    public bool HaveGarage { get; set; }
    public decimal Price { get; set; }
    public int NumRooms { get; set; }
}
