using System.ComponentModel.DataAnnotations.Schema;

namespace GameZone.Models
{
    public class Categorey:BaseEntity
    {
        public ICollection<Game> Games { get; set; } = new HashSet<Game>();

    }
}
