namespace GameZone.Core.Models
{
    public class Device : BaseEntity
    {

        public string ICone { get; set; } = string.Empty;
        public ICollection<GameDevice> Games { get; set; } = new HashSet<GameDevice>();
    }
}
