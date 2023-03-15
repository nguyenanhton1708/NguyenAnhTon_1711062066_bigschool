using System.ComponentModel.DataAnnotations;

namespace NguyenAnhTon_1711062066.Models
{
    public class Category
    {
        public byte Id { get; set; }
        [Required]
        [StringLength(255)]
        public string Name { get; set; }
    }
}