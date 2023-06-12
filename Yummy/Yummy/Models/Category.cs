using System.ComponentModel.DataAnnotations;

namespace Yummy.Models
{
    public class Category
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(20)]
        public string Name { get; set; }

        public List<Meal> Meals { get; set; }
    }
}
