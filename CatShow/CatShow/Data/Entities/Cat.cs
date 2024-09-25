using System.ComponentModel.DataAnnotations;

namespace CatShow.Data.Entities
{
    public class Cat
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(30)]
        public string Name { get; set; } = null!;

        [Required]
        [MaxLength(30)]
        public string Breed { get; set; } = null!;

        [Required]
        [Range(0,15)]
        public int Age { get; set; }

        public string Picture { get; set; } = null!;
    }
}
