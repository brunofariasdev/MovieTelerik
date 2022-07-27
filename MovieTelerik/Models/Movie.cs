using System.ComponentModel.DataAnnotations;

namespace MovieTelerik.Models
{
    public class Movie : EntityBase
    {

        [Required(ErrorMessage = "Campo obrigatório")]
        public string? Title { get; set; }
        public DateTime CreatedDate { get; set; }
        [Required(ErrorMessage = "Campo obrigatório")]
        public string? UrlImg { get; set; }
        [Required(ErrorMessage = "Campo obrigatório")]
        public string? Resume { get; set; }
        public int MetaScore { get; set; }

        //Navigation Properties
        [UIHint("ClientGenre")]
        public Genre? Genre { get; set; }
        public int GenreId { get; set; }

    }
}