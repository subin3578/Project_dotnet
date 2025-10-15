using System.ComponentModel.DataAnnotations;
namespace BoardApp.Models;
public class Post
{
    [Key]
    public int Id { get; set; }

    [Required]
    [StringLength(100)]
    public string Title { get; set; }

    [Required]
    public string Content { get; set; }

    [Required]
    public string Author { get; set; }

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
}