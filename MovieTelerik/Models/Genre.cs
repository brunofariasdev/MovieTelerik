using System.ComponentModel.DataAnnotations;

namespace MovieTelerik.Models
{
    public class Genre : EntityBase
    {
        [Required(ErrorMessage = "Campo obrigatório")]
        public string? Name { get; set; }
    }
}