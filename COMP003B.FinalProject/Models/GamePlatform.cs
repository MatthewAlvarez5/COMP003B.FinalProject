using COMP003B.FinalProject.Models;
namespace COMP003B.FinalProject.Models
{
    public class GamePlatform
    {
        public int Id { get; set; }
        public int GameId { get; set; }
        public int PlatformId { get; set; }
        

        public virtual Game? Game { get; set; }
        public virtual Platform? Platform { get; set; }

        

    }
}
