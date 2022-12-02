using System;
using System.ComponentModel.DataAnnotations;

namespace ArticlesApp.Models
{
    public class Comment
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Continutul este obligatoriu")]
        public string? Content { get; set; }

        public DateTime Date { get; set; }

        public int? ArticleId { get; set; }

        public string? UserId { get; set; }

        public virtual ApplicationUser? User { get; set; } // un comentariu apartine unui singur utilizator

        public virtual Article? Article { get; set; }
    }

}
