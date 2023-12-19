using System.ComponentModel.DataAnnotations;

namespace ApiPeliculas.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        public required string Name { get; set; }

        [Required]
        public required DateTime CreationDate { get; set; }
    }
}