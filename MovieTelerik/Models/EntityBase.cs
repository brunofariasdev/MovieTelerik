using System.ComponentModel.DataAnnotations;

namespace MovieTelerik.Models
{
    public class EntityBase
    {
        [Key]
        public int Id { get; set; }
    }
}
