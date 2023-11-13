using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models
{
    public class Company
    {
        [Column("CompanyId")]
        public Guid Id { get; set; }
        [Required(ErrorMessage = "Tên công ty không được để trống.")]
        [MaxLength(60, ErrorMessage = "Tên công ty không được vượt quá 60 ký tự.")]
        public string? Name { get; set; }
        [Required(ErrorMessage = "Địa chỉ công ty không được để trống.")]
        [MaxLength(60, ErrorMessage = "Địa chỉ công ty không được vượt quá 60 ký tự.")]
        public string? Address { get; set; }
        public string? Country { get; set; }
        public ICollection<Employee>? Employees { get; set; }
    }
}
