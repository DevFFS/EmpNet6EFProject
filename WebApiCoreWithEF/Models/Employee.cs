using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebApiCoreWithEF.Models
{
    public class Employee
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int EmployeeId { get; set; }

        public string EmployeeName { get; set; } = null!;

        public string DateOfBirth { get; set; } = null!;

        public string Gender { get; set; } = null!;

        public string CurrentAddress { get; set; } = null!;

        public string PermanentAddress { get; set; } = null!;

        public string City { get; set; } = null!;

        public string Nationality { get; set; } = null!;

        public int PINCode { get; set; }
    }
}
