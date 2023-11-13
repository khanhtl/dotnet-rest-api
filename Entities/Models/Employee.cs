using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models
{
    public class Employee
    {
        [Column("EmployeeId")]
        public Guid Id { get; set; }
        [Required(ErrorMessage = "Họ và tên không được để trống.")]
        [MaxLength(30, ErrorMessage = "Họ và tên không được vượt quá 30 ký tự.")]
        public string? Name { get; set; }
        [Required(ErrorMessage = "Tuổi không được để trống.")]
        public int Age { get; set; }
        [Required(ErrorMessage = "Vị trí không được để trống")]
        [MaxLength(20, ErrorMessage = "Vị trí không được vượt quá 20 ký tự.")]
        public string? Possition { get; set; }
        [ForeignKey(nameof(Company))]
        public Guid CompanyId { get; set; }
        public Company? Company { get; set; }
    }
}
