using System.ComponentModel.DataAnnotations;

namespace Yummy.Models
{
    public class Ingredient
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(20)]
        public string Name { get; set; }
    }
}
