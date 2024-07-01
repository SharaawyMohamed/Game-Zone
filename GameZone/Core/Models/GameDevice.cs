using System.ComponentModel.DataAnnotations.Schema;

namespace GameZone.Core.Models
{
    public class GameDevice
    {
        public Game Game { get; set; }
        [ForeignKey("Game")]
        public int GameId { get; set; }

        public Device Device { get; set; }
        [ForeignKey("Device")]
        public int DeviceId { get; set; }

    }
}
