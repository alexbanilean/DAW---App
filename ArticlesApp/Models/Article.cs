using System.ComponentModel.DataAnnotations;

namespace ArticlesApp.Models
{
    public class Article
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Titlul este obligatoriu")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Continutul articolului este obligatoriu")]
        public string Content { get; set; }
        public DateTime Date { get; set; }
        [Required(ErrorMessage = "Categoria este obligatorie")]
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
    }

}
