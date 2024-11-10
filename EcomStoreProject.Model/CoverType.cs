using System.ComponentModel.DataAnnotations;

namespace EcomStoreProject.Model
{
    public class CoverType
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string? Name { get; set; }
    }
}
