namespace GameZone.Core.Models
{
    public class Game : BaseEntity
    {
        public string Description { get; set; } = string.Empty;
        public string Cover { get; set; } = string.Empty;

        public Categorey Categoriy { get; set; }
        [ForeignKey("Categoriy")]
        public int CatId { get; set; }

        public ICollection<GameDevice> Devices { get; set; } = new HashSet<GameDevice>();
    }
}
