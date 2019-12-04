using System.ComponentModel.DataAnnotations;

namespace IdeaAppCore.Models
{
    public class Idea
    {
        public int Id { get; set; }
        [Required]
        public string Note { get; set; }
    }
}
