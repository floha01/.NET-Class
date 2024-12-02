using System.ComponentModel.DataAnnotations;

namespace Articles.Models
{
    public class ArticleModel
    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Content { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }

    }
}
