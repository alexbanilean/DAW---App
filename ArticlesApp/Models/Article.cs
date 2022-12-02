using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ArticlesApp.Models
{
    public class Article
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Titlul este obligatoriu")]
        [MinLength(5, ErrorMessage = "Titlul trebuie sa aiba mai mult de 5 caractere")]
        [StringLength(100, ErrorMessage = "Titlul poate avea maxim 100 de caractere")]
        public string? Title { get; set; }

        [Required(ErrorMessage = "Continutul articolului este obligatoriu")]
        public string? Content { get; set; }

        public DateTime Date { get; set; }

        [Required(ErrorMessage = "Articolul trebuie sa apartina unei categorii")]
        public int? CategoryId { get; set; }

        public virtual Category? Category { get; set; }
        
        public string? UserId { get; set; }

        public virtual ApplicationUser? User { get; set; } // un articol apartine unui singur utilizator

        public virtual ICollection<Comment>? Comments { get; set; }

        [NotMapped]
        public IEnumerable<SelectListItem>? Categ { get; set; }
    }

}
