using System.ComponentModel.DataAnnotations;

namespace RESTful_API.Models
{
    public class Category
    {
        [Required]
        public int Id { get; set; }

        [Required]
        
        public string title { get; set; }

        [Required]

        public int  displayOrder { get; set; }
    }
}
