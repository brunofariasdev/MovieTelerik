using System.ComponentModel.DataAnnotations;

namespace MovieTelerik.Models
{
    public class Movie : EntityBase
    {
        public string? Title { get; set; }
        public DateTime CreatedDate { get; set; }
        public string? UrlImg { get; set; }
        public string? Resume { get; set; }
        public int MetaScore { get; set; }

        //Navigation Properties
        [UIHint("ClientGenre")]
        public Genre? Genre { get; set; }
        public int GenreId { get; set; }

    }
}