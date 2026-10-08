using System.ComponentModel.DataAnnotations;

namespace BooksApi.Model
{
    public class Book
    {
        public int Id { get; set; }

        [Required]
        [StringLength(200, MinimumLength = 2)]
        public string Title { get; set; } = "";

        [Required]
        [StringLength(100)]
        public string Author { get; set; } = "";

        [Range(typeof(DateTime), "1000-01-01", "2023-01-01",
            ErrorMessage = "Published date must be between 1000-01-01 and 2023-01-01")]

        public DateTime PublishedDate { get; set; }
    }
}
