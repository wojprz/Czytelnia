using System.ComponentModel.DataAnnotations;

namespace Czytelnia.Models
{
    public class Book
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        public string Author { get; set; }
        public int Pages { get; set; } = 0;
        public DateTime CreatedDate { get; set; } = DateTime.Now;

    }
}
